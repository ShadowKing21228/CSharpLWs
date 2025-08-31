using System.Data;
using Npgsql;

namespace LR5;

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
    
    public DataTable GetTableData(string tableName)
    {
        using var conn = new NpgsqlConnection(connectionString);
        conn.Open();

        string query = $"SELECT * FROM \"{tableName}\"";

        using var cmd = new NpgsqlCommand(query, conn);
        using var adapter = new NpgsqlDataAdapter(cmd);

        var dataTable = new DataTable();
        adapter.Fill(dataTable);
        return dataTable;
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
    {
        return connection.State;
    }
    
    public void CloseDataBaseConnection()
    {
        connection.Close();
    }
    public int ExecuteNonQuery(string sql)
    {
        using var conn = new NpgsqlConnection(connectionString);
        conn.Open();

        using var cmd = new NpgsqlCommand(sql, conn);
        return cmd.ExecuteNonQuery(); // Возвращает число затронутых строк
    }

    // 🔹 Выполнить запрос и вернуть одно значение (например, COUNT(*))
    public object ExecuteScalar(string sql)
    {
        using var conn = new NpgsqlConnection(connectionString);
        conn.Open();

        using var cmd = new NpgsqlCommand(sql, conn);
        return cmd.ExecuteScalar(); // Возвращает результат первой строки, первого столбца
    }
    public DataTable ExecuteQuery(string sql)
    {
        using var conn = new NpgsqlConnection(connectionString);
        conn.Open();

        using var cmd = new NpgsqlCommand(sql, conn);
        using var adapter = new NpgsqlDataAdapter(cmd);
    
        var dt = new DataTable();
        adapter.Fill(dt); // Получаем результат запроса
        return dt;
    }
}