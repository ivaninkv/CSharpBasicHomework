namespace ClassStack.App;

public class Stack
{
    private StackItem? _stackItem;

    public Stack(params string?[]? elements)
    {
        if (elements != null)
            foreach (var element in elements)
            {
                _stackItem = new StackItem(element, _stackItem);
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
        if (Size == 0)
            throw new InvalidOperationException("Стек пустой");
        var result = Top;
        _stackItem = _stackItem?.PreviousElement;
        Top = _stackItem?.Value;
        Size--;
        return result;
    }

    public static Stack Concat(params Stack[] stacks)
    {
        var result = new Stack();
        foreach (var element in stacks)
        {
            var size = element.Size;
            for (var j = 0; j < size; j++)
                result.Add(element.Pop());
        }


        return result;
    }

    public override bool Equals(object? obj)
    {
        return Equals(obj as Stack);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(_stackItem, Size, Top);
    }

    private bool Equals(Stack? stack)
    {
        if (stack == null)
            return false;
        if (stack.Size != Size)
            return false;
        if (stack._stackItem?.Value != _stackItem?.Value)
            return false;

        var size = stack.Size;
        for (var i = 0; i < size; i++)
        {
            var si1 = stack._stackItem?.PreviousElement;
            var si2 = _stackItem?.PreviousElement;
            if (si1?.Value != si2?.Value)
                return false;
        }

        return true;
    }

    public override string ToString()
    {
        return $"Size - {Size}, Top element - {Top}";
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