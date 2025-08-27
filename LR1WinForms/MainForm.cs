namespace LR1WinForms;

    public partial class MainForm : Form
    {
        private string filePath = "strings.txt";
        private List<string> stringsList = new List<string>();

        public MainForm()
        {
            InitializeComponent();
            LoadStringsFromFile();
            DisplayStrings();
        }

        private void LoadStringsFromFile()
        {
            if (File.Exists(filePath))
            {
                stringsList = File.ReadAllLines(filePath).ToList();
            }
            else
            {
                stringsList = new List<string>();
            }
        }

        private void SaveStringsToFile()
        {
            File.WriteAllLines(filePath, stringsList);
        }

        private void DisplayStrings()
        {
            listBoxStrings.Items.Clear();
            foreach (var str in stringsList)
            {
                listBoxStrings.Items.Add(str);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string newString = textBoxInput.Text.Trim();
            if (!string.IsNullOrEmpty(newString))
            {
                stringsList.Add(newString);
                SaveStringsToFile();
                DisplayStrings();
                textBoxInput.Clear();
            }
            else
            {
                MessageBox.Show("Введите строку для добавления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listBoxStrings.SelectedIndex != -1)
            {
                string editedString = textBoxInput.Text.Trim();
                if (!string.IsNullOrEmpty(editedString))
                {
                    stringsList[listBoxStrings.SelectedIndex] = editedString;
                    SaveStringsToFile();
                    DisplayStrings();
                    textBoxInput.Clear();
                }
                else
                {
                    MessageBox.Show("Введите новое значение строки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Выберите строку для редактирования", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBoxStrings.SelectedIndex != -1)
            {
                stringsList.RemoveAt(listBoxStrings.SelectedIndex);
                SaveStringsToFile();
                DisplayStrings();
                textBoxInput.Clear();
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearch.Text.Trim();
            if (!string.IsNullOrEmpty(searchTerm))
            {
                List<string> results = new List<string>();
                
                foreach (string str in stringsList)
                {
                    bool found = false;
                    
                    for (int i = 0; i <= str.Length - searchTerm.Length; i++)
                    {
                        bool match = true;
                        for (int j = 0; j < searchTerm.Length; j++)
                        {
                            if (str[i + j] != searchTerm[j])
                            {
                                match = false;
                                break;
                            }
                        }
                        if (match)
                        {
                            found = true;
                            break;
                        }
                    }
                    
                    if (found)
                    {
                        results.Add(str);
                    }
                }
                
                listBoxStrings.Items.Clear();
                foreach (string result in results)
                {
                    listBoxStrings.Items.Add(result);
                }
            }
            else
            {
                DisplayStrings();
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            DisplayStrings();
            textBoxSearch.Clear();
        }

        private void listBoxStrings_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxStrings.SelectedIndex != -1)
            {
                textBoxInput.Text = stringsList[listBoxStrings.SelectedIndex];
            }
        }
    }