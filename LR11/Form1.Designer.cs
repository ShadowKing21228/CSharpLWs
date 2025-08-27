namespace LR11;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    private TextBox textBoxInput;
    private ListBox listBoxKeys;
    private Button clearButton;

    private void InitializeComponent()
    {
        this.textBoxInput = new TextBox();
        this.listBoxKeys = new ListBox();
        this.clearButton = new Button();

        // textBoxInput
        this.textBoxInput.Location = new System.Drawing.Point(20, 20);
        this.textBoxInput.Size = new System.Drawing.Size(300, 30);
        this.textBoxInput.KeyPress += new KeyPressEventHandler(this.textBoxInput_KeyPress);

        // listBoxKeys
        this.listBoxKeys.Location = new System.Drawing.Point(20, 60);
        this.listBoxKeys.Size = new System.Drawing.Size(300, 200);

        this.clearButton.Location = new System.Drawing.Point(20, 270);
        this.clearButton.Size = new System.Drawing.Size(100, 20);
        this.clearButton.Text = "Очистить";
        this.clearButton.Click += new EventHandler(this.TextBoxClear);
        // Form1
        this.ClientSize = new System.Drawing.Size(350, 300);
        this.Text = "Клавиатурный ввод";
        this.Controls.Add(this.clearButton);
        this.Controls.Add(this.textBoxInput);
        this.Controls.Add(this.listBoxKeys);
    }
}