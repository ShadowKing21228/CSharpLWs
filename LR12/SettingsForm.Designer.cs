using System.ComponentModel;

namespace LR12;

partial class SettingsForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
        changeWindowButton.Location = new System.Drawing.Point(241, 294);
        changeWindowButton.Name = "changeWindowButton";
        changeWindowButton.Size = new System.Drawing.Size(300, 108);
        changeWindowButton.TabIndex = 0;
        changeWindowButton.Text = "Перейти в основное окно";
        changeWindowButton.UseVisualStyleBackColor = true;
        changeWindowButton.Click += changeWindow;
        // 
        // SettingsForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(changeWindowButton);
        RightToLeftLayout = true;
        Text = "SettingsForm";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button changeWindowButton;

    #endregion
}