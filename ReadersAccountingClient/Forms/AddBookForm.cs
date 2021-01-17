using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
        }

        private void but_add_new_book_Click(object sender, EventArgs e)
        {
            //this.booksTableAdapter.Fill(this.library451DataSet.Books);
            this.library451DataSet.Books.AddBooksRow(tb_book.Text, chb_avl.Checked);
            this.booksTableAdapter.Update(this.library451DataSet.Books);
            this.library451DWHDataSet.DimBook.AddDimBookRow(this.library451DataSet.Books.Last().Book_ID, tb_book.Text);
            this.dimBookTableAdapter.Update(this.library451DWHDataSet.DimBook);
            Close();
        }

        private void but_close_add_new_book_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
