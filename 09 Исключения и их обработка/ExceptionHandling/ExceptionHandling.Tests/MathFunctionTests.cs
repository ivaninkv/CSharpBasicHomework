using ExceptionHandling.App;

namespace ExceptionHandling.Tests;

public class MathFunctionTests
{
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 5, 9)]
    [InlineData(2, 1, 3)]
    [InlineData(5, 4, 9)]
    [InlineData(-1, -2, -3)]
    [InlineData(-4, -5, -9)]
    [InlineData(-2, -1, -3)]
    [InlineData(-5, -4, -9)]
    [InlineData(0, -2, -2)]
    [InlineData(-4, 0, -4)]
    [InlineData(0, 0, 0)]
    public void Sum_Equals(int a, int b, int s)
    {
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);
        Program.Sum(a, b);
        Assert.Equal($"Ответ: {s}", stringWriter.ToString().TrimEnd());
    }

    [Theory]
    [InlineData(2, 2, 0)]
    [InlineData(6, 5, 1)]
    [InlineData(22, 11, 11)]
    [InlineData(5, 4, 1)]
    [InlineData(-2, -2, 0)]
    [InlineData(-6, 5, -11)]
    [InlineData(0, 11, -11)]
    [InlineData(5, 0, 5)]
    public void Sub_Equals(int a, int b, int s)
    {
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);
        Program.Sub(a, b);
        Assert.Equal($"Ответ: {s}", stringWriter.ToString().TrimEnd());
    }

    [Theory]
    [InlineData(2, 2, 4)]
    [InlineData(6, 5, 30)]
    [InlineData(22, 11, 242)]
    [InlineData(5, 4, 20)]
    [InlineData(-2, -2, 4)]
    [InlineData(-6, 5, -30)]
    [InlineData(0, 11, 0)]
    [InlineData(5, 0, 0)]
    public void Mul_Equals(int a, int b, int s)
    {
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);
        Program.Mul(a, b);
        Assert.Equal($"Ответ: {s}", stringWriter.ToString().TrimEnd());
    }

    [Theory]
    [InlineData(2, 2, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(22, 11, 2)]
    [InlineData(5, 4, 1)]
    [InlineData(-2, -2, 1)]
    [InlineData(-6, 5, -1)]
    [InlineData(0, 11, 0)]
    public void Div_Equals(int a, int b, int s)
    {
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);
        Program.Div(a, b);
        Assert.Equal($"Ответ: {s}", stringWriter.ToString().TrimEnd());
    }
}