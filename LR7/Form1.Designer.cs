namespace LR7;

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
    this.lblQuery = new System.Windows.Forms.Label();
    this.txtQuery = new System.Windows.Forms.TextBox();
    this.btnExecuteQuery = new System.Windows.Forms.Button();
    this.lblFunc = new System.Windows.Forms.Label();
    this.comboFunction = new System.Windows.Forms.ComboBox();
    this.panelParams = new System.Windows.Forms.Panel();
    this.btnCallFunction = new System.Windows.Forms.Button();
    this.lblInfo = new System.Windows.Forms.Label();
    this.txtDataToPrint = new System.Windows.Forms.RichTextBox();
    this.btnPrint = new System.Windows.Forms.Button();
    this.printDocument = new System.Drawing.Printing.PrintDocument();
    this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
    this.tabControl = new System.Windows.Forms.TabControl();
    this.tabTables = new System.Windows.Forms.TabPage();
    this.tabSQL = new System.Windows.Forms.TabPage();
    this.tabFunctions = new System.Windows.Forms.TabPage();
    this.tabPrint = new System.Windows.Forms.TabPage();

    ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
    this.SuspendLayout();

    // comboTables
    this.comboTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
    this.comboTables.Location = new System.Drawing.Point(20, 20);
    this.comboTables.Name = "comboTables";
    this.comboTables.Size = new System.Drawing.Size(200, 28);

    // btnLoad
    this.btnLoad.Location = new System.Drawing.Point(250, 20);
    this.btnLoad.Name = "btnLoad";
    this.btnLoad.Size = new System.Drawing.Size(100, 30);
    this.btnLoad.Text = "Загрузить";
    this.btnLoad.UseVisualStyleBackColor = true;
    this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);

    // dataGridView
    this.dataGridView.Location = new System.Drawing.Point(20, 60);
    this.dataGridView.Size = new System.Drawing.Size(700, 350);
    this.dataGridView.ReadOnly = true;
    this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

    // lblQuery
    this.lblQuery.Text = "Произвольный SQL-запрос:";
    this.lblQuery.Location = new System.Drawing.Point(20, 20);
    this.lblQuery.Size = new System.Drawing.Size(300, 20);

    // txtQuery
    this.txtQuery.Location = new System.Drawing.Point(20, 45);
    this.txtQuery.Size = new System.Drawing.Size(700, 80);
    this.txtQuery.Multiline = true;
    this.txtQuery.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;

    // btnExecuteQuery
    this.btnExecuteQuery.Text = "Выполнить";
    this.btnExecuteQuery.Location = new System.Drawing.Point(20, 140);
    this.btnExecuteQuery.Size = new System.Drawing.Size(120, 30);
    this.btnExecuteQuery.Click += new System.EventHandler(this.btnExecuteQuery_Click);

    // lblFunc
    this.lblFunc.Text = "Выберите функцию:";
    this.lblFunc.Location = new System.Drawing.Point(20, 20);
    this.lblFunc.Size = new System.Drawing.Size(200, 20);

    // comboFunction
    this.comboFunction.Location = new System.Drawing.Point(20, 45);
    this.comboFunction.Size = new System.Drawing.Size(300, 28);
    this.comboFunction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
    this.comboFunction.Items.AddRange(new string[] {
        "get_games_by_genre",
        "get_average_price_by_genre",
        "add_game"
    });
    this.comboFunction.SelectedIndexChanged += new System.EventHandler(this.comboFunction_SelectedIndexChanged);

    // panelParams
    this.panelParams.Location = new System.Drawing.Point(20, 85);
    this.panelParams.Size = new System.Drawing.Size(700, 100);
    this.panelParams.AutoScroll = true;

    // btnCallFunction
    this.btnCallFunction.Text = "Вызвать";
    this.btnCallFunction.Location = new System.Drawing.Point(20, 200);
    this.btnCallFunction.Size = new System.Drawing.Size(100, 30);
    this.btnCallFunction.Click += new System.EventHandler(this.btnCallFunction_Click);

    // lblInfo
    this.lblInfo.Text = "Информация для печати:";
    this.lblInfo.Location = new System.Drawing.Point(20, 20);
    this.lblInfo.Size = new System.Drawing.Size(200, 20);

    // txtDataToPrint
    this.txtDataToPrint.Location = new System.Drawing.Point(20, 45);
    this.txtDataToPrint.Size = new System.Drawing.Size(700, 70);

    // btnPrint
    this.btnPrint.Text = "Печать";
    this.btnPrint.Location = new System.Drawing.Point(20, 130);
    this.btnPrint.Size = new System.Drawing.Size(100, 30);
    this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);

    // printDocument
    this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);

    // printPreviewDialog
    this.printPreviewDialog.Document = this.printDocument;

    // tabControl
    this.tabControl.Location = new System.Drawing.Point(10, 10);
    this.tabControl.Size = new System.Drawing.Size(770, 780);
    this.tabControl.TabPages.AddRange(new TabPage[] {
        this.tabTables, this.tabSQL, this.tabFunctions, this.tabPrint
    });

    // tabTables
    this.tabTables.Text = "Просмотр таблиц";
    this.tabTables.Controls.Add(this.comboTables);
    this.tabTables.Controls.Add(this.btnLoad);
    this.tabTables.Controls.Add(this.dataGridView);

    // tabSQL
    this.tabSQL.Text = "SQL-запрос";
    this.tabSQL.Controls.Add(this.lblQuery);
    this.tabSQL.Controls.Add(this.txtQuery);
    this.tabSQL.Controls.Add(this.btnExecuteQuery);

    // tabFunctions
    this.tabFunctions.Text = "Функции БД";
    this.tabFunctions.Controls.Add(this.lblFunc);
    this.tabFunctions.Controls.Add(this.comboFunction);
    this.tabFunctions.Controls.Add(this.panelParams);
    this.tabFunctions.Controls.Add(this.btnCallFunction);

    // tabPrint
    this.tabPrint.Text = "Печать";
    this.tabPrint.Controls.Add(this.lblInfo);
    this.tabPrint.Controls.Add(this.txtDataToPrint);
    this.tabPrint.Controls.Add(this.btnPrint);

    // Form
    this.ClientSize = new System.Drawing.Size(800, 830);
    this.Controls.Add(this.tabControl);
    this.Text = "GameBase Viewer";
    this.Load += new System.EventHandler(this.Form1_Load);

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
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.RichTextBox txtDataToPrint;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabTables;
        private System.Windows.Forms.TabPage tabSQL;
        private System.Windows.Forms.TabPage tabFunctions;
        private System.Windows.Forms.TabPage tabPrint;
        private PrintPreviewDialog printPreviewDialog;
        
    }