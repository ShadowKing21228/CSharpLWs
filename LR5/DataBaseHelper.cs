using System.Data;
using Npgsql;

namespace LR5;

public static class DatabaseHelper
{
    private const string connectionString = "Host=localhost;Username=GameBaseUser;Password=123321;Database=GameBase";

    public static DataTable GetTables()
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

    public static DataTable GetTableData(string tableName)
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
    public static int ExecuteNonQuery(string sql)
    {
        using var conn = new NpgsqlConnection(connectionString);
        conn.Open();

        using var cmd = new NpgsqlCommand(sql, conn);
        return cmd.ExecuteNonQuery(); // Возвращает число затронутых строк
    }

    // 🔹 Выполнить запрос и вернуть одно значение (например, COUNT(*))
    public static object ExecuteScalar(string sql)
    {
        using var conn = new NpgsqlConnection(connectionString);
        conn.Open();

        using var cmd = new NpgsqlCommand(sql, conn);
        return cmd.ExecuteScalar(); // Возвращает результат первой строки, первого столбца
    }
    public static DataTable ExecuteQuery(string sql)
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