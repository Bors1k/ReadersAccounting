using iTextSharp.text.pdf;
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
                dimBookTableAdapter.Fill(this.library451DWHDataSet.DimBook);
                dimDateTableAdapter.Fill(this.library451DWHDataSet.DimDate);
                dimReaderTableAdapter.Fill(this.library451DWHDataSet.DimReader);

                this.booksTableAdapter.Fill(this.library451DataSet.Books);
                this.readersTableAdapter.Fill(this.library451DataSet.Readers);
                this.debtsTableAdapter.Fill(this.library451DataSet.Debts);
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
            DateTime today = DateTime.Today;
            try
            {
                if(func.CheckDates(today, dateTimePicker1.Value) == null)
                {
                    if (library451DWHDataSet.DimDate.Count == 0)
                    {
                        int week = (int)today.DayOfWeek / 7 + 1;
                        library451DWHDataSet.DimDate.AddDimDateRow(today, week, today.Month, today.Year);
                        dimDateTableAdapter.Update(library451DWHDataSet.DimDate);
                        this.library451DWHDataSet.FactsBookHistory.AddFactsBookHistoryRow(library451DWHDataSet.DimReader.FindByReader_ID(readerID), library451DWHDataSet.DimBook.FindBybook_id(Int32.Parse(book_IDTextBox.Text)), library451DWHDataSet.DimDate.Last());
                    }
                    else
                    {
                        if (library451DWHDataSet.DimDate.Last().Date != today)
                        {
                            int week = (int)today.DayOfWeek / 7 + 1;
                            library451DWHDataSet.DimDate.AddDimDateRow(today, week, today.Month, today.Year);
                            dimDateTableAdapter.Update(library451DWHDataSet.DimDate);
                            this.library451DWHDataSet.FactsBookHistory.AddFactsBookHistoryRow(library451DWHDataSet.DimReader.FindByReader_ID(readerID), library451DWHDataSet.DimBook.FindBybook_id(Int32.Parse(book_IDTextBox.Text)), library451DWHDataSet.DimDate.Last());
                        }
                        else this.library451DWHDataSet.FactsBookHistory.AddFactsBookHistoryRow(library451DWHDataSet.DimReader.FindByReader_ID(readerID), library451DWHDataSet.DimBook.FindBybook_id(Int32.Parse(book_IDTextBox.Text)), library451DWHDataSet.DimDate.Last());
                    }
                    this.factsBookHistoryTableAdapter.Update(this.library451DWHDataSet.FactsBookHistory);

                    this.library451DataSet.Debts.AddDebtsRow(this.library451DataSet.Readers.FindByReader_ID(readerID), this.library451DataSet.Books.FindByBook_ID(Int32.Parse(book_IDTextBox.Text)), today, dateTimePicker1.Value, false);
                    this.availabilityCheckBox.Checked = false;
                    this.booksBindingSource.EndEdit();
                    this.booksTableAdapter.Update(library451DataSet.Books);
                    this.debtsTableAdapter.Update(library451DataSet.Debts);
                    Close();
                }
                else
                {
                    throw func.CheckDates(today, dateTimePicker1.Value);
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
