using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
         
        }

        private void подключениеКБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //открываем форму настроек
            DB_Settings_Form settings = new DB_Settings_Form();
            settings.Show();
            settings.FormClosing += Settings_FormClosing;
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.UpdateConnectionString();
            this.LoadFromDB("all");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.LoadFromDB("all");
        }

        private void LoadFromDB(String settings)
        {
            //загрузка данных
            try
            {
                if (settings == "all")
                {
                    this.bOOKSTableAdapter.Fill(this.libraryDataSet.BOOKS);
                    this.auT_ACCOUNTSTableAdapter1.Fill(this.libraryDataSet.AUT_ACCOUNTS);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void UpdateConnectionString()
        {
            //обновление строк подключения
            try
            {
                this.bOOKSTableAdapter.Connection.ConnectionString = Properties.Settings.Default.ConnectionString;
                this.auT_ACCOUNTSTableAdapter1.Connection.ConnectionString = Properties.Settings.Default.ConnectionString;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void butt_authorized_Click(object sender, EventArgs e)
        {
            //авторизация
            bool aut_flag = false;
            foreach (DataRow row in this.libraryDataSet.AUT_ACCOUNTS.Rows)
            {
                DataRow newrow = row;
                if (row["LOGIN"].ToString().Contains(tb_login.Text))
                {
                    if (row["PASSWORD"].ToString().Contains(tb_password.Text))
                    {
                        aut_flag = true;
                        tabControl1.Visible = true;
                    }
                }
            }
            if(aut_flag == false)
            {
                MessageBox.Show("Логин/Пароль введены неверно");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //поиск по имени
            this.libraryDataSet.BOOKS.DefaultView.RowFilter = string.Format("[BOOK_NAME] LIKE '%{0}%'", tb_book_search.Text);
            dataGridView1.DataSource = this.libraryDataSet.BOOKS;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //просто для теста на данный момент
            MessageBox.Show("hello");
        }

        private void разлогинитьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl1.Visible = false;
        }
    }
}
