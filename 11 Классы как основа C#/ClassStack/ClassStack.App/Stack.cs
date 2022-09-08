namespace ClassStack.App;

public class Stack
{
    private StackItem? _stackItem;

    public Stack(params string?[]? elements)
    {
        if (elements != null)
            foreach (var element in elements)
            {
                _stackItem = new StackItem(element);
                Top = _stackItem.Value;
                Size++;
            }
    }

    public int Size { get; private set; }
    public string? Top { get; private set; }

    public void Add(string? newElement)
    {
        _stackItem = new StackItem(newElement, _stackItem);
        Top = _stackItem.Value;
        Size++;
    }

    public string? Pop()
    {
        var result = Top;
        _stackItem = _stackItem?.PreviousElement ?? throw new InvalidOperationException("Стек пустой");
        Top = _stackItem.Value;
        Size--;
        return result;
    }


    private class StackItem
    {
        public StackItem(string? value, StackItem? previousElement = null)
        {
            Value = value;
            PreviousElement = previousElement;
        }

        public string? Value { get; }
        public StackItem? PreviousElement { get; }
    }
}