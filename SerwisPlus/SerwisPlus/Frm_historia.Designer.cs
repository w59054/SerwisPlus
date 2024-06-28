
namespace SerwisPlus
{
    partial class Frm_historia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_historia = new System.Windows.Forms.Panel();
            this.btn_podglad_zgloszenia = new System.Windows.Forms.Button();
            this.txt_szukaj = new System.Windows.Forms.TextBox();
            this.btn_szukaj = new System.Windows.Forms.Button();
            this.btn_aktualizuj_dane = new System.Windows.Forms.Button();
            this.btn_usun_zgloszenie = new System.Windows.Forms.Button();
            this.btn_przywroc_zgloszenie = new System.Windows.Forms.Button();
            this.dgv_historia = new System.Windows.Forms.DataGridView();
            this.panel_aktualizuj = new System.Windows.Forms.Panel();
            this.tb_ulica = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_aktualizuj = new System.Windows.Forms.Button();
            this.cb_typ_zgloszenia = new System.Windows.Forms.ComboBox();
            this.dtp_data = new System.Windows.Forms.DateTimePicker();
            this.tb_opis = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_tel_nr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_kod_pocztowy = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_miejscowosc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_nip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nazwa_firmy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_historia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historia)).BeginInit();
            this.panel_aktualizuj.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_historia
            // 
            this.panel_historia.BackColor = System.Drawing.Color.White;
            this.panel_historia.Controls.Add(this.btn_podglad_zgloszenia);
            this.panel_historia.Controls.Add(this.txt_szukaj);
            this.panel_historia.Controls.Add(this.btn_szukaj);
            this.panel_historia.Controls.Add(this.btn_aktualizuj_dane);
            this.panel_historia.Controls.Add(this.btn_usun_zgloszenie);
            this.panel_historia.Controls.Add(this.btn_przywroc_zgloszenie);
            this.panel_historia.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_historia.Location = new System.Drawing.Point(0, 0);
            this.panel_historia.Name = "panel_historia";
            this.panel_historia.Size = new System.Drawing.Size(1288, 64);
            this.panel_historia.TabIndex = 2;
            // 
            // btn_podglad_zgloszenia
            // 
            this.btn_podglad_zgloszenia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_podglad_zgloszenia.Location = new System.Drawing.Point(869, 3);
            this.btn_podglad_zgloszenia.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btn_podglad_zgloszenia.Name = "btn_podglad_zgloszenia";
            this.btn_podglad_zgloszenia.Size = new System.Drawing.Size(120, 47);
            this.btn_podglad_zgloszenia.TabIndex = 6;
            this.btn_podglad_zgloszenia.Text = "Podgląd zgłoszenia";
            this.btn_podglad_zgloszenia.UseVisualStyleBackColor = true;
            this.btn_podglad_zgloszenia.Click += new System.EventHandler(this.btn_podglad_zgloszenia_Click);
            // 
            // txt_szukaj
            // 
            this.txt_szukaj.Location = new System.Drawing.Point(12, 17);
            this.txt_szukaj.Name = "txt_szukaj";
            this.txt_szukaj.Size = new System.Drawing.Size(259, 20);
            this.txt_szukaj.TabIndex = 1;
            this.txt_szukaj.Text = "Wpisz nazwę firmy do wyszukania";
            this.txt_szukaj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_szukaj_KeyPress);
            // 
            // btn_szukaj
            // 
            this.btn_szukaj.Location = new System.Drawing.Point(284, 3);
            this.btn_szukaj.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btn_szukaj.Name = "btn_szukaj";
            this.btn_szukaj.Size = new System.Drawing.Size(120, 47);
            this.btn_szukaj.TabIndex = 2;
            this.btn_szukaj.Text = "Szukaj";
            this.btn_szukaj.UseVisualStyleBackColor = true;
            this.btn_szukaj.Click += new System.EventHandler(this.btn_szukaj_Click);
            // 
            // btn_aktualizuj_dane
            // 
            this.btn_aktualizuj_dane.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_aktualizuj_dane.Location = new System.Drawing.Point(729, 3);
            this.btn_aktualizuj_dane.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btn_aktualizuj_dane.Name = "btn_aktualizuj_dane";
            this.btn_aktualizuj_dane.Size = new System.Drawing.Size(120, 47);
            this.btn_aktualizuj_dane.TabIndex = 3;
            this.btn_aktualizuj_dane.Text = "Aktualizuj zgłoszenie";
            this.btn_aktualizuj_dane.UseVisualStyleBackColor = true;
            this.btn_aktualizuj_dane.Click += new System.EventHandler(this.btn_aktualizuj_dane_Click);
            // 
            // btn_usun_zgloszenie
            // 
            this.btn_usun_zgloszenie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_usun_zgloszenie.Location = new System.Drawing.Point(1149, 3);
            this.btn_usun_zgloszenie.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btn_usun_zgloszenie.Name = "btn_usun_zgloszenie";
            this.btn_usun_zgloszenie.Size = new System.Drawing.Size(120, 47);
            this.btn_usun_zgloszenie.TabIndex = 5;
            this.btn_usun_zgloszenie.Text = "Usuń zgłoszenie";
            this.btn_usun_zgloszenie.UseVisualStyleBackColor = true;
            this.btn_usun_zgloszenie.Click += new System.EventHandler(this.btn_usun_zgloszenie_Click);
            // 
            // btn_przywroc_zgloszenie
            // 
            this.btn_przywroc_zgloszenie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_przywroc_zgloszenie.Location = new System.Drawing.Point(1009, 3);
            this.btn_przywroc_zgloszenie.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btn_przywroc_zgloszenie.Name = "btn_przywroc_zgloszenie";
            this.btn_przywroc_zgloszenie.Size = new System.Drawing.Size(120, 47);
            this.btn_przywroc_zgloszenie.TabIndex = 4;
            this.btn_przywroc_zgloszenie.Text = "Przywróć zgłoszenie";
            this.btn_przywroc_zgloszenie.UseVisualStyleBackColor = true;
            this.btn_przywroc_zgloszenie.Click += new System.EventHandler(this.btn_przywroc_zgloszenie_Click);
            // 
            // dgv_historia
            // 
            this.dgv_historia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_historia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_historia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_historia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_historia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_historia.Location = new System.Drawing.Point(0, 0);
            this.dgv_historia.Name = "dgv_historia";
            this.dgv_historia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv_historia.RowHeadersWidth = 30;
            this.dgv_historia.RowTemplate.Height = 30;
            this.dgv_historia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_historia.Size = new System.Drawing.Size(1288, 600);
            this.dgv_historia.TabIndex = 6;
            // 
            // panel_aktualizuj
            // 
            this.panel_aktualizuj.Controls.Add(this.tb_ulica);
            this.panel_aktualizuj.Controls.Add(this.label9);
            this.panel_aktualizuj.Controls.Add(this.btn_aktualizuj);
            this.panel_aktualizuj.Controls.Add(this.cb_typ_zgloszenia);
            this.panel_aktualizuj.Controls.Add(this.dtp_data);
            this.panel_aktualizuj.Controls.Add(this.tb_opis);
            this.panel_aktualizuj.Controls.Add(this.label8);
            this.panel_aktualizuj.Controls.Add(this.label7);
            this.panel_aktualizuj.Controls.Add(this.label6);
            this.panel_aktualizuj.Controls.Add(this.tb_tel_nr);
            this.panel_aktualizuj.Controls.Add(this.label5);
            this.panel_aktualizuj.Controls.Add(this.tb_kod_pocztowy);
            this.panel_aktualizuj.Controls.Add(this.label4);
            this.panel_aktualizuj.Controls.Add(this.tb_miejscowosc);
            this.panel_aktualizuj.Controls.Add(this.label3);
            this.panel_aktualizuj.Controls.Add(this.tb_nip);
            this.panel_aktualizuj.Controls.Add(this.label2);
            this.panel_aktualizuj.Controls.Add(this.tb_nazwa_firmy);
            this.panel_aktualizuj.Controls.Add(this.label1);
            this.panel_aktualizuj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_aktualizuj.Location = new System.Drawing.Point(0, 0);
            this.panel_aktualizuj.Name = "panel_aktualizuj";
            this.panel_aktualizuj.Size = new System.Drawing.Size(1288, 600);
            this.panel_aktualizuj.TabIndex = 7;
            // 
            // tb_ulica
            // 
            this.tb_ulica.Location = new System.Drawing.Point(430, 236);
            this.tb_ulica.Margin = new System.Windows.Forms.Padding(10);
            this.tb_ulica.Name = "tb_ulica";
            this.tb_ulica.Size = new System.Drawing.Size(472, 20);
            this.tb_ulica.TabIndex = 47;
            this.tb_ulica.Text = " ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(259, 239);
            this.label9.Margin = new System.Windows.Forms.Padding(10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 19);
            this.label9.TabIndex = 46;
            this.label9.Text = "Ulica i numer budynku";
            // 
            // btn_aktualizuj
            // 
            this.btn_aktualizuj.Location = new System.Drawing.Point(750, 525);
            this.btn_aktualizuj.Name = "btn_aktualizuj";
            this.btn_aktualizuj.Size = new System.Drawing.Size(152, 39);
            this.btn_aktualizuj.TabIndex = 45;
            this.btn_aktualizuj.Text = "Aktualizuj dane";
            this.btn_aktualizuj.UseVisualStyleBackColor = true;
            // 
            // cb_typ_zgloszenia
            // 
            this.cb_typ_zgloszenia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_typ_zgloszenia.FormattingEnabled = true;
            this.cb_typ_zgloszenia.Items.AddRange(new object[] {
            "Serwis Gwarancyjny",
            "Serwis Pogwarancyjny",
            "Przegląd Gwarancyjny",
            "Usługa"});
            this.cb_typ_zgloszenia.Location = new System.Drawing.Point(430, 317);
            this.cb_typ_zgloszenia.Margin = new System.Windows.Forms.Padding(10);
            this.cb_typ_zgloszenia.Name = "cb_typ_zgloszenia";
            this.cb_typ_zgloszenia.Size = new System.Drawing.Size(472, 21);
            this.cb_typ_zgloszenia.TabIndex = 42;
            // 
            // dtp_data
            // 
            this.dtp_data.Checked = false;
            this.dtp_data.CustomFormat = "yyyyMMdd";
            this.dtp_data.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtp_data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_data.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.dtp_data.Location = new System.Drawing.Point(430, 357);
            this.dtp_data.Margin = new System.Windows.Forms.Padding(10);
            this.dtp_data.Name = "dtp_data";
            this.dtp_data.Size = new System.Drawing.Size(200, 22);
            this.dtp_data.TabIndex = 43;
            // 
            // tb_opis
            // 
            this.tb_opis.Location = new System.Drawing.Point(430, 399);
            this.tb_opis.Margin = new System.Windows.Forms.Padding(10);
            this.tb_opis.Multiline = true;
            this.tb_opis.Name = "tb_opis";
            this.tb_opis.Size = new System.Drawing.Size(472, 113);
            this.tb_opis.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(363, 399);
            this.label8.Margin = new System.Windows.Forms.Padding(10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 19);
            this.label8.TabIndex = 35;
            this.label8.Text = "Opis";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(290, 357);
            this.label7.Margin = new System.Windows.Forms.Padding(10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 19);
            this.label7.TabIndex = 36;
            this.label7.Text = "Data wykonania";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(305, 319);
            this.label6.Margin = new System.Windows.Forms.Padding(10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 19);
            this.label6.TabIndex = 33;
            this.label6.Text = "Typ zgłoszenia";
            // 
            // tb_tel_nr
            // 
            this.tb_tel_nr.Location = new System.Drawing.Point(430, 277);
            this.tb_tel_nr.Margin = new System.Windows.Forms.Padding(10);
            this.tb_tel_nr.Name = "tb_tel_nr";
            this.tb_tel_nr.Size = new System.Drawing.Size(472, 20);
            this.tb_tel_nr.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(293, 278);
            this.label5.Margin = new System.Windows.Forms.Padding(10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 19);
            this.label5.TabIndex = 29;
            this.label5.Text = "Numer Telefonu";
            // 
            // tb_kod_pocztowy
            // 
            this.tb_kod_pocztowy.Location = new System.Drawing.Point(430, 197);
            this.tb_kod_pocztowy.Margin = new System.Windows.Forms.Padding(10);
            this.tb_kod_pocztowy.Name = "tb_kod_pocztowy";
            this.tb_kod_pocztowy.Size = new System.Drawing.Size(115, 20);
            this.tb_kod_pocztowy.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(315, 198);
            this.label4.Margin = new System.Windows.Forms.Padding(10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 19);
            this.label4.TabIndex = 32;
            this.label4.Text = "Kod Pocztowy";
            // 
            // tb_miejscowosc
            // 
            this.tb_miejscowosc.Location = new System.Drawing.Point(430, 157);
            this.tb_miejscowosc.Margin = new System.Windows.Forms.Padding(10);
            this.tb_miejscowosc.MaxLength = 50;
            this.tb_miejscowosc.Name = "tb_miejscowosc";
            this.tb_miejscowosc.Size = new System.Drawing.Size(472, 20);
            this.tb_miejscowosc.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(315, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 31;
            this.label3.Text = "Miejscowosc";
            // 
            // tb_nip
            // 
            this.tb_nip.Location = new System.Drawing.Point(430, 117);
            this.tb_nip.Margin = new System.Windows.Forms.Padding(10);
            this.tb_nip.Name = "tb_nip";
            this.tb_nip.Size = new System.Drawing.Size(472, 20);
            this.tb_nip.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(374, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "NIP";
            // 
            // tb_nazwa_firmy
            // 
            this.tb_nazwa_firmy.Location = new System.Drawing.Point(430, 77);
            this.tb_nazwa_firmy.Margin = new System.Windows.Forms.Padding(10);
            this.tb_nazwa_firmy.Name = "tb_nazwa_firmy";
            this.tb_nazwa_firmy.Size = new System.Drawing.Size(472, 20);
            this.tb_nazwa_firmy.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(315, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 34;
            this.label1.Text = "Nazwa Firmy";
            // 
            // Frm_historia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 600);
            this.Controls.Add(this.panel_historia);
            this.Controls.Add(this.dgv_historia);
            this.Controls.Add(this.panel_aktualizuj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_historia";
            this.Text = "Historia";
            this.Load += new System.EventHandler(this.Frm_historia_Load);
            this.panel_historia.ResumeLayout(false);
            this.panel_historia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historia)).EndInit();
            this.panel_aktualizuj.ResumeLayout(false);
            this.panel_aktualizuj.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_historia;
        private System.Windows.Forms.Button btn_szukaj;
        private System.Windows.Forms.Button btn_aktualizuj_dane;
        private System.Windows.Forms.Button btn_usun_zgloszenie;
        private System.Windows.Forms.Button btn_przywroc_zgloszenie;
        private System.Windows.Forms.Panel panel_aktualizuj;
        public System.Windows.Forms.TextBox tb_ulica;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_aktualizuj;
        private System.Windows.Forms.ComboBox cb_typ_zgloszenia;
        private System.Windows.Forms.DateTimePicker dtp_data;
        public System.Windows.Forms.TextBox tb_opis;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox tb_tel_nr;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tb_kod_pocztowy;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tb_miejscowosc;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tb_nip;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tb_nazwa_firmy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_podglad_zgloszenia;
        public System.Windows.Forms.TextBox txt_szukaj;
        public System.Windows.Forms.DataGridView dgv_historia;
    }
}