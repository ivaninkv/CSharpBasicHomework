namespace ORM.App;

public static class Config
{
    public static readonly string ConnectionString =
        Environment.GetEnvironmentVariable("CONNECTION_STRING") ??
        "User ID=postgres;Password=password;Host=localhost;Port=5432;Database=Shop;";
}
