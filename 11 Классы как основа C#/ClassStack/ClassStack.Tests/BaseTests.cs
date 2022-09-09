using ClassStack.App;

namespace ClassStack.Tests;

public class BaseTests
{
    [Theory]
    [InlineData(null, 0)]
    [InlineData(new[] { "a", "b", "c" }, 3)]
    [InlineData(new[] { "1", "2", "3", "4", "5" }, 5)]
    public void SizeTest(string[] elements, int expectedSize)
    {
        var stack = new Stack(elements);
        Assert.Equal(expectedSize, stack.Size);
    }


    [Theory]
    [InlineData(null, null)]
    [InlineData(new[] { "a", "b", "c" }, "c")]
    [InlineData(new[] { "1", "2", "3", "4", "5" }, "5")]
    public void TopTest(string[] elements, string? expectedElement)
    {
        var stack = new Stack(elements);
        Assert.Equal(expectedElement, stack.Top);
    }

    [Theory]
    [InlineData(new[] { "a", "b", "c" }, "c")]
    [InlineData(new[] { "1", "2", "3", "4", "5" }, "5")]
    public void PopTest(string[] elements, string? expectedElement)
    {
        var stack = new Stack(elements);
        Assert.Equal(expectedElement, stack.Pop());
    }

    [Theory]
    [InlineData(new[] { "a", "b", "c" }, "c")]
    [InlineData(new[] { "1", "2", "3", "4", "5" }, "5")]
    public void AddTest(string[] elements, string? newElement)
    {
        var stack = new Stack(elements);
        var size = stack.Size;
        stack.Add(newElement);
        Assert.Equal(newElement, stack.Top);
        Assert.Equal(++size, stack.Size);
    }
}