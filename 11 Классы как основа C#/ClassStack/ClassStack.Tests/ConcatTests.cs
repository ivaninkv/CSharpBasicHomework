using ClassStack.App;

namespace ClassStack.Tests;

public class ConcatTests
{
    [Theory]
    [InlineData(null, null, null)]
    [InlineData(new[] { "a", "b" }, new[] { "1", "2" }, new[] { "b", "a", "2", "1" })]
    [InlineData(new[] { "a", "b", "c" }, new[] { "1", "2", "3" }, new[] { "c", "b", "a", "3", "2", "1" })]
    public void ConcatTest(string[] stack1Elements, string[] stack2Elements, string[] resultStackElements)
    {
        var stack1 = new Stack(stack1Elements);
        var stack2 = new Stack(stack2Elements);
        var expectedStack = new Stack(resultStackElements);

        Assert.Equal(expectedStack, Stack.Concat(stack1, stack2));
    }
}