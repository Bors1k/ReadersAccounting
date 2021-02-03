
namespace WindowsFormsApp1
{
    partial class AddDebtForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label book_IDLabel;
            System.Windows.Forms.Label book_NameLabel;
            System.Windows.Forms.Label availabilityLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDebtForm));
            this.library451DataSet = new WindowsFormsApp1.Library451DataSet();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableAdapter = new WindowsFormsApp1.Library451DataSetTableAdapters.BooksTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.Library451DataSetTableAdapters.TableAdapterManager();
            this.booksDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.book_IDTextBox = new System.Windows.Forms.TextBox();
            this.book_NameTextBox = new System.Windows.Forms.TextBox();
            this.availabilityCheckBox = new System.Windows.Forms.CheckBox();
            this.debtsTableAdapter = new WindowsFormsApp1.Library451DataSetTableAdapters.DebtsTableAdapter();
            this.butAddNewDebt = new System.Windows.Forms.Button();
            this.butClose = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.readersTableAdapter = new WindowsFormsApp1.Library451DataSetTableAdapters.ReadersTableAdapter();
            this.tbSearchBook = new System.Windows.Forms.TextBox();
            this.butResetSearch = new System.Windows.Forms.Button();
            this.library451DWHDataSet = new WindowsFormsApp1.Library451DWHDataSet();
            this.dimReaderTableAdapter = new WindowsFormsApp1.Library451DWHDataSetTableAdapters.DimReaderTableAdapter();
            this.dimDateTableAdapter = new WindowsFormsApp1.Library451DWHDataSetTableAdapters.DimDateTableAdapter();
            this.dimBookTableAdapter = new WindowsFormsApp1.Library451DWHDataSetTableAdapters.DimBookTableAdapter();
            this.factsBookHistoryTableAdapter = new WindowsFormsApp1.Library451DWHDataSetTableAdapters.FactsBookHistoryTableAdapter();
            book_IDLabel = new System.Windows.Forms.Label();
            book_NameLabel = new System.Windows.Forms.Label();
            availabilityLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.library451DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library451DWHDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // book_IDLabel
            // 
            book_IDLabel.AutoSize = true;
            book_IDLabel.Location = new System.Drawing.Point(12, 266);
            book_IDLabel.Name = "book_IDLabel";
            book_IDLabel.Size = new System.Drawing.Size(83, 13);
            book_IDLabel.TabIndex = 1;
            book_IDLabel.Text = "Учтный номер:";
            // 
            // book_NameLabel
            // 
            book_NameLabel.AutoSize = true;
            book_NameLabel.Location = new System.Drawing.Point(12, 292);
            book_NameLabel.Name = "book_NameLabel";
            book_NameLabel.Size = new System.Drawing.Size(40, 13);
            book_NameLabel.TabIndex = 3;
            book_NameLabel.Text = "Книга:";
            // 
            // availabilityLabel
            // 
            availabilityLabel.AutoSize = true;
            availabilityLabel.Location = new System.Drawing.Point(225, 157);
            availabilityLabel.Name = "availabilityLabel";
            availabilityLabel.Size = new System.Drawing.Size(76, 13);
            availabilityLabel.TabIndex = 5;
            availabilityLabel.Text = "Доступность:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 323);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(86, 13);
            label1.TabIndex = 10;
            label1.Text = "Дата возврата:";
            // 
            // library451DataSet
            // 
            this.library451DataSet.DataSetName = "Library451DataSet";
            this.library451DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.library451DataSet;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.autTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BooksTableAdapter = this.booksTableAdapter;
            this.tableAdapterManager.DebtsTableAdapter = null;
            this.tableAdapterManager.ReadersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.Library451DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // booksDataGridView
            // 
            this.booksDataGridView.AllowUserToAddRows = false;
            this.booksDataGridView.AllowUserToDeleteRows = false;
            this.booksDataGridView.AutoGenerateColumns = false;
            this.booksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1});
            this.booksDataGridView.DataSource = this.booksBindingSource;
            this.booksDataGridView.Location = new System.Drawing.Point(12, 49);
            this.booksDataGridView.Name = "booksDataGridView";
            this.booksDataGridView.ReadOnly = true;
            this.booksDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.booksDataGridView.Size = new System.Drawing.Size(776, 199);
            this.booksDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Availability";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Доступность";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 80;
            // 
            // book_IDTextBox
            // 
            this.book_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Book_ID", true));
            this.book_IDTextBox.Location = new System.Drawing.Point(101, 263);
            this.book_IDTextBox.Name = "book_IDTextBox";
            this.book_IDTextBox.ReadOnly = true;
            this.book_IDTextBox.Size = new System.Drawing.Size(389, 20);
            this.book_IDTextBox.TabIndex = 2;
            // 
            // book_NameTextBox
            // 
            this.book_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Book_Name", true));
            this.book_NameTextBox.Location = new System.Drawing.Point(101, 289);
            this.book_NameTextBox.Name = "book_NameTextBox";
            this.book_NameTextBox.ReadOnly = true;
            this.book_NameTextBox.Size = new System.Drawing.Size(687, 20);
            this.book_NameTextBox.TabIndex = 4;
            // 
            // availabilityCheckBox
            // 
            this.availabilityCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.booksBindingSource, "Availability", true));
            this.availabilityCheckBox.Enabled = false;
            this.availabilityCheckBox.Location = new System.Drawing.Point(314, 152);
            this.availabilityCheckBox.Name = "availabilityCheckBox";
            this.availabilityCheckBox.Size = new System.Drawing.Size(104, 24);
            this.availabilityCheckBox.TabIndex = 6;
            this.availabilityCheckBox.UseVisualStyleBackColor = true;
            // 
            // debtsTableAdapter
            // 
            this.debtsTableAdapter.ClearBeforeFill = true;
            // 
            // butAddNewDebt
            // 
            this.butAddNewDebt.Location = new System.Drawing.Point(12, 371);
            this.butAddNewDebt.Name = "butAddNewDebt";
            this.butAddNewDebt.Size = new System.Drawing.Size(75, 23);
            this.butAddNewDebt.TabIndex = 7;
            this.butAddNewDebt.Text = "Добавить";
            this.butAddNewDebt.UseVisualStyleBackColor = true;
            this.butAddNewDebt.Click += new System.EventHandler(this.butAddNewDebt_Click);
            // 
            // butClose
            // 
            this.butClose.Location = new System.Drawing.Point(721, 371);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(75, 23);
            this.butClose.TabIndex = 8;
            this.butClose.Text = "Отмена";
            this.butClose.UseVisualStyleBackColor = true;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(101, 317);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // readersTableAdapter
            // 
            this.readersTableAdapter.ClearBeforeFill = true;
            // 
            // tbSearchBook
            // 
            this.tbSearchBook.Location = new System.Drawing.Point(15, 13);
            this.tbSearchBook.Name = "tbSearchBook";
            this.tbSearchBook.Size = new System.Drawing.Size(688, 20);
            this.tbSearchBook.TabIndex = 11;
            this.tbSearchBook.TextChanged += new System.EventHandler(this.tbSearchBook_TextChanged);
            // 
            // butResetSearch
            // 
            this.butResetSearch.Location = new System.Drawing.Point(709, 11);
            this.butResetSearch.Name = "butResetSearch";
            this.butResetSearch.Size = new System.Drawing.Size(75, 23);
            this.butResetSearch.TabIndex = 12;
            this.butResetSearch.Text = "Cбросить";
            this.butResetSearch.UseVisualStyleBackColor = true;
            this.butResetSearch.Click += new System.EventHandler(this.butResetSearch_Click);
            // 
            // library451DWHDataSet
            // 
            this.library451DWHDataSet.DataSetName = "Library451DWHDataSet";
            this.library451DWHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dimReaderTableAdapter
            // 
            this.dimReaderTableAdapter.ClearBeforeFill = true;
            // 
            // dimDateTableAdapter
            // 
            this.dimDateTableAdapter.ClearBeforeFill = true;
            // 
            // dimBookTableAdapter
            // 
            this.dimBookTableAdapter.ClearBeforeFill = true;
            // 
            // factsBookHistoryTableAdapter
            // 
            this.factsBookHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // AddDebtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 406);
            this.Controls.Add(this.butResetSearch);
            this.Controls.Add(this.tbSearchBook);
            this.Controls.Add(this.booksDataGridView);
            this.Controls.Add(label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.butAddNewDebt);
            this.Controls.Add(book_IDLabel);
            this.Controls.Add(this.book_IDTextBox);
            this.Controls.Add(book_NameLabel);
            this.Controls.Add(this.book_NameTextBox);
            this.Controls.Add(availabilityLabel);
            this.Controls.Add(this.availabilityCheckBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(824, 445);
            this.MinimumSize = new System.Drawing.Size(824, 445);
            this.Name = "AddDebtForm";
            this.Text = "Задолженность";
            this.Load += new System.EventHandler(this.AddReaderDebt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.library451DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library451DWHDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Library451DataSet library451DataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private Library451DataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private Library451DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView booksDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.TextBox book_IDTextBox;
        private System.Windows.Forms.TextBox book_NameTextBox;
        private System.Windows.Forms.CheckBox availabilityCheckBox;
        private Library451DataSetTableAdapters.DebtsTableAdapter debtsTableAdapter;
        private System.Windows.Forms.Button butAddNewDebt;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Library451DataSetTableAdapters.ReadersTableAdapter readersTableAdapter;
        private System.Windows.Forms.TextBox tbSearchBook;
        private System.Windows.Forms.Button butResetSearch;
        private Library451DWHDataSet library451DWHDataSet;
        private Library451DWHDataSetTableAdapters.DimReaderTableAdapter dimReaderTableAdapter;
        private Library451DWHDataSetTableAdapters.DimDateTableAdapter dimDateTableAdapter;
        private Library451DWHDataSetTableAdapters.DimBookTableAdapter dimBookTableAdapter;
        private Library451DWHDataSetTableAdapters.FactsBookHistoryTableAdapter factsBookHistoryTableAdapter;
    }
}