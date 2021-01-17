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
                dimActionTypeTableAdapter.Fill(this.library451DWHDataSet.DimActionType);
                dimBookTableAdapter.Fill(this.library451DWHDataSet.DimBook);
                dimDateTableAdapter.Fill(this.library451DWHDataSet.DimDate);
                dimReaderTableAdapter.Fill(this.library451DWHDataSet.DimReader);

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
                    if (library451DWHDataSet.DimDate.Count == 0)
                    {
                        int week = (int)DateTime.Today.DayOfWeek / 7 + 1;
                        library451DWHDataSet.DimDate.AddDimDateRow(DateTime.Today, week, DateTime.Today.Month, DateTime.Today.Year);
                        dimDateTableAdapter.Update(library451DWHDataSet.DimDate);
                        this.library451DWHDataSet.FactDebts.AddFactDebtsRow(library451DWHDataSet.DimReader.FindByReader_ID(readerID), library451DWHDataSet.DimBook.FindBybook_id(Int32.Parse(book_IDTextBox.Text)), library451DWHDataSet.DimDate.Last(), library451DWHDataSet.DimActionType.FindByID(1));
                    }
                    else
                    {
                        if (library451DWHDataSet.DimDate.Last().action_date != DateTime.Today)
                        {
                            int week = (int)DateTime.Today.DayOfWeek / 7 + 1;
                            library451DWHDataSet.DimDate.AddDimDateRow(DateTime.Today, week, DateTime.Today.Month, DateTime.Today.Year);
                            dimDateTableAdapter.Update(library451DWHDataSet.DimDate);
                            this.library451DWHDataSet.FactDebts.AddFactDebtsRow(library451DWHDataSet.DimReader.FindByReader_ID(readerID), library451DWHDataSet.DimBook.FindBybook_id(Int32.Parse(book_IDTextBox.Text)), library451DWHDataSet.DimDate.Last(), library451DWHDataSet.DimActionType.FindByID(1));
                        }
                        else this.library451DWHDataSet.FactDebts.AddFactDebtsRow(library451DWHDataSet.DimReader.FindByReader_ID(readerID), library451DWHDataSet.DimBook.FindBybook_id(Int32.Parse(book_IDTextBox.Text)), library451DWHDataSet.DimDate.Last(), library451DWHDataSet.DimActionType.FindByID(1));
                    }
                    this.factDebtsTableAdapter.Update(this.library451DWHDataSet.FactDebts);

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

        private void tbSearchBook_TextChanged(object sender, EventArgs e)
        {
            booksBindingSource.Filter = string.Format("[Book_Name] LIKE '%{0}%' AND [Availability] = true", tbSearchBook.Text);
        }

        private void butResetSearch_Click(object sender, EventArgs e)
        {
            tbSearchBook.Clear();
        }
    }
}
