
namespace WindowsFormsApp1
{
    partial class ReaderAddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label fIOLabel;
            System.Windows.Forms.Label pASSPORTLabel;
            System.Windows.Forms.Label aDDRESSLabel;
            System.Windows.Forms.Label tELEPHONELabel;
            this.fIOTextBox = new System.Windows.Forms.TextBox();
            this.aDDRESSTextBox = new System.Windows.Forms.TextBox();
            this.library451DataSet = new WindowsFormsApp1.Library451DataSet();
            this.readersTableAdapter = new WindowsFormsApp1.Library451DataSetTableAdapters.ReadersTableAdapter();
            this.butAddNewReader = new System.Windows.Forms.Button();
            this.butCancelAdd = new System.Windows.Forms.Button();
            this.tELEPHONETextBox = new System.Windows.Forms.MaskedTextBox();
            this.pASSPORTTextBox = new System.Windows.Forms.MaskedTextBox();
            fIOLabel = new System.Windows.Forms.Label();
            pASSPORTLabel = new System.Windows.Forms.Label();
            aDDRESSLabel = new System.Windows.Forms.Label();
            tELEPHONELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.library451DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // fIOLabel
            // 
            fIOLabel.AutoSize = true;
            fIOLabel.Location = new System.Drawing.Point(17, 21);
            fIOLabel.Name = "fIOLabel";
            fIOLabel.Size = new System.Drawing.Size(37, 13);
            fIOLabel.TabIndex = 35;
            fIOLabel.Text = "ФИО:";
            // 
            // pASSPORTLabel
            // 
            pASSPORTLabel.AutoSize = true;
            pASSPORTLabel.Location = new System.Drawing.Point(17, 47);
            pASSPORTLabel.Name = "pASSPORTLabel";
            pASSPORTLabel.Size = new System.Drawing.Size(53, 13);
            pASSPORTLabel.TabIndex = 37;
            pASSPORTLabel.Text = "Паспорт:";
            // 
            // aDDRESSLabel
            // 
            aDDRESSLabel.AutoSize = true;
            aDDRESSLabel.Location = new System.Drawing.Point(17, 73);
            aDDRESSLabel.Name = "aDDRESSLabel";
            aDDRESSLabel.Size = new System.Drawing.Size(41, 13);
            aDDRESSLabel.TabIndex = 39;
            aDDRESSLabel.Text = "Адрес:";
            // 
            // tELEPHONELabel
            // 
            tELEPHONELabel.AutoSize = true;
            tELEPHONELabel.Location = new System.Drawing.Point(17, 99);
            tELEPHONELabel.Name = "tELEPHONELabel";
            tELEPHONELabel.Size = new System.Drawing.Size(55, 13);
            tELEPHONELabel.TabIndex = 41;
            tELEPHONELabel.Text = "Телефон:";
            // 
            // fIOTextBox
            // 
            this.fIOTextBox.Location = new System.Drawing.Point(108, 18);
            this.fIOTextBox.Name = "fIOTextBox";
            this.fIOTextBox.Size = new System.Drawing.Size(456, 20);
            this.fIOTextBox.TabIndex = 36;
            // 
            // aDDRESSTextBox
            // 
            this.aDDRESSTextBox.Location = new System.Drawing.Point(108, 70);
            this.aDDRESSTextBox.Name = "aDDRESSTextBox";
            this.aDDRESSTextBox.Size = new System.Drawing.Size(456, 20);
            this.aDDRESSTextBox.TabIndex = 40;
            // 
            // library451DataSet
            // 
            this.library451DataSet.DataSetName = "Library451DataSet";
            this.library451DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // readersTableAdapter
            // 
            this.readersTableAdapter.ClearBeforeFill = true;
            // 
            // butAddNewReader
            // 
            this.butAddNewReader.Location = new System.Drawing.Point(20, 152);
            this.butAddNewReader.Name = "butAddNewReader";
            this.butAddNewReader.Size = new System.Drawing.Size(75, 23);
            this.butAddNewReader.TabIndex = 43;
            this.butAddNewReader.Text = "Добавить";
            this.butAddNewReader.UseVisualStyleBackColor = true;
            this.butAddNewReader.Click += new System.EventHandler(this.butAddNewReader_Click);
            // 
            // butCancelAdd
            // 
            this.butCancelAdd.Location = new System.Drawing.Point(489, 152);
            this.butCancelAdd.Name = "butCancelAdd";
            this.butCancelAdd.Size = new System.Drawing.Size(75, 23);
            this.butCancelAdd.TabIndex = 44;
            this.butCancelAdd.Text = "Отмена";
            this.butCancelAdd.UseVisualStyleBackColor = true;
            this.butCancelAdd.Click += new System.EventHandler(this.butCancelAdd_Click);
            // 
            // tELEPHONETextBox
            // 
            this.tELEPHONETextBox.Location = new System.Drawing.Point(108, 96);
            this.tELEPHONETextBox.Mask = "+7 (999) 000-0000";
            this.tELEPHONETextBox.Name = "tELEPHONETextBox";
            this.tELEPHONETextBox.Size = new System.Drawing.Size(456, 20);
            this.tELEPHONETextBox.TabIndex = 45;
            // 
            // pASSPORTTextBox
            // 
            this.pASSPORTTextBox.Location = new System.Drawing.Point(108, 44);
            this.pASSPORTTextBox.Mask = "0000 000000";
            this.pASSPORTTextBox.Name = "pASSPORTTextBox";
            this.pASSPORTTextBox.Size = new System.Drawing.Size(456, 20);
            this.pASSPORTTextBox.TabIndex = 46;
            // 
            // ReaderAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 195);
            this.Controls.Add(this.pASSPORTTextBox);
            this.Controls.Add(this.tELEPHONETextBox);
            this.Controls.Add(this.butCancelAdd);
            this.Controls.Add(this.butAddNewReader);
            this.Controls.Add(fIOLabel);
            this.Controls.Add(this.fIOTextBox);
            this.Controls.Add(pASSPORTLabel);
            this.Controls.Add(aDDRESSLabel);
            this.Controls.Add(this.aDDRESSTextBox);
            this.Controls.Add(tELEPHONELabel);
            this.Name = "ReaderAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление читателя";
            ((System.ComponentModel.ISupportInitialize)(this.library451DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox fIOTextBox;
        private System.Windows.Forms.TextBox aDDRESSTextBox;
        private Library451DataSet library451DataSet;
        private Library451DataSetTableAdapters.ReadersTableAdapter readersTableAdapter;
        private System.Windows.Forms.Button butAddNewReader;
        private System.Windows.Forms.Button butCancelAdd;
        private System.Windows.Forms.MaskedTextBox tELEPHONETextBox;
        private System.Windows.Forms.MaskedTextBox pASSPORTTextBox;
    }
}