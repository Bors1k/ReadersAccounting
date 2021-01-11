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
    public partial class AddReaderDebt : Form
    {
        private int readerID;
        public AddReaderDebt(int readerID)
        {
            this.readerID = readerID;
            InitializeComponent();
        }
        private void AddReaderDebt_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "library451DataSet.Books". При необходимости она может быть перемещена или удалена.
            this.booksTableAdapter.Fill(this.library451DataSet.Books);
            this.readersTableAdapter1.Fill(this.library451DataSet.Readers);
            this.debtsTableAdapter1.Fill(this.library451DataSet.Debts);
            this.booksBindingSource.Filter = "[Availability] = true";

        }

        private void butAddNewDebt_Click(object sender, EventArgs e)
        {
            this.library451DataSet.Debts.AddDebtsRow(this.library451DataSet.Readers.FindByReader_ID(readerID), this.library451DataSet.Books.FindByBook_ID(Int32.Parse(book_IDTextBox.Text)), DateTime.Today, dateTimePicker1.Value,false);
            this.availabilityCheckBox.Checked = false;
            this.booksBindingSource.EndEdit();
            this.booksTableAdapter.Update(library451DataSet.Books);
            this.debtsTableAdapter1.Update(library451DataSet.Debts);
            Close();
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
