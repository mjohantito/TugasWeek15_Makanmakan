namespace TugasWeek15_Makanmakan
{
    partial class Form1
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
            this.labelNamaItem = new System.Windows.Forms.Label();
            this.labelKategori = new System.Windows.Forms.Label();
            this.textBoxNamaitem = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonMakanan = new System.Windows.Forms.RadioButton();
            this.radioButtonMinuman = new System.Windows.Forms.RadioButton();
            this.buttonInput = new System.Windows.Forms.Button();
            this.buttonPindah = new System.Windows.Forms.Button();
            this.buttonX = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxMakanan = new System.Windows.Forms.CheckBox();
            this.checkBoxMinuman = new System.Windows.Forms.CheckBox();
            this.labelFilter = new System.Windows.Forms.Label();
            this.listBoxKiri = new System.Windows.Forms.ListBox();
            this.listBoxKanan = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNamaItem
            // 
            this.labelNamaItem.AutoSize = true;
            this.labelNamaItem.Location = new System.Drawing.Point(35, 34);
            this.labelNamaItem.Name = "labelNamaItem";
            this.labelNamaItem.Size = new System.Drawing.Size(58, 13);
            this.labelNamaItem.TabIndex = 0;
            this.labelNamaItem.Text = "Nama Item";
            // 
            // labelKategori
            // 
            this.labelKategori.AutoSize = true;
            this.labelKategori.Location = new System.Drawing.Point(35, 88);
            this.labelKategori.Name = "labelKategori";
            this.labelKategori.Size = new System.Drawing.Size(46, 13);
            this.labelKategori.TabIndex = 1;
            this.labelKategori.Text = "Kategori";
            // 
            // textBoxNamaitem
            // 
            this.textBoxNamaitem.Location = new System.Drawing.Point(126, 34);
            this.textBoxNamaitem.Name = "textBoxNamaitem";
            this.textBoxNamaitem.Size = new System.Drawing.Size(100, 20);
            this.textBoxNamaitem.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.radioButtonMakanan, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioButtonMinuman, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(126, 88);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 34);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // radioButtonMakanan
            // 
            this.radioButtonMakanan.AutoSize = true;
            this.radioButtonMakanan.Location = new System.Drawing.Point(3, 3);
            this.radioButtonMakanan.Name = "radioButtonMakanan";
            this.radioButtonMakanan.Size = new System.Drawing.Size(70, 17);
            this.radioButtonMakanan.TabIndex = 0;
            this.radioButtonMakanan.TabStop = true;
            this.radioButtonMakanan.Text = "Makanan";
            this.radioButtonMakanan.UseVisualStyleBackColor = true;
            // 
            // radioButtonMinuman
            // 
            this.radioButtonMinuman.AutoSize = true;
            this.radioButtonMinuman.Location = new System.Drawing.Point(103, 3);
            this.radioButtonMinuman.Name = "radioButtonMinuman";
            this.radioButtonMinuman.Size = new System.Drawing.Size(68, 17);
            this.radioButtonMinuman.TabIndex = 1;
            this.radioButtonMinuman.TabStop = true;
            this.radioButtonMinuman.Text = "Minuman";
            this.radioButtonMinuman.UseVisualStyleBackColor = true;
            // 
            // buttonInput
            // 
            this.buttonInput.Location = new System.Drawing.Point(126, 141);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(75, 23);
            this.buttonInput.TabIndex = 4;
            this.buttonInput.Text = "Input";
            this.buttonInput.UseVisualStyleBackColor = true;
            this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // buttonPindah
            // 
            this.buttonPindah.Location = new System.Drawing.Point(229, 208);
            this.buttonPindah.Name = "buttonPindah";
            this.buttonPindah.Size = new System.Drawing.Size(75, 23);
            this.buttonPindah.TabIndex = 5;
            this.buttonPindah.Text = ">";
            this.buttonPindah.UseVisualStyleBackColor = true;
            this.buttonPindah.Click += new System.EventHandler(this.buttonPindah_Click);
            // 
            // buttonX
            // 
            this.buttonX.Location = new System.Drawing.Point(229, 237);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(75, 23);
            this.buttonX.TabIndex = 6;
            this.buttonX.Text = "X";
            this.buttonX.UseVisualStyleBackColor = true;
            this.buttonX.Click += new System.EventHandler(this.buttonX_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.checkBoxMakanan, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.checkBoxMinuman, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(228, 289);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(84, 63);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // checkBoxMakanan
            // 
            this.checkBoxMakanan.AutoSize = true;
            this.checkBoxMakanan.Location = new System.Drawing.Point(3, 3);
            this.checkBoxMakanan.Name = "checkBoxMakanan";
            this.checkBoxMakanan.Size = new System.Drawing.Size(71, 17);
            this.checkBoxMakanan.TabIndex = 0;
            this.checkBoxMakanan.Text = "Makanan";
            this.checkBoxMakanan.UseVisualStyleBackColor = true;
            this.checkBoxMakanan.CheckedChanged += new System.EventHandler(this.checkBoxMakanan_CheckedChanged);
            // 
            // checkBoxMinuman
            // 
            this.checkBoxMinuman.AutoSize = true;
            this.checkBoxMinuman.Location = new System.Drawing.Point(3, 35);
            this.checkBoxMinuman.Name = "checkBoxMinuman";
            this.checkBoxMinuman.Size = new System.Drawing.Size(69, 17);
            this.checkBoxMinuman.TabIndex = 1;
            this.checkBoxMinuman.Text = "Minuman";
            this.checkBoxMinuman.UseVisualStyleBackColor = true;
            this.checkBoxMinuman.CheckedChanged += new System.EventHandler(this.checkBoxMinuman_CheckedChanged);
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Location = new System.Drawing.Point(228, 273);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(29, 13);
            this.labelFilter.TabIndex = 8;
            this.labelFilter.Text = "Filter";
            // 
            // listBoxKiri
            // 
            this.listBoxKiri.FormattingEnabled = true;
            this.listBoxKiri.Location = new System.Drawing.Point(38, 208);
            this.listBoxKiri.Name = "listBoxKiri";
            this.listBoxKiri.Size = new System.Drawing.Size(163, 199);
            this.listBoxKiri.TabIndex = 9;
            this.listBoxKiri.SelectedIndexChanged += new System.EventHandler(this.listBoxKiri_SelectedIndexChanged);
            // 
            // listBoxKanan
            // 
            this.listBoxKanan.FormattingEnabled = true;
            this.listBoxKanan.Location = new System.Drawing.Point(342, 208);
            this.listBoxKanan.Name = "listBoxKanan";
            this.listBoxKanan.Size = new System.Drawing.Size(163, 199);
            this.listBoxKanan.TabIndex = 10;
            this.listBoxKanan.SelectedIndexChanged += new System.EventHandler(this.listBoxKanan_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 450);
            this.Controls.Add(this.listBoxKanan);
            this.Controls.Add(this.listBoxKiri);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.buttonX);
            this.Controls.Add(this.buttonPindah);
            this.Controls.Add(this.buttonInput);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.textBoxNamaitem);
            this.Controls.Add(this.labelKategori);
            this.Controls.Add(this.labelNamaItem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNamaItem;
        private System.Windows.Forms.Label labelKategori;
        private System.Windows.Forms.TextBox textBoxNamaitem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton radioButtonMakanan;
        private System.Windows.Forms.RadioButton radioButtonMinuman;
        private System.Windows.Forms.Button buttonInput;
        private System.Windows.Forms.Button buttonPindah;
        private System.Windows.Forms.Button buttonX;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox checkBoxMakanan;
        private System.Windows.Forms.CheckBox checkBoxMinuman;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.ListBox listBoxKiri;
        private System.Windows.Forms.ListBox listBoxKanan;
    }
}

