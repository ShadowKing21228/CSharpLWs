using StringSorterProject;

namespace LR2
{
    public partial class Form1 : Form
    {
        private string[] lines;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "strings.txt");

            if (File.Exists(filePath))
            {
                lines = File.ReadAllLines(filePath);
                listBoxStrings.Items.AddRange(lines);
            }
            else
            {
                MessageBox.Show("Файл strings.txt не найден.");
                File.Create(filePath);
                lines = Array.Empty<string>();
            }
        }

        private void btnSortAsc_Click(object sender, EventArgs e)
        {
            var var = SortAscending(lines);
            UpdateListBox(var);
        }

        private void btnSortDesc_Click(object sender, EventArgs e)
        {
            var var = SortDescending(lines);
            UpdateListBox(var);
        }

        private void UpdateListBox(string[] sorted)
        {
            listBoxStrings.Items.Clear();
            listBoxStrings.Items.AddRange(sorted);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var text = txtInput.Text.Trim();
            if (!string.IsNullOrEmpty(text))
            {
                listBoxStrings.Items.Add(text);
                txtInput.Clear();
                UpdateLinesFromListBox();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBoxStrings.SelectedItem != null)
            {
                listBoxStrings.Items.Remove(listBoxStrings.SelectedItem);
                UpdateLinesFromListBox();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int index = listBoxStrings.SelectedIndex;
            if (index >= 0 && !string.IsNullOrWhiteSpace(txtInput.Text))
            {
                listBoxStrings.Items[index] = txtInput.Text.Trim();
                txtInput.Clear();
                UpdateLinesFromListBox();
            }
        }
        
        private void UpdateLinesFromListBox()
        {
            lines = listBoxStrings.Items.Cast<string>().ToArray();
        }
        private static string[] SortAscending(string[] input)
        {
            string[] arr = (string[])input.Clone();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (string.Compare(arr[j], arr[j + 1], StringComparison.OrdinalIgnoreCase) > 0)
                    {
                        string temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }
        private static string[] SortDescending(string[] input)
        {
            string[] arr = (string[])input.Clone();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (string.Compare(arr[j], arr[j + 1], StringComparison.OrdinalIgnoreCase) < 0)
                    {
                        string temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }
    }
}