using System.Text.RegularExpressions;

namespace LR10;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnFind_Click(object sender, EventArgs e)
    {
        listMatches.Items.Clear();

        string input = txtInput.Text;
        string pattern = txtRegex.Text;

        try
        {
            MatchCollection matches = Regex.Matches(input, pattern);
            lblCount.Text = $"Найдено совпадений: {matches.Count}";

            foreach (Match match in matches)
            {
                listMatches.Items.Add(match.Value);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка регулярного выражения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        txtInput.Clear();
        txtRegex.Clear();
        listMatches.Items.Clear();
        lblCount.Text = "Найдено совпадений: 0";
    }
}