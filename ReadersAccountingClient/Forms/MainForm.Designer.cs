
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label книгаLabel;
            System.Windows.Forms.Label дата_выдачиLabel;
            System.Windows.Forms.Label дата_возвратаLabel;
            System.Windows.Forms.Label возвращеноLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label iDLabel2;
            System.Windows.Forms.Label loginLabel1;
            System.Windows.Forms.Label passwordLabel1;
            System.Windows.Forms.Label is_adminLabel1;
            System.Windows.Forms.Label fIOLabel1;
            System.Windows.Forms.Label label6;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подключениеКБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разлогинитьсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_book_search = new System.Windows.Forms.TextBox();
            this.but_books_search_reset = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_books = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.but_vis_add_book = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.but_delete_book = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.but_book_chages_back = new System.Windows.Forms.Button();
            this.but_save_book_changes = new System.Windows.Forms.Button();
            this.availabilityCheckBox = new System.Windows.Forms.CheckBox();
            this.book_IDTextBox = new System.Windows.Forms.TextBox();
            this.book_NameTextBox = new System.Windows.Forms.TextBox();
            this.booksDataGridView = new System.Windows.Forms.DataGridView();
            this.tp_readers = new System.Windows.Forms.TabPage();
            this.but_add_new_reader = new System.Windows.Forms.Button();
            this.readersDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pASSPORTTextBox = new System.Windows.Forms.MaskedTextBox();
            this.tELEPHONETextBox = new System.Windows.Forms.MaskedTextBox();
            this.but_delete_reader = new System.Windows.Forms.Button();
            this.but_back_changes_reader = new System.Windows.Forms.Button();
            this.but_save_changes_reader = new System.Windows.Forms.Button();
            this.but_change_reader = new System.Windows.Forms.Button();
            this.reader_IDTextBox = new System.Windows.Forms.TextBox();
            this.fIOTextBox = new System.Windows.Forms.TextBox();
            this.aDDRESSTextBox = new System.Windows.Forms.TextBox();
            this.but_readers_search_reset = new System.Windows.Forms.Button();
            this.tb_readers_search = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.butSearchDebts = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.tbDebtsSearch = new System.Windows.Forms.TextBox();
            this.butBackChangesDebts = new System.Windows.Forms.Button();
            this.butSaveDebts = new System.Windows.Forms.Button();
            this.butCloseDebt = new System.Windows.Forms.Button();
            this.butChangeDebt = new System.Windows.Forms.Button();
            this.butDeleteDebt = new System.Windows.Forms.Button();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.книгаTextBox = new System.Windows.Forms.TextBox();
            this.дата_выдачиDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.дата_возвратаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.возвращеноCheckBox = new System.Windows.Forms.CheckBox();
            this.butAddDebt = new System.Windows.Forms.Button();
            this.reades_debtsDataGridView = new System.Windows.Forms.DataGridView();
            this.Возвращено = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Book_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpOtchet = new System.Windows.Forms.TabPage();
            this.tcReports = new System.Windows.Forms.TabControl();
            this.tpReportBooks = new System.Windows.Forms.TabPage();
            this.tbCountBooks = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.readersHistoryDataGridView = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.readersDataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.reader_IDTextBox1 = new System.Windows.Forms.TextBox();
            this.tpReportReaders = new System.Windows.Forms.TabPage();
            this.tbCountBookGive = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.booksHistoryDataGridView = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.booksDataGridView2 = new System.Windows.Forms.DataGridView();
            this.dtPickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dtPickerTo = new System.Windows.Forms.DateTimePicker();
            this.butCreateReport = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.book_IDTextBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tpAccounts = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.butDeletAcc = new System.Windows.Forms.Button();
            this.butCancelNewAcc = new System.Windows.Forms.Button();
            this.iDAccTextBox = new System.Windows.Forms.TextBox();
            this.butSaveNewAcc = new System.Windows.Forms.Button();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.loginTextBox1 = new System.Windows.Forms.TextBox();
            this.fIOAccTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.is_adminCheckBox = new System.Windows.Forms.CheckBox();
            this.gbNewAcc = new System.Windows.Forms.GroupBox();
            this.tbNewAccFIO = new System.Windows.Forms.TextBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.butCancelAdd = new System.Windows.Forms.Button();
            this.butAddAccount = new System.Windows.Forms.Button();
            this.chkbIsAdmin = new System.Windows.Forms.CheckBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.butResetAccSearch = new System.Windows.Forms.Button();
            this.tbAccSearch = new System.Windows.Forms.TextBox();
            this.butChangeAccounts = new System.Windows.Forms.Button();
            this.autDataGridView = new System.Windows.Forms.DataGridView();
            this.FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.library451DataSet = new WindowsFormsApp1.Library451DataSet();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reades_debtsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readersHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.library451DWHDataSet = new WindowsFormsApp1.Library451DWHDataSet();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReportReadersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booksHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReportBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.booksTableAdapter = new WindowsFormsApp1.Library451DataSetTableAdapters.BooksTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.Library451DataSetTableAdapters.TableAdapterManager();
            this.autTableAdapter = new WindowsFormsApp1.Library451DataSetTableAdapters.autTableAdapter();
            this.readersTableAdapter = new WindowsFormsApp1.Library451DataSetTableAdapters.ReadersTableAdapter();
            this.reades_debtsTableAdapter = new WindowsFormsApp1.Library451DataSetTableAdapters.reades_debtsTableAdapter();
            this.debtsTableAdapter = new WindowsFormsApp1.Library451DataSetTableAdapters.DebtsTableAdapter();
            this.readersHistoryTableAdapter = new WindowsFormsApp1.Library451DWHDataSetTableAdapters.ReadersHistoryTableAdapter();
            this.tableAdapterManager1 = new WindowsFormsApp1.Library451DWHDataSetTableAdapters.TableAdapterManager();
            this.booksHistoryTableAdapter = new WindowsFormsApp1.Library451DWHDataSetTableAdapters.BooksHistoryTableAdapter();
            this.fIOTextBox1 = new System.Windows.Forms.TextBox();
            this.book_NameTextBox1 = new System.Windows.Forms.TextBox();
            reader_IDLabel = new System.Windows.Forms.Label();
            fIOLabel = new System.Windows.Forms.Label();
            pASSPORTLabel = new System.Windows.Forms.Label();
            aDDRESSLabel = new System.Windows.Forms.Label();
            tELEPHONELabel = new System.Windows.Forms.Label();
            book_IDLabel = new System.Windows.Forms.Label();
            book_NameLabel = new System.Windows.Forms.Label();
            availabilityLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            книгаLabel = new System.Windows.Forms.Label();
            дата_выдачиLabel = new System.Windows.Forms.Label();
            дата_возвратаLabel = new System.Windows.Forms.Label();
            возвращеноLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            iDLabel2 = new System.Windows.Forms.Label();
            loginLabel1 = new System.Windows.Forms.Label();
            passwordLabel1 = new System.Windows.Forms.Label();
            is_adminLabel1 = new System.Windows.Forms.Label();
            fIOLabel1 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
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
            this.tpOtchet.SuspendLayout();
            this.tcReports.SuspendLayout();
            this.tpReportBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.readersHistoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readersDataGridView1)).BeginInit();
            this.tpReportReaders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksHistoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView2)).BeginInit();
            this.tpAccounts.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbNewAcc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library451DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reades_debtsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readersHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library451DWHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportReadersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportBooksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autBindingSource)).BeginInit();
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
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(670, 80);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(22, 14);
            iDLabel.TabIndex = 24;
            iDLabel.Text = "ID:";
            // 
            // книгаLabel
            // 
            книгаLabel.AutoSize = true;
            книгаLabel.Location = new System.Drawing.Point(670, 106);
            книгаLabel.Name = "книгаLabel";
            книгаLabel.Size = new System.Drawing.Size(39, 14);
            книгаLabel.TabIndex = 26;
            книгаLabel.Text = "Книга:";
            // 
            // дата_выдачиLabel
            // 
            дата_выдачиLabel.AutoSize = true;
            дата_выдачиLabel.Location = new System.Drawing.Point(670, 133);
            дата_выдачиLabel.Name = "дата_выдачиLabel";
            дата_выдачиLabel.Size = new System.Drawing.Size(70, 14);
            дата_выдачиLabel.TabIndex = 28;
            дата_выдачиLabel.Text = "Дата выдачи:";
            // 
            // дата_возвратаLabel
            // 
            дата_возвратаLabel.AutoSize = true;
            дата_возвратаLabel.Location = new System.Drawing.Point(670, 159);
            дата_возвратаLabel.Name = "дата_возвратаLabel";
            дата_возвратаLabel.Size = new System.Drawing.Size(77, 14);
            дата_возвратаLabel.TabIndex = 30;
            дата_возвратаLabel.Text = "Дата возврата:";
            // 
            // возвращеноLabel
            // 
            возвращеноLabel.AutoSize = true;
            возвращеноLabel.Location = new System.Drawing.Point(670, 189);
            возвращеноLabel.Name = "возвращеноLabel";
            возвращеноLabel.Size = new System.Drawing.Size(68, 14);
            возвращеноLabel.TabIndex = 34;
            возвращеноLabel.Text = "Возвращено:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(7, 53);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(40, 14);
            label3.TabIndex = 6;
            label3.Text = "Логин:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(7, 79);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(45, 14);
            label4.TabIndex = 7;
            label4.Text = "Пароль:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(7, 108);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(44, 14);
            label5.TabIndex = 19;
            label5.Text = "Админ?";
            // 
            // iDLabel2
            // 
            iDLabel2.AutoSize = true;
            iDLabel2.Location = new System.Drawing.Point(13, 29);
            iDLabel2.Name = "iDLabel2";
            iDLabel2.Size = new System.Drawing.Size(22, 14);
            iDLabel2.TabIndex = 18;
            iDLabel2.Text = "ID:";
            // 
            // loginLabel1
            // 
            loginLabel1.AutoSize = true;
            loginLabel1.Location = new System.Drawing.Point(13, 91);
            loginLabel1.Name = "loginLabel1";
            loginLabel1.Size = new System.Drawing.Size(40, 14);
            loginLabel1.TabIndex = 20;
            loginLabel1.Text = "Логин:";
            // 
            // passwordLabel1
            // 
            passwordLabel1.AutoSize = true;
            passwordLabel1.Location = new System.Drawing.Point(13, 117);
            passwordLabel1.Name = "passwordLabel1";
            passwordLabel1.Size = new System.Drawing.Size(45, 14);
            passwordLabel1.TabIndex = 22;
            passwordLabel1.Text = "Пароль:";
            // 
            // is_adminLabel1
            // 
            is_adminLabel1.AutoSize = true;
            is_adminLabel1.Location = new System.Drawing.Point(13, 145);
            is_adminLabel1.Name = "is_adminLabel1";
            is_adminLabel1.Size = new System.Drawing.Size(44, 14);
            is_adminLabel1.TabIndex = 24;
            is_adminLabel1.Text = "Админ?";
            // 
            // fIOLabel1
            // 
            fIOLabel1.AutoSize = true;
            fIOLabel1.Location = new System.Drawing.Point(13, 59);
            fIOLabel1.Name = "fIOLabel1";
            fIOLabel1.Size = new System.Drawing.Size(34, 14);
            fIOLabel1.TabIndex = 26;
            fIOLabel1.Text = "ФИО:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(7, 27);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(34, 14);
            label6.TabIndex = 27;
            label6.Text = "ФИО:";
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
            // обновитьДанныеToolStripMenuItem
            // 
            this.обновитьДанныеToolStripMenuItem.Name = "обновитьДанныеToolStripMenuItem";
            this.обновитьДанныеToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.обновитьДанныеToolStripMenuItem.Text = "Обновить данные";
            this.обновитьДанныеToolStripMenuItem.Click += new System.EventHandler(this.обновитьДанныеToolStripMenuItem_Click);
            // 
            // разлогинитьсяToolStripMenuItem
            // 
            this.разлогинитьсяToolStripMenuItem.Name = "разлогинитьсяToolStripMenuItem";
            this.разлогинитьсяToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.разлогинитьсяToolStripMenuItem.Text = "Разлогиниться";
            this.разлогинитьсяToolStripMenuItem.Click += new System.EventHandler(this.разлогинитьсяToolStripMenuItem_Click);
            // 
            // tb_book_search
            // 
            this.tb_book_search.Location = new System.Drawing.Point(8, 25);
            this.tb_book_search.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tb_book_search.Name = "tb_book_search";
            this.tb_book_search.Size = new System.Drawing.Size(537, 20);
            this.tb_book_search.TabIndex = 6;
            this.tb_book_search.TextChanged += new System.EventHandler(this.tb_book_search_TextChanged);
            // 
            // but_books_search_reset
            // 
            this.but_books_search_reset.Location = new System.Drawing.Point(549, 23);
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
            this.tabControl1.Controls.Add(this.tpOtchet);
            this.tabControl1.Controls.Add(this.tpAccounts);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1264, 651);
            this.tabControl1.TabIndex = 8;
            // 
            // tp_books
            // 
            this.tp_books.AutoScroll = true;
            this.tp_books.Controls.Add(this.checkBox1);
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
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(628, 27);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 18);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Доступность";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
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
            this.but_book_chages_back.Enabled = false;
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
            this.but_save_book_changes.Enabled = false;
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
            this.availabilityCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.booksBindingSource, "Availability", true));
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
            this.readersDataGridView.Size = new System.Drawing.Size(643, 313);
            this.readersDataGridView.TabIndex = 23;
            this.readersDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rEADERSDataGridView_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pASSPORTTextBox);
            this.groupBox1.Controls.Add(this.tELEPHONETextBox);
            this.groupBox1.Controls.Add(this.but_delete_reader);
            this.groupBox1.Controls.Add(this.but_back_changes_reader);
            this.groupBox1.Controls.Add(this.but_save_changes_reader);
            this.groupBox1.Controls.Add(this.but_change_reader);
            this.groupBox1.Controls.Add(reader_IDLabel);
            this.groupBox1.Controls.Add(this.reader_IDTextBox);
            this.groupBox1.Controls.Add(fIOLabel);
            this.groupBox1.Controls.Add(this.fIOTextBox);
            this.groupBox1.Controls.Add(pASSPORTLabel);
            this.groupBox1.Controls.Add(aDDRESSLabel);
            this.groupBox1.Controls.Add(this.aDDRESSTextBox);
            this.groupBox1.Controls.Add(tELEPHONELabel);
            this.groupBox1.Location = new System.Drawing.Point(657, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 312);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Читатель";
            // 
            // pASSPORTTextBox
            // 
            this.pASSPORTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.readersBindingSource, "PASSPORT", true));
            this.pASSPORTTextBox.Location = new System.Drawing.Point(115, 88);
            this.pASSPORTTextBox.Mask = "0000 000000";
            this.pASSPORTTextBox.Name = "pASSPORTTextBox";
            this.pASSPORTTextBox.ReadOnly = true;
            this.pASSPORTTextBox.Size = new System.Drawing.Size(456, 20);
            this.pASSPORTTextBox.TabIndex = 38;
            // 
            // tELEPHONETextBox
            // 
            this.tELEPHONETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.readersBindingSource, "TELEPHONE", true));
            this.tELEPHONETextBox.Location = new System.Drawing.Point(115, 143);
            this.tELEPHONETextBox.Mask = "+7 (999) 000-0000";
            this.tELEPHONETextBox.Name = "tELEPHONETextBox";
            this.tELEPHONETextBox.ReadOnly = true;
            this.tELEPHONETextBox.Size = new System.Drawing.Size(456, 20);
            this.tELEPHONETextBox.TabIndex = 37;
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
            // but_back_changes_reader
            // 
            this.but_back_changes_reader.Enabled = false;
            this.but_back_changes_reader.Location = new System.Drawing.Point(225, 180);
            this.but_back_changes_reader.Name = "but_back_changes_reader";
            this.but_back_changes_reader.Size = new System.Drawing.Size(93, 25);
            this.but_back_changes_reader.TabIndex = 35;
            this.but_back_changes_reader.Text = "Отменить";
            this.but_back_changes_reader.UseVisualStyleBackColor = true;
            this.but_back_changes_reader.Click += new System.EventHandler(this.but_back_changes_reader_Click);
            // 
            // but_save_changes_reader
            // 
            this.but_save_changes_reader.Enabled = false;
            this.but_save_changes_reader.Location = new System.Drawing.Point(126, 180);
            this.but_save_changes_reader.Name = "but_save_changes_reader";
            this.but_save_changes_reader.Size = new System.Drawing.Size(93, 25);
            this.but_save_changes_reader.TabIndex = 34;
            this.but_save_changes_reader.Text = "Сохранить";
            this.but_save_changes_reader.UseVisualStyleBackColor = true;
            this.but_save_changes_reader.Click += new System.EventHandler(this.but_save_changes_reader_Click);
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
            // reader_IDTextBox
            // 
            this.reader_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.readersBindingSource, "Reader_ID", true));
            this.reader_IDTextBox.Location = new System.Drawing.Point(115, 36);
            this.reader_IDTextBox.Name = "reader_IDTextBox";
            this.reader_IDTextBox.ReadOnly = true;
            this.reader_IDTextBox.Size = new System.Drawing.Size(456, 20);
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
            // aDDRESSTextBox
            // 
            this.aDDRESSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.readersBindingSource, "ADDRESS", true));
            this.aDDRESSTextBox.Location = new System.Drawing.Point(115, 114);
            this.aDDRESSTextBox.Name = "aDDRESSTextBox";
            this.aDDRESSTextBox.ReadOnly = true;
            this.aDDRESSTextBox.Size = new System.Drawing.Size(456, 20);
            this.aDDRESSTextBox.TabIndex = 30;
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
            this.tb_readers_search.Location = new System.Drawing.Point(8, 13);
            this.tb_readers_search.Name = "tb_readers_search";
            this.tb_readers_search.Size = new System.Drawing.Size(562, 20);
            this.tb_readers_search.TabIndex = 12;
            this.tb_readers_search.TextChanged += new System.EventHandler(this.tb_readers_search_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.butSearchDebts);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.tbDebtsSearch);
            this.groupBox2.Controls.Add(this.butBackChangesDebts);
            this.groupBox2.Controls.Add(this.butSaveDebts);
            this.groupBox2.Controls.Add(this.butCloseDebt);
            this.groupBox2.Controls.Add(this.butChangeDebt);
            this.groupBox2.Controls.Add(this.butDeleteDebt);
            this.groupBox2.Controls.Add(iDLabel);
            this.groupBox2.Controls.Add(this.iDTextBox);
            this.groupBox2.Controls.Add(книгаLabel);
            this.groupBox2.Controls.Add(this.книгаTextBox);
            this.groupBox2.Controls.Add(дата_выдачиLabel);
            this.groupBox2.Controls.Add(this.дата_выдачиDateTimePicker);
            this.groupBox2.Controls.Add(дата_возвратаLabel);
            this.groupBox2.Controls.Add(this.дата_возвратаDateTimePicker);
            this.groupBox2.Controls.Add(возвращеноLabel);
            this.groupBox2.Controls.Add(this.возвращеноCheckBox);
            this.groupBox2.Controls.Add(this.butAddDebt);
            this.groupBox2.Controls.Add(this.reades_debtsDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(5, 358);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1243, 262);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Задолженности";
            // 
            // butSearchDebts
            // 
            this.butSearchDebts.Location = new System.Drawing.Point(455, 26);
            this.butSearchDebts.Name = "butSearchDebts";
            this.butSearchDebts.Size = new System.Drawing.Size(75, 23);
            this.butSearchDebts.TabIndex = 43;
            this.butSearchDebts.Text = "Сбросить";
            this.butSearchDebts.UseVisualStyleBackColor = true;
            this.butSearchDebts.Click += new System.EventHandler(this.butSearchDebts_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(552, 29);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(99, 18);
            this.checkBox2.TabIndex = 42;
            this.checkBox2.Text = "Открытый долг";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // tbDebtsSearch
            // 
            this.tbDebtsSearch.Location = new System.Drawing.Point(6, 27);
            this.tbDebtsSearch.Name = "tbDebtsSearch";
            this.tbDebtsSearch.Size = new System.Drawing.Size(433, 20);
            this.tbDebtsSearch.TabIndex = 41;
            this.tbDebtsSearch.TextChanged += new System.EventHandler(this.tbDebtsSearch_TextChanged);
            // 
            // butBackChangesDebts
            // 
            this.butBackChangesDebts.Enabled = false;
            this.butBackChangesDebts.Location = new System.Drawing.Point(754, 233);
            this.butBackChangesDebts.Name = "butBackChangesDebts";
            this.butBackChangesDebts.Size = new System.Drawing.Size(75, 23);
            this.butBackChangesDebts.TabIndex = 40;
            this.butBackChangesDebts.Text = "Отмена";
            this.butBackChangesDebts.UseVisualStyleBackColor = true;
            this.butBackChangesDebts.Click += new System.EventHandler(this.butBackChangesDebts_Click);
            // 
            // butSaveDebts
            // 
            this.butSaveDebts.Enabled = false;
            this.butSaveDebts.Location = new System.Drawing.Point(673, 233);
            this.butSaveDebts.Name = "butSaveDebts";
            this.butSaveDebts.Size = new System.Drawing.Size(75, 23);
            this.butSaveDebts.TabIndex = 39;
            this.butSaveDebts.Text = "Сохранить";
            this.butSaveDebts.UseVisualStyleBackColor = true;
            this.butSaveDebts.Click += new System.EventHandler(this.butSaveDebts_Click);
            // 
            // butCloseDebt
            // 
            this.butCloseDebt.Location = new System.Drawing.Point(852, 32);
            this.butCloseDebt.Name = "butCloseDebt";
            this.butCloseDebt.Size = new System.Drawing.Size(128, 23);
            this.butCloseDebt.TabIndex = 38;
            this.butCloseDebt.Text = "Закрыть задолженность";
            this.butCloseDebt.UseVisualStyleBackColor = true;
            this.butCloseDebt.Click += new System.EventHandler(this.butCloseDebt_Click);
            // 
            // butChangeDebt
            // 
            this.butChangeDebt.Location = new System.Drawing.Point(754, 32);
            this.butChangeDebt.Name = "butChangeDebt";
            this.butChangeDebt.Size = new System.Drawing.Size(92, 23);
            this.butChangeDebt.TabIndex = 37;
            this.butChangeDebt.Text = "Редактировать";
            this.butChangeDebt.UseVisualStyleBackColor = true;
            this.butChangeDebt.Click += new System.EventHandler(this.butChangeDebt_Click);
            // 
            // butDeleteDebt
            // 
            this.butDeleteDebt.Location = new System.Drawing.Point(1153, 32);
            this.butDeleteDebt.Name = "butDeleteDebt";
            this.butDeleteDebt.Size = new System.Drawing.Size(75, 23);
            this.butDeleteDebt.TabIndex = 36;
            this.butDeleteDebt.Text = "Удалить";
            this.butDeleteDebt.UseVisualStyleBackColor = true;
            this.butDeleteDebt.Click += new System.EventHandler(this.butDeleteDebt_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reades_debtsBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(753, 77);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.iDTextBox.Size = new System.Drawing.Size(461, 20);
            this.iDTextBox.TabIndex = 25;
            // 
            // книгаTextBox
            // 
            this.книгаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reades_debtsBindingSource, "Книга", true));
            this.книгаTextBox.Location = new System.Drawing.Point(753, 103);
            this.книгаTextBox.Name = "книгаTextBox";
            this.книгаTextBox.ReadOnly = true;
            this.книгаTextBox.Size = new System.Drawing.Size(461, 20);
            this.книгаTextBox.TabIndex = 27;
            // 
            // дата_выдачиDateTimePicker
            // 
            this.дата_выдачиDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reades_debtsBindingSource, "Дата выдачи", true));
            this.дата_выдачиDateTimePicker.Enabled = false;
            this.дата_выдачиDateTimePicker.Location = new System.Drawing.Point(753, 129);
            this.дата_выдачиDateTimePicker.Name = "дата_выдачиDateTimePicker";
            this.дата_выдачиDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_выдачиDateTimePicker.TabIndex = 29;
            // 
            // дата_возвратаDateTimePicker
            // 
            this.дата_возвратаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reades_debtsBindingSource, "Дата возврата", true));
            this.дата_возвратаDateTimePicker.Enabled = false;
            this.дата_возвратаDateTimePicker.Location = new System.Drawing.Point(753, 155);
            this.дата_возвратаDateTimePicker.Name = "дата_возвратаDateTimePicker";
            this.дата_возвратаDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_возвратаDateTimePicker.TabIndex = 31;
            // 
            // возвращеноCheckBox
            // 
            this.возвращеноCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.reades_debtsBindingSource, "Возвращено", true));
            this.возвращеноCheckBox.Enabled = false;
            this.возвращеноCheckBox.Location = new System.Drawing.Point(753, 184);
            this.возвращеноCheckBox.Name = "возвращеноCheckBox";
            this.возвращеноCheckBox.Size = new System.Drawing.Size(200, 24);
            this.возвращеноCheckBox.TabIndex = 35;
            this.возвращеноCheckBox.UseVisualStyleBackColor = true;
            // 
            // butAddDebt
            // 
            this.butAddDebt.Location = new System.Drawing.Point(673, 32);
            this.butAddDebt.Name = "butAddDebt";
            this.butAddDebt.Size = new System.Drawing.Size(75, 23);
            this.butAddDebt.TabIndex = 24;
            this.butAddDebt.Text = "Добавить задолженность";
            this.butAddDebt.UseVisualStyleBackColor = true;
            this.butAddDebt.Click += new System.EventHandler(this.butAddDebt_Click);
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
            this.Возвращено,
            this.dataGridViewTextBoxColumn7,
            this.Book_ID});
            this.reades_debtsDataGridView.DataSource = this.reades_debtsBindingSource;
            this.reades_debtsDataGridView.Location = new System.Drawing.Point(6, 65);
            this.reades_debtsDataGridView.Name = "reades_debtsDataGridView";
            this.reades_debtsDataGridView.ReadOnly = true;
            this.reades_debtsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reades_debtsDataGridView.Size = new System.Drawing.Size(640, 191);
            this.reades_debtsDataGridView.TabIndex = 23;
            // 
            // Возвращено
            // 
            this.Возвращено.DataPropertyName = "Возвращено";
            this.Возвращено.HeaderText = "Возвращено";
            this.Возвращено.Name = "Возвращено";
            this.Возвращено.ReadOnly = true;
            // 
            // Book_ID
            // 
            this.Book_ID.DataPropertyName = "Book_ID";
            this.Book_ID.HeaderText = "Book_ID";
            this.Book_ID.Name = "Book_ID";
            this.Book_ID.ReadOnly = true;
            this.Book_ID.Visible = false;
            // 
            // tpOtchet
            // 
            this.tpOtchet.AutoScroll = true;
            this.tpOtchet.Controls.Add(this.tcReports);
            this.tpOtchet.Controls.Add(this.label8);
            this.tpOtchet.Location = new System.Drawing.Point(4, 23);
            this.tpOtchet.Name = "tpOtchet";
            this.tpOtchet.Padding = new System.Windows.Forms.Padding(3);
            this.tpOtchet.Size = new System.Drawing.Size(1256, 624);
            this.tpOtchet.TabIndex = 3;
            this.tpOtchet.Text = "Отчет";
            this.tpOtchet.UseVisualStyleBackColor = true;
            // 
            // tcReports
            // 
            this.tcReports.Controls.Add(this.tpReportBooks);
            this.tcReports.Controls.Add(this.tpReportReaders);
            this.tcReports.Location = new System.Drawing.Point(0, 3);
            this.tcReports.Multiline = true;
            this.tcReports.Name = "tcReports";
            this.tcReports.SelectedIndex = 0;
            this.tcReports.Size = new System.Drawing.Size(1253, 616);
            this.tcReports.TabIndex = 6;
            // 
            // tpReportBooks
            // 
            this.tpReportBooks.AutoScroll = true;
            this.tpReportBooks.Controls.Add(this.tbCountBooks);
            this.tpReportBooks.Controls.Add(this.label2);
            this.tpReportBooks.Controls.Add(this.readersHistoryDataGridView);
            this.tpReportBooks.Controls.Add(this.button3);
            this.tpReportBooks.Controls.Add(this.textBox1);
            this.tpReportBooks.Controls.Add(this.readersDataGridView1);
            this.tpReportBooks.Controls.Add(this.label1);
            this.tpReportBooks.Controls.Add(this.dateTimePicker1);
            this.tpReportBooks.Controls.Add(this.button2);
            this.tpReportBooks.Controls.Add(this.dateTimePicker2);
            this.tpReportBooks.Controls.Add(this.reader_IDTextBox1);
            this.tpReportBooks.Controls.Add(this.fIOTextBox1);
            this.tpReportBooks.Location = new System.Drawing.Point(4, 23);
            this.tpReportBooks.Name = "tpReportBooks";
            this.tpReportBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tpReportBooks.Size = new System.Drawing.Size(1245, 589);
            this.tpReportBooks.TabIndex = 0;
            this.tpReportBooks.Text = "Отчет о читателе";
            this.tpReportBooks.UseVisualStyleBackColor = true;
            // 
            // tbCountBooks
            // 
            this.tbCountBooks.Location = new System.Drawing.Point(1135, 510);
            this.tbCountBooks.Name = "tbCountBooks";
            this.tbCountBooks.ReadOnly = true;
            this.tbCountBooks.Size = new System.Drawing.Size(100, 20);
            this.tbCountBooks.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1136, 481);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 14);
            this.label2.TabIndex = 17;
            this.label2.Text = "Кол-во взятых книг";
            // 
            // readersHistoryDataGridView
            // 
            this.readersHistoryDataGridView.AllowUserToAddRows = false;
            this.readersHistoryDataGridView.AllowUserToDeleteRows = false;
            this.readersHistoryDataGridView.AutoGenerateColumns = false;
            this.readersHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.readersHistoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn19});
            this.readersHistoryDataGridView.DataSource = this.readersHistoryBindingSource;
            this.readersHistoryDataGridView.Location = new System.Drawing.Point(614, 44);
            this.readersHistoryDataGridView.Name = "readersHistoryDataGridView";
            this.readersHistoryDataGridView.ReadOnly = true;
            this.readersHistoryDataGridView.Size = new System.Drawing.Size(625, 425);
            this.readersHistoryDataGridView.TabIndex = 16;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(533, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Сбросить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(521, 20);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // readersDataGridView1
            // 
            this.readersDataGridView1.AllowUserToAddRows = false;
            this.readersDataGridView1.AllowUserToDeleteRows = false;
            this.readersDataGridView1.AutoGenerateColumns = false;
            this.readersDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.readersDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18});
            this.readersDataGridView1.DataSource = this.ReportReadersBindingSource;
            this.readersDataGridView1.Location = new System.Drawing.Point(6, 44);
            this.readersDataGridView1.Name = "readersDataGridView1";
            this.readersDataGridView1.ReadOnly = true;
            this.readersDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.readersDataGridView1.Size = new System.Drawing.Size(602, 537);
            this.readersDataGridView1.TabIndex = 5;
            this.readersDataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.readersDataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(800, 481);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "Указать отчетный период";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(876, 508);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(836, 549);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Создать отчет";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(661, 508);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 3;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // reader_IDTextBox1
            // 
            this.reader_IDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ReportReadersBindingSource, "Reader_ID", true));
            this.reader_IDTextBox1.Location = new System.Drawing.Point(86, 105);
            this.reader_IDTextBox1.Name = "reader_IDTextBox1";
            this.reader_IDTextBox1.Size = new System.Drawing.Size(100, 20);
            this.reader_IDTextBox1.TabIndex = 16;
            // 
            // tpReportReaders
            // 
            this.tpReportReaders.AutoScroll = true;
            this.tpReportReaders.Controls.Add(this.tbCountBookGive);
            this.tpReportReaders.Controls.Add(this.label9);
            this.tpReportReaders.Controls.Add(this.booksHistoryDataGridView);
            this.tpReportReaders.Controls.Add(this.button5);
            this.tpReportReaders.Controls.Add(this.textBox2);
            this.tpReportReaders.Controls.Add(this.booksDataGridView2);
            this.tpReportReaders.Controls.Add(this.dtPickerFrom);
            this.tpReportReaders.Controls.Add(this.dtPickerTo);
            this.tpReportReaders.Controls.Add(this.butCreateReport);
            this.tpReportReaders.Controls.Add(this.label7);
            this.tpReportReaders.Controls.Add(this.book_IDTextBox1);
            this.tpReportReaders.Controls.Add(this.book_NameTextBox1);
            this.tpReportReaders.Location = new System.Drawing.Point(4, 23);
            this.tpReportReaders.Name = "tpReportReaders";
            this.tpReportReaders.Padding = new System.Windows.Forms.Padding(3);
            this.tpReportReaders.Size = new System.Drawing.Size(1245, 589);
            this.tpReportReaders.TabIndex = 1;
            this.tpReportReaders.Text = "Отчет о книге";
            this.tpReportReaders.UseVisualStyleBackColor = true;
            // 
            // tbCountBookGive
            // 
            this.tbCountBookGive.Location = new System.Drawing.Point(1114, 517);
            this.tbCountBookGive.Name = "tbCountBookGive";
            this.tbCountBookGive.ReadOnly = true;
            this.tbCountBookGive.Size = new System.Drawing.Size(100, 20);
            this.tbCountBookGive.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1101, 487);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 14);
            this.label9.TabIndex = 19;
            this.label9.Text = "Сколько раз книгу брали";
            // 
            // booksHistoryDataGridView
            // 
            this.booksHistoryDataGridView.AllowUserToAddRows = false;
            this.booksHistoryDataGridView.AllowUserToDeleteRows = false;
            this.booksHistoryDataGridView.AutoGenerateColumns = false;
            this.booksHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksHistoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.bookidDataGridViewTextBoxColumn,
            this.readerIDDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.booksHistoryDataGridView.DataSource = this.booksHistoryBindingSource;
            this.booksHistoryDataGridView.Location = new System.Drawing.Point(614, 43);
            this.booksHistoryDataGridView.Name = "booksHistoryDataGridView";
            this.booksHistoryDataGridView.ReadOnly = true;
            this.booksHistoryDataGridView.Size = new System.Drawing.Size(625, 429);
            this.booksHistoryDataGridView.TabIndex = 10;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(534, 15);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(74, 25);
            this.button5.TabIndex = 9;
            this.button5.Text = "Сбросить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 17);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(524, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // booksDataGridView2
            // 
            this.booksDataGridView2.AllowUserToAddRows = false;
            this.booksDataGridView2.AllowUserToDeleteRows = false;
            this.booksDataGridView2.AllowUserToOrderColumns = true;
            this.booksDataGridView2.AutoGenerateColumns = false;
            this.booksDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksDataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn24});
            this.booksDataGridView2.DataSource = this.ReportBooksBindingSource;
            this.booksDataGridView2.Location = new System.Drawing.Point(6, 43);
            this.booksDataGridView2.Name = "booksDataGridView2";
            this.booksDataGridView2.ReadOnly = true;
            this.booksDataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.booksDataGridView2.Size = new System.Drawing.Size(602, 537);
            this.booksDataGridView2.TabIndex = 5;
            this.booksDataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.booksDataGridView2_CellClick);
            // 
            // dtPickerFrom
            // 
            this.dtPickerFrom.Location = new System.Drawing.Point(629, 517);
            this.dtPickerFrom.Name = "dtPickerFrom";
            this.dtPickerFrom.Size = new System.Drawing.Size(200, 20);
            this.dtPickerFrom.TabIndex = 3;
            this.dtPickerFrom.ValueChanged += new System.EventHandler(this.dtPickerFrom_ValueChanged);
            // 
            // dtPickerTo
            // 
            this.dtPickerTo.Location = new System.Drawing.Point(844, 517);
            this.dtPickerTo.Name = "dtPickerTo";
            this.dtPickerTo.Size = new System.Drawing.Size(200, 20);
            this.dtPickerTo.TabIndex = 2;
            this.dtPickerTo.ValueChanged += new System.EventHandler(this.dtPickerFrom_ValueChanged);
            // 
            // butCreateReport
            // 
            this.butCreateReport.Location = new System.Drawing.Point(798, 557);
            this.butCreateReport.Name = "butCreateReport";
            this.butCreateReport.Size = new System.Drawing.Size(75, 23);
            this.butCreateReport.TabIndex = 1;
            this.butCreateReport.Text = "Создать отчет";
            this.butCreateReport.UseVisualStyleBackColor = true;
            this.butCreateReport.Click += new System.EventHandler(this.butCreateReport_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(774, 487);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 14);
            this.label7.TabIndex = 4;
            this.label7.Text = "Указать отчетный период";
            // 
            // book_IDTextBox1
            // 
            this.book_IDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ReportBooksBindingSource, "Book_ID", true));
            this.book_IDTextBox1.Location = new System.Drawing.Point(75, 86);
            this.book_IDTextBox1.Name = "book_IDTextBox1";
            this.book_IDTextBox1.Size = new System.Drawing.Size(100, 20);
            this.book_IDTextBox1.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(209, 467);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = "-";
            // 
            // tpAccounts
            // 
            this.tpAccounts.Controls.Add(this.groupBox4);
            this.tpAccounts.Controls.Add(this.gbNewAcc);
            this.tpAccounts.Controls.Add(this.button4);
            this.tpAccounts.Controls.Add(this.butResetAccSearch);
            this.tpAccounts.Controls.Add(this.tbAccSearch);
            this.tpAccounts.Controls.Add(this.butChangeAccounts);
            this.tpAccounts.Controls.Add(this.autDataGridView);
            this.tpAccounts.Location = new System.Drawing.Point(4, 23);
            this.tpAccounts.Name = "tpAccounts";
            this.tpAccounts.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccounts.Size = new System.Drawing.Size(1256, 624);
            this.tpAccounts.TabIndex = 2;
            this.tpAccounts.Text = "Аккаунты";
            this.tpAccounts.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(iDLabel2);
            this.groupBox4.Controls.Add(this.butDeletAcc);
            this.groupBox4.Controls.Add(this.butCancelNewAcc);
            this.groupBox4.Controls.Add(this.iDAccTextBox);
            this.groupBox4.Controls.Add(this.butSaveNewAcc);
            this.groupBox4.Controls.Add(loginLabel1);
            this.groupBox4.Controls.Add(this.checkBox4);
            this.groupBox4.Controls.Add(this.loginTextBox1);
            this.groupBox4.Controls.Add(fIOLabel1);
            this.groupBox4.Controls.Add(passwordLabel1);
            this.groupBox4.Controls.Add(this.fIOAccTextBox);
            this.groupBox4.Controls.Add(this.passwordTextBox);
            this.groupBox4.Controls.Add(this.is_adminCheckBox);
            this.groupBox4.Controls.Add(is_adminLabel1);
            this.groupBox4.Enabled = false;
            this.groupBox4.Location = new System.Drawing.Point(567, 60);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(327, 211);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Пользователь";
            // 
            // butDeletAcc
            // 
            this.butDeletAcc.Location = new System.Drawing.Point(128, 182);
            this.butDeletAcc.Name = "butDeletAcc";
            this.butDeletAcc.Size = new System.Drawing.Size(75, 23);
            this.butDeletAcc.TabIndex = 16;
            this.butDeletAcc.Text = "Удалить";
            this.butDeletAcc.UseVisualStyleBackColor = true;
            this.butDeletAcc.Click += new System.EventHandler(this.butDeletAcc_Click);
            // 
            // butCancelNewAcc
            // 
            this.butCancelNewAcc.Location = new System.Drawing.Point(246, 182);
            this.butCancelNewAcc.Name = "butCancelNewAcc";
            this.butCancelNewAcc.Size = new System.Drawing.Size(75, 23);
            this.butCancelNewAcc.TabIndex = 11;
            this.butCancelNewAcc.Text = "Отменить";
            this.butCancelNewAcc.UseVisualStyleBackColor = true;
            this.butCancelNewAcc.Click += new System.EventHandler(this.button3_Click);
            // 
            // iDAccTextBox
            // 
            this.iDAccTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autBindingSource, "ID", true));
            this.iDAccTextBox.Location = new System.Drawing.Point(70, 26);
            this.iDAccTextBox.Name = "iDAccTextBox";
            this.iDAccTextBox.ReadOnly = true;
            this.iDAccTextBox.Size = new System.Drawing.Size(226, 20);
            this.iDAccTextBox.TabIndex = 19;
            // 
            // butSaveNewAcc
            // 
            this.butSaveNewAcc.Location = new System.Drawing.Point(6, 182);
            this.butSaveNewAcc.Name = "butSaveNewAcc";
            this.butSaveNewAcc.Size = new System.Drawing.Size(75, 23);
            this.butSaveNewAcc.TabIndex = 10;
            this.butSaveNewAcc.Text = "Сохранить";
            this.butSaveNewAcc.UseVisualStyleBackColor = true;
            this.butSaveNewAcc.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(239, 117);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(78, 18);
            this.checkBox4.TabIndex = 17;
            this.checkBox4.Text = "Видимость";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // loginTextBox1
            // 
            this.loginTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autBindingSource, "login", true));
            this.loginTextBox1.Location = new System.Drawing.Point(70, 88);
            this.loginTextBox1.Name = "loginTextBox1";
            this.loginTextBox1.Size = new System.Drawing.Size(163, 20);
            this.loginTextBox1.TabIndex = 21;
            // 
            // fIOAccTextBox
            // 
            this.fIOAccTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autBindingSource, "FIO", true));
            this.fIOAccTextBox.Location = new System.Drawing.Point(70, 56);
            this.fIOAccTextBox.Name = "fIOAccTextBox";
            this.fIOAccTextBox.Size = new System.Drawing.Size(226, 20);
            this.fIOAccTextBox.TabIndex = 27;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autBindingSource, "password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(70, 114);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(163, 20);
            this.passwordTextBox.TabIndex = 23;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // is_adminCheckBox
            // 
            this.is_adminCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.autBindingSource, "is_admin", true));
            this.is_adminCheckBox.Location = new System.Drawing.Point(70, 140);
            this.is_adminCheckBox.Name = "is_adminCheckBox";
            this.is_adminCheckBox.Size = new System.Drawing.Size(104, 24);
            this.is_adminCheckBox.TabIndex = 25;
            this.is_adminCheckBox.UseVisualStyleBackColor = true;
            // 
            // gbNewAcc
            // 
            this.gbNewAcc.Controls.Add(this.tbNewAccFIO);
            this.gbNewAcc.Controls.Add(label6);
            this.gbNewAcc.Controls.Add(label5);
            this.gbNewAcc.Controls.Add(this.checkBox5);
            this.gbNewAcc.Controls.Add(this.butCancelAdd);
            this.gbNewAcc.Controls.Add(this.butAddAccount);
            this.gbNewAcc.Controls.Add(label3);
            this.gbNewAcc.Controls.Add(label4);
            this.gbNewAcc.Controls.Add(this.chkbIsAdmin);
            this.gbNewAcc.Controls.Add(this.tbPassword);
            this.gbNewAcc.Controls.Add(this.tbLogin);
            this.gbNewAcc.Location = new System.Drawing.Point(567, 277);
            this.gbNewAcc.Name = "gbNewAcc";
            this.gbNewAcc.Size = new System.Drawing.Size(327, 173);
            this.gbNewAcc.TabIndex = 15;
            this.gbNewAcc.TabStop = false;
            this.gbNewAcc.Text = "Новый пользователь";
            this.gbNewAcc.Visible = false;
            // 
            // tbNewAccFIO
            // 
            this.tbNewAccFIO.Location = new System.Drawing.Point(58, 21);
            this.tbNewAccFIO.Name = "tbNewAccFIO";
            this.tbNewAccFIO.Size = new System.Drawing.Size(242, 20);
            this.tbNewAccFIO.TabIndex = 28;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(243, 78);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(78, 18);
            this.checkBox5.TabIndex = 18;
            this.checkBox5.Text = "Видимость";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // butCancelAdd
            // 
            this.butCancelAdd.Location = new System.Drawing.Point(246, 138);
            this.butCancelAdd.Name = "butCancelAdd";
            this.butCancelAdd.Size = new System.Drawing.Size(75, 23);
            this.butCancelAdd.TabIndex = 9;
            this.butCancelAdd.Text = "Отмена";
            this.butCancelAdd.UseVisualStyleBackColor = true;
            this.butCancelAdd.Click += new System.EventHandler(this.butCancelAdd_Click);
            // 
            // butAddAccount
            // 
            this.butAddAccount.Location = new System.Drawing.Point(6, 136);
            this.butAddAccount.Name = "butAddAccount";
            this.butAddAccount.Size = new System.Drawing.Size(75, 23);
            this.butAddAccount.TabIndex = 8;
            this.butAddAccount.Text = "Добавить";
            this.butAddAccount.UseVisualStyleBackColor = true;
            this.butAddAccount.Click += new System.EventHandler(this.butAddAccount_Click);
            // 
            // chkbIsAdmin
            // 
            this.chkbIsAdmin.AutoSize = true;
            this.chkbIsAdmin.Location = new System.Drawing.Point(58, 107);
            this.chkbIsAdmin.Name = "chkbIsAdmin";
            this.chkbIsAdmin.Size = new System.Drawing.Size(15, 14);
            this.chkbIsAdmin.TabIndex = 2;
            this.chkbIsAdmin.UseVisualStyleBackColor = true;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(58, 76);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(179, 20);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(58, 50);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(179, 20);
            this.tbLogin.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(664, 31);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Создать нового";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // butResetAccSearch
            // 
            this.butResetAccSearch.Location = new System.Drawing.Point(473, 30);
            this.butResetAccSearch.Name = "butResetAccSearch";
            this.butResetAccSearch.Size = new System.Drawing.Size(75, 23);
            this.butResetAccSearch.TabIndex = 13;
            this.butResetAccSearch.Text = "Сбросить";
            this.butResetAccSearch.UseVisualStyleBackColor = true;
            this.butResetAccSearch.Click += new System.EventHandler(this.butResetAccSearch_Click);
            // 
            // tbAccSearch
            // 
            this.tbAccSearch.Location = new System.Drawing.Point(8, 31);
            this.tbAccSearch.Name = "tbAccSearch";
            this.tbAccSearch.Size = new System.Drawing.Size(456, 20);
            this.tbAccSearch.TabIndex = 12;
            this.tbAccSearch.TextChanged += new System.EventHandler(this.tbAccSearch_TextChanged);
            // 
            // butChangeAccounts
            // 
            this.butChangeAccounts.Location = new System.Drawing.Point(567, 31);
            this.butChangeAccounts.Name = "butChangeAccounts";
            this.butChangeAccounts.Size = new System.Drawing.Size(91, 23);
            this.butChangeAccounts.TabIndex = 9;
            this.butChangeAccounts.Text = "Редактировать";
            this.butChangeAccounts.UseVisualStyleBackColor = true;
            this.butChangeAccounts.Click += new System.EventHandler(this.butChangeAccounts_Click);
            // 
            // autDataGridView
            // 
            this.autDataGridView.AllowUserToAddRows = false;
            this.autDataGridView.AllowUserToDeleteRows = false;
            this.autDataGridView.AutoGenerateColumns = false;
            this.autDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.autDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.FIO,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewCheckBoxColumn2});
            this.autDataGridView.DataSource = this.autBindingSource;
            this.autDataGridView.Location = new System.Drawing.Point(6, 66);
            this.autDataGridView.Name = "autDataGridView";
            this.autDataGridView.ReadOnly = true;
            this.autDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.autDataGridView.Size = new System.Drawing.Size(539, 356);
            this.autDataGridView.TabIndex = 0;
            // 
            // FIO
            // 
            this.FIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FIO.DataPropertyName = "FIO";
            this.FIO.HeaderText = "ФИО";
            this.FIO.Name = "FIO";
            this.FIO.ReadOnly = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "Report";
            this.saveFileDialog1.Filter = "PDF | *.pdf";
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
            // reades_debtsBindingSource
            // 
            this.reades_debtsBindingSource.DataMember = "reades_debts";
            this.reades_debtsBindingSource.DataSource = this.library451DataSet;
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
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn13.HeaderText = "ID";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 50;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Reader_ID";
            this.dataGridViewTextBoxColumn14.HeaderText = "Reader_ID";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Visible = false;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Book_ID";
            this.dataGridViewTextBoxColumn15.HeaderText = "Номер книги";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn16.DataPropertyName = "book_name";
            this.dataGridViewTextBoxColumn16.HeaderText = "Книга";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn19.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Width = 80;
            // 
            // readersHistoryBindingSource
            // 
            this.readersHistoryBindingSource.DataMember = "ReadersHistory";
            this.readersHistoryBindingSource.DataSource = this.library451DWHDataSet;
            // 
            // library451DWHDataSet
            // 
            this.library451DWHDataSet.DataSetName = "Library451DWHDataSet";
            this.library451DWHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Reader_ID";
            this.dataGridViewTextBoxColumn17.HeaderText = "Учетный номер";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Width = 110;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn18.DataPropertyName = "FIO";
            this.dataGridViewTextBoxColumn18.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // ReportReadersBindingSource
            // 
            this.ReportReadersBindingSource.DataMember = "Readers";
            this.ReportReadersBindingSource.DataSource = this.library451DataSet;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookidDataGridViewTextBoxColumn
            // 
            this.bookidDataGridViewTextBoxColumn.DataPropertyName = "book_id";
            this.bookidDataGridViewTextBoxColumn.HeaderText = "book_id";
            this.bookidDataGridViewTextBoxColumn.Name = "bookidDataGridViewTextBoxColumn";
            this.bookidDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookidDataGridViewTextBoxColumn.Visible = false;
            // 
            // readerIDDataGridViewTextBoxColumn
            // 
            this.readerIDDataGridViewTextBoxColumn.DataPropertyName = "Reader_ID";
            this.readerIDDataGridViewTextBoxColumn.HeaderText = "Читательский номер";
            this.readerIDDataGridViewTextBoxColumn.Name = "readerIDDataGridViewTextBoxColumn";
            this.readerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.readerIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            this.fIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 80;
            // 
            // booksHistoryBindingSource
            // 
            this.booksHistoryBindingSource.DataMember = "BooksHistory";
            this.booksHistoryBindingSource.DataSource = this.library451DWHDataSet;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Book_ID";
            this.dataGridViewTextBoxColumn20.HeaderText = "Учетный номер";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            this.dataGridViewTextBoxColumn20.Width = 110;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn24.DataPropertyName = "Book_Name";
            this.dataGridViewTextBoxColumn24.HeaderText = "Книга";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            // 
            // ReportBooksBindingSource
            // 
            this.ReportBooksBindingSource.DataMember = "Books";
            this.ReportBooksBindingSource.DataSource = this.library451DataSet;
            // 
            // autBindingSource
            // 
            this.autBindingSource.DataMember = "aut";
            this.autBindingSource.DataSource = this.library451DataSet;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn10.HeaderText = "ID";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 50;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "login";
            this.dataGridViewTextBoxColumn11.HeaderText = "login";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "password";
            this.dataGridViewTextBoxColumn12.HeaderText = "password";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "is_admin";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Админ?";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            this.dataGridViewCheckBoxColumn2.Width = 80;
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
            // debtsTableAdapter
            // 
            this.debtsTableAdapter.ClearBeforeFill = true;
            // 
            // readersHistoryTableAdapter
            // 
            this.readersHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.DimBookTableAdapter = null;
            this.tableAdapterManager1.DimDateTableAdapter = null;
            this.tableAdapterManager1.DimReaderTableAdapter = null;
            this.tableAdapterManager1.FactsBookHistoryTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = WindowsFormsApp1.Library451DWHDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // booksHistoryTableAdapter
            // 
            this.booksHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // fIOTextBox1
            // 
            this.fIOTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ReportReadersBindingSource, "FIO", true));
            this.fIOTextBox1.Location = new System.Drawing.Point(86, 131);
            this.fIOTextBox1.Name = "fIOTextBox1";
            this.fIOTextBox1.Size = new System.Drawing.Size(100, 20);
            this.fIOTextBox1.TabIndex = 19;
            // 
            // book_NameTextBox1
            // 
            this.book_NameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ReportBooksBindingSource, "Book_Name", true));
            this.book_NameTextBox1.Location = new System.Drawing.Point(75, 112);
            this.book_NameTextBox1.Name = "book_NameTextBox1";
            this.book_NameTextBox1.Size = new System.Drawing.Size(100, 20);
            this.book_NameTextBox1.TabIndex = 21;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учет читателей";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
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
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reades_debtsDataGridView)).EndInit();
            this.tpOtchet.ResumeLayout(false);
            this.tpOtchet.PerformLayout();
            this.tcReports.ResumeLayout(false);
            this.tpReportBooks.ResumeLayout(false);
            this.tpReportBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.readersHistoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readersDataGridView1)).EndInit();
            this.tpReportReaders.ResumeLayout(false);
            this.tpReportReaders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksHistoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView2)).EndInit();
            this.tpAccounts.ResumeLayout(false);
            this.tpAccounts.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gbNewAcc.ResumeLayout(false);
            this.gbNewAcc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library451DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reades_debtsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readersHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library451DWHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportReadersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportBooksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подключениеКБДToolStripMenuItem;
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
        private System.Windows.Forms.TextBox aDDRESSTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
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
        private System.Windows.Forms.Button butAddDebt;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox книгаTextBox;
        private System.Windows.Forms.DateTimePicker дата_выдачиDateTimePicker;
        private System.Windows.Forms.DateTimePicker дата_возвратаDateTimePicker;
        private System.Windows.Forms.CheckBox возвращеноCheckBox;
        private System.Windows.Forms.Button butDeleteDebt;
        private Library451DataSetTableAdapters.DebtsTableAdapter debtsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Возвращено;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_ID;
        private System.Windows.Forms.Button butCloseDebt;
        private System.Windows.Forms.Button butChangeDebt;
        private System.Windows.Forms.Button butBackChangesDebts;
        private System.Windows.Forms.Button butSaveDebts;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button butSearchDebts;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox tbDebtsSearch;
        private System.Windows.Forms.MaskedTextBox tELEPHONETextBox;
        private System.Windows.Forms.MaskedTextBox pASSPORTTextBox;
        private System.Windows.Forms.TabPage tpAccounts;
        private System.Windows.Forms.DataGridView autDataGridView;
        private System.Windows.Forms.BindingSource autBindingSource;
        private System.Windows.Forms.Button butChangeAccounts;
        private System.Windows.Forms.GroupBox gbNewAcc;
        private System.Windows.Forms.CheckBox chkbIsAdmin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button butResetAccSearch;
        private System.Windows.Forms.TextBox tbAccSearch;
        private System.Windows.Forms.Button butCancelNewAcc;
        private System.Windows.Forms.Button butSaveNewAcc;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button butDeletAcc;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Button butCancelAdd;
        private System.Windows.Forms.Button butAddAccount;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.TextBox iDAccTextBox;
        private System.Windows.Forms.TextBox loginTextBox1;
        private System.Windows.Forms.TextBox fIOAccTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.CheckBox is_adminCheckBox;
        private System.Windows.Forms.TextBox tbNewAccFIO;
        private System.Windows.Forms.TabPage tpOtchet;
        private System.Windows.Forms.Button butCreateReport;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtPickerFrom;
        private System.Windows.Forms.DateTimePicker dtPickerTo;
        private System.Windows.Forms.TabControl tcReports;
        private System.Windows.Forms.TabPage tpReportBooks;
        private System.Windows.Forms.TabPage tpReportReaders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private Library451DWHDataSet library451DWHDataSet;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView readersDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView booksDataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.BindingSource ReportReadersBindingSource;
        private System.Windows.Forms.BindingSource ReportBooksBindingSource;
        private System.Windows.Forms.TextBox reader_IDTextBox1;
        private System.Windows.Forms.TextBox book_IDTextBox1;
        private System.Windows.Forms.BindingSource readersHistoryBindingSource;
        private Library451DWHDataSetTableAdapters.ReadersHistoryTableAdapter readersHistoryTableAdapter;
        private Library451DWHDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView readersHistoryDataGridView;
        private System.Windows.Forms.BindingSource booksHistoryBindingSource;
        private Library451DWHDataSetTableAdapters.BooksHistoryTableAdapter booksHistoryTableAdapter;
        private System.Windows.Forms.DataGridView booksHistoryDataGridView;
        private System.Windows.Forms.TextBox tbCountBooks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCountBookGive;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn readerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox fIOTextBox1;
        private System.Windows.Forms.TextBox book_NameTextBox1;
    }
}

