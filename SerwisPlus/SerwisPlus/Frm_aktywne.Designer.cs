
namespace SerwisPlus
{
    partial class Frm_aktywne 
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_aktywne1 = new System.Windows.Forms.DataGridView();
            this.panel_aktywne = new System.Windows.Forms.Panel();
            this.btn_pokaz_na_mapie = new System.Windows.Forms.Button();
            this.btn_podglad_wydruku = new System.Windows.Forms.Button();
            this.txt_szukaj = new System.Windows.Forms.TextBox();
            this.btn_szukaj = new System.Windows.Forms.Button();
            this.btn_aktualizuj_dane = new System.Windows.Forms.Button();
            this.btn_usun_zgloszenie = new System.Windows.Forms.Button();
            this.btn_ukoncz_zgloszenie = new System.Windows.Forms.Button();
            this.panel_aktualizuj = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.tbserwisanciBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.serwis_plus_DBDataSet1 = new SerwisPlus.Serwis_plus_DBDataSet1();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_id_serwisant = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_serwisant = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
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
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.tbserwisanciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_serwisanciTableAdapter = new SerwisPlus.Serwis_plus_DBDataSet1TableAdapters.tb_serwisanciTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_aktywne1)).BeginInit();
            this.panel_aktywne.SuspendLayout();
            this.panel_aktualizuj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbserwisanciBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serwis_plus_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbserwisanciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_aktywne1
            // 
            this.dgv_aktywne1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_aktywne1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_aktywne1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_aktywne1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_aktywne1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_aktywne1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_aktywne1.Location = new System.Drawing.Point(0, 0);
            this.dgv_aktywne1.MultiSelect = false;
            this.dgv_aktywne1.Name = "dgv_aktywne1";
            this.dgv_aktywne1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv_aktywne1.RowHeadersWidth = 30;
            this.dgv_aktywne1.RowTemplate.Height = 30;
            this.dgv_aktywne1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_aktywne1.Size = new System.Drawing.Size(1228, 636);
            this.dgv_aktywne1.TabIndex = 0;
            this.dgv_aktywne1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_aktywne1_CellContentClick);
            // 
            // panel_aktywne
            // 
            this.panel_aktywne.BackColor = System.Drawing.Color.White;
            this.panel_aktywne.Controls.Add(this.btn_pokaz_na_mapie);
            this.panel_aktywne.Controls.Add(this.btn_podglad_wydruku);
            this.panel_aktywne.Controls.Add(this.txt_szukaj);
            this.panel_aktywne.Controls.Add(this.btn_szukaj);
            this.panel_aktywne.Controls.Add(this.btn_aktualizuj_dane);
            this.panel_aktywne.Controls.Add(this.btn_usun_zgloszenie);
            this.panel_aktywne.Controls.Add(this.btn_ukoncz_zgloszenie);
            this.panel_aktywne.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_aktywne.Location = new System.Drawing.Point(0, 0);
            this.panel_aktywne.Name = "panel_aktywne";
            this.panel_aktywne.Size = new System.Drawing.Size(1228, 64);
            this.panel_aktywne.TabIndex = 1;
            // 
            // btn_pokaz_na_mapie
            // 
            this.btn_pokaz_na_mapie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_pokaz_na_mapie.Location = new System.Drawing.Point(684, 5);
            this.btn_pokaz_na_mapie.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_pokaz_na_mapie.Name = "btn_pokaz_na_mapie";
            this.btn_pokaz_na_mapie.Size = new System.Drawing.Size(100, 45);
            this.btn_pokaz_na_mapie.TabIndex = 8;
            this.btn_pokaz_na_mapie.Text = "Pokaż na mapie";
            this.btn_pokaz_na_mapie.UseVisualStyleBackColor = true;
            this.btn_pokaz_na_mapie.Click += new System.EventHandler(this.btn_pokaz_na_mapie_Click);
            // 
            // btn_podglad_wydruku
            // 
            this.btn_podglad_wydruku.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_podglad_wydruku.Location = new System.Drawing.Point(904, 5);
            this.btn_podglad_wydruku.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_podglad_wydruku.Name = "btn_podglad_wydruku";
            this.btn_podglad_wydruku.Size = new System.Drawing.Size(100, 45);
            this.btn_podglad_wydruku.TabIndex = 7;
            this.btn_podglad_wydruku.Text = "Podgląd Zgłoszenia";
            this.btn_podglad_wydruku.UseVisualStyleBackColor = true;
            this.btn_podglad_wydruku.Click += new System.EventHandler(this.btn_podglad_wydruku_Click);
            // 
            // txt_szukaj
            // 
            this.txt_szukaj.Location = new System.Drawing.Point(12, 17);
            this.txt_szukaj.Name = "txt_szukaj";
            this.txt_szukaj.Size = new System.Drawing.Size(307, 20);
            this.txt_szukaj.TabIndex = 6;
            this.txt_szukaj.Text = "Wpisz nazwę firmy do wyszukania";
            this.txt_szukaj.Enter += new System.EventHandler(this.txt_szukaj_Enter);
            this.txt_szukaj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_szukaj_KeyPress);
            // 
            // btn_szukaj
            // 
            this.btn_szukaj.Location = new System.Drawing.Point(332, 4);
            this.btn_szukaj.Margin = new System.Windows.Forms.Padding(10, 3, 5, 3);
            this.btn_szukaj.Name = "btn_szukaj";
            this.btn_szukaj.Size = new System.Drawing.Size(80, 45);
            this.btn_szukaj.TabIndex = 5;
            this.btn_szukaj.Text = "Szukaj";
            this.btn_szukaj.UseVisualStyleBackColor = true;
            this.btn_szukaj.Click += new System.EventHandler(this.btn_szukaj_Click);
            // 
            // btn_aktualizuj_dane
            // 
            this.btn_aktualizuj_dane.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_aktualizuj_dane.Location = new System.Drawing.Point(794, 5);
            this.btn_aktualizuj_dane.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_aktualizuj_dane.Name = "btn_aktualizuj_dane";
            this.btn_aktualizuj_dane.Size = new System.Drawing.Size(100, 45);
            this.btn_aktualizuj_dane.TabIndex = 4;
            this.btn_aktualizuj_dane.Text = "Aktualizuj zgłoszenie";
            this.btn_aktualizuj_dane.UseVisualStyleBackColor = true;
            this.btn_aktualizuj_dane.Click += new System.EventHandler(this.btn_aktualizuj_dane_Click);
            // 
            // btn_usun_zgloszenie
            // 
            this.btn_usun_zgloszenie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_usun_zgloszenie.Location = new System.Drawing.Point(1124, 5);
            this.btn_usun_zgloszenie.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_usun_zgloszenie.Name = "btn_usun_zgloszenie";
            this.btn_usun_zgloszenie.Size = new System.Drawing.Size(100, 45);
            this.btn_usun_zgloszenie.TabIndex = 3;
            this.btn_usun_zgloszenie.Text = "Usuń zgłoszenie";
            this.btn_usun_zgloszenie.UseVisualStyleBackColor = true;
            this.btn_usun_zgloszenie.Click += new System.EventHandler(this.btn_usun_zgloszenie_Click);
            // 
            // btn_ukoncz_zgloszenie
            // 
            this.btn_ukoncz_zgloszenie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ukoncz_zgloszenie.Location = new System.Drawing.Point(1014, 5);
            this.btn_ukoncz_zgloszenie.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_ukoncz_zgloszenie.Name = "btn_ukoncz_zgloszenie";
            this.btn_ukoncz_zgloszenie.Size = new System.Drawing.Size(100, 45);
            this.btn_ukoncz_zgloszenie.TabIndex = 2;
            this.btn_ukoncz_zgloszenie.Text = "Ukończ zgłoszenie";
            this.btn_ukoncz_zgloszenie.UseVisualStyleBackColor = true;
            this.btn_ukoncz_zgloszenie.Click += new System.EventHandler(this.btn_ukoncz_zgloszenie_Click);
            // 
            // panel_aktualizuj
            // 
            this.panel_aktualizuj.Controls.Add(this.label13);
            this.panel_aktualizuj.Controls.Add(this.label12);
            this.panel_aktualizuj.Controls.Add(this.lbl_id_serwisant);
            this.panel_aktualizuj.Controls.Add(this.label11);
            this.panel_aktualizuj.Controls.Add(this.cb_serwisant);
            this.panel_aktualizuj.Controls.Add(this.label10);
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
            this.panel_aktualizuj.Size = new System.Drawing.Size(1228, 636);
            this.panel_aktualizuj.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbserwisanciBindingSource1, "Imie_Serwisanta", true));
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(701, 365);
            this.label13.Margin = new System.Windows.Forms.Padding(10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 19);
            this.label13.TabIndex = 34;
            this.label13.Text = "?";
            // 
            // tbserwisanciBindingSource1
            // 
            this.tbserwisanciBindingSource1.DataMember = "tb_serwisanci";
            this.tbserwisanciBindingSource1.DataSource = this.serwis_plus_DBDataSet1;
            // 
            // serwis_plus_DBDataSet1
            // 
            this.serwis_plus_DBDataSet1.DataSetName = "Serwis_plus_DBDataSet1";
            this.serwis_plus_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(660, 365);
            this.label12.Margin = new System.Windows.Forms.Padding(10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 19);
            this.label12.TabIndex = 33;
            this.label12.Text = "Imie:";
            // 
            // lbl_id_serwisant
            // 
            this.lbl_id_serwisant.AutoSize = true;
            this.lbl_id_serwisant.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbserwisanciBindingSource1, "Id", true));
            this.lbl_id_serwisant.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_id_serwisant.Location = new System.Drawing.Point(883, 365);
            this.lbl_id_serwisant.Margin = new System.Windows.Forms.Padding(10);
            this.lbl_id_serwisant.Name = "lbl_id_serwisant";
            this.lbl_id_serwisant.Size = new System.Drawing.Size(17, 19);
            this.lbl_id_serwisant.TabIndex = 32;
            this.lbl_id_serwisant.Text = "?";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(849, 365);
            this.label11.Margin = new System.Windows.Forms.Padding(10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 19);
            this.label11.TabIndex = 31;
            this.label11.Text = "ID:";
            // 
            // cb_serwisant
            // 
            this.cb_serwisant.DataSource = this.tbserwisanciBindingSource1;
            this.cb_serwisant.DisplayMember = "Nazwisko_Serwisanta";
            this.cb_serwisant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_serwisant.FormattingEnabled = true;
            this.cb_serwisant.Location = new System.Drawing.Point(451, 365);
            this.cb_serwisant.Margin = new System.Windows.Forms.Padding(10);
            this.cb_serwisant.Name = "cb_serwisant";
            this.cb_serwisant.Size = new System.Drawing.Size(189, 21);
            this.cb_serwisant.TabIndex = 30;
            this.cb_serwisant.ValueMember = "Id";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(290, 365);
            this.label10.Margin = new System.Windows.Forms.Padding(10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 19);
            this.label10.TabIndex = 29;
            this.label10.Text = "Przypisany serwisant";
            // 
            // tb_ulica
            // 
            this.tb_ulica.Location = new System.Drawing.Point(451, 243);
            this.tb_ulica.Margin = new System.Windows.Forms.Padding(10);
            this.tb_ulica.Name = "tb_ulica";
            this.tb_ulica.Size = new System.Drawing.Size(472, 20);
            this.tb_ulica.TabIndex = 28;
            this.tb_ulica.Text = " ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(280, 242);
            this.label9.Margin = new System.Windows.Forms.Padding(10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 19);
            this.label9.TabIndex = 27;
            this.label9.Text = "Ulica i numer budynku";
            // 
            // btn_aktualizuj
            // 
            this.btn_aktualizuj.Location = new System.Drawing.Point(771, 566);
            this.btn_aktualizuj.Name = "btn_aktualizuj";
            this.btn_aktualizuj.Size = new System.Drawing.Size(152, 39);
            this.btn_aktualizuj.TabIndex = 26;
            this.btn_aktualizuj.Text = "Aktualizuj dane";
            this.btn_aktualizuj.UseVisualStyleBackColor = true;
            this.btn_aktualizuj.Click += new System.EventHandler(this.btn_aktualizuj_Click);
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
            this.cb_typ_zgloszenia.Location = new System.Drawing.Point(451, 327);
            this.cb_typ_zgloszenia.Margin = new System.Windows.Forms.Padding(10);
            this.cb_typ_zgloszenia.Name = "cb_typ_zgloszenia";
            this.cb_typ_zgloszenia.Size = new System.Drawing.Size(472, 21);
            this.cb_typ_zgloszenia.TabIndex = 23;
            // 
            // dtp_data
            // 
            this.dtp_data.CustomFormat = "yyyyMMdd";
            this.dtp_data.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtp_data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_data.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.dtp_data.Location = new System.Drawing.Point(451, 400);
            this.dtp_data.Margin = new System.Windows.Forms.Padding(10);
            this.dtp_data.Name = "dtp_data";
            this.dtp_data.Size = new System.Drawing.Size(200, 22);
            this.dtp_data.TabIndex = 24;
            this.dtp_data.Value = new System.DateTime(2022, 11, 28, 0, 0, 0, 0);
            // 
            // tb_opis
            // 
            this.tb_opis.Location = new System.Drawing.Point(451, 440);
            this.tb_opis.Margin = new System.Windows.Forms.Padding(10);
            this.tb_opis.Multiline = true;
            this.tb_opis.Name = "tb_opis";
            this.tb_opis.Size = new System.Drawing.Size(472, 113);
            this.tb_opis.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(384, 440);
            this.label8.Margin = new System.Windows.Forms.Padding(10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Opis";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(311, 400);
            this.label7.Margin = new System.Windows.Forms.Padding(10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Data zgłoszenia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(326, 326);
            this.label6.Margin = new System.Windows.Forms.Padding(10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Typ zgłoszenia";
            // 
            // tb_tel_nr
            // 
            this.tb_tel_nr.Location = new System.Drawing.Point(451, 284);
            this.tb_tel_nr.Margin = new System.Windows.Forms.Padding(10);
            this.tb_tel_nr.Name = "tb_tel_nr";
            this.tb_tel_nr.Size = new System.Drawing.Size(472, 20);
            this.tb_tel_nr.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(314, 285);
            this.label5.Margin = new System.Windows.Forms.Padding(10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Numer Telefonu";
            // 
            // tb_kod_pocztowy
            // 
            this.tb_kod_pocztowy.Location = new System.Drawing.Point(451, 204);
            this.tb_kod_pocztowy.Margin = new System.Windows.Forms.Padding(10);
            this.tb_kod_pocztowy.Name = "tb_kod_pocztowy";
            this.tb_kod_pocztowy.Size = new System.Drawing.Size(115, 20);
            this.tb_kod_pocztowy.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(336, 205);
            this.label4.Margin = new System.Windows.Forms.Padding(10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Kod Pocztowy";
            // 
            // tb_miejscowosc
            // 
            this.tb_miejscowosc.Location = new System.Drawing.Point(451, 164);
            this.tb_miejscowosc.Margin = new System.Windows.Forms.Padding(10);
            this.tb_miejscowosc.Name = "tb_miejscowosc";
            this.tb_miejscowosc.Size = new System.Drawing.Size(472, 20);
            this.tb_miejscowosc.TabIndex = 20;
            this.tb_miejscowosc.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(336, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Miejscowosc";
            // 
            // tb_nip
            // 
            this.tb_nip.Location = new System.Drawing.Point(451, 124);
            this.tb_nip.Margin = new System.Windows.Forms.Padding(10);
            this.tb_nip.Name = "tb_nip";
            this.tb_nip.Size = new System.Drawing.Size(472, 20);
            this.tb_nip.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(395, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "NIP";
            // 
            // tb_nazwa_firmy
            // 
            this.tb_nazwa_firmy.Location = new System.Drawing.Point(451, 84);
            this.tb_nazwa_firmy.Margin = new System.Windows.Forms.Padding(10);
            this.tb_nazwa_firmy.Name = "tb_nazwa_firmy";
            this.tb_nazwa_firmy.Size = new System.Drawing.Size(472, 20);
            this.tb_nazwa_firmy.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(336, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nazwa Firmy";
            // 
            // webBrowser2
            // 
            this.webBrowser2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser2.Location = new System.Drawing.Point(0, 0);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(1228, 636);
            this.webBrowser2.TabIndex = 3;
            // 
            // tbserwisanciBindingSource
            // 
            this.tbserwisanciBindingSource.DataMember = "tb_serwisanci";
            this.tbserwisanciBindingSource.DataSource = this.serwis_plus_DBDataSet1;
            // 
            // tb_serwisanciTableAdapter
            // 
            this.tb_serwisanciTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_aktywne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 636);
            this.Controls.Add(this.panel_aktywne);
            this.Controls.Add(this.panel_aktualizuj);
            this.Controls.Add(this.webBrowser2);
            this.Controls.Add(this.dgv_aktywne1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_aktywne";
            this.Text = "Akywne";
            this.Load += new System.EventHandler(this.Frm_aktywne_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_aktywne1)).EndInit();
            this.panel_aktywne.ResumeLayout(false);
            this.panel_aktywne.PerformLayout();
            this.panel_aktualizuj.ResumeLayout(false);
            this.panel_aktualizuj.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbserwisanciBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serwis_plus_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbserwisanciBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_aktywne;
        private System.Windows.Forms.DataGridView dgv_aktywne1;
        private System.Windows.Forms.Button btn_usun_zgloszenie;
        private System.Windows.Forms.Button btn_ukoncz_zgloszenie;
        private System.Windows.Forms.TextBox txt_szukaj;
        private System.Windows.Forms.Button btn_szukaj;
        private System.Windows.Forms.Button btn_aktualizuj_dane;
        private System.Windows.Forms.Button btn_podglad_wydruku;
        private System.Windows.Forms.Panel panel_aktualizuj;
        private System.Windows.Forms.Button btn_aktualizuj;
        private System.Windows.Forms.ComboBox cb_typ_zgloszenia;
        private System.Windows.Forms.DateTimePicker dtp_data;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox tb_opis;
        private System.Windows.Forms.Button btn_pokaz_na_mapie;
        private System.Windows.Forms.WebBrowser webBrowser2;
        public System.Windows.Forms.TextBox tb_ulica;
        private System.Windows.Forms.Label label9;
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
        private System.Windows.Forms.Label lbl_id_serwisant;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cb_serwisant;
        private System.Windows.Forms.Label label10;
        private Serwis_plus_DBDataSet1 serwis_plus_DBDataSet1;
        private System.Windows.Forms.BindingSource tbserwisanciBindingSource;
        private Serwis_plus_DBDataSet1TableAdapters.tb_serwisanciTableAdapter tb_serwisanciTableAdapter;
        private System.Windows.Forms.BindingSource tbserwisanciBindingSource1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}