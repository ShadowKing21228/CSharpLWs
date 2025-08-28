namespace LR14;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        lblFileName = new System.Windows.Forms.Label();
        selectButton = new System.Windows.Forms.Button();
        playButton = new System.Windows.Forms.Button();
        pauseButton = new System.Windows.Forms.Button();
        StopButton = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // lblFileName
        // 
        lblFileName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        lblFileName.Location = new System.Drawing.Point(110, 121);
        lblFileName.Name = "lblFileName";
        lblFileName.Size = new System.Drawing.Size(552, 70);
        lblFileName.TabIndex = 0;
        lblFileName.Text = "Файл не выбран";
        lblFileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // selectButton
        // 
        selectButton.Location = new System.Drawing.Point(264, 289);
        selectButton.Name = "selectButton";
        selectButton.Size = new System.Drawing.Size(244, 54);
        selectButton.TabIndex = 1;
        selectButton.Text = "Выбрать файл";
        selectButton.UseVisualStyleBackColor = true;
        selectButton.Click += btnOpen_Click;
        // 
        // playButton
        // 
        playButton.AutoSize = true;
        playButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        playButton.Location = new System.Drawing.Point(247, 208);
        playButton.Name = "playButton";
        playButton.Size = new System.Drawing.Size(62, 40);
        playButton.TabIndex = 2;
        playButton.Text = " ▶";
        playButton.UseVisualStyleBackColor = true;
        playButton.Click += btnPlay_Click;
        // 
        // pauseButton
        // 
        pauseButton.AutoSize = true;
        pauseButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        pauseButton.Location = new System.Drawing.Point(352, 208);
        pauseButton.Name = "pauseButton";
        pauseButton.Size = new System.Drawing.Size(61, 40);
        pauseButton.TabIndex = 3;
        pauseButton.Text = "❚❚";
        pauseButton.UseVisualStyleBackColor = true;
        pauseButton.Click += btnPause_Click;
        // 
        // StopButton
        // 
        StopButton.AutoSize = true;
        StopButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        StopButton.Location = new System.Drawing.Point(452, 208);
        StopButton.Name = "StopButton";
        StopButton.Size = new System.Drawing.Size(56, 40);
        StopButton.TabIndex = 4;
        StopButton.Text = "◼";
        StopButton.UseVisualStyleBackColor = true;
        StopButton.Click += btnStop_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(StopButton);
        Controls.Add(pauseButton);
        Controls.Add(playButton);
        Controls.Add(selectButton);
        Controls.Add(lblFileName);
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button StopButton;

    private System.Windows.Forms.Button pauseButton;

    private System.Windows.Forms.Button playButton;

    private System.Windows.Forms.Button selectButton;

    private System.Windows.Forms.Label lblFileName;

    private System.Windows.Forms.RichTextBox richTextBox1;

    #endregion
}