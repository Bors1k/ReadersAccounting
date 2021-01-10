
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
            System.Windows.Forms.Label reader_IDLabel;
            System.Windows.Forms.Label fIOLabel;
            System.Windows.Forms.Label pASSPORTLabel;
            System.Windows.Forms.Label aDDRESSLabel;
            System.Windows.Forms.Label tELEPHONELabel;
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подключениеКБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разлогинитьсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.butt_authorized = new System.Windows.Forms.Button();
            this.tb_book_search = new System.Windows.Forms.TextBox();
            this.but_books_search_reset = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_books = new System.Windows.Forms.TabPage();
            this.booksDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.library451DataSet = new WindowsFormsApp1.Library451DataSet();
            this.tp_readers = new System.Windows.Forms.TabPage();
            this.readersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reader_IDTextBox = new System.Windows.Forms.TextBox();
            this.fIOTextBox = new System.Windows.Forms.TextBox();
            this.pASSPORTTextBox = new System.Windows.Forms.TextBox();
            this.aDDRESSTextBox = new System.Windows.Forms.TextBox();
            this.tELEPHONETextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.reades_debtsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reades_debtsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.but_readers_search_reset = new System.Windows.Forms.Button();
            this.tb_readers_search = new System.Windows.Forms.TextBox();
            this.booksTableAdapter = new WindowsFormsApp1.Library451DataSetTableAdapters.BooksTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.Library451DataSetTableAdapters.TableAdapterManager();
            this.autTableAdapter = new WindowsFormsApp1.Library451DataSetTableAdapters.autTableAdapter();
            this.reades_debtsTableAdapter = new WindowsFormsApp1.Library451DataSetTableAdapters.reades_debtsTableAdapter();
            this.readersTableAdapter = new WindowsFormsApp1.Library451DataSetTableAdapters.ReadersTableAdapter();
            reader_IDLabel = new System.Windows.Forms.Label();
            fIOLabel = new System.Windows.Forms.Label();
            pASSPORTLabel = new System.Windows.Forms.Label();
            aDDRESSLabel = new System.Windows.Forms.Label();
            tELEPHONELabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tp_books.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library451DataSet)).BeginInit();
            this.tp_readers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.readersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readersBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reades_debtsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reades_debtsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reader_IDLabel
            // 
            reader_IDLabel.AutoSize = true;
            reader_IDLabel.Location = new System.Drawing.Point(24, 39);
            reader_IDLabel.Name = "reader_IDLabel";
            reader_IDLabel.Size = new System.Drawing.Size(86, 14);
            reader_IDLabel.TabIndex = 23;
            reader_IDLabel.Text = "Учетный номер:";
            // 
            // fIOLabel
            // 
            fIOLabel.AutoSize = true;
            fIOLabel.Location = new System.Drawing.Point(24, 65);
            fIOLabel.Name = "fIOLabel";
            fIOLabel.Size = new System.Drawing.Size(34, 14);
            fIOLabel.TabIndex = 25;
            fIOLabel.Text = "ФИО:";
            // 
            // pASSPORTLabel
            // 
            pASSPORTLabel.AutoSize = true;
            pASSPORTLabel.Location = new System.Drawing.Point(24, 91);
            pASSPORTLabel.Name = "pASSPORTLabel";
            pASSPORTLabel.Size = new System.Drawing.Size(51, 14);
            pASSPORTLabel.TabIndex = 27;
            pASSPORTLabel.Text = "Паспорт:";
            // 
            // aDDRESSLabel
            // 
            aDDRESSLabel.AutoSize = true;
            aDDRESSLabel.Location = new System.Drawing.Point(24, 117);
            aDDRESSLabel.Name = "aDDRESSLabel";
            aDDRESSLabel.Size = new System.Drawing.Size(39, 14);
            aDDRESSLabel.TabIndex = 29;
            aDDRESSLabel.Text = "Адрес:";
            // 
            // tELEPHONELabel
            // 
            tELEPHONELabel.AutoSize = true;
            tELEPHONELabel.Location = new System.Drawing.Point(24, 143);
            tELEPHONELabel.Name = "tELEPHONELabel";
            tELEPHONELabel.Size = new System.Drawing.Size(52, 14);
            tELEPHONELabel.TabIndex = 31;
            tELEPHONELabel.Text = "Телефон:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1112, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.подключениеКБДToolStripMenuItem,
            this.разлогинитьсяToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.настройкиToolStripMenuItem.Text = "Меню";
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
            this.tb_login.Size = new System.Drawing.Size(102, 20);
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
            this.tb_book_search.TextChanged += new System.EventHandler(this.tb_book_search_TextChanged);
            // 
            // but_books_search_reset
            // 
            this.but_books_search_reset.Location = new System.Drawing.Point(1008, 23);
            this.but_books_search_reset.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.but_books_search_reset.Name = "but_books_search_reset";
            this.but_books_search_reset.Size = new System.Drawing.Size(74, 25);
            this.but_books_search_reset.TabIndex = 7;
            this.but_books_search_reset.Text = "Сбросить";
            this.but_books_search_reset.UseVisualStyleBackColor = true;
            this.but_books_search_reset.Click += new System.EventHandler(this.but_books_search_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_books);
            this.tabControl1.Controls.Add(this.tp_readers);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1112, 680);
            this.tabControl1.TabIndex = 8;
            this.tabControl1.Visible = false;
            // 
            // tp_books
            // 
            this.tp_books.AutoScroll = true;
            this.tp_books.Controls.Add(this.booksDataGridView);
            this.tp_books.Controls.Add(this.but_books_search_reset);
            this.tp_books.Controls.Add(this.tb_book_search);
            this.tp_books.Location = new System.Drawing.Point(4, 23);
            this.tp_books.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tp_books.Name = "tp_books";
            this.tp_books.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tp_books.Size = new System.Drawing.Size(1104, 653);
            this.tp_books.TabIndex = 0;
            this.tp_books.Text = "Книги";
            this.tp_books.UseVisualStyleBackColor = true;
            // 
            // booksDataGridView
            // 
            this.booksDataGridView.AllowUserToAddRows = false;
            this.booksDataGridView.AllowUserToDeleteRows = false;
            this.booksDataGridView.AllowUserToOrderColumns = true;
            this.booksDataGridView.AutoGenerateColumns = false;
            this.booksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1});
            this.booksDataGridView.DataSource = this.booksBindingSource;
            this.booksDataGridView.Location = new System.Drawing.Point(8, 54);
            this.booksDataGridView.Name = "booksDataGridView";
            this.booksDataGridView.ReadOnly = true;
            this.booksDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.booksDataGridView.Size = new System.Drawing.Size(1078, 596);
            this.booksDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Book_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Book_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Книга";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Availability";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Доступность";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 80;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.library451DataSet;
            // 
            // library451DataSet
            // 
            this.library451DataSet.DataSetName = "Library451DataSet";
            this.library451DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tp_readers
            // 
            this.tp_readers.AutoScroll = true;
            this.tp_readers.Controls.Add(this.readersDataGridView);
            this.tp_readers.Controls.Add(this.groupBox1);
            this.tp_readers.Controls.Add(this.but_readers_search_reset);
            this.tp_readers.Controls.Add(this.tb_readers_search);
            this.tp_readers.Location = new System.Drawing.Point(4, 23);
            this.tp_readers.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tp_readers.Name = "tp_readers";
            this.tp_readers.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tp_readers.Size = new System.Drawing.Size(1104, 653);
            this.tp_readers.TabIndex = 1;
            this.tp_readers.Text = "Читатели";
            this.tp_readers.UseVisualStyleBackColor = true;
            // 
            // readersDataGridView
            // 
            this.readersDataGridView.AllowUserToAddRows = false;
            this.readersDataGridView.AllowUserToDeleteRows = false;
            this.readersDataGridView.AutoGenerateColumns = false;
            this.readersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.readersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.readersDataGridView.DataSource = this.readersBindingSource;
            this.readersDataGridView.Location = new System.Drawing.Point(8, 39);
            this.readersDataGridView.Name = "readersDataGridView";
            this.readersDataGridView.ReadOnly = true;
            this.readersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.readersDataGridView.Size = new System.Drawing.Size(504, 606);
            this.readersDataGridView.TabIndex = 23;
            this.readersDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rEADERSDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Reader_ID";
            this.dataGridViewTextBoxColumn8.HeaderText = "Учетный номер";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 110;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "FIO";
            this.dataGridViewTextBoxColumn9.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // readersBindingSource
            // 
            this.readersBindingSource.DataMember = "Readers";
            this.readersBindingSource.DataSource = this.library451DataSet;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(reader_IDLabel);
            this.groupBox1.Controls.Add(this.reader_IDTextBox);
            this.groupBox1.Controls.Add(fIOLabel);
            this.groupBox1.Controls.Add(this.fIOTextBox);
            this.groupBox1.Controls.Add(pASSPORTLabel);
            this.groupBox1.Controls.Add(this.pASSPORTTextBox);
            this.groupBox1.Controls.Add(aDDRESSLabel);
            this.groupBox1.Controls.Add(this.aDDRESSTextBox);
            this.groupBox1.Controls.Add(tELEPHONELabel);
            this.groupBox1.Controls.Add(this.tELEPHONETextBox);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(518, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 632);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Читатель";
            this.groupBox1.Visible = false;
            // 
            // reader_IDTextBox
            // 
            this.reader_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.readersBindingSource, "Reader_ID", true));
            this.reader_IDTextBox.Location = new System.Drawing.Point(115, 36);
            this.reader_IDTextBox.Name = "reader_IDTextBox";
            this.reader_IDTextBox.ReadOnly = true;
            this.reader_IDTextBox.Size = new System.Drawing.Size(52, 20);
            this.reader_IDTextBox.TabIndex = 24;
            // 
            // fIOTextBox
            // 
            this.fIOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.readersBindingSource, "FIO", true));
            this.fIOTextBox.Location = new System.Drawing.Point(115, 62);
            this.fIOTextBox.Name = "fIOTextBox";
            this.fIOTextBox.Size = new System.Drawing.Size(456, 20);
            this.fIOTextBox.TabIndex = 26;
            // 
            // pASSPORTTextBox
            // 
            this.pASSPORTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.readersBindingSource, "PASSPORT", true));
            this.pASSPORTTextBox.Location = new System.Drawing.Point(115, 88);
            this.pASSPORTTextBox.Name = "pASSPORTTextBox";
            this.pASSPORTTextBox.Size = new System.Drawing.Size(456, 20);
            this.pASSPORTTextBox.TabIndex = 28;
            // 
            // aDDRESSTextBox
            // 
            this.aDDRESSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.readersBindingSource, "ADDRESS", true));
            this.aDDRESSTextBox.Location = new System.Drawing.Point(115, 114);
            this.aDDRESSTextBox.Name = "aDDRESSTextBox";
            this.aDDRESSTextBox.Size = new System.Drawing.Size(456, 20);
            this.aDDRESSTextBox.TabIndex = 30;
            // 
            // tELEPHONETextBox
            // 
            this.tELEPHONETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.readersBindingSource, "TELEPHONE", true));
            this.tELEPHONETextBox.Location = new System.Drawing.Point(115, 140);
            this.tELEPHONETextBox.Name = "tELEPHONETextBox";
            this.tELEPHONETextBox.Size = new System.Drawing.Size(456, 20);
            this.tELEPHONETextBox.TabIndex = 32;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.reades_debtsDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(6, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(565, 434);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Задолженности";
            // 
            // reades_debtsDataGridView
            // 
            this.reades_debtsDataGridView.AllowUserToAddRows = false;
            this.reades_debtsDataGridView.AllowUserToDeleteRows = false;
            this.reades_debtsDataGridView.AllowUserToOrderColumns = true;
            this.reades_debtsDataGridView.AutoGenerateColumns = false;
            this.reades_debtsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reades_debtsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.reades_debtsDataGridView.DataSource = this.reades_debtsBindingSource;
            this.reades_debtsDataGridView.Location = new System.Drawing.Point(6, 19);
            this.reades_debtsDataGridView.Name = "reades_debtsDataGridView";
            this.reades_debtsDataGridView.ReadOnly = true;
            this.reades_debtsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reades_debtsDataGridView.Size = new System.Drawing.Size(553, 409);
            this.reades_debtsDataGridView.TabIndex = 23;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Книга";
            this.dataGridViewTextBoxColumn4.HeaderText = "Книга";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Дата выдачи";
            this.dataGridViewTextBoxColumn5.HeaderText = "Дата выдачи";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Дата возврата";
            this.dataGridViewTextBoxColumn6.HeaderText = "Дата возврата";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Reader_ID";
            this.dataGridViewTextBoxColumn7.HeaderText = "Reader_ID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // reades_debtsBindingSource
            // 
            this.reades_debtsBindingSource.DataMember = "reades_debts";
            this.reades_debtsBindingSource.DataSource = this.library451DataSet;
            // 
            // but_readers_search_reset
            // 
            this.but_readers_search_reset.Location = new System.Drawing.Point(437, 12);
            this.but_readers_search_reset.Name = "but_readers_search_reset";
            this.but_readers_search_reset.Size = new System.Drawing.Size(75, 23);
            this.but_readers_search_reset.TabIndex = 13;
            this.but_readers_search_reset.Text = "Сбросить";
            this.but_readers_search_reset.UseVisualStyleBackColor = true;
            this.but_readers_search_reset.Click += new System.EventHandler(this.but_readers_search_reset_Click);
            // 
            // tb_readers_search
            // 
            this.tb_readers_search.Location = new System.Drawing.Point(5, 13);
            this.tb_readers_search.Name = "tb_readers_search";
            this.tb_readers_search.Size = new System.Drawing.Size(426, 20);
            this.tb_readers_search.TabIndex = 12;
            this.tb_readers_search.TextChanged += new System.EventHandler(this.tb_readers_search_TextChanged);
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.autTableAdapter = this.autTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BooksTableAdapter = this.booksTableAdapter;
            this.tableAdapterManager.DebtsTableAdapter = null;
            this.tableAdapterManager.ReadersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.Library451DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // autTableAdapter
            // 
            this.autTableAdapter.ClearBeforeFill = true;
            // 
            // reades_debtsTableAdapter
            // 
            this.reades_debtsTableAdapter.ClearBeforeFill = true;
            // 
            // readersTableAdapter
            // 
            this.readersTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 705);
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
            this.tabControl1.ResumeLayout(false);
            this.tp_books.ResumeLayout(false);
            this.tp_books.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library451DataSet)).EndInit();
            this.tp_readers.ResumeLayout(false);
            this.tp_readers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.readersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readersBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reades_debtsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reades_debtsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подключениеКБДToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button butt_authorized;
        private System.Windows.Forms.TextBox tb_book_search;
        private System.Windows.Forms.Button but_books_search_reset;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_books;
        private System.Windows.Forms.TabPage tp_readers;
        private System.Windows.Forms.ToolStripMenuItem разлогинитьсяToolStripMenuItem;
        private System.Windows.Forms.Button but_readers_search_reset;
        private System.Windows.Forms.TextBox tb_readers_search;
        private Library451DataSet library451DataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private Library451DataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private Library451DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView booksDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private Library451DataSetTableAdapters.autTableAdapter autTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource reades_debtsBindingSource;
        private Library451DataSetTableAdapters.reades_debtsTableAdapter reades_debtsTableAdapter;
        private System.Windows.Forms.DataGridView reades_debtsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.BindingSource readersBindingSource;
        private Library451DataSetTableAdapters.ReadersTableAdapter readersTableAdapter;
        private System.Windows.Forms.DataGridView readersDataGridView;
        private System.Windows.Forms.TextBox reader_IDTextBox;
        private System.Windows.Forms.TextBox fIOTextBox;
        private System.Windows.Forms.TextBox pASSPORTTextBox;
        private System.Windows.Forms.TextBox aDDRESSTextBox;
        private System.Windows.Forms.TextBox tELEPHONETextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}

