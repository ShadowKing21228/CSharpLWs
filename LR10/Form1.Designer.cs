namespace LR10;

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

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
private void InitializeComponent()
{
    this.txtInput = new TextBox();
    this.txtRegex = new TextBox();
    this.btnFind = new Button();
    this.btnClear = new Button();
    this.listMatches = new ListBox();
    this.lblCount = new Label();
    this.SuspendLayout();

    // txtInput
    this.txtInput.Location = new System.Drawing.Point(20, 20);
    this.txtInput.Multiline = true;
    this.txtInput.Size = new System.Drawing.Size(400, 100);
    this.txtInput.ScrollBars = ScrollBars.Vertical;

    // txtRegex
    this.txtRegex.Location = new System.Drawing.Point(20, 130);
    this.txtRegex.Size = new System.Drawing.Size(400, 23);

    // btnFind
    this.btnFind.Location = new System.Drawing.Point(20, 160);
    this.btnFind.Size = new System.Drawing.Size(100, 30);
    this.btnFind.Text = "Найти";
    this.btnFind.Click += new EventHandler(this.btnFind_Click);

    // btnClear
    this.btnClear.Location = new System.Drawing.Point(130, 160);
    this.btnClear.Size = new System.Drawing.Size(100, 30);
    this.btnClear.Text = "Очистить";
    this.btnClear.Click += new EventHandler(this.btnClear_Click);

    // lblCount
    this.lblCount.Location = new System.Drawing.Point(20, 200);
    this.lblCount.Size = new System.Drawing.Size(300, 20);
    this.lblCount.Text = "Найдено совпадений: 0";

    // listMatches
    this.listMatches.Location = new System.Drawing.Point(20, 230);
    this.listMatches.Size = new System.Drawing.Size(400, 150);

    // Form1
    this.ClientSize = new System.Drawing.Size(450, 400);
    this.Controls.Add(this.txtInput);
    this.Controls.Add(this.txtRegex);
    this.Controls.Add(this.btnFind);
    this.Controls.Add(this.btnClear);
    this.Controls.Add(this.lblCount);
    this.Controls.Add(this.listMatches);
    this.Text = "Регулярные выражения";
    this.ResumeLayout(false);
    this.PerformLayout();
}   
    private TextBox txtInput;
    private TextBox txtRegex;
    private Button btnFind;
    private Button btnClear;
    private ListBox listMatches;
    private Label lblCount;
    #endregion
}