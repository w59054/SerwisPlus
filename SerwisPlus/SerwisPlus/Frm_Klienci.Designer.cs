
namespace SerwisPlus
{
    partial class Frm_Klienci
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
            this.panel_klienci = new System.Windows.Forms.Panel();
            this.btn_dodaj_klienta = new System.Windows.Forms.Button();
            this.btn_aktualizuj_dane = new System.Windows.Forms.Button();
            this.btn_usun_klienta = new System.Windows.Forms.Button();
            this.txt_szukaj = new System.Windows.Forms.TextBox();
            this.btn_szukaj = new System.Windows.Forms.Button();
            this.dgv_klienci = new System.Windows.Forms.DataGridView();
            this.panel_aktualizuj_klienta = new System.Windows.Forms.Panel();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_nr_tel = new System.Windows.Forms.TextBox();
            this.btn_aktualizuj_klienta = new System.Windows.Forms.Button();
            this.btn_dodaj_klienta_2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_ulica = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_kod_pocztowy = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_miejscowosc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_nip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nazwa_firmy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_klienci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_klienci)).BeginInit();
            this.panel_aktualizuj_klienta.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_klienci
            // 
            this.panel_klienci.BackColor = System.Drawing.Color.White;
            this.panel_klienci.Controls.Add(this.btn_dodaj_klienta);
            this.panel_klienci.Controls.Add(this.btn_aktualizuj_dane);
            this.panel_klienci.Controls.Add(this.btn_usun_klienta);
            this.panel_klienci.Controls.Add(this.txt_szukaj);
            this.panel_klienci.Controls.Add(this.btn_szukaj);
            this.panel_klienci.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_klienci.Location = new System.Drawing.Point(0, 0);
            this.panel_klienci.Name = "panel_klienci";
            this.panel_klienci.Size = new System.Drawing.Size(1288, 64);
            this.panel_klienci.TabIndex = 0;
            // 
            // btn_dodaj_klienta
            // 
            this.btn_dodaj_klienta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_dodaj_klienta.Location = new System.Drawing.Point(962, 3);
            this.btn_dodaj_klienta.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_dodaj_klienta.Name = "btn_dodaj_klienta";
            this.btn_dodaj_klienta.Size = new System.Drawing.Size(100, 45);
            this.btn_dodaj_klienta.TabIndex = 12;
            this.btn_dodaj_klienta.Text = "Dodaj klienta";
            this.btn_dodaj_klienta.UseVisualStyleBackColor = true;
            this.btn_dodaj_klienta.Click += new System.EventHandler(this.btn_dodaj_klienta_Click);
            // 
            // btn_aktualizuj_dane
            // 
            this.btn_aktualizuj_dane.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_aktualizuj_dane.Location = new System.Drawing.Point(1072, 3);
            this.btn_aktualizuj_dane.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_aktualizuj_dane.Name = "btn_aktualizuj_dane";
            this.btn_aktualizuj_dane.Size = new System.Drawing.Size(100, 45);
            this.btn_aktualizuj_dane.TabIndex = 11;
            this.btn_aktualizuj_dane.Text = "Aktualizuj dane";
            this.btn_aktualizuj_dane.UseVisualStyleBackColor = true;
            this.btn_aktualizuj_dane.Click += new System.EventHandler(this.btn_aktualizuj_dane_Click);
            // 
            // btn_usun_klienta
            // 
            this.btn_usun_klienta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_usun_klienta.Location = new System.Drawing.Point(1182, 3);
            this.btn_usun_klienta.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_usun_klienta.Name = "btn_usun_klienta";
            this.btn_usun_klienta.Size = new System.Drawing.Size(100, 45);
            this.btn_usun_klienta.TabIndex = 10;
            this.btn_usun_klienta.Text = "Usuń klienta";
            this.btn_usun_klienta.UseVisualStyleBackColor = true;
            this.btn_usun_klienta.Click += new System.EventHandler(this.btn_usun_klienta_Click);
            // 
            // txt_szukaj
            // 
            this.txt_szukaj.Location = new System.Drawing.Point(12, 16);
            this.txt_szukaj.Name = "txt_szukaj";
            this.txt_szukaj.Size = new System.Drawing.Size(262, 20);
            this.txt_szukaj.TabIndex = 8;
            this.txt_szukaj.Text = "Wpisz nazwę firmy do wyszukania";
            this.txt_szukaj.Enter += new System.EventHandler(this.txt_szukaj_Enter);
            this.txt_szukaj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_szukaj_KeyPress);
            // 
            // btn_szukaj
            // 
            this.btn_szukaj.Location = new System.Drawing.Point(287, 3);
            this.btn_szukaj.Margin = new System.Windows.Forms.Padding(10, 3, 5, 3);
            this.btn_szukaj.Name = "btn_szukaj";
            this.btn_szukaj.Size = new System.Drawing.Size(124, 45);
            this.btn_szukaj.TabIndex = 7;
            this.btn_szukaj.Text = "Szukaj";
            this.btn_szukaj.UseVisualStyleBackColor = true;
            this.btn_szukaj.Click += new System.EventHandler(this.btn_szukaj_Click);
            // 
            // dgv_klienci
            // 
            this.dgv_klienci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_klienci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_klienci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_klienci.Location = new System.Drawing.Point(0, 0);
            this.dgv_klienci.Name = "dgv_klienci";
            this.dgv_klienci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_klienci.Size = new System.Drawing.Size(1288, 636);
            this.dgv_klienci.TabIndex = 1;
            // 
            // panel_aktualizuj_klienta
            // 
            this.panel_aktualizuj_klienta.BackColor = System.Drawing.SystemColors.Control;
            this.panel_aktualizuj_klienta.Controls.Add(this.tb_email);
            this.panel_aktualizuj_klienta.Controls.Add(this.tb_nr_tel);
            this.panel_aktualizuj_klienta.Controls.Add(this.btn_aktualizuj_klienta);
            this.panel_aktualizuj_klienta.Controls.Add(this.btn_dodaj_klienta_2);
            this.panel_aktualizuj_klienta.Controls.Add(this.label7);
            this.panel_aktualizuj_klienta.Controls.Add(this.label6);
            this.panel_aktualizuj_klienta.Controls.Add(this.tb_ulica);
            this.panel_aktualizuj_klienta.Controls.Add(this.label5);
            this.panel_aktualizuj_klienta.Controls.Add(this.tb_kod_pocztowy);
            this.panel_aktualizuj_klienta.Controls.Add(this.label4);
            this.panel_aktualizuj_klienta.Controls.Add(this.tb_miejscowosc);
            this.panel_aktualizuj_klienta.Controls.Add(this.label3);
            this.panel_aktualizuj_klienta.Controls.Add(this.tb_nip);
            this.panel_aktualizuj_klienta.Controls.Add(this.label2);
            this.panel_aktualizuj_klienta.Controls.Add(this.tb_nazwa_firmy);
            this.panel_aktualizuj_klienta.Controls.Add(this.label1);
            this.panel_aktualizuj_klienta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_aktualizuj_klienta.Location = new System.Drawing.Point(0, 0);
            this.panel_aktualizuj_klienta.Name = "panel_aktualizuj_klienta";
            this.panel_aktualizuj_klienta.Size = new System.Drawing.Size(1288, 636);
            this.panel_aktualizuj_klienta.TabIndex = 2;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(458, 377);
            this.tb_email.Margin = new System.Windows.Forms.Padding(10);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(472, 20);
            this.tb_email.TabIndex = 44;
            // 
            // tb_nr_tel
            // 
            this.tb_nr_tel.Location = new System.Drawing.Point(458, 339);
            this.tb_nr_tel.Margin = new System.Windows.Forms.Padding(10);
            this.tb_nr_tel.MaxLength = 15;
            this.tb_nr_tel.Name = "tb_nr_tel";
            this.tb_nr_tel.Size = new System.Drawing.Size(472, 20);
            this.tb_nr_tel.TabIndex = 44;
            // 
            // btn_aktualizuj_klienta
            // 
            this.btn_aktualizuj_klienta.Location = new System.Drawing.Point(607, 479);
            this.btn_aktualizuj_klienta.Name = "btn_aktualizuj_klienta";
            this.btn_aktualizuj_klienta.Size = new System.Drawing.Size(152, 39);
            this.btn_aktualizuj_klienta.TabIndex = 43;
            this.btn_aktualizuj_klienta.Text = "Aktualizuj klienta";
            this.btn_aktualizuj_klienta.UseVisualStyleBackColor = true;
            this.btn_aktualizuj_klienta.Click += new System.EventHandler(this.btn_aktualizuj_klienta_Click);
            // 
            // btn_dodaj_klienta_2
            // 
            this.btn_dodaj_klienta_2.Location = new System.Drawing.Point(777, 479);
            this.btn_dodaj_klienta_2.Name = "btn_dodaj_klienta_2";
            this.btn_dodaj_klienta_2.Size = new System.Drawing.Size(152, 39);
            this.btn_dodaj_klienta_2.TabIndex = 43;
            this.btn_dodaj_klienta_2.Text = "Dodaj klienta";
            this.btn_dodaj_klienta_2.UseVisualStyleBackColor = true;
            this.btn_dodaj_klienta_2.Click += new System.EventHandler(this.btn_dodaj_klienta_2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(385, 376);
            this.label7.Margin = new System.Windows.Forms.Padding(10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 19);
            this.label7.TabIndex = 34;
            this.label7.Text = "E-mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(324, 337);
            this.label6.Margin = new System.Windows.Forms.Padding(10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 19);
            this.label6.TabIndex = 31;
            this.label6.Text = "Numer telefonu";
            // 
            // tb_ulica
            // 
            this.tb_ulica.Location = new System.Drawing.Point(458, 297);
            this.tb_ulica.Margin = new System.Windows.Forms.Padding(10);
            this.tb_ulica.Name = "tb_ulica";
            this.tb_ulica.Size = new System.Drawing.Size(472, 20);
            this.tb_ulica.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(279, 298);
            this.label5.Margin = new System.Windows.Forms.Padding(10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "Ulica i numer budynku";
            // 
            // tb_kod_pocztowy
            // 
            this.tb_kod_pocztowy.Location = new System.Drawing.Point(458, 257);
            this.tb_kod_pocztowy.Margin = new System.Windows.Forms.Padding(10);
            this.tb_kod_pocztowy.MaxLength = 6;
            this.tb_kod_pocztowy.Name = "tb_kod_pocztowy";
            this.tb_kod_pocztowy.Size = new System.Drawing.Size(115, 20);
            this.tb_kod_pocztowy.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(335, 256);
            this.label4.Margin = new System.Windows.Forms.Padding(10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 19);
            this.label4.TabIndex = 30;
            this.label4.Text = "Kod Pocztowy";
            // 
            // tb_miejscowosc
            // 
            this.tb_miejscowosc.Location = new System.Drawing.Point(458, 217);
            this.tb_miejscowosc.Margin = new System.Windows.Forms.Padding(10);
            this.tb_miejscowosc.Name = "tb_miejscowosc";
            this.tb_miejscowosc.Size = new System.Drawing.Size(472, 20);
            this.tb_miejscowosc.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(343, 218);
            this.label3.Margin = new System.Windows.Forms.Padding(10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 29;
            this.label3.Text = "Miejscowosc";
            // 
            // tb_nip
            // 
            this.tb_nip.Location = new System.Drawing.Point(458, 177);
            this.tb_nip.Margin = new System.Windows.Forms.Padding(10);
            this.tb_nip.Name = "tb_nip";
            this.tb_nip.Size = new System.Drawing.Size(472, 20);
            this.tb_nip.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(401, 179);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "NIP";
            // 
            // tb_nazwa_firmy
            // 
            this.tb_nazwa_firmy.Location = new System.Drawing.Point(458, 137);
            this.tb_nazwa_firmy.Margin = new System.Windows.Forms.Padding(10);
            this.tb_nazwa_firmy.Name = "tb_nazwa_firmy";
            this.tb_nazwa_firmy.Size = new System.Drawing.Size(472, 20);
            this.tb_nazwa_firmy.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(341, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 32;
            this.label1.Text = "Nazwa Firmy";
            // 
            // Frm_Klienci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 636);
            this.ControlBox = false;
            this.Controls.Add(this.panel_klienci);
            this.Controls.Add(this.panel_aktualizuj_klienta);
            this.Controls.Add(this.dgv_klienci);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Klienci";
            this.ShowIcon = false;
            this.Text = "Frm_Klienci";
            this.Load += new System.EventHandler(this.Frm_Klienci_Load);
            this.panel_klienci.ResumeLayout(false);
            this.panel_klienci.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_klienci)).EndInit();
            this.panel_aktualizuj_klienta.ResumeLayout(false);
            this.panel_aktualizuj_klienta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_klienci;
        private System.Windows.Forms.DataGridView dgv_klienci;
        private System.Windows.Forms.TextBox txt_szukaj;
        private System.Windows.Forms.Button btn_szukaj;
        private System.Windows.Forms.Button btn_aktualizuj_dane;
        private System.Windows.Forms.Button btn_usun_klienta;
        private System.Windows.Forms.Button btn_dodaj_klienta;
        private System.Windows.Forms.Panel panel_aktualizuj_klienta;
        private System.Windows.Forms.Button btn_dodaj_klienta_2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox tb_ulica;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tb_kod_pocztowy;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tb_miejscowosc;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tb_nip;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tb_nazwa_firmy;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tb_email;
        public System.Windows.Forms.TextBox tb_nr_tel;
        private System.Windows.Forms.Button btn_aktualizuj_klienta;
    }
}