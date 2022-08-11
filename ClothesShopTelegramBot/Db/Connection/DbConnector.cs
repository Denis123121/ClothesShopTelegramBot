namespace ClothesShopTelegramBot.Db.Connection;
using Npgsql;

public class DbConnector
{
    private static DbConnector _connector = null;
    
    private const string connectionString = 
        "Host=194.67.105.79;Username=warriorbotuser;Password=679;Database=warriorbotdb";
    
    private NpgsqlConnection _connection;

    private DbConnector()
    {
        _connection = new NpgsqlConnection(connectionString);
        _connection.Open();
    }

    public static NpgsqlConnection GetConnection()
    {
        if (_connector == null)
        {
            _connector = new DbConnector();
        }

        return _connector._connection;
    }
}