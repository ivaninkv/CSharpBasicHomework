using Dapper;
using Npgsql;
using ORM.App.Models;

namespace ORM.App.Repositories;

public class OrderRepository
{
    public List<Order> GetOrders()
    {
        const string query = "select \"ID\", \"CustomerID\", \"ProductID\", \"Quantity\" from \"Orders\"";
        using var conn = new NpgsqlConnection(Config.ConnectionString);
        var list = conn.Query<Order>(query);
        return list.ToList();
    }

    public Order GetOrderById(int id)
    {
        const string query =
            "select \"ID\", \"CustomerID\", \"ProductID\", \"Quantity\" from \"Orders\" where \"ID\" = @id";
        using var conn = new NpgsqlConnection(Config.ConnectionString);
        return conn.QueryFirstOrDefault<Order>(query, new { id });
    }
}
