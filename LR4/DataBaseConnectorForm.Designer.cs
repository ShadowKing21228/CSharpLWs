namespace LR4;

partial class DataBaseConnectorForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DBName = new System.Windows.Forms.TextBox();
            DBPassword = new System.Windows.Forms.TextBox();
            DBUsername = new System.Windows.Forms.TextBox();
            DBIP = new System.Windows.Forms.TextBox();
            DBPort = new System.Windows.Forms.TextBox();
            ConnectionStateLabel = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            connectionStringLabel = new System.Windows.Forms.Label();
            button4 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // DBName
            // 
            DBName.Location = new System.Drawing.Point(105, 196);
            DBName.Name = "DBName";
            DBName.Size = new System.Drawing.Size(187, 23);
            DBName.TabIndex = 0;
            DBName.Text = "DBName";
            // 
            // DBPassword
            // 
            DBPassword.Location = new System.Drawing.Point(105, 167);
            DBPassword.Name = "DBPassword";
            DBPassword.Size = new System.Drawing.Size(187, 23);
            DBPassword.TabIndex = 1;
            DBPassword.Text = "Password";
            // 
            // DBUsername
            // 
            DBUsername.Location = new System.Drawing.Point(105, 138);
            DBUsername.Name = "DBUsername";
            DBUsername.Size = new System.Drawing.Size(187, 23);
            DBUsername.TabIndex = 2;
            DBUsername.Text = "Username";
            // 
            // DBIP
            // 
            DBIP.Location = new System.Drawing.Point(105, 80);
            DBIP.Name = "DBIP";
            DBIP.Size = new System.Drawing.Size(187, 23);
            DBIP.TabIndex = 3;
            DBIP.Text = "IP";
            // 
            // DBPort
            // 
            DBPort.Location = new System.Drawing.Point(105, 109);
            DBPort.Name = "DBPort";
            DBPort.Size = new System.Drawing.Size(187, 23);
            DBPort.TabIndex = 4;
            DBPort.Text = "Port";
            // 
            // ConnectionStateLabel
            // 
            ConnectionStateLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
            ConnectionStateLabel.Location = new System.Drawing.Point(399, 167);
            ConnectionStateLabel.Name = "ConnectionStateLabel";
            ConnectionStateLabel.Size = new System.Drawing.Size(304, 85);
            ConnectionStateLabel.TabIndex = 5;
            ConnectionStateLabel.Text = "Подключение неизвестно";
            ConnectionStateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(105, 271);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(187, 41);
            button1.TabIndex = 6;
            button1.Text = "Подключится";
            button1.UseVisualStyleBackColor = true;
            button1.Click += dbConnect;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(105, 318);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(187, 41);
            button2.TabIndex = 7;
            button2.Text = "Отключится";
            button2.UseVisualStyleBackColor = true;
            button2.Click += dbCloseConnection;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(105, 365);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(187, 41);
            button3.TabIndex = 8;
            button3.Text = "Получить состояние подключения";
            button3.UseVisualStyleBackColor = true;
            button3.Click += getConnectionState;
            // 
            // connectionStringLabel
            // 
            connectionStringLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
            connectionStringLabel.Location = new System.Drawing.Point(1, 24);
            connectionStringLabel.Name = "connectionStringLabel";
            connectionStringLabel.Size = new System.Drawing.Size(389, 41);
            connectionStringLabel.TabIndex = 9;
            connectionStringLabel.Text = "Текущая строка подключения";
            connectionStringLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            connectionStringLabel.Click += connectionStringLabel_Click;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(105, 225);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(187, 41);
            button4.TabIndex = 10;
            button4.Text = "Обновить строку подключения";
            button4.UseVisualStyleBackColor = true;
            button4.Click += updateConnectionString;
            // 
            // DataBaseConnectorForm
            // 
            ClientSize = new System.Drawing.Size(780, 460);
            Controls.Add(button4);
            Controls.Add(connectionStringLabel);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(ConnectionStateLabel);
            Controls.Add(DBPort);
            Controls.Add(DBIP);
            Controls.Add(DBUsername);
            Controls.Add(DBPassword);
            Controls.Add(DBName);
            Text = "GameBase Viewer";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button button4;

        private System.Windows.Forms.Label connectionStringLabel;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.TextBox DBPort;
        private System.Windows.Forms.Label ConnectionStateLabel;

        private System.Windows.Forms.TextBox DBName;
        private System.Windows.Forms.TextBox DBPassword;
        private System.Windows.Forms.TextBox DBUsername;
        private System.Windows.Forms.TextBox DBIP;
    }