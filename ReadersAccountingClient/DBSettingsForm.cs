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
    public partial class DBSettingsForm : Form
    {
        public DBSettingsForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.Upgrade();
            tb_ip.Text = Properties.Settings.Default.IP;
            tb_port.Text = Properties.Settings.Default.Port;
            chbox_wireless.Checked = Properties.Settings.Default.Wireless;
            tblogin.Text = Properties.Settings.Default.login;
            tbpassword.Text = Properties.Settings.Default.password;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //записываем настройки в Свойства.Настройки
            Properties.Settings.Default.IP = tb_ip.Text;
            Properties.Settings.Default.Port = tb_port.Text;
            Properties.Settings.Default.Wireless = chbox_wireless.Checked;
            Properties.Settings.Default.login = tblogin.Text;
            Properties.Settings.Default.password = tbpassword.Text;
            //сохраняем настройки
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Upgrade();
            
            //на основе настроек прописываем строку подключения к бд
            if (chbox_wireless.Checked == true)
            {
                Properties.Settings.Default.ConnectionString = @"Data Source=" + Properties.Settings.Default.IP + ", " + Properties.Settings.Default.Port + ";Initial Catalog=Library451; User Id ="+ Properties.Settings.Default.login + "; Password ="+Properties.Settings.Default.password;
            }
            else
            {
                Properties.Settings.Default.ConnectionString = @"Data Source=" + Properties.Settings.Default.IP + ";Initial Catalog=Library451;Integrated Security=True";
            }

            Properties.Settings.Default.Save();
            Properties.Settings.Default.Upgrade();

            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //закрытие формы настроек
            //но когда закрываешь настройки, срабатывает обработчик в главной форме и он пытается подключиться к БД, что при неправильных настройках, 
            //заставляет долго ждать.
            //пришлось передавать в главную форму значение, чтобы отделять сохранение+закрытие и закрытие без применения настроек
            MainForm owner = this.Owner as MainForm; 
            owner.IsSettingUserClose = false;
            this.Close();
        }

        private void chbox_wireless_CheckedChanged(object sender, EventArgs e)
        {
            if (chbox_wireless.Checked)
            {
                gb.Enabled = true;
            }
            else gb.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                tbpassword.UseSystemPasswordChar = false;
            }
            else tbpassword.UseSystemPasswordChar = true;
        }
    }
}
