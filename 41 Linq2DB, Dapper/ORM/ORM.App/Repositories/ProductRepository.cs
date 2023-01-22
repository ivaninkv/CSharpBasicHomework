using Dapper;
using Npgsql;
using ORM.App.Models;

namespace ORM.App.Repositories;

public class ProductRepository
{
    public List<Product> GetProducts()
    {
        const string query = "select \"ID\", \"Name\", \"Description\", \"StockQuantity\", \"Price\" from \"Products\"";
        using var conn = new NpgsqlConnection(Config.ConnectionString);
        var list = conn.Query<Product>(query);
        return list.ToList();
    }

    public Product GetProductById(int id)
    {
        const string query =
            "select \"ID\", \"Name\", \"Description\", \"StockQuantity\", \"Price\" from \"Products\" where \"ID\" = @id";
        using var conn = new NpgsqlConnection(Config.ConnectionString);
        return conn.QueryFirstOrDefault<Product>(query, new { id });
    }
}
