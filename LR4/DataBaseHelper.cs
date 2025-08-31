using System.Data;
using Npgsql;

namespace LR4;

public class DatabaseHelper
{
    //private const string connectionString = "Host=localhost;Username=GameBaseUser;Password=123321;Database=GameBase";
    private readonly string connectionString;
    private NpgsqlConnection connection;
    public DatabaseHelper(String connectionString)
    {
        this.connectionString = connectionString;
    }
    public DataTable GetTables()
    {
        using var conn = new NpgsqlConnection(connectionString);
        conn.Open();

        string query = "SELECT table_name FROM information_schema.tables WHERE table_schema = 'public';";

        using var cmd = new NpgsqlCommand(query, conn);
        using var reader = cmd.ExecuteReader();

        var table = new DataTable();
        table.Load(reader);
        return table;
    }

    public Exception? ConnectToDataBase()
    {
        var conn = new NpgsqlConnection(connectionString);
        
        try {
            conn.Open();
            connection = conn;
        }
        
        catch (Exception? e) {
            return e;
        }
        return null;
    }
    
    public ConnectionState GetConnectionState()
    { ;
        return connection.State;
    }
    
    public void CloseDataBaseConnection()
    {
        connection.Close();
    }
}