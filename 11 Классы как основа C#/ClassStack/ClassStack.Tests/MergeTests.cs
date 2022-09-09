using ClassStack.App;

namespace ClassStack.Tests;

public class MergeTests
{
    [Theory]
    [InlineData(null, null, null)]
    [InlineData(new[] { "a", "b", "c" }, new[] { "1", "2", "3" }, new[] { "a", "b", "c", "3", "2", "1" })]
    [InlineData(new[] { "a", "b" }, new[] { "2", "3" }, new[] { "a", "b", "3", "2" })]
    [InlineData(new[] { "a", null }, new[] { null, "3" }, new[] { "a", null, "3", null })]
    public void MergeTest(string[] stack1Elements, string[] stack2Elements, string[] resultStackElements)
    {
        var stack1 = new Stack(stack1Elements);
        var stack2 = new Stack(stack2Elements);
        var resultStack = new Stack(resultStackElements);
        stack1.Merge(stack2);

        Assert.Equal(resultStack, stack1);
    }
}