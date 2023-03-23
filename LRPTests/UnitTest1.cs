using System.Collections.Generic;
using LRP;
using NUnit.Framework;

namespace LRPTests;

public class Tests
{
    [Test]
    public void RandomNumberGenerator1()
    {
        var freeMember = new List<byte[]?> { new byte[] { 1, 0, 0, 0 }, new byte[] { 2, 0, 0, 0 } };
        var setCoefficients = new List<byte[]?> { new byte[]{ 1, 0, 0, 0 }, new byte[] { 3, 0, 0, 0 } };
        var c = new byte[] { 0, 0, 0, 0 };
        var generator = new Lrp(freeMember, setCoefficients, c);
        var waiting = new List<byte[]> { new byte[] { 7, 0, 0, 0 }, new byte[] { 11, 0, 0, 0 }, new byte[] { 26, 0, 0, 0 }, new byte[] { 37, 0, 0, 0 } };
        var result = new List<byte[]> { generator.Random(), generator.Random(), generator.Random(), generator.Random() };
        Assert.That(result, Is.EqualTo(waiting));
    }
    
    [Test]
    public void RandomNumberGenerator2()
    {
        var freeMember = new List<byte[]?> { new byte[] { 2, 0, 0, 0 }, new byte[] { 4, 0, 0, 0 } };
        var setCoefficients = new List<byte[]?> { new byte[]{ 1, 0, 0, 0 }, new byte[] { 5, 0, 0, 0 } };
        var c = new byte[] { 3, 0, 0, 0 };
        var generator = new Lrp(freeMember, setCoefficients, c);
        var waiting = new List<byte[]> { new byte[] { 21, 0, 0, 0 }, new byte[] { 70, 0, 0, 0 }, new byte[] { 85, 0, 0, 0 }, new byte[] { 89, 0, 0, 0 } };
        var result = new List<byte[]> { generator.Random(), generator.Random(), generator.Random(), generator.Random() };
        Assert.That(result, Is.EqualTo(waiting));
    }
    
    [Test]
    public void RandomNumberGenerator3()
    {
        var freeMember = new List<byte[]?> { new byte[] { 1, 0, 0, 0 }, new byte[] { 3, 0, 0, 0 } };
        var setCoefficients = new List<byte[]?> { new byte[]{ 7, 0, 0, 0 }, new byte[] { 1, 0, 0, 0 } };
        var c = new byte[] { 4, 0, 0, 0 };
        var generator = new Lrp(freeMember, setCoefficients, c);
        var waiting = new List<byte[]> { new byte[] { 0, 0, 0, 0 }, new byte[] { 13, 0, 0, 0 }, new byte[] { 9, 0, 0, 0 }, new byte[] { 46, 0, 0, 0 } };
        var result = new List<byte[]> { generator.Random(), generator.Random(), generator.Random(), generator.Random() };
        Assert.That(result, Is.EqualTo(waiting));
    }
    
    [Test]
    public void RandomNumberGenerator4()
    {
        var freeMember = new List<byte[]?> { new byte[] { 1, 0, 0, 0 }, new byte[] { 1, 0, 0, 0 } };
        var setCoefficients = new List<byte[]?> { new byte[]{ 1, 0, 0, 0 }, new byte[] { 1, 0, 0, 0 } };
        var c = new byte[] { 7, 0, 0, 0 };
        var generator = new Lrp(freeMember, setCoefficients, c);
        var waiting = new List<byte[]> { new byte[] { 7, 0, 0, 0 }, new byte[] { 1, 0, 0, 0 }, new byte[] { 1, 0, 0, 0 }, new byte[] { 7, 0, 0, 0 } };
        var result = new List<byte[]> { generator.Random(), generator.Random(), generator.Random(), generator.Random() };
        Assert.That(result, Is.EqualTo(waiting));
    }
    
    [Test]
    public void RandomNumberGenerator5()
    {
        var freeMember = new List<byte[]?> { new byte[] { 1, 0, 0, 0 }, new byte[] { 3, 0, 0, 0 } };
        var setCoefficients = new List<byte[]?> { new byte[]{ 0, 0, 0, 0 }, new byte[] { 0, 0, 0, 0 } };
        var c = new byte[] { 4, 0, 0, 0 };
        var generator = new Lrp(freeMember, setCoefficients, c);
        var waiting = new List<byte[]> { new byte[] { 4, 0, 0, 0 }, new byte[] { 4, 0, 0, 0 }, new byte[] { 4, 0, 0, 0 }, new byte[] { 4, 0, 0, 0 } };
        var result = new List<byte[]> { generator.Random(), generator.Random(), generator.Random(), generator.Random() };
        Assert.That(result, Is.EqualTo(waiting));
    }
}