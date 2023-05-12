using System.Collections.Generic;
using LRP;
using NUnit.Framework;

namespace LRPTests;

public class Tests
{
    [Test]
    public void RandomNumberGenerator1()
    {
        var seed = new List<byte> { 1, 2 };
        var setCoefficients = new List<byte> { 1, 3 };
        var c = (byte) 0;
        var generator = new LRS(seed, setCoefficients, c);
        var waiting = new List<byte> { 7, 11, 26, 37 };
        var result = new List<byte> { generator.Random(), generator.Random(), generator.Random(), generator.Random() };
        Assert.That(result, Is.EqualTo(waiting));
    }
    
    [Test]
    public void RandomNumberGenerator2()
    {
        var seed = new List<byte> { 2, 4 };
        var setCoefficients = new List<byte> { 1, 5 };
        var c = (byte) 3;
        var generator = new LRS(seed, setCoefficients, c);
        var waiting = new List<byte> { 21, 70, 85, 89 };
        var result = new List<byte> { generator.Random(), generator.Random(), generator.Random(), generator.Random() };
        Assert.That(result, Is.EqualTo(waiting));
    }
    
    [Test]
    public void RandomNumberGenerator3()
    {
        var seed = new List<byte> { 1, 3 };
        var setCoefficients = new List<byte> { 7, 1 };
        var c = (byte) 4;
        var generator = new LRS(seed, setCoefficients, c);
        var waiting = new List<byte> { 0, 13, 9, 46 };
        var result = new List<byte> { generator.Random(), generator.Random(), generator.Random(), generator.Random() };
        Assert.That(result, Is.EqualTo(waiting));
    }
    
    [Test]
    public void RandomNumberGenerator4()
    {
        var seed = new List<byte> { 1, 1 };
        var setCoefficients = new List<byte> { 1, 1 };
        var c = (byte) 7;
        var generator = new LRS(seed, setCoefficients, c);
        var waiting = new List<byte> { 7, 1, 1, 7 };
        var result = new List<byte> { generator.Random(), generator.Random(), generator.Random(), generator.Random() };
        Assert.That(result, Is.EqualTo(waiting));
    }
    
    [Test]
    public void RandomNumberGenerator5()
    {
        var seed = new List<byte> { 1, 3 };
        var setCoefficients = new List<byte> { 0, 0 };
        var c = (byte) 4;
        var generator = new LRS(seed, setCoefficients, c);
        var waiting = new List<byte> { 4, 4, 4, 4};
        var result = new List<byte> { generator.Random(), generator.Random(), generator.Random(), generator.Random() };
        Assert.That(result, Is.EqualTo(waiting));
    }
}