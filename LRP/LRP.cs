using FiniteFields;
namespace LRP;

public class Lrp
{
    private FiniteField field = new FiniteField(2, 8, new int[] { 1, 0, 1, 1, 1, 0, 0, 0, 1 });
    private List<FiniteFieldElement> FreeMember = new ();
    private FiniteFieldElement[] SetCoefficients { get; } 
    private FiniteFieldElement C { get; }
        
    public Lrp(List<byte[]?> freeMember, List<byte[]?> setCoefficients, byte[]? c)
    {
        if (freeMember.Count != setCoefficients.Count)
            throw new Exception("Exception");
        SetCoefficients = new FiniteFieldElement[setCoefficients.Count];
        for (var i = 0; i < setCoefficients.Count; i++)
        {
            FreeMember.Add(field.GetFiniteFieldRepresent(freeMember[i]));
            SetCoefficients[i] = field.GetFiniteFieldRepresent(setCoefficients[i]);
        }
        C = field.GetFiniteFieldRepresent(c);
    }

    public byte[] Random()
    {
        var n = FreeMember.Count - SetCoefficients.Length;
        var x_nk = field.GetZero();
        for (var i = 0; i < SetCoefficients.Length; i++)
        {
            x_nk += SetCoefficients[i] * FreeMember[i+n];
        }
        x_nk += C;
        FreeMember.Add(x_nk);
        return field.GetBinaryRepresent(x_nk);
    }
}