﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Font = iTextSharp.text.Font;
using WindowsFormsApp1.Forms;

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
            aut,
            reports
        }
        private Functions func;
        public bool IsSettingUserClose = true;
        private string UserFIO;
        private bool adminState;
        private AutForm autForm;
        public MainForm(AutForm autForm, string userfio, bool admin_state)
        {
            this.autForm = autForm;
            UserFIO = userfio;
            adminState = admin_state;
            func = new Functions();
            InitializeComponent();
            LoadFromDB(TypeOfLoadDB.all);
            UpdateConnectionString();

            if (adminState == true)
            {
                if (tabControl1.TabPages.Count != 4)
                {
                    tabControl1.TabPages.Add(tpAccounts);
                }
            }
            else
            {
                tabControl1.TabPages.Remove(tpAccounts);
            }
            //dtPickerFrom.Value = dtPickerTo.Value - TimeSpan.FromDays(30);
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
                    this.debtsTableAdapter.Fill(this.library451DataSet.Debts);
                    this.booksHistoryTableAdapter.Fill(this.library451DWHDataSet.BooksHistory);
                    this.readersHistoryTableAdapter.Fill(this.library451DWHDataSet.ReadersHistory);
                }
                if (type == TypeOfLoadDB.book)
                {
                    this.booksTableAdapter.Fill(this.library451DataSet.Books);
                }
                if (type == TypeOfLoadDB.debts)
                {
                    this.reades_debtsTableAdapter.Fill(this.library451DataSet.reades_debts);
                    this.debtsTableAdapter.Fill(this.library451DataSet.Debts);
                }
                if (type == TypeOfLoadDB.readers)
                {
                    this.readersTableAdapter.Fill(this.library451DataSet.Readers);
                }
                if (type == TypeOfLoadDB.aut)
                {
                    this.autTableAdapter.Fill(this.library451DataSet.aut);
                }
                if(type == TypeOfLoadDB.reports)
                {
                    this.booksHistoryTableAdapter.Fill(this.library451DWHDataSet.BooksHistory);
                    this.readersHistoryTableAdapter.Fill(this.library451DWHDataSet.ReadersHistory);
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
                this.booksHistoryTableAdapter.Connection.ConnectionString = Properties.Settings.Default.DWH_ConnectionString;
                this.readersHistoryTableAdapter.Connection.ConnectionString = Properties.Settings.Default.DWH_ConnectionString;

                this.booksTableAdapter.Connection.ConnectionString = Properties.Settings.Default.ConnectionString;
                this.autTableAdapter.Connection.ConnectionString = Properties.Settings.Default.ConnectionString;
                this.readersTableAdapter.Connection.ConnectionString = Properties.Settings.Default.ConnectionString;
                this.reades_debtsTableAdapter.Connection.ConnectionString = Properties.Settings.Default.ConnectionString;
                this.debtsTableAdapter.Connection.ConnectionString = Properties.Settings.Default.ConnectionString;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void but_books_search_Click(object sender, EventArgs e)
        {
            //сброс поиска книг
            tb_book_search.Clear();
        }

        private void разлогинитьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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
            LoadFromDB(TypeOfLoadDB.reports);
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
                        this.debtsTableAdapter.Delete(Int32.Parse(iDTextBox.Text), Int32.Parse(reades_debtsDataGridView.CurrentRow.Cells["dataGridViewTextBoxColumn7"].Value.ToString()),
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
                    this.debtsTableAdapter.Update(this.library451DataSet.Debts);
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
                //this.reades_debtsBindingSource.EndEdit();
                возвращеноCheckBox.Checked = true;
                this.library451DataSet.Debts.FindByDebts_ID(Int32.Parse(iDTextBox.Text)).Closed = true;

                int book_id = this.library451DataSet.Debts.FindByDebts_ID(Int32.Parse(iDTextBox.Text)).Book_ID;

                this.library451DataSet.Books.FindByBook_ID(book_id).Availability = true;
                this.booksTableAdapter.Update(this.library451DataSet.Books);
                this.debtsTableAdapter.Update(this.library451DataSet.Debts);
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
            //изменение фильтра в зависимости от того включена фильтрация по доступным или нет
            if (checkBox1.Checked)
            {
                booksBindingSource.Filter = string.Format("[Book_Name] LIKE '%{0}%' AND [Availability] = true", tb_book_search.Text);
            }
            else booksBindingSource.Filter = string.Format("[Book_Name] LIKE '%{0}%'", tb_book_search.Text);
        }

        private void tbDebtsSearch_TextChanged(object sender, EventArgs e)
        {
            //фильтрация в зависимости от того включена фильтрация по открытым долгам или нет
            filterDebts();
        }

        private void butSearchDebts_Click(object sender, EventArgs e)
        {
            tbDebtsSearch.Clear();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //изменение фильтра в зависимости от того включена фильтрация по открытым долгам или нет
            filterDebts();        
        }

        private void filterDebts()
        {
            //функция фильтрации в зависимости от того включена фильтрация по открытым долгам или нет
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
            //добавление нового пользователя
            try
            {
                if (!func.ValidateLogin(tbLogin.Text)){
                    throw new Exception("Логин введен неверно, он должен содержать минимум 8 симоволов.");
                }
                if (!func.ValidatePassword(tbPassword.Text))
                {
                    throw new Exception("Пароль введен неверно, он должен содержать минимум 8 симоволов, и минимум по 1 символу: верхнего регистра, нижнего регистра, цифры");
                }
                this.library451DataSet.aut.AddautRow(this.tbLogin.Text, this.tbPassword.Text, this.chkbIsAdmin.Checked, tbNewAccFIO.Text);
                this.autTableAdapter.Update(this.library451DataSet.aut);

                //очищаем инпуты и скрываем форму
                ClrAddAccForm();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClrAddAccForm()
        {
            //очистка и сокрытие
            tbLogin.Clear();
            tbPassword.Clear();
            checkBox5.Checked = false;
            tbNewAccFIO.Clear();
            gbNewAcc.Visible = false;
        }

        private void butCancelAdd_Click(object sender, EventArgs e)
        {
            //отменяем добавление нового аккаунта
            ClrAddAccForm();
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
                if (!func.ValidateLogin(loginTextBox1.Text))
                {
                    throw new Exception("Логин введен неверно, он должен содержать минимум 8 симоволов.");
                }
                if (!func.ValidatePassword(passwordTextBox.Text))
                {
                    throw new Exception("Пароль введен неверно, он должен содержать минимум 8 симоволов, и минимум по 1 символу: верхнего регистра, нижнего регистра, цифры");
                }
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
            PasswordVisible(checkBox4, passwordTextBox);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            //включаем видимость пароля при создании нового пользователя
            PasswordVisible(checkBox5, tbPassword);
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

        private void PasswordVisible(CheckBox checkBox,TextBox textBox)
        {
            if (checkBox.Checked)
            {
                textBox.UseSystemPasswordChar = false;
            }
            else textBox.UseSystemPasswordChar = true;
        }

        private void CreateReport(DataGridView dataGridView, string Type, string name, string id, DateTimePicker from, DateTimePicker to, string count)
        {
            Stream fs;
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if ((fs = saveFileDialog1.OpenFile()) != null)
                    {
                        Document doc = new Document();
                        doc.SetPageSize(PageSize.A4);
                        PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                        doc.Open();

                        //base font
                        BaseFont bfnt = BaseFont.CreateFont(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "TIMES.TTF"), BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

                        //Report Header
                        Font fntHead = new Font(bfnt, 16, 1, BaseColor.BLACK);
                        Paragraph prgHead = new Paragraph();
                        prgHead.Alignment = Element.ALIGN_CENTER;
                        prgHead.Add(new Chunk("ОТЧЕТ О " + Type.ToUpper(), fntHead));
                        doc.Add(prgHead);

                        //info
                        Font fntInfo = new Font(bfnt, 14, 1, BaseColor.BLACK);

                        Paragraph prgName = new Paragraph();
                        prgName.Alignment = Element.ALIGN_CENTER;
                        prgName.Add(new Chunk(name, fntInfo));
                        doc.Add(prgName);

                        Paragraph prgID = new Paragraph();
                        prgID.Alignment = Element.ALIGN_CENTER;
                        prgID.Add(new Chunk("Учетный номер: " + id, fntInfo));
                        doc.Add(prgID);

                        Paragraph prgDates = new Paragraph();
                        prgDates.Alignment = Element.ALIGN_CENTER;
                        prgDates.Add(new Chunk("В период с " + from.Value.ToShortDateString() + " по " + to.Value.ToShortDateString(), fntInfo));
                        doc.Add(prgDates);

                        Paragraph prgCount = new Paragraph();
                        prgCount.Alignment = Element.ALIGN_CENTER;
                        prgCount.Add(new Chunk(count, fntInfo));
                        doc.Add(prgCount);

                        //line   
                        Paragraph prgLine = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_CENTER, 0F)));
                        doc.Add(prgLine);

                        //line break
                        doc.Add(new Chunk("\n", fntHead));

                        //Data table
                        Font fntTable = new Font(bfnt, 10, 1, BaseColor.BLACK);
                        PdfPTable table = new PdfPTable(dataGridView.Columns.Count-2);
                        table.TotalWidth = 1000f;
                        table.SetWidths(new float[] { 180f,660f,160f});  
                        for (int i = 2; i < dataGridView.Columns.Count; i++)
                        {
                            PdfPCell cell = new PdfPCell();
                            cell.BackgroundColor = BaseColor.WHITE;
                            cell.Phrase = new Phrase(dataGridView.Columns[i].HeaderText, fntTable);
                            cell.HorizontalAlignment = Element.ALIGN_CENTER;
                            table.AddCell(cell);
                        }
                        for (int i = 0; i < dataGridView.Rows.Count; i++)
                        {
                            for (int j = 2; j < dataGridView.Columns.Count; j++)
                            {
                                PdfPCell content_cell = new PdfPCell();
                                if (dataGridView.Rows[i].Cells[j].Value.GetType() == DateTime.Today.GetType())
                                {
                                    content_cell.AddElement(new Chunk(" " + ((DateTime)dataGridView.Rows[i].Cells[j].Value).ToShortDateString(), fntTable));
                                    table.AddCell(content_cell);
                                }
                                else
                                {
                                    content_cell.AddElement(new Chunk(" " + dataGridView.Rows[i].Cells[j].Value.ToString(), fntTable));
                                    table.AddCell(content_cell);
                                }
                            }

                        }

                        doc.Add(table);

                        //line
                        doc.Add(new Chunk("\n", fntHead));
                        doc.Add(prgLine);
                        doc.Add(new Chunk("\n", fntHead));

                        //footer
                        Paragraph prgFooter = new Paragraph();
                        prgFooter.Alignment = Element.ALIGN_RIGHT;
                        prgFooter.Add(new Chunk(UserFIO + "    " + DateTime.Today.ToShortDateString(), fntInfo));
                        doc.Add(prgFooter);

                        doc.Close();
                        writer.Close();
                        fs.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void dtPickerFrom_ValueChanged(object sender, EventArgs e)
        {
            booksHistoryBindingSource.Filter = string.Format("[Date] >=  '{0}' AND [Date] <= '{1}' AND [book_id] = {2}", dtPickerFrom.Value.ToShortDateString(), dtPickerTo.Value.ToShortDateString(), Int32.Parse(book_IDTextBox1.Text));
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            autForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ReportReadersBindingSource.Filter = string.Format("[FIO] LIKE '%{0}%'", textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ReportBooksBindingSource.Filter = string.Format("[Book_Name] LIKE '%{0}%'", textBox2.Text);
        }

        private void readersDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            readersHistoryBindingSource.Filter = string.Format("[Date] >=  '{0}' AND [Date] <= '{1}' AND [Reader_ID] = {2}", dateTimePicker2.Value.ToShortDateString(), dateTimePicker1.Value.ToShortDateString(), Int32.Parse(reader_IDTextBox1.Text));
            tbCountBooks.Text = readersHistoryDataGridView.Rows.Count.ToString();
        }

        private void booksDataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            booksHistoryBindingSource.Filter = string.Format("[Date] >=  '{0}' AND [Date] <= '{1}' AND [book_id] = {2}", dtPickerFrom.Value.ToShortDateString(), dtPickerTo.Value.ToShortDateString(), Int32.Parse(book_IDTextBox1.Text));
            tbCountBookGive.Text = booksHistoryDataGridView.Rows.Count.ToString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.booksHistoryTableAdapter.Fill(this.library451DWHDataSet.BooksHistory);
            this.readersHistoryTableAdapter.Fill(this.library451DWHDataSet.ReadersHistory);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //очистка поиска для отчета по читателям
            textBox1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //очистка поиска для отчета по книгам
            textBox2.Text = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //отчет для читателя
            CreateReport(readersHistoryDataGridView,"читатале", fIOTextBox1.Text, reader_IDTextBox1.Text, dateTimePicker2, dateTimePicker1,"Кол-во взятых книг: " + tbCountBooks.Text);
        }

        private void butCreateReport_Click(object sender, EventArgs e)
        {
            //отчет для книги
            CreateReport(booksHistoryDataGridView, "книге", book_NameTextBox1.Text, book_IDTextBox1.Text, dtPickerFrom, dtPickerTo, "Кол-во взятых раз: " + tbCountBookGive.Text);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            readersHistoryBindingSource.Filter = string.Format("[Date] >=  '{0}' AND [Date] <= '{1}' AND [Reader_ID] = {2}", dateTimePicker2.Value.ToShortDateString(), dateTimePicker1.Value.ToShortDateString(), Int32.Parse(reader_IDTextBox1.Text));
        }
    }
}
