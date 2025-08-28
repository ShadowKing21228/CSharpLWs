namespace LR13;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    
    private RichTextBox richTextBoxViewer;
    
    private Button btnOpenFile;
    
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
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "Form1";
        
        richTextBoxViewer = new RichTextBox();
        richTextBoxViewer.Name = "richTextBoxViewer";
        richTextBoxViewer.Dock = DockStyle.Fill;
        richTextBoxViewer.ReadOnly = true;
        richTextBoxViewer.Font = new Font("Consolas", 12);
        this.Controls.Add(richTextBoxViewer);
    
        btnOpenFile = new Button();
        btnOpenFile.Click += btnOpenFile_Click;
        btnOpenFile.Text = "Открыть файл (.txt)";
        btnOpenFile.Dock = DockStyle.Top;
        
        this.Controls.Add(btnOpenFile);
    }

    #endregion
}