
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
            System.Windows.Forms.Label book_IDLabel;
            System.Windows.Forms.Label book_NameLabel;
            System.Windows.Forms.Label availabilityLabel;
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
            this.but_vis_add_book = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.but_book_chages_back = new System.Windows.Forms.Button();
            this.but_save_book_changes = new System.Windows.Forms.Button();
            this.availabilityCheckBox = new System.Windows.Forms.CheckBox();
            this.book_IDTextBox = new System.Windows.Forms.TextBox();
            this.book_NameTextBox = new System.Windows.Forms.TextBox();
            this.booksDataGridView = new System.Windows.Forms.DataGridView();
            this.tp_readers = new System.Windows.Forms.TabPage();
            this.readersDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reader_IDTextBox = new System.Windows.Forms.TextBox();
            this.fIOTextBox = new System.Windows.Forms.TextBox();
            this.pASSPORTTextBox = new System.Windows.Forms.TextBox();
            this.aDDRESSTextBox = new System.Windows.Forms.TextBox();
            this.tELEPHONETextBox = new System.Windows.Forms.TextBox();
            this.but_readers_search_reset = new System.Windows.Forms.Button();
            this.tb_readers_search = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.reades_debtsDataGridView = new System.Windows.Forms.DataGridView();
            this.but_delete_book = new System.Windows.Forms.Button();
            this.but_change_reader = new System.Windows.Forms.Button();
            this.but_save_changes_reader = new System.Windows.Forms.Button();
            this.but_back_changes_reader = new System.Windows.Forms.Button();
            this.but_add_new_reader = new System.Windows.Forms.Button();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.library451DataSet = new WindowsFormsApp1.Library451DataSet();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reades_debtsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableAdapter = new WindowsFormsApp1.Library451DataSetTableAdapters.BooksTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.Library451DataSetTableAdapters.TableAdapterManager();
            this.autTableAdapter = new WindowsFormsApp1.Library451DataSetTableAdapters.autTableAdapter();
            this.readersTableAdapter = new WindowsFormsApp1.Library451DataSetTableAdapters.ReadersTableAdapter();
            this.reades_debtsTableAdapter = new WindowsFormsApp1.Library451DataSetTableAdapters.reades_debtsTableAdapter();
            this.but_delete_reader = new System.Windows.Forms.Button();
            this.обновитьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            reader_IDLabel = new System.Windows.Forms.Label();
            fIOLabel = new System.Windows.Forms.Label();
            pASSPORTLabel = new System.Windows.Forms.Label();
            aDDRESSLabel = new System.Windows.Forms.Label();
            tELEPHONELabel = new System.Windows.Forms.Label();
            book_IDLabel = new System.Windows.Forms.Label();
            book_NameLabel = new System.Windows.Forms.Label();
            availabilityLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tp_books.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).BeginInit();
            this.tp_readers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.readersDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reades_debtsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library451DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readersBindingSource)).BeginInit();
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
            // book_IDLabel
            // 
            book_IDLabel.AutoSize = true;
            book_IDLabel.Location = new System.Drawing.Point(6, 26);
            book_IDLabel.Name = "book_IDLabel";
            book_IDLabel.Size = new System.Drawing.Size(22, 14);
            book_IDLabel.TabIndex = 7;
            book_IDLabel.Text = "ID:";
            // 
            // book_NameLabel
            // 
            book_NameLabel.AutoSize = true;
            book_NameLabel.Location = new System.Drawing.Point(6, 52);
            book_NameLabel.Name = "book_NameLabel";
            book_NameLabel.Size = new System.Drawing.Size(39, 14);
            book_NameLabel.TabIndex = 9;
            book_NameLabel.Text = "Книга:";
            // 
            // availabilityLabel
            // 
            availabilityLabel.AutoSize = true;
            availabilityLabel.Location = new System.Drawing.Point(6, 80);
            availabilityLabel.Name = "availabilityLabel";
            availabilityLabel.Size = new System.Drawing.Size(73, 14);
            availabilityLabel.TabIndex = 11;
            availabilityLabel.Text = "Доступность:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.подключениеКБДToolStripMenuItem,
            this.обновитьДанныеToolStripMenuItem,
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
            this.разлогинитьсяToolStripMenuItem.Enabled = false;
            this.разлогинитьсяToolStripMenuItem.Name = "разлогинитьсяToolStripMenuItem";
            this.разлогинитьсяToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.разлогинитьсяToolStripMenuItem.Text = "Разлогиниться";
            this.разлогинитьсяToolStripMenuItem.Click += new System.EventHandler(this.разлогинитьсяToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(109, 60);
            this.tb_login.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(102, 20);
            this.tb_login.TabIndex = 4;
            this.tb_login.Text = "admin";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(110, 110);
            this.tb_password.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(100, 20);
            this.tb_password.TabIndex = 5;
            this.tb_password.Text = "admin";
            // 
            // butt_authorized
            // 
            this.butt_authorized.Location = new System.Drawing.Point(123, 140);
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
            this.tb_book_search.Size = new System.Drawing.Size(618, 20);
            this.tb_book_search.TabIndex = 6;
            this.tb_book_search.TextChanged += new System.EventHandler(this.tb_book_search_TextChanged);
            // 
            // but_books_search_reset
            // 
            this.but_books_search_reset.Location = new System.Drawing.Point(641, 23);
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
            this.tabControl1.Size = new System.Drawing.Size(1264, 651);
            this.tabControl1.TabIndex = 8;
            this.tabControl1.Visible = false;
            // 
            // tp_books
            // 
            this.tp_books.AutoScroll = true;
            this.tp_books.Controls.Add(this.but_vis_add_book);
            this.tp_books.Controls.Add(this.groupBox3);
            this.tp_books.Controls.Add(this.booksDataGridView);
            this.tp_books.Controls.Add(this.but_books_search_reset);
            this.tp_books.Controls.Add(this.tb_book_search);
            this.tp_books.Location = new System.Drawing.Point(4, 23);
            this.tp_books.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tp_books.Name = "tp_books";
            this.tp_books.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tp_books.Size = new System.Drawing.Size(1256, 624);
            this.tp_books.TabIndex = 0;
            this.tp_books.Text = "Книги";
            this.tp_books.UseVisualStyleBackColor = true;
            // 
            // but_vis_add_book
            // 
            this.but_vis_add_book.Location = new System.Drawing.Point(737, 24);
            this.but_vis_add_book.Name = "but_vis_add_book";
            this.but_vis_add_book.Size = new System.Drawing.Size(105, 23);
            this.but_vis_add_book.TabIndex = 16;
            this.but_vis_add_book.Text = "Добавить новую";
            this.but_vis_add_book.UseVisualStyleBackColor = true;
            this.but_vis_add_book.Click += new System.EventHandler(this.but_vis_add_book_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.but_delete_book);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.but_book_chages_back);
            this.groupBox3.Controls.Add(this.but_save_book_changes);
            this.groupBox3.Controls.Add(availabilityLabel);
            this.groupBox3.Controls.Add(book_IDLabel);
            this.groupBox3.Controls.Add(this.availabilityCheckBox);
            this.groupBox3.Controls.Add(this.book_IDTextBox);
            this.groupBox3.Controls.Add(this.book_NameTextBox);
            this.groupBox3.Controls.Add(book_NameLabel);
            this.groupBox3.Location = new System.Drawing.Point(737, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(498, 157);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Управление";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Редактировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // but_book_chages_back
            // 
            this.but_book_chages_back.Location = new System.Drawing.Point(213, 116);
            this.but_book_chages_back.Name = "but_book_chages_back";
            this.but_book_chages_back.Size = new System.Drawing.Size(96, 23);
            this.but_book_chages_back.TabIndex = 14;
            this.but_book_chages_back.Text = "Отмена";
            this.but_book_chages_back.UseVisualStyleBackColor = true;
            this.but_book_chages_back.Click += new System.EventHandler(this.but_book_chages_back_Click);
            // 
            // but_save_book_changes
            // 
            this.but_save_book_changes.Location = new System.Drawing.Point(111, 116);
            this.but_save_book_changes.Name = "but_save_book_changes";
            this.but_save_book_changes.Size = new System.Drawing.Size(96, 23);
            this.but_save_book_changes.TabIndex = 14;
            this.but_save_book_changes.Text = "Сохранить";
            this.but_save_book_changes.UseVisualStyleBackColor = true;
            this.but_save_book_changes.Click += new System.EventHandler(this.but_save_book_changes_Click);
            // 
            // availabilityCheckBox
            // 
            this.availabilityCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.booksBindingSource, "Availability", true));
            this.availabilityCheckBox.Enabled = false;
            this.availabilityCheckBox.Location = new System.Drawing.Point(89, 76);
            this.availabilityCheckBox.Name = "availabilityCheckBox";
            this.availabilityCheckBox.Size = new System.Drawing.Size(104, 24);
            this.availabilityCheckBox.TabIndex = 12;
            this.availabilityCheckBox.UseVisualStyleBackColor = true;
            // 
            // book_IDTextBox
            // 
            this.book_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Book_ID", true));
            this.book_IDTextBox.Location = new System.Drawing.Point(89, 24);
            this.book_IDTextBox.Name = "book_IDTextBox";
            this.book_IDTextBox.ReadOnly = true;
            this.book_IDTextBox.Size = new System.Drawing.Size(403, 20);
            this.book_IDTextBox.TabIndex = 8;
            // 
            // book_NameTextBox
            // 
            this.book_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Book_Name", true));
            this.book_NameTextBox.Location = new System.Drawing.Point(89, 50);
            this.book_NameTextBox.Name = "book_NameTextBox";
            this.book_NameTextBox.ReadOnly = true;
            this.book_NameTextBox.Size = new System.Drawing.Size(403, 20);
            this.book_NameTextBox.TabIndex = 10;
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
            this.booksDataGridView.Size = new System.Drawing.Size(707, 565);
            this.booksDataGridView.TabIndex = 7;
            // 
            // tp_readers
            // 
            this.tp_readers.AutoScroll = true;
            this.tp_readers.Controls.Add(this.but_add_new_reader);
            this.tp_readers.Controls.Add(this.readersDataGridView);
            this.tp_readers.Controls.Add(this.groupBox1);
            this.tp_readers.Controls.Add(this.but_readers_search_reset);
            this.tp_readers.Controls.Add(this.tb_readers_search);
            this.tp_readers.Controls.Add(this.groupBox2);
            this.tp_readers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tp_readers.Location = new System.Drawing.Point(4, 23);
            this.tp_readers.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tp_readers.Name = "tp_readers";
            this.tp_readers.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tp_readers.Size = new System.Drawing.Size(1256, 624);
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
            this.readersDataGridView.Size = new System.Drawing.Size(643, 351);
            this.readersDataGridView.TabIndex = 23;
            this.readersDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rEADERSDataGridView_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.but_delete_reader);
            this.groupBox1.Controls.Add(this.but_back_changes_reader);
            this.groupBox1.Controls.Add(this.but_save_changes_reader);
            this.groupBox1.Controls.Add(this.but_change_reader);
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
            this.groupBox1.Location = new System.Drawing.Point(657, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 350);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Читатель";
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
            this.fIOTextBox.ReadOnly = true;
            this.fIOTextBox.Size = new System.Drawing.Size(456, 20);
            this.fIOTextBox.TabIndex = 26;
            // 
            // pASSPORTTextBox
            // 
            this.pASSPORTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.readersBindingSource, "PASSPORT", true));
            this.pASSPORTTextBox.Location = new System.Drawing.Point(115, 88);
            this.pASSPORTTextBox.Name = "pASSPORTTextBox";
            this.pASSPORTTextBox.ReadOnly = true;
            this.pASSPORTTextBox.Size = new System.Drawing.Size(456, 20);
            this.pASSPORTTextBox.TabIndex = 28;
            // 
            // aDDRESSTextBox
            // 
            this.aDDRESSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.readersBindingSource, "ADDRESS", true));
            this.aDDRESSTextBox.Location = new System.Drawing.Point(115, 114);
            this.aDDRESSTextBox.Name = "aDDRESSTextBox";
            this.aDDRESSTextBox.ReadOnly = true;
            this.aDDRESSTextBox.Size = new System.Drawing.Size(456, 20);
            this.aDDRESSTextBox.TabIndex = 30;
            // 
            // tELEPHONETextBox
            // 
            this.tELEPHONETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.readersBindingSource, "TELEPHONE", true));
            this.tELEPHONETextBox.Location = new System.Drawing.Point(115, 140);
            this.tELEPHONETextBox.Name = "tELEPHONETextBox";
            this.tELEPHONETextBox.ReadOnly = true;
            this.tELEPHONETextBox.Size = new System.Drawing.Size(456, 20);
            this.tELEPHONETextBox.TabIndex = 32;
            // 
            // but_readers_search_reset
            // 
            this.but_readers_search_reset.Location = new System.Drawing.Point(576, 12);
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
            this.tb_readers_search.Size = new System.Drawing.Size(565, 20);
            this.tb_readers_search.TabIndex = 12;
            this.tb_readers_search.TextChanged += new System.EventHandler(this.tb_readers_search_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.reades_debtsDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(5, 396);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1226, 222);
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
            this.reades_debtsDataGridView.Size = new System.Drawing.Size(1214, 191);
            this.reades_debtsDataGridView.TabIndex = 23;
            // 
            // but_delete_book
            // 
            this.but_delete_book.BackColor = System.Drawing.Color.Transparent;
            this.but_delete_book.Location = new System.Drawing.Point(403, 116);
            this.but_delete_book.Name = "but_delete_book";
            this.but_delete_book.Size = new System.Drawing.Size(89, 23);
            this.but_delete_book.TabIndex = 17;
            this.but_delete_book.Text = "Удалить книгу";
            this.but_delete_book.UseVisualStyleBackColor = false;
            this.but_delete_book.Click += new System.EventHandler(this.but_delete_book_Click);
            // 
            // but_change_reader
            // 
            this.but_change_reader.Location = new System.Drawing.Point(27, 180);
            this.but_change_reader.Name = "but_change_reader";
            this.but_change_reader.Size = new System.Drawing.Size(93, 25);
            this.but_change_reader.TabIndex = 33;
            this.but_change_reader.Text = "Редактировать";
            this.but_change_reader.UseVisualStyleBackColor = true;
            this.but_change_reader.Click += new System.EventHandler(this.but_change_reader_Click);
            // 
            // but_save_changes_reader
            // 
            this.but_save_changes_reader.Location = new System.Drawing.Point(126, 180);
            this.but_save_changes_reader.Name = "but_save_changes_reader";
            this.but_save_changes_reader.Size = new System.Drawing.Size(93, 25);
            this.but_save_changes_reader.TabIndex = 34;
            this.but_save_changes_reader.Text = "Сохранить";
            this.but_save_changes_reader.UseVisualStyleBackColor = true;
            this.but_save_changes_reader.Click += new System.EventHandler(this.but_save_changes_reader_Click);
            // 
            // but_back_changes_reader
            // 
            this.but_back_changes_reader.Location = new System.Drawing.Point(225, 180);
            this.but_back_changes_reader.Name = "but_back_changes_reader";
            this.but_back_changes_reader.Size = new System.Drawing.Size(93, 25);
            this.but_back_changes_reader.TabIndex = 35;
            this.but_back_changes_reader.Text = "Отменить";
            this.but_back_changes_reader.UseVisualStyleBackColor = true;
            this.but_back_changes_reader.Click += new System.EventHandler(this.but_back_changes_reader_Click);
            // 
            // but_add_new_reader
            // 
            this.but_add_new_reader.Location = new System.Drawing.Point(658, 12);
            this.but_add_new_reader.Name = "but_add_new_reader";
            this.but_add_new_reader.Size = new System.Drawing.Size(109, 23);
            this.but_add_new_reader.TabIndex = 24;
            this.but_add_new_reader.Text = "Добавить читателя";
            this.but_add_new_reader.UseVisualStyleBackColor = true;
            this.but_add_new_reader.Click += new System.EventHandler(this.but_add_new_reader_Click);
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
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // readersBindingSource
            // 
            this.readersBindingSource.DataMember = "Readers";
            this.readersBindingSource.DataSource = this.library451DataSet;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Книга";
            this.dataGridViewTextBoxColumn4.HeaderText = "Книга";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Дата выдачи";
            this.dataGridViewTextBoxColumn5.HeaderText = "Дата выдачи";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Дата возврата";
            this.dataGridViewTextBoxColumn6.HeaderText = "Дата возврата";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Reader_ID";
            this.dataGridViewTextBoxColumn7.HeaderText = "Reader_ID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // reades_debtsBindingSource
            // 
            this.reades_debtsBindingSource.DataMember = "reades_debts";
            this.reades_debtsBindingSource.DataSource = this.library451DataSet;
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
            this.tableAdapterManager.ReadersTableAdapter = this.readersTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.Library451DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // autTableAdapter
            // 
            this.autTableAdapter.ClearBeforeFill = true;
            // 
            // readersTableAdapter
            // 
            this.readersTableAdapter.ClearBeforeFill = true;
            // 
            // reades_debtsTableAdapter
            // 
            this.reades_debtsTableAdapter.ClearBeforeFill = true;
            // 
            // but_delete_reader
            // 
            this.but_delete_reader.Location = new System.Drawing.Point(468, 180);
            this.but_delete_reader.Name = "but_delete_reader";
            this.but_delete_reader.Size = new System.Drawing.Size(100, 23);
            this.but_delete_reader.TabIndex = 36;
            this.but_delete_reader.Text = "Удалить читателя";
            this.but_delete_reader.UseVisualStyleBackColor = true;
            this.but_delete_reader.Click += new System.EventHandler(this.but_delete_reader_Click);
            // 
            // обновитьДанныеToolStripMenuItem
            // 
            this.обновитьДанныеToolStripMenuItem.Name = "обновитьДанныеToolStripMenuItem";
            this.обновитьДанныеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.обновитьДанныеToolStripMenuItem.Text = "Обновить данные";
            this.обновитьДанныеToolStripMenuItem.Click += new System.EventHandler(this.обновитьДанныеToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
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
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учет читателей";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tp_books.ResumeLayout(false);
            this.tp_books.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).EndInit();
            this.tp_readers.ResumeLayout(false);
            this.tp_readers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.readersDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reades_debtsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library451DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readersBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox book_IDTextBox;
        private System.Windows.Forms.TextBox book_NameTextBox;
        private System.Windows.Forms.CheckBox availabilityCheckBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button but_save_book_changes;
        private System.Windows.Forms.Button but_book_chages_back;
        private System.Windows.Forms.Button but_vis_add_book;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button but_delete_book;
        private System.Windows.Forms.Button but_add_new_reader;
        private System.Windows.Forms.Button but_back_changes_reader;
        private System.Windows.Forms.Button but_save_changes_reader;
        private System.Windows.Forms.Button but_change_reader;
        private System.Windows.Forms.Button but_delete_reader;
        private System.Windows.Forms.ToolStripMenuItem обновитьДанныеToolStripMenuItem;
    }
}

