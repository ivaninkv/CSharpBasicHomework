namespace TopExt.App;

public static class TopExtension
{
    public static IEnumerable<T> Top<T>(this IEnumerable<T> collection, int percent)
    {
        if (percent is < 1 or > 100)
        {
            throw new ArgumentException("Argument should be between 1 and 100");
        }

        var qtyElements = (int)Math.Ceiling(collection.Count() * percent / 100.0);
        return collection.OrderByDescending(x => x)
            .Take(qtyElements);
    }

    public static IEnumerable<T> Top<T>(this IEnumerable<T> collection, int percent,
        Func<T, int> orderByField)
    {
        if (percent is < 1 or > 100)
        {
            throw new ArgumentException("Argument should be between 1 and 100");
        }

        var qtyElements = (int)Math.Ceiling(collection.Count() * percent / 100.0);
        return collection.OrderByDescending(orderByField)
            .Take(qtyElements);
    }
}
