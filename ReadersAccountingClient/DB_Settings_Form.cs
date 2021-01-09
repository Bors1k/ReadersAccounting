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
    public partial class DB_Settings_Form : Form
    {
        public DB_Settings_Form()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.Upgrade();
            tb_ip.Text = Properties.Settings.Default.IP;
            tb_port.Text = Properties.Settings.Default.Port;
            chbox_wireless.Checked = Properties.Settings.Default.Wireless;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //записываем настройки в Свойства.Настройки
            Properties.Settings.Default.IP = tb_ip.Text;
            Properties.Settings.Default.Port = tb_port.Text;
            Properties.Settings.Default.Wireless = chbox_wireless.Checked;
            //сохраняем настройки
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Upgrade();
            
            //на основе настроек прописываем строку подключения к бд
            if (Properties.Settings.Default.Wireless == true)
            {
                Properties.Settings.Default.ConnectionString = @"Data Source=" + Properties.Settings.Default.IP + ", " + Properties.Settings.Default.Port + ";Initial Catalog=Library;Integrated Security=True";
            }
            else
            {
                Properties.Settings.Default.ConnectionString = @"Data Source=" + Properties.Settings.Default.IP + ";Initial Catalog=Library;Integrated Security=True";
            }

            Properties.Settings.Default.Save();
            Properties.Settings.Default.Upgrade();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
