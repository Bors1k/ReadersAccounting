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
    public partial class ReaderAddForm : Form
    {
        public ReaderAddForm()
        {
            InitializeComponent();
        }

        private void butAddNewReader_Click(object sender, EventArgs e)
        {
            //this.readersTableAdapter.Fill(this.library451DataSet.Readers);
            this.library451DataSet.Readers.AddReadersRow(fIOTextBox.Text, pASSPORTTextBox.Text, aDDRESSTextBox.Text, tELEPHONETextBox.Text);
            this.readersTableAdapter.Update(this.library451DataSet.Readers);
            Close();
        }

        private void butCancelAdd_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
