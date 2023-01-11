using System.Collections.ObjectModel;

namespace Collections.Buyer;

public class Shop
{
    public readonly ObservableCollection<Item> Items = new();
    private int _lastIndex;

    public void Add(string itemName)
    {
        Items.Add(new Item(++_lastIndex, itemName));
    }

    public void Remove(int removedId)
    {
        var itemForDelete = Items.Where(i => i.Id == removedId).ToList();
        foreach (var item in itemForDelete)
        {
            Items.Remove(item);
        }
    }
}
