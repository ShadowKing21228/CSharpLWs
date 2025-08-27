namespace LR4;

partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.comboTables = new System.Windows.Forms.ComboBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();

            // comboTables
            this.comboTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTables.Location = new System.Drawing.Point(30, 30);
            this.comboTables.Name = "comboTables";
            this.comboTables.Size = new System.Drawing.Size(200, 28);

            // btnLoad
            this.btnLoad.Location = new System.Drawing.Point(250, 30);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(100, 30);
            this.btnLoad.Text = "Загрузить";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);

            // dataGridView
            this.dataGridView.Location = new System.Drawing.Point(30, 80);
            this.dataGridView.Size = new System.Drawing.Size(700, 350);
            this.dataGridView.ReadOnly = true;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // Form1
            this.ClientSize = new System.Drawing.Size(780, 460);
            this.Controls.Add(this.comboTables);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dataGridView);
            this.Text = "GameBase Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ComboBox comboTables;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dataGridView;
    }