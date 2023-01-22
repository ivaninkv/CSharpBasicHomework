using Dapper;
using Npgsql;
using ORM.App.Models;

namespace ORM.App.Repositories;

public class CustomerRepository
{
    public List<Customer> GetCustomers()
    {
        const string query = "select \"ID\", \"FirstName\", \"LastName\", \"Age\" from \"Customers\"";
        using var conn = new NpgsqlConnection(Config.ConnectionString);
        var list = conn.Query<Customer>(query);
        return list.ToList();
    }

    public Customer GetCustomerById(int id)
    {
        const string query =
            "select \"ID\", \"FirstName\", \"LastName\", \"Age\" from \"Customers\" where \"ID\" = @id";
        using var conn = new NpgsqlConnection(Config.ConnectionString);
        return conn.QueryFirstOrDefault<Customer>(query, new { id });
    }
}
