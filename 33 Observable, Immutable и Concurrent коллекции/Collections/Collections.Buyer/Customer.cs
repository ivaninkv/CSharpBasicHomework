using System.Collections.Specialized;

namespace Collections.Buyer;

public class Customer
{
    private Shop _shop;

    public void Subscribe(Shop shop)
    {
        _shop = shop;
        _shop.Items.CollectionChanged += OnItemChanged;
    }

    private void OnItemChanged(object? sender, NotifyCollectionChangedEventArgs e)
    {
        switch (e.Action)
        {
            case NotifyCollectionChangedAction.Add:
                var newItem = (Item)e.NewItems[^1];
                Console.WriteLine($"Добавлен товар {newItem.Name} с Id {newItem.Id}");
                break;
            case NotifyCollectionChangedAction.Remove:
                var oldItem = (Item)e.OldItems[0];
                Console.WriteLine($"Удален товар {oldItem.Name} с Id {oldItem.Id}");
                break;
            case NotifyCollectionChangedAction.Replace:
            case NotifyCollectionChangedAction.Move:
            case NotifyCollectionChangedAction.Reset:
            default:
                break;
        }
    }
}
