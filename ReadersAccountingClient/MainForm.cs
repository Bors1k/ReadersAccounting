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
        //DataSet ds;
        //string connectionString;
        public MainForm()
        {
            InitializeComponent();
            /*
            //узнаем где находится бд и выбираем строчку подключения
            if (Properties.Settings.Default.Wireless == true)
            {
                connectionString = @"Data Source=" + Properties.Settings.Default.IP + ", " + Properties.Settings.Default.Port + ";Initial Catalog=Library;Integrated Security=True";
            }
            else
            {
                connectionString = @"Data Source=" + Properties.Settings.Default.IP + ";Initial Catalog=Library;Integrated Security=True";
            }

            //запрос на таблицы
            string sql = "SELECT * FROM BOOKS; SELECT * FROM AUT_ACCOUNTS";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    // Создаем объект DataAdapter
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    // Создаем объект Dataset
                    ds = new DataSet();
                    // Заполняем Dataset
                    adapter.Fill(ds);
                    // Отображаем данные
                    dataGridView1.DataSource = ds.Tables[0];
                    //connection.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            */
        }

        private void подключениеКБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //открываем форму настроек
            DB_Settings_Form settings = new DB_Settings_Form();
            settings.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet.BOOKS". При необходимости она может быть перемещена или удалена.
            try
            {
                this.bOOKSTableAdapter.Fill(this.libraryDataSet.BOOKS);
                this.auT_ACCOUNTSTableAdapter1.Fill(this.libraryDataSet.AUT_ACCOUNTS);
            }
            catch(Exception ex)
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
    }
}
