namespace LR12;

public partial class SettingsForm : Form
{
    public SettingsForm()
    {
        InitializeComponent();
    }
    
    private void changeWindow(object sender, EventArgs e)
    {
        var mainWindow = new Form1();
        Hide();
        mainWindow.Show();
    }
}