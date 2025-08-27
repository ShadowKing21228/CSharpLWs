using System.Data;
using System.Text;
using Npgsql;

namespace LR7;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        try
        {
            DataTable tables = DatabaseHelper.GetTables();
            foreach (DataRow row in tables.Rows)
            {
                comboTables.Items.Add(row["table_name"].ToString());
            }

            if (comboTables.Items.Count > 0)
                comboTables.SelectedIndex = 0;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ошибка загрузки таблиц: " + ex.Message);
        }
    }

    private void btnLoad_Click(object sender, EventArgs e)
    {
        try
        {
            string selectedTable = comboTables.SelectedItem.ToString();
            DataTable tableData = DatabaseHelper.GetTableData(selectedTable);
            dataGridView.DataSource = tableData;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ошибка загрузки данных: " + ex.Message);
        }
    }
    private void btnExecuteQuery_Click(object sender, EventArgs e)
    {
        string sql = txtQuery.Text.Trim();
        if (string.IsNullOrEmpty(sql))
        {
            MessageBox.Show("Введите SQL-запрос.");
            return;
        }

        try
        {
            // Проверим, SELECT ли это
            if (sql.StartsWith("select", StringComparison.OrdinalIgnoreCase))
            {
                var result = DatabaseHelper.ExecuteQuery(sql);
                dataGridView.DataSource = result;
            }
            else
            {
                int affectedRows = DatabaseHelper.ExecuteNonQuery(sql);
                MessageBox.Show($"Запрос выполнен. Затронуто строк: {affectedRows}");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ошибка при выполнении запроса:\n" + ex.Message);
        }
    }
    private void comboFunction_SelectedIndexChanged(object sender, EventArgs e)
    {
        panelParams.Controls.Clear();
        string selected = comboFunction.SelectedItem?.ToString();

        if (selected == "get_games_by_genre" || selected == "get_average_price_by_genre")
        {
            var lbl = new Label() { Text = "Жанр:", Location = new Point(0, 10), Width = 80 };
            var txt = new TextBox() { Name = "txtGenre", Location = new Point(90, 7), Width = 200 };
            panelParams.Controls.Add(lbl);
            panelParams.Controls.Add(txt);
        }
        else if (selected == "add_game")
        {
            panelParams.Controls.Add(new Label() { Text = "Название:", Location = new Point(0, 10), Width = 80 });
            panelParams.Controls.Add(new TextBox() { Name = "txtName", Location = new Point(90, 7), Width = 200 });

            panelParams.Controls.Add(new Label() { Text = "Дата:", Location = new Point(0, 40), Width = 80 });
            panelParams.Controls.Add(new DateTimePicker() { Name = "dateRelease", Location = new Point(90, 37), Width = 200 });

            panelParams.Controls.Add(new Label() { Text = "Цена:", Location = new Point(0, 70), Width = 80 });
            panelParams.Controls.Add(new TextBox() { Name = "txtPrice", Location = new Point(90, 67), Width = 200 });

            panelParams.Controls.Add(new Label() { Text = "Жанр:", Location = new Point(0, 100), Width = 80 });
            panelParams.Controls.Add(new TextBox() { Name = "txtGenre", Location = new Point(90, 97), Width = 200 });
        }
    }
    private void btnCallFunction_Click(object sender, EventArgs e)
{
    string func = comboFunction.SelectedItem?.ToString();
    if (func == null) return;

    try
    {
        using var conn = new NpgsqlConnection("Host=localhost;Username=GameBaseUser;Password=123321;Database=GameBase");
        conn.Open();

        using var cmd = new NpgsqlCommand();
        cmd.Connection = conn;

        if (func == "get_games_by_genre")
        {
            string genre = panelParams.Controls["txtGenre"].Text;
            cmd.CommandText = "SELECT * FROM get_games_by_genre(@genre)";
            cmd.Parameters.AddWithValue("genre", genre);

            var dt = new DataTable();
            new NpgsqlDataAdapter(cmd).Fill(dt);
            dataGridView.DataSource = dt;
        }
        else if (func == "get_average_price_by_genre")
        {
            string genre = panelParams.Controls["txtGenre"].Text;
            cmd.CommandText = "SELECT get_average_price_by_genre(@genre)";
            cmd.Parameters.AddWithValue("genre", genre);

            object result = cmd.ExecuteScalar();
            MessageBox.Show($"Средняя цена: {result}");
        }
        else if (func == "add_game")
        {
            string name = panelParams.Controls["txtName"].Text;
            DateTime release = ((DateTimePicker)panelParams.Controls["dateRelease"]).Value;
            int price = int.Parse(panelParams.Controls["txtPrice"].Text);
            string genre = panelParams.Controls["txtGenre"].Text;

            cmd.CommandText = "SELECT add_game(@name, @release, @price, @genre)";
            cmd.Parameters.AddWithValue("name", name);
            cmd.Parameters.AddWithValue("release", release);
            cmd.Parameters.AddWithValue("price", price);
            cmd.Parameters.AddWithValue("genre", genre);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Игра добавлена.");
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("Ошибка: " + ex.Message);
    }
}
    private void LoadDataForPrinting()
    {
        using (var conn = new NpgsqlConnection("Host=localhost;Username=GameBaseUser;Password=123321;Database=GameBase"))
        {
            conn.Open();
        
            // Пример запроса
            var cmd = new NpgsqlCommand("SELECT g.name, g.release_date, g.price, gn.name AS genre FROM game g JOIN genre gn ON g.genre_id = gn.id", conn);
        
            var reader = cmd.ExecuteReader();
            StringBuilder sb = new StringBuilder();

            // Формирование строки для печати
            while (reader.Read())
            {
                sb.AppendLine($"Название: {reader["name"]}, Дата выпуска: {reader["release_date"]}, Цена: {reader["price"]}, Жанр: {reader["genre"]}");
            }

            // Выводим в RichTextBox
            txtDataToPrint.Text = sb.ToString();
        }
    }
    private void btnPrint_Click(object sender, EventArgs e)
    {
        // Загружаем данные для печати в текстовое поле
        LoadDataForPrinting();

        // Открываем диалог предварительного просмотра
        printPreviewDialog.ShowDialog();
    }

    private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
    {
        // Получаем информацию из RichTextBox
        string printData = txtDataToPrint.Text;

        // Выводим текст на страницу
        e.Graphics.DrawString(printData, new Font("Arial", 12), Brushes.Black, 100, 100);

        // Указываем, что больше страниц нет
        e.HasMorePages = false;
    }
    
}