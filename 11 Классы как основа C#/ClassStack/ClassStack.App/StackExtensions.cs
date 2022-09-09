namespace ClassStack.App;

public static class StackExtensions
{
    public static Stack Merge(this Stack s1, Stack s2)
    {
        var size = s2.Size;
        for (var i = 0; i < size; i++) s1.Add(s2.Pop());

        return s1;
    }
}