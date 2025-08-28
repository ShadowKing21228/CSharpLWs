namespace LR13;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnOpenFile_Click(object sender, EventArgs e)
    {
        OpenFileDialog openDialog = new OpenFileDialog();
        openDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
        openDialog.Title = "Выберите документ";

        if (openDialog.ShowDialog() == DialogResult.OK)
        {
            try
            {
                string content = File.ReadAllText(openDialog.FileName);
                richTextBoxViewer.Text = content;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при чтении файла: " + ex.Message);
            }
        }
    }
}