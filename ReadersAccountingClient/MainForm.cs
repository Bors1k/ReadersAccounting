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
        enum TypeOfLoadDB
        {
            //для душевного спокойствия
            all,
            book,
            readers,
            debts,
            aut
        }
        public bool IsSettingUserClose = true;
        public MainForm()
        {
            InitializeComponent();
            //стартовый ресайз, чтобы было удобно работать с конструктором и 
            ResizeForm(this, 320, 240,false);


        }

        private void подключениеКБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //открываем форму настроек
            DBSettingsForm settings = new DBSettingsForm();
            settings.Owner = this;
            settings.Show();
            settings.FormClosing += Settings_FormClosing;

        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            //обновляем подключение к бд после настройки 
            if(IsSettingUserClose == true)
            {
                this.UpdateConnectionString();
                this.LoadFromDB(TypeOfLoadDB.all);
            }
            IsSettingUserClose = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Wireless == true)
            {
                Properties.Settings.Default.ConnectionString = @"Data Source=" + Properties.Settings.Default.IP + ", " + Properties.Settings.Default.Port + ";Initial Catalog=Library451; User Id = sa; Password = 1234";
            }
            else
            {
                Properties.Settings.Default.ConnectionString = @"Data Source=" + Properties.Settings.Default.IP + ";Initial Catalog=Library451;Integrated Security=True";
            }
            //this.LoadFromDB(TypeOfLoadDB.all);
        }

        private void LoadFromDB(TypeOfLoadDB type)
        {
            //загрузка данных
            try
            {
                if (type == TypeOfLoadDB.all)
                {
                    this.reades_debtsTableAdapter.Fill(this.library451DataSet.reades_debts);
                    this.readersTableAdapter.Fill(this.library451DataSet.Readers);
                    this.booksTableAdapter.Fill(this.library451DataSet.Books);
                    this.autTableAdapter.Fill(this.library451DataSet.aut);
                    this.debtsTableAdapter1.Fill(this.library451DataSet.Debts);
                }
                if (type == TypeOfLoadDB.book)
                {
                    this.booksTableAdapter.Fill(this.library451DataSet.Books);
                }
                if (type == TypeOfLoadDB.debts)
                {
                    this.reades_debtsTableAdapter.Fill(this.library451DataSet.reades_debts);
                    this.debtsTableAdapter1.Fill(this.library451DataSet.Debts);
                }
                if (type == TypeOfLoadDB.readers)
                {
                    this.readersTableAdapter.Fill(this.library451DataSet.Readers);
                }
                if (type == TypeOfLoadDB.aut)
                {
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
                this.readersTableAdapter.Connection.ConnectionString = Properties.Settings.Default.ConnectionString;
                this.reades_debtsTableAdapter.Connection.ConnectionString = Properties.Settings.Default.ConnectionString;
                this.debtsTableAdapter1.Connection.ConnectionString = Properties.Settings.Default.ConnectionString;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void butt_authorized_Click(object sender, EventArgs e)
        {
            try
            {
                this.LoadFromDB(TypeOfLoadDB.all);
                //авторизация
                bool aut_flag = false;
                foreach (DataRow row in this.library451DataSet.aut.Rows)
                {
                    if (aut_flag == true) break;
                    if (row["login"].ToString() == tb_login.Text)
                    {
                        if (row["password"].ToString() == tb_password.Text)
                        {
                            aut_flag = true;
                            tabControl1.Visible = true;
                            //делаем ресайз для дальнейшей работы

                            if(row["is_admin"].ToString() == "True")
                            {
                                if(tabControl1.TabPages.Count != 3)
                                {
                                    tabControl1.TabPages.Add(tpAccounts);
                                }
                                ResizeForm(this, 1280, 720, true);
                            }
                            else
                            {
                                tabControl1.TabPages.Remove(tpAccounts);
                                ResizeForm(this, 1280, 720, true);
                            }
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

        private void ResizeForm(Form form,int width, int height, bool stateOfUnlogin)
        {
            //ресайз формы для авторизации
            form.MaximumSize = new Size(width, height);
            form.MinimumSize = new Size(width, height);
            form.Size = new Size(width, height);
            form.Location = new Point(Screen.PrimaryScreen.Bounds.Size.Width/2 - width/2, Screen.PrimaryScreen.Bounds.Size.Height/2-height/2);
            this.разлогинитьсяToolStripMenuItem.Enabled = stateOfUnlogin;
        }

        private void but_books_search_Click(object sender, EventArgs e)
        {
            //сброс поиска книг
            tb_book_search.Clear();
        }

        private void разлогинитьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl1.Visible = false;
            ResizeForm(this, 320, 240,false);
        }

        private void rEADERSDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Фильтрация задолженностей для читателя
            filterDebts();
        }

        private void but_readers_search_reset_Click(object sender, EventArgs e)
        {
            //сброс поиска читателей
            tb_readers_search.Clear();
        }

        private void tb_book_search_TextChanged(object sender, EventArgs e)
        {
            //поиск книги
            if (checkBox1.Checked)
            {
                booksBindingSource.Filter = string.Format("[Book_Name] LIKE '%{0}%' AND [Availability] = true", tb_book_search.Text);
            }
            else booksBindingSource.Filter = string.Format("[Book_Name] LIKE '%{0}%'", tb_book_search.Text);
        }

        private void tb_readers_search_TextChanged(object sender, EventArgs e)
        {
            //поиск читателя
            readersBindingSource.Filter = string.Format("[FIO] LIKE '%{0}%'", tb_readers_search.Text);
            //фильтрация задолженностей
            try
            {
                this.reades_debtsBindingSource.Filter = string.Format("[Reader_ID] = {0}", Convert.ToInt32(reader_IDTextBox.Text));
            }
            catch(Exception ex)
            {

            }
            finally
            {
                this.reades_debtsBindingSource.Filter = string.Format("[Reader_ID] = {0}", -1);
            }
        }

        private void but_change_book_Click(object sender, EventArgs e)
        {
            //включаем видимость формы на изменение
            this.groupBox3.Visible = true;
        }

        private void but_book_chages_back_Click(object sender, EventArgs e)
        {
            //отменяем изменения в книге
            bookChangeState(false);
            this.booksBindingSource.CancelEdit();
        }

        private void but_save_book_changes_Click(object sender, EventArgs e)
        {
            //сохраняем изменения по книге
            try
            {
                this.booksBindingSource.EndEdit();
                this.booksTableAdapter.Update(this.library451DataSet.Books);
                this.library451DataSet.AcceptChanges();
                LoadFromDB(TypeOfLoadDB.all);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            bookChangeState(false);
        }

        private void but_vis_add_book_Click(object sender, EventArgs e)
        {
            //открываем форму на добавление
            AddBookForm addbook = new AddBookForm();
            addbook.Show();
            //событие, которое сработает при закрытии формы
            addbook.FormClosing += Addbook_FormClosing;
        }

        private void Addbook_FormClosing(object sender, FormClosingEventArgs e)
        {
            //обновляем данные, при закрытии формы
            LoadFromDB(TypeOfLoadDB.all);
        }

        private void bookChangeState(bool state)
        {
            book_NameTextBox.ReadOnly = !state;
            availabilityCheckBox.Enabled = state;
            but_save_book_changes.Enabled = state;
            but_book_chages_back.Enabled = state;
            //checkBox4.Checked = !state;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //даем доступ на редактирование
            bookChangeState(true);
        }

        private void but_delete_book_Click(object sender, EventArgs e)
        {
            //удаление книги из БД
            DialogResult dr = MessageBox.Show("Точно хотите удалить?", "Удаление", MessageBoxButtons.YesNo,
            MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    this.booksBindingSource.EndEdit();
                    this.library451DataSet.AcceptChanges();
                    this.booksTableAdapter.Delete(Int32.Parse(book_IDTextBox.Text), availabilityCheckBox.Checked);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                LoadFromDB(TypeOfLoadDB.all);
            }
        }

        private void change_readonly_reader(bool state)
        {
            //изменение состояния инпутов читателя, чтобы уменьшить объем кода
            fIOTextBox.ReadOnly = state;
            tELEPHONETextBox.ReadOnly = state;
            aDDRESSTextBox.ReadOnly = state;
            pASSPORTTextBox.ReadOnly = state;
            but_save_changes_reader.Enabled = !state;
            but_back_changes_reader.Enabled = !state;
        }

        private void but_change_reader_Click(object sender, EventArgs e)
        {
            //открываем возможность изменить
            change_readonly_reader(false);
        }

        private void but_back_changes_reader_Click(object sender, EventArgs e)
        {
            //отменяем изменения
            this.readersBindingSource.CancelEdit();
            //закрываем возможность изменить
            change_readonly_reader(true);
        }

        private void but_save_changes_reader_Click(object sender, EventArgs e)
        {
            //сохраняем изменения
            try
            {
                this.readersBindingSource.EndEdit();
                this.readersTableAdapter.Update(this.library451DataSet.Readers);
                this.library451DataSet.AcceptChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LoadFromDB(TypeOfLoadDB.all);
            //закрываем возможность изменить
            change_readonly_reader(true);
        }

        private void but_add_new_reader_Click(object sender, EventArgs e)
        {
            //Открываем форму добавления нового читателя
            ReaderAddForm readeradd = new ReaderAddForm();
            readeradd.Show();
            readeradd.FormClosing += Readeradd_FormClosing;
        }

        private void Readeradd_FormClosing(object sender, FormClosingEventArgs e)
        {
            //обновляем данные по читателям из бд, после закрытия формы 
            LoadFromDB(TypeOfLoadDB.readers);
        }

        private void but_delete_reader_Click(object sender, EventArgs e)
        {
            //удаление книги из БД
            DialogResult dr = MessageBox.Show("Точно хотите удалить?", "Удаление", MessageBoxButtons.YesNo,
            MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    this.readersBindingSource.EndEdit();
                    this.readersTableAdapter.Delete(Int32.Parse(reader_IDTextBox.Text));
                    this.library451DataSet.AcceptChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                LoadFromDB(TypeOfLoadDB.readers);
            }
        }

        private void обновитьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //пункт меню на обновление данных из бд
            LoadFromDB(TypeOfLoadDB.all);
        }

        private void butAddDebt_Click(object sender, EventArgs e)
        {
            //открываем форму добавления новой записи о задолженности
;           AddDebtForm addReaderDebt = new AddDebtForm(Int32.Parse(reader_IDTextBox.Text));
            addReaderDebt.Show();
            addReaderDebt.FormClosing += AddReaderDebt_FormClosing;
        }

        private void AddReaderDebt_FormClosing(object sender, FormClosingEventArgs e)
        {
            //после закрытия формы закрытия записи о задолженности обновляем данные из бд
            LoadFromDB(TypeOfLoadDB.debts);
            LoadFromDB(TypeOfLoadDB.readers);
            LoadFromDB(TypeOfLoadDB.book);
        }

        private void butDeleteDebt_Click(object sender, EventArgs e)
        {
            //удаление задолженности из БД
            if (this.library451DataSet.Debts.FindByDebts_ID(Int32.Parse(iDTextBox.Text)).Closed == true)
            {
                DialogResult dr = MessageBox.Show("Точно хотите удалить?", "Удаление", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        this.debtsTableAdapter1.Delete(Int32.Parse(iDTextBox.Text), Int32.Parse(reades_debtsDataGridView.CurrentRow.Cells["dataGridViewTextBoxColumn7"].Value.ToString()),
                            Int32.Parse(reades_debtsDataGridView.CurrentRow.Cells["Book_ID"].Value.ToString()),
                            дата_выдачиDateTimePicker.Value, дата_возвратаDateTimePicker.Value, возвращеноCheckBox.Checked);
                        this.library451DataSet.AcceptChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    LoadFromDB(TypeOfLoadDB.all);
                }
            }
            else
            {
                MessageBox.Show("Сначала закройте задолженность");
            }
        }

        private void debtsStateChanger(bool state)
        {
            //изменение состояния работы элементов управления задолженностями
            дата_выдачиDateTimePicker.Enabled = state;
            дата_возвратаDateTimePicker.Enabled = state;
            butSaveDebts.Enabled = state;
            butBackChangesDebts.Enabled = state;
        }

        private void butChangeDebt_Click(object sender, EventArgs e)
        {
            //включаем возможность внести изменения в задолженности
            debtsStateChanger(true);
        }

        private void butSaveDebts_Click(object sender, EventArgs e)
        {
            Functions func = new Functions();
            //сохранение изменений в задолженностях
            try
            {
                if (func.CheckDates(this.дата_выдачиDateTimePicker.Value, this.дата_возвратаDateTimePicker.Value) != null)
                {
                    throw func.CheckDates(this.дата_выдачиDateTimePicker.Value, this.дата_возвратаDateTimePicker.Value);
                }
                else
                {
                    this.reades_debtsBindingSource.EndEdit();
                    this.library451DataSet.Debts.FindByDebts_ID(Int32.Parse(iDTextBox.Text)).Issue_Date = this.дата_выдачиDateTimePicker.Value;
                    this.library451DataSet.Debts.FindByDebts_ID(Int32.Parse(iDTextBox.Text)).Return_Date = this.дата_возвратаDateTimePicker.Value;
                    this.debtsTableAdapter1.Update(this.library451DataSet.Debts);
                    this.library451DataSet.AcceptChanges();
                    LoadFromDB(TypeOfLoadDB.debts);
                    debtsStateChanger(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }        
        }

        private void butBackChangesDebts_Click(object sender, EventArgs e)
        {
            //отмена изменений в задолженностях
            reades_debtsBindingSource.CancelEdit();
            debtsStateChanger(false);
        }

        private void butCloseDebt_Click(object sender, EventArgs e)
        {
            //закрываем задолженность и освобождаем книгу
            try
            {
                this.reades_debtsBindingSource.EndEdit();
                возвращеноCheckBox.Checked = true;
                this.library451DataSet.Debts.FindByDebts_ID(Int32.Parse(iDTextBox.Text)).Closed = true;
                int book_id = this.library451DataSet.Debts.FindByDebts_ID(Int32.Parse(iDTextBox.Text)).Book_ID;
                this.library451DataSet.Books.FindByBook_ID(book_id).Availability = true;
                this.booksTableAdapter.Update(this.library451DataSet.Books);
                this.debtsTableAdapter1.Update(this.library451DataSet.Debts);
                this.library451DataSet.AcceptChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LoadFromDB(TypeOfLoadDB.all);
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                booksBindingSource.Filter = string.Format("[Book_Name] LIKE '%{0}%' AND [Availability] = true", tb_book_search.Text);
            }
            else booksBindingSource.Filter = string.Format("[Book_Name] LIKE '%{0}%'", tb_book_search.Text);
        }

        private void tbDebtsSearch_TextChanged(object sender, EventArgs e)
        {
            filterDebts();
        }

        private void butSearchDebts_Click(object sender, EventArgs e)
        {
            tbDebtsSearch.Clear();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            filterDebts();        
        }

        private void filterDebts()
        {
            if (checkBox2.Checked)
            {
                reades_debtsBindingSource.Filter = string.Format("[Книга] LIKE '%{0}%' AND [Возвращено] = false AND [Reader_ID] = {1}", tbDebtsSearch.Text, Convert.ToInt32(reader_IDTextBox.Text));
            }
            else reades_debtsBindingSource.Filter = string.Format("[Книга] LIKE '%{0}%' AND [Возвращено] = true AND [Reader_ID] = {1}", tbDebtsSearch.Text, Convert.ToInt32(reader_IDTextBox.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //включаем видимость формы добавления нового аккаунта
            gbNewAcc.Visible = true;
        }

        private void butAddAccount_Click(object sender, EventArgs e)
        {
            try
            {
                this.library451DataSet.aut.AddautRow(this.tbLogin.Text, this.tbPassword.Text, this.chkbIsAdmin.Checked, tbNewAccFIO.Text);
                this.autTableAdapter.Update(this.library451DataSet.aut);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            gbNewAcc.Visible = false;
        }

        private void butCancelAdd_Click(object sender, EventArgs e)
        {
            gbNewAcc.Visible = false;
        }

        private void butResetAccSearch_Click(object sender, EventArgs e)
        {
            //очищаем строку поиска аккаунта по логину
            tbAccSearch.Clear();
        }

        private void butChangeAccounts_Click(object sender, EventArgs e)
        {
            //включаем возможность редактирования аккаунтов
            groupBox4.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //сохраняем изменения у пользователя
            try
            {
                this.autBindingSource.EndEdit();
                this.autTableAdapter.Update(this.library451DataSet.aut);
                this.library451DataSet.AcceptChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LoadFromDB(TypeOfLoadDB.aut);
            checkBox4.Checked = false;
            groupBox4.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //отменяем изменения у пользователя
            this.autBindingSource.CancelEdit();
            checkBox4.Checked = false;
            groupBox4.Enabled = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            //включаем видимость пароля при редактировании пользователя
            if (checkBox4.Checked)
            {
                passwordTextBox.UseSystemPasswordChar = false;
            }
            else passwordTextBox.UseSystemPasswordChar = true;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            //включаем видимость пароля при создании нового пользователя
            if (checkBox5.Checked)
            {
                tbPassword.UseSystemPasswordChar = false;
            }
            else tbPassword.UseSystemPasswordChar = true;
        }

        private void tbAccSearch_TextChanged(object sender, EventArgs e)
        {
            //поиск пользователя
            autBindingSource.Filter = string.Format("[login] LIKE '%{0}%' OR [FIO] LIKE '%{0}%'", tbAccSearch.Text);
        }

        private void butDeletAcc_Click(object sender, EventArgs e)
        {
            //удаляем аккаунт для авторизации
            DialogResult dr = MessageBox.Show("Точно хотите удалить?", "Удаление", MessageBoxButtons.YesNo,
            MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    this.autBindingSource.EndEdit();
                    this.autTableAdapter.Delete(Int32.Parse(iDAccTextBox.Text), loginTextBox1.Text, passwordTextBox.Text, is_adminCheckBox.Checked);
                    this.library451DataSet.AcceptChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                LoadFromDB(TypeOfLoadDB.aut);
            }
        }

        private void chkbxVisiblePassLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxVisiblePassLogin.Checked)
            {
                tb_password.UseSystemPasswordChar = false;
            }
            else tb_password.UseSystemPasswordChar = true;
        }
    }
}
