namespace LR11;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void textBoxInput_KeyPress(object sender, KeyPressEventArgs e)
    {
        listBoxKeys.Items.Add($"[{DateTime.Now}] Вы нажали: '{e.KeyChar}' (код: {(int)e.KeyChar})");
    }
    private void TextBoxClear(object sender, EventArgs e)
    {
        listBoxKeys.Items.Clear();
    }
}