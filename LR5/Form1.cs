using System.Data;

namespace LR5;

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
}