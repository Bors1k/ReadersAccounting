
namespace WindowsFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подключениеКБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разлогинитьсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bOOKSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet = new WindowsFormsApp1.LibraryDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.butt_authorized = new System.Windows.Forms.Button();
            this.tb_book_search = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_books = new System.Windows.Forms.TabPage();
            this.tp_readers = new System.Windows.Forms.TabPage();
            this.bOOKSTableAdapter = new WindowsFormsApp1.LibraryDataSetTableAdapters.BOOKSTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.LibraryDataSetTableAdapters.TableAdapterManager();
            this.auT_ACCOUNTSTableAdapter1 = new WindowsFormsApp1.LibraryDataSetTableAdapters.AUT_ACCOUNTSTableAdapter();
            this.bOOKIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOOKNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aVAILABILITYDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tp_books.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1097, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.подключениеКБДToolStripMenuItem,
            this.разлогинитьсяToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // подключениеКБДToolStripMenuItem
            // 
            this.подключениеКБДToolStripMenuItem.Name = "подключениеКБДToolStripMenuItem";
            this.подключениеКБДToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.подключениеКБДToolStripMenuItem.Text = "Подключение к БД";
            this.подключениеКБДToolStripMenuItem.Click += new System.EventHandler(this.подключениеКБДToolStripMenuItem_Click);
            // 
            // разлогинитьсяToolStripMenuItem
            // 
            this.разлогинитьсяToolStripMenuItem.Name = "разлогинитьсяToolStripMenuItem";
            this.разлогинитьсяToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.разлогинитьсяToolStripMenuItem.Text = "Разлогиниться";
            this.разлогинитьсяToolStripMenuItem.Click += new System.EventHandler(this.разлогинитьсяToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bOOKIDDataGridViewTextBoxColumn,
            this.bOOKNAMEDataGridViewTextBoxColumn,
            this.aVAILABILITYDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.bOOKSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 62);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1075, 585);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // bOOKSBindingSource
            // 
            this.bOOKSBindingSource.DataMember = "BOOKS";
            this.bOOKSBindingSource.DataSource = this.libraryDataSet;
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(404, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(408, 160);
            this.tb_login.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(100, 20);
            this.tb_login.TabIndex = 4;
            this.tb_login.Text = "admin";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(410, 226);
            this.tb_password.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(100, 20);
            this.tb_password.TabIndex = 5;
            this.tb_password.Text = "admin";
            // 
            // butt_authorized
            // 
            this.butt_authorized.Location = new System.Drawing.Point(422, 266);
            this.butt_authorized.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.butt_authorized.Name = "butt_authorized";
            this.butt_authorized.Size = new System.Drawing.Size(74, 25);
            this.butt_authorized.TabIndex = 6;
            this.butt_authorized.Text = "Войти";
            this.butt_authorized.UseVisualStyleBackColor = true;
            this.butt_authorized.Click += new System.EventHandler(this.butt_authorized_Click);
            // 
            // tb_book_search
            // 
            this.tb_book_search.Location = new System.Drawing.Point(7, 25);
            this.tb_book_search.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tb_book_search.Name = "tb_book_search";
            this.tb_book_search.Size = new System.Drawing.Size(988, 20);
            this.tb_book_search.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1008, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 25);
            this.button1.TabIndex = 7;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_books);
            this.tabControl1.Controls.Add(this.tp_readers);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1097, 680);
            this.tabControl1.TabIndex = 8;
            this.tabControl1.Visible = false;
            // 
            // tp_books
            // 
            this.tp_books.Controls.Add(this.button1);
            this.tp_books.Controls.Add(this.tb_book_search);
            this.tp_books.Controls.Add(this.dataGridView1);
            this.tp_books.Location = new System.Drawing.Point(4, 23);
            this.tp_books.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tp_books.Name = "tp_books";
            this.tp_books.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tp_books.Size = new System.Drawing.Size(1089, 653);
            this.tp_books.TabIndex = 0;
            this.tp_books.Text = "Книги";
            this.tp_books.UseVisualStyleBackColor = true;
            // 
            // tp_readers
            // 
            this.tp_readers.Location = new System.Drawing.Point(4, 23);
            this.tp_readers.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tp_readers.Name = "tp_readers";
            this.tp_readers.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tp_readers.Size = new System.Drawing.Size(1089, 653);
            this.tp_readers.TabIndex = 1;
            this.tp_readers.Text = "Читатели";
            this.tp_readers.UseVisualStyleBackColor = true;
            // 
            // bOOKSTableAdapter
            // 
            this.bOOKSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AUT_ACCOUNTSTableAdapter = this.auT_ACCOUNTSTableAdapter1;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOOKSTableAdapter = this.bOOKSTableAdapter;
            this.tableAdapterManager.DEBTSTableAdapter = null;
            this.tableAdapterManager.READERSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.LibraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // auT_ACCOUNTSTableAdapter1
            // 
            this.auT_ACCOUNTSTableAdapter1.ClearBeforeFill = true;
            // 
            // bOOKIDDataGridViewTextBoxColumn
            // 
            this.bOOKIDDataGridViewTextBoxColumn.DataPropertyName = "BOOK_ID";
            this.bOOKIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.bOOKIDDataGridViewTextBoxColumn.Name = "bOOKIDDataGridViewTextBoxColumn";
            this.bOOKIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bOOKIDDataGridViewTextBoxColumn.Width = 70;
            // 
            // bOOKNAMEDataGridViewTextBoxColumn
            // 
            this.bOOKNAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bOOKNAMEDataGridViewTextBoxColumn.DataPropertyName = "BOOK_NAME";
            this.bOOKNAMEDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.bOOKNAMEDataGridViewTextBoxColumn.Name = "bOOKNAMEDataGridViewTextBoxColumn";
            this.bOOKNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aVAILABILITYDataGridViewCheckBoxColumn
            // 
            this.aVAILABILITYDataGridViewCheckBoxColumn.DataPropertyName = "AVAILABILITY";
            this.aVAILABILITYDataGridViewCheckBoxColumn.HeaderText = "Доступность";
            this.aVAILABILITYDataGridViewCheckBoxColumn.Name = "aVAILABILITYDataGridViewCheckBoxColumn";
            this.aVAILABILITYDataGridViewCheckBoxColumn.ReadOnly = true;
            this.aVAILABILITYDataGridViewCheckBoxColumn.Width = 80;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 707);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.butt_authorized);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MainForm";
            this.Text = "Учет читателей";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tp_books.ResumeLayout(false);
            this.tp_books.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подключениеКБДToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button butt_authorized;
        private System.Windows.Forms.TextBox tb_book_search;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_books;
        private System.Windows.Forms.TabPage tp_readers;
        private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource bOOKSBindingSource;
        private LibraryDataSetTableAdapters.BOOKSTableAdapter bOOKSTableAdapter;
        private LibraryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private LibraryDataSetTableAdapters.AUT_ACCOUNTSTableAdapter auT_ACCOUNTSTableAdapter1;
        private System.Windows.Forms.ToolStripMenuItem разлогинитьсяToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOOKIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOOKNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aVAILABILITYDataGridViewCheckBoxColumn;
    }
}

