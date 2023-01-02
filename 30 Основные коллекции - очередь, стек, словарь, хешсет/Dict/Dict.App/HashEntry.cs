namespace Dict.App;

public class HashEntry
{
    public HashEntry(int key, string? value)
    {
        Key = key;
        Value = value;
    }

    public int Key { get; set; }
    public string? Value { get; set; }
}
