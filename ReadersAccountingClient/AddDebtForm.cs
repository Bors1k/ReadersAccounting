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
    public partial class AddDebtForm : Form
    {
        private int readerID;
        public AddDebtForm(int readerID)
        {
            this.readerID = readerID;
            InitializeComponent();
        }
        private void AddReaderDebt_Load(object sender, EventArgs e)
        {
            this.dateTimePicker1.Value = DateTime.Today + TimeSpan.FromDays(7);
            try
            {
                this.booksTableAdapter.Fill(this.library451DataSet.Books);
                this.readersTableAdapter1.Fill(this.library451DataSet.Readers);
                this.debtsTableAdapter1.Fill(this.library451DataSet.Debts);
                this.booksBindingSource.Filter = "[Availability] = true";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butAddNewDebt_Click(object sender, EventArgs e)
        {
            Functions func = new Functions();
            try
            {
                if(func.CheckDates(DateTime.Today, dateTimePicker1.Value) == null)
                {
                    this.library451DataSet.Debts.AddDebtsRow(this.library451DataSet.Readers.FindByReader_ID(readerID), this.library451DataSet.Books.FindByBook_ID(Int32.Parse(book_IDTextBox.Text)), DateTime.Today, dateTimePicker1.Value, false);
                    this.availabilityCheckBox.Checked = false;
                    this.booksBindingSource.EndEdit();
                    this.booksTableAdapter.Update(library451DataSet.Books);
                    this.debtsTableAdapter1.Update(library451DataSet.Debts);
                    Close();
                }
                else
                {
                    throw func.CheckDates(DateTime.Today, dateTimePicker1.Value);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
