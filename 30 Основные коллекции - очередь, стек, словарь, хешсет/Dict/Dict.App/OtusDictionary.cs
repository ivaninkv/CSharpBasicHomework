namespace Dict.App;

public class OtusDictionary
{
    private HashEntry[] _array = new HashEntry[2];

    public string? this[int i]
    {
        get => _array[i].Value;
        set => _array[i].Value = value;
    }

    public string? Get(int key)
    {
        return _array[FindSlot(key, _array)]?.Value;
    }

    public void Add(int key, string? value)
    {
        if (value is null)
        {
            throw new ArgumentException("Value can't be null");
        }

        if (!CheckOpenSpace(_array))
        {
            RebuildArray(ref _array);
        }

        var index = FindSlot(key, _array);
        _array[index] = new HashEntry(key, value);
    }

    private void RebuildArray(ref HashEntry[] array)
    {
        var newArray = new HashEntry[array.Length * 2];
        foreach (var he in array)
        {
            var newSlot = FindSlot(he.Key, newArray);
            newArray[newSlot] = he;
        }

        array = newArray;
    }

    private bool CheckOpenSpace(HashEntry[] array)
    {
        return array.Any(entry => entry is null);
    }


    private int FindSlot(int key, HashEntry[] array)
    {
        var index = key % array.Length;
        while (array[index] != null && array[index].Key != key)
        {
            index = (index + 1) % array.Length;
        }

        return index;
    }
}
