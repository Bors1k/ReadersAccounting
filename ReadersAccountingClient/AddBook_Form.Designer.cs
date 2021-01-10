
namespace WindowsFormsApp1
{
    partial class AddBook_Form
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label5;
            this.but_close_add_new_book = new System.Windows.Forms.Button();
            this.but_add_new_book = new System.Windows.Forms.Button();
            this.chb_avl = new System.Windows.Forms.CheckBox();
            this.tb_book = new System.Windows.Forms.TextBox();
            this.booksTableAdapter = new WindowsFormsApp1.Library451DataSetTableAdapters.BooksTableAdapter();
            this.library451DataSet = new WindowsFormsApp1.Library451DataSet();
            label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.library451DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(13, 51);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(76, 13);
            label3.TabIndex = 17;
            label3.Text = "Доступность:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(13, 21);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(40, 13);
            label5.TabIndex = 15;
            label5.Text = "Книга:";
            // 
            // but_close_add_new_book
            // 
            this.but_close_add_new_book.Location = new System.Drawing.Point(126, 77);
            this.but_close_add_new_book.Name = "but_close_add_new_book";
            this.but_close_add_new_book.Size = new System.Drawing.Size(96, 23);
            this.but_close_add_new_book.TabIndex = 19;
            this.but_close_add_new_book.Text = "Отмена";
            this.but_close_add_new_book.UseVisualStyleBackColor = true;
            this.but_close_add_new_book.Click += new System.EventHandler(this.but_close_add_new_book_Click);
            // 
            // but_add_new_book
            // 
            this.but_add_new_book.Location = new System.Drawing.Point(12, 77);
            this.but_add_new_book.Name = "but_add_new_book";
            this.but_add_new_book.Size = new System.Drawing.Size(96, 23);
            this.but_add_new_book.TabIndex = 20;
            this.but_add_new_book.Text = "Добавить";
            this.but_add_new_book.UseVisualStyleBackColor = true;
            this.but_add_new_book.Click += new System.EventHandler(this.but_add_new_book_Click);
            // 
            // chb_avl
            // 
            this.chb_avl.Location = new System.Drawing.Point(92, 47);
            this.chb_avl.Name = "chb_avl";
            this.chb_avl.Size = new System.Drawing.Size(104, 24);
            this.chb_avl.TabIndex = 18;
            this.chb_avl.UseVisualStyleBackColor = true;
            // 
            // tb_book
            // 
            this.tb_book.Location = new System.Drawing.Point(92, 21);
            this.tb_book.Name = "tb_book";
            this.tb_book.Size = new System.Drawing.Size(403, 20);
            this.tb_book.TabIndex = 16;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // library451DataSet
            // 
            this.library451DataSet.DataSetName = "Library451DataSet";
            this.library451DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddBook_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 121);
            this.Controls.Add(this.but_close_add_new_book);
            this.Controls.Add(this.but_add_new_book);
            this.Controls.Add(label3);
            this.Controls.Add(this.chb_avl);
            this.Controls.Add(this.tb_book);
            this.Controls.Add(label5);
            this.MaximumSize = new System.Drawing.Size(530, 160);
            this.MinimumSize = new System.Drawing.Size(530, 160);
            this.Name = "AddBook_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить книгу";
            ((System.ComponentModel.ISupportInitialize)(this.library451DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_close_add_new_book;
        private System.Windows.Forms.Button but_add_new_book;
        private System.Windows.Forms.CheckBox chb_avl;
        private System.Windows.Forms.TextBox tb_book;
        private Library451DataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private Library451DataSet library451DataSet;
    }
}