namespace LR6;

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

            this.ClientSize = new System.Drawing.Size(800, 830);
            this.Controls.Add(this.comboTables);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.lblQuery);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.btnExecuteQuery);
            this.Text = "GameBase Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            
            this.lblQuery = new System.Windows.Forms.Label();
            this.lblQuery.Text = "Произвольный SQL-запрос:";
            this.lblQuery.Location = new System.Drawing.Point(30, 450);
            this.lblQuery.Size = new System.Drawing.Size(300, 20);
            
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.txtQuery.Location = new System.Drawing.Point(30, 470);
            this.txtQuery.Size = new System.Drawing.Size(700, 80);
            this.txtQuery.Multiline = true;
            this.txtQuery.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            
            this.btnExecuteQuery = new System.Windows.Forms.Button();
            this.btnExecuteQuery.Text = "Выполнить";
            this.btnExecuteQuery.Location = new System.Drawing.Point(30, 560);
            this.btnExecuteQuery.Size = new System.Drawing.Size(120, 30);
            this.btnExecuteQuery.Click += new System.EventHandler(this.btnExecuteQuery_Click);
            
            this.Controls.Add(this.lblQuery);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.btnExecuteQuery);
            this.lblFunc = new Label();
            this.lblFunc.Text = "Выберите функцию:";
            this.lblFunc.Location = new Point(30, 600);
            this.lblFunc.Size = new Size(200, 20);
            
            this.comboFunction = new ComboBox();
            this.comboFunction.Location = new Point(30, 625);
            this.comboFunction.Size = new Size(300, 28);
            this.comboFunction.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboFunction.Items.AddRange(new string[] {
                "get_games_by_genre",
                "get_average_price_by_genre",
                "add_game"
            });
            this.comboFunction.SelectedIndexChanged += comboFunction_SelectedIndexChanged;
            
            this.panelParams = new Panel();
            this.panelParams.Location = new Point(30, 660);
            this.panelParams.Size = new Size(700, 100);
            this.panelParams.AutoScroll = true;
            
            this.btnCallFunction = new Button();
            this.btnCallFunction.Text = "Вызвать";
            this.btnCallFunction.Location = new Point(30, 800);
            this.btnCallFunction.Size = new Size(100, 30);
            this.btnCallFunction.Click += btnCallFunction_Click;

            this.Controls.Add(this.lblFunc);
            this.Controls.Add(this.comboFunction);
            this.Controls.Add(this.panelParams);
            this.Controls.Add(this.btnCallFunction);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Label lblFunc;
        private System.Windows.Forms.ComboBox comboFunction;
        private System.Windows.Forms.Panel panelParams;
        private System.Windows.Forms.Button btnCallFunction;
        private System.Windows.Forms.Label lblQuery;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Button btnExecuteQuery;
        private System.Windows.Forms.ComboBox comboTables;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dataGridView;
    }