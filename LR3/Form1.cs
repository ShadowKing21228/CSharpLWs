namespace LR3;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnSelectFolder_Click(object sender, EventArgs e)
    {
        if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
        {
            listBoxFiles.Items.Clear();
            string selectedPath = folderBrowserDialog.SelectedPath;
            ScanDirectory(selectedPath);
        }
    }
    
    private void ScanDirectory(string path)
    {
        try
        {
            foreach (var file in Directory.GetFiles(path))
            {
                listBoxFiles.Items.Add(file);
            }
            
            foreach (var directory in Directory.GetDirectories(path))
            {
                ScanDirectory(directory);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ошибка: " + ex.Message);
        }
    }
}