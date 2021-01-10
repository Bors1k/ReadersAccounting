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
            //обновляем подключение к бд после настройки 
            this.UpdateConnectionString();
            this.LoadFromDB("all");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.reades_debtsTableAdapter.Fill(this.library451DataSet.reades_debts);
            this.readersTableAdapter.Fill(this.library451DataSet.Readers);
            this.booksTableAdapter.Fill(this.library451DataSet.Books);
            this.LoadFromDB("all");
        }

        private void LoadFromDB(String settings)
        {
            //загрузка данных
            try
            {
                if (settings == "all")
                {
                    this.booksTableAdapter.Fill(this.library451DataSet.Books);
                    this.autTableAdapter.Fill(this.library451DataSet.aut);
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
                this.booksTableAdapter.Connection.ConnectionString = Properties.Settings.Default.ConnectionString;
                this.autTableAdapter.Connection.ConnectionString = Properties.Settings.Default.ConnectionString;
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
            foreach (DataRow row in this.library451DataSet.aut.Rows)
            {
                DataRow newrow = row;
                if (row["login"].ToString().Contains(tb_login.Text))
                {
                    if (row["password"].ToString().Contains(tb_password.Text))
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

        private void but_books_search_Click(object sender, EventArgs e)
        {
            //сброс поиска книг
            tb_book_search.Text = "";
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


        //int row_id = this.rEADERSDataGridView.SelectedRows[0].Cells[0].RowIndex;
        //Readers_profile profile_form = new Readers_profile(row_id);
        //profile_form.Show();

        private void rEADERSDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!groupBox1.Visible) groupBox1.Visible = true;
            //Фильтрация задолженностей для читателя
            int reader_id = Convert.ToInt32(reader_IDTextBox.Text.Trim());
            this.reades_debtsBindingSource.Filter = string.Format("[Reader_ID] = {0}", reader_id);
        }

        private void but_readers_search_reset_Click(object sender, EventArgs e)
        {
            //сброс поиска читателей
            tb_readers_search.Text = "";
        }

        private void tb_book_search_TextChanged(object sender, EventArgs e)
        {
           //поиск книги
           booksBindingSource.Filter = string.Format("[Book_Name] LIKE '%{0}%'", tb_book_search.Text);
        }

        private void tb_readers_search_TextChanged(object sender, EventArgs e)
        {
            //поиск читателя
            readersBindingSource.Filter = string.Format("[FIO] LIKE '%{0}%'", tb_readers_search.Text);
            //фильтрация задолженностей
            try
            {
                int reader_id = Convert.ToInt32(reader_IDTextBox.Text.Trim());
                this.reades_debtsBindingSource.Filter = string.Format("[Reader_ID] = {0}", reader_id);
            }
            catch(Exception ex)
            {
            }
            finally
            {
                this.reades_debtsBindingSource.Filter = string.Format("[Reader_ID] = {0}", -1);
            }
        }
    }
}
