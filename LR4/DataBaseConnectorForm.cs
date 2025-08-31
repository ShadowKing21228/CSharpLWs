using System.Data;

namespace LR4;

public partial class DataBaseConnectorForm : Form
{
    private DatabaseHelper dataBaseHelper;
    public DataBaseConnectorForm()
    {
        InitializeComponent();
        dataBaseHelper = new DatabaseHelper("");
    }
    
    private void updateConnectionString(object sender, EventArgs e)
    {
        dataBaseHelper = new DatabaseHelper($"Host={DBIP.Text};Username={DBUsername.Text};Password={DBPassword.Text};Database={DBName.Text}");
        connectionStringLabel.Text = $"Host={DBIP.Text};Username={DBUsername.Text};Password={DBPassword.Text};Database={DBName.Text}";
    }

    private void dbConnect(object sender, EventArgs e)
    {
        var var = dataBaseHelper.ConnectToDataBase();
        
        if (var != null) {
            MessageBox.Show(var.Message);
        }
    }
    
    private void dbCloseConnection(object sender, EventArgs e)
    {
        dataBaseHelper.CloseDataBaseConnection();
    }
    
    private void getConnectionState(object sender, EventArgs e)
    {
        var var = dataBaseHelper.GetConnectionState();
        if (var.Equals(ConnectionState.Closed))
            ConnectionStateLabel.Text = "Соединение закрыто";
        
        else if (var.Equals(ConnectionState.Open))
            ConnectionStateLabel.Text = "Подключено";
        
        else ConnectionStateLabel.Text = "Состояние неопределено";
    }
    private void getConnectionState()
    {
        var var = dataBaseHelper.GetConnectionState();
        if (var.Equals(ConnectionState.Closed))
            ConnectionStateLabel.Text = "Соединение закрыто";
        
        else if (var.Equals(ConnectionState.Open))
            ConnectionStateLabel.Text = "Подключено";
        
        else ConnectionStateLabel.Text = "Состояние неопределено";
    }

    private void connectionStringLabel_Click(object sender, EventArgs e)
    {
        throw new NotImplementedException();
    }
}