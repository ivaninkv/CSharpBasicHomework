using LoopRecursion.App;

namespace LoopRecursion.Tests;

public class LoopRecursionTests
{
    [Theory]
    [InlineData(1, 0)]
    [InlineData(2, 1)]
    [InlineData(3, 1)]
    [InlineData(4, 2)]
    [InlineData(5, 3)]
    [InlineData(6, 5)]
    [InlineData(7, 8)]
    [InlineData(8, 13)]
    [InlineData(9, 21)]
    [InlineData(10, 34)]
    public void LoopTest(ulong number, ulong result)
    {
        Assert.Equal(result, Program.FiboLoop(number));
    }

    [Theory]
    [InlineData(1, 0)]
    [InlineData(2, 1)]
    [InlineData(3, 1)]
    [InlineData(4, 2)]
    [InlineData(5, 3)]
    [InlineData(6, 5)]
    [InlineData(7, 8)]
    [InlineData(8, 13)]
    [InlineData(9, 21)]
    [InlineData(10, 34)]
    public void RecursionTest(ulong number, ulong result)
    {
        Assert.Equal(result, Program.FiboRecursion(number));
    }

    [Theory]
    [InlineData(1, 0)]
    [InlineData(2, 1)]
    [InlineData(3, 1)]
    [InlineData(4, 2)]
    [InlineData(5, 3)]
    [InlineData(6, 5)]
    [InlineData(7, 8)]
    [InlineData(8, 13)]
    [InlineData(9, 21)]
    [InlineData(10, 34)]
    public void CachedRecursionTest(ulong number, ulong result)
    {
        Assert.Equal(result, Program.FiboCachedRecursion(number));
    }
}
