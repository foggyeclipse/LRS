using FiniteFields;
namespace LRP;

public class LRS
{
    private FiniteField field = new FiniteField(2, 8, new int[] { 1, 0, 1, 1, 1, 0, 0, 0, 1 });
    private List<FiniteFieldElement> Seed = new ();
    private FiniteFieldElement[] SetCoefficients { get; } 
    private FiniteFieldElement C { get; }
        
    public LRS(List<byte> seed, List<byte> setCoefficients, byte c)
    {
        if (seed.Count != setCoefficients.Count)
            throw new Exception("Exception");
        SetCoefficients = new FiniteFieldElement[setCoefficients.Count];
        for (var i = 0; i < setCoefficients.Count; i++)
        {
            Seed.Add(field.GetFiniteFieldRepresent(seed[i]));
            SetCoefficients[i] = field.GetFiniteFieldRepresent(setCoefficients[i]);
        }
        C = field.GetFiniteFieldRepresent(c);
    }

    public byte Random()
    {
        var x_nk = field.GetZero();
        for (var i = 0; i < SetCoefficients.Length; i++)
        {
            x_nk += SetCoefficients[i] * Seed[i];
        }
        x_nk += C;
        Seed.Add(x_nk);
        Seed.RemoveAt(0);
        return field.GetBinaryRepresent(x_nk);
    }
}