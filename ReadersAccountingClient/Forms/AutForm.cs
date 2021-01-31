using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class AutForm : Form
    {
        public AutForm()
        {
            InitializeComponent();
            this.autTableAdapter.Fill(this.library451DataSet.aut);
        }

        private string UserFIO;
        private bool adminState;
        public bool IsSettingUserClose = true;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //авторизация
                bool aut_flag = false;
                foreach (DataRow row in this.library451DataSet.aut.Rows)
                {
                    if (aut_flag == true) break;
                    if (row["login"].ToString() == tb_login.Text)
                    {
                        this.UserFIO = row["FIO"].ToString();
                        if (row["password"].ToString() == tb_password.Text)
                        {
                            aut_flag = true;
                            adminState = (bool)row["is_admin"];
                            MainForm mainForm = new MainForm(this, UserFIO, adminState);
                            mainForm.Show();
                            this.Hide();
                        }
                    }
                }
                if (aut_flag == false)
                {
                    MessageBox.Show("Логин/Пароль введены неверно");
                }
                chkbxVisiblePassLogin.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void PasswordVisible(CheckBox checkBox, TextBox textBox)
        {
            if (checkBox.Checked)
            {
                textBox.UseSystemPasswordChar = false;
            }
            else textBox.UseSystemPasswordChar = true;
        }

        private void chkbxVisiblePassLogin_CheckedChanged(object sender, EventArgs e)
        {
            PasswordVisible(chkbxVisiblePassLogin, tb_password);
        }

        private void подключениеКБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBSettingsForm settings = new DBSettingsForm();
            settings.Owner = this;
            settings.Show();
            settings.FormClosing += Settings_FormClosing;
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsSettingUserClose == true)
            {
                this.autTableAdapter.Connection.ConnectionString = Properties.Settings.Default.ConnectionString;
                this.autTableAdapter.Fill(this.library451DataSet.aut);
            }
            IsSettingUserClose = true;
        }

        private void обновитьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.autTableAdapter.Fill(this.library451DataSet.aut);
        }
    }
}
