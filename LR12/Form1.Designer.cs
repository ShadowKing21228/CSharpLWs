namespace LR12;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.Button changeWindowButton;

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

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        changeWindowButton = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // changeWindowButton
        // 
        changeWindowButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        changeWindowButton.Location = new System.Drawing.Point(247, 282);
        changeWindowButton.Name = "changeWindowButton";
        changeWindowButton.Size = new System.Drawing.Size(319, 135);
        changeWindowButton.TabIndex = 0;
        changeWindowButton.Text = "Перейти в окно настроек\r\n\r\n";
        changeWindowButton.Click += changeWindow;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(changeWindowButton);
        Text = "Form1";
        ResumeLayout(false);
    }
}