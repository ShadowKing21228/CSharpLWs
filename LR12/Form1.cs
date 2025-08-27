namespace LR12;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    
    private void changeWindow(object sender, EventArgs e)
    {
        SettingsForm settings = new SettingsForm();
        Hide();
        settings.Show();
    }
}