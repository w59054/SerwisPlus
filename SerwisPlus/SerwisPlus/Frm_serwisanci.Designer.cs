
namespace SerwisPlus
{
    partial class Frm_serwisanci
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
            this.dgv_serwisanci = new System.Windows.Forms.DataGridView();
            this.panel_serwisanci = new System.Windows.Forms.Panel();
            this.btn_dodaj_serwisanta = new System.Windows.Forms.Button();
            this.btn_aktualizuj_dane_serwisanta = new System.Windows.Forms.Button();
            this.btn_usun_serwisanta = new System.Windows.Forms.Button();
            this.panel_dodaj_aktualizuj_serwisanta = new System.Windows.Forms.Panel();
            this.tb_email_serwisanta = new System.Windows.Forms.TextBox();
            this.tb_nr_tel_serwisanta = new System.Windows.Forms.TextBox();
            this.btn_aktualizuj_serwisanta = new System.Windows.Forms.Button();
            this.btn_dodaj_serwisanta2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_Nazwisko_serwisanta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_imie_serwisanta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_serwisanci)).BeginInit();
            this.panel_serwisanci.SuspendLayout();
            this.panel_dodaj_aktualizuj_serwisanta.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_serwisanci
            // 
            this.dgv_serwisanci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_serwisanci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_serwisanci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_serwisanci.Location = new System.Drawing.Point(0, 0);
            this.dgv_serwisanci.Name = "dgv_serwisanci";
            this.dgv_serwisanci.Size = new System.Drawing.Size(1212, 597);
            this.dgv_serwisanci.TabIndex = 0;
            // 
            // panel_serwisanci
            // 
            this.panel_serwisanci.BackColor = System.Drawing.Color.White;
            this.panel_serwisanci.Controls.Add(this.btn_dodaj_serwisanta);
            this.panel_serwisanci.Controls.Add(this.btn_aktualizuj_dane_serwisanta);
            this.panel_serwisanci.Controls.Add(this.btn_usun_serwisanta);
            this.panel_serwisanci.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_serwisanci.Location = new System.Drawing.Point(0, 0);
            this.panel_serwisanci.Name = "panel_serwisanci";
            this.panel_serwisanci.Size = new System.Drawing.Size(1212, 60);
            this.panel_serwisanci.TabIndex = 1;
            // 
            // btn_dodaj_serwisanta
            // 
            this.btn_dodaj_serwisanta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_dodaj_serwisanta.Location = new System.Drawing.Point(878, 3);
            this.btn_dodaj_serwisanta.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_dodaj_serwisanta.Name = "btn_dodaj_serwisanta";
            this.btn_dodaj_serwisanta.Size = new System.Drawing.Size(100, 45);
            this.btn_dodaj_serwisanta.TabIndex = 15;
            this.btn_dodaj_serwisanta.Text = "Dodaj serwisanta";
            this.btn_dodaj_serwisanta.UseVisualStyleBackColor = true;
            this.btn_dodaj_serwisanta.Click += new System.EventHandler(this.btn_dodaj_serwisanta_Click);
            // 
            // btn_aktualizuj_dane_serwisanta
            // 
            this.btn_aktualizuj_dane_serwisanta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_aktualizuj_dane_serwisanta.Location = new System.Drawing.Point(988, 3);
            this.btn_aktualizuj_dane_serwisanta.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_aktualizuj_dane_serwisanta.Name = "btn_aktualizuj_dane_serwisanta";
            this.btn_aktualizuj_dane_serwisanta.Size = new System.Drawing.Size(100, 45);
            this.btn_aktualizuj_dane_serwisanta.TabIndex = 14;
            this.btn_aktualizuj_dane_serwisanta.Text = "Aktualizuj dane";
            this.btn_aktualizuj_dane_serwisanta.UseVisualStyleBackColor = true;
            this.btn_aktualizuj_dane_serwisanta.Click += new System.EventHandler(this.btn_aktualizuj_dane_serwisanta_Click);
            // 
            // btn_usun_serwisanta
            // 
            this.btn_usun_serwisanta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_usun_serwisanta.Location = new System.Drawing.Point(1098, 3);
            this.btn_usun_serwisanta.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_usun_serwisanta.Name = "btn_usun_serwisanta";
            this.btn_usun_serwisanta.Size = new System.Drawing.Size(100, 45);
            this.btn_usun_serwisanta.TabIndex = 13;
            this.btn_usun_serwisanta.Text = "Usuń serwisanta";
            this.btn_usun_serwisanta.UseVisualStyleBackColor = true;
            this.btn_usun_serwisanta.Click += new System.EventHandler(this.btn_usun_serwisanta_Click);
            // 
            // panel_dodaj_aktualizuj_serwisanta
            // 
            this.panel_dodaj_aktualizuj_serwisanta.Controls.Add(this.tb_email_serwisanta);
            this.panel_dodaj_aktualizuj_serwisanta.Controls.Add(this.tb_nr_tel_serwisanta);
            this.panel_dodaj_aktualizuj_serwisanta.Controls.Add(this.btn_aktualizuj_serwisanta);
            this.panel_dodaj_aktualizuj_serwisanta.Controls.Add(this.btn_dodaj_serwisanta2);
            this.panel_dodaj_aktualizuj_serwisanta.Controls.Add(this.label7);
            this.panel_dodaj_aktualizuj_serwisanta.Controls.Add(this.label6);
            this.panel_dodaj_aktualizuj_serwisanta.Controls.Add(this.tb_Nazwisko_serwisanta);
            this.panel_dodaj_aktualizuj_serwisanta.Controls.Add(this.label2);
            this.panel_dodaj_aktualizuj_serwisanta.Controls.Add(this.tb_imie_serwisanta);
            this.panel_dodaj_aktualizuj_serwisanta.Controls.Add(this.label1);
            this.panel_dodaj_aktualizuj_serwisanta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_dodaj_aktualizuj_serwisanta.Location = new System.Drawing.Point(0, 60);
            this.panel_dodaj_aktualizuj_serwisanta.Name = "panel_dodaj_aktualizuj_serwisanta";
            this.panel_dodaj_aktualizuj_serwisanta.Size = new System.Drawing.Size(1212, 537);
            this.panel_dodaj_aktualizuj_serwisanta.TabIndex = 2;
            // 
            // tb_email_serwisanta
            // 
            this.tb_email_serwisanta.Location = new System.Drawing.Point(460, 196);
            this.tb_email_serwisanta.Margin = new System.Windows.Forms.Padding(10);
            this.tb_email_serwisanta.Name = "tb_email_serwisanta";
            this.tb_email_serwisanta.Size = new System.Drawing.Size(472, 20);
            this.tb_email_serwisanta.TabIndex = 59;
            // 
            // tb_nr_tel_serwisanta
            // 
            this.tb_nr_tel_serwisanta.Location = new System.Drawing.Point(460, 158);
            this.tb_nr_tel_serwisanta.Margin = new System.Windows.Forms.Padding(10);
            this.tb_nr_tel_serwisanta.MaxLength = 15;
            this.tb_nr_tel_serwisanta.Name = "tb_nr_tel_serwisanta";
            this.tb_nr_tel_serwisanta.Size = new System.Drawing.Size(472, 20);
            this.tb_nr_tel_serwisanta.TabIndex = 60;
            // 
            // btn_aktualizuj_serwisanta
            // 
            this.btn_aktualizuj_serwisanta.Location = new System.Drawing.Point(609, 420);
            this.btn_aktualizuj_serwisanta.Name = "btn_aktualizuj_serwisanta";
            this.btn_aktualizuj_serwisanta.Size = new System.Drawing.Size(152, 39);
            this.btn_aktualizuj_serwisanta.TabIndex = 57;
            this.btn_aktualizuj_serwisanta.Text = "Aktualizuj dane";
            this.btn_aktualizuj_serwisanta.UseVisualStyleBackColor = true;
            this.btn_aktualizuj_serwisanta.Click += new System.EventHandler(this.btn_aktualizuj_serwisanta_Click);
            // 
            // btn_dodaj_serwisanta2
            // 
            this.btn_dodaj_serwisanta2.Location = new System.Drawing.Point(779, 420);
            this.btn_dodaj_serwisanta2.Name = "btn_dodaj_serwisanta2";
            this.btn_dodaj_serwisanta2.Size = new System.Drawing.Size(152, 39);
            this.btn_dodaj_serwisanta2.TabIndex = 58;
            this.btn_dodaj_serwisanta2.Text = "Dodaj serwisanta";
            this.btn_dodaj_serwisanta2.UseVisualStyleBackColor = true;
            this.btn_dodaj_serwisanta2.Click += new System.EventHandler(this.btn_dodaj_serwisanta2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(387, 195);
            this.label7.Margin = new System.Windows.Forms.Padding(10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 19);
            this.label7.TabIndex = 51;
            this.label7.Text = "E-mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(326, 156);
            this.label6.Margin = new System.Windows.Forms.Padding(10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 19);
            this.label6.TabIndex = 49;
            this.label6.Text = "Numer telefonu";
            // 
            // tb_Nazwisko_serwisanta
            // 
            this.tb_Nazwisko_serwisanta.Location = new System.Drawing.Point(460, 118);
            this.tb_Nazwisko_serwisanta.Margin = new System.Windows.Forms.Padding(10);
            this.tb_Nazwisko_serwisanta.Name = "tb_Nazwisko_serwisanta";
            this.tb_Nazwisko_serwisanta.Size = new System.Drawing.Size(472, 20);
            this.tb_Nazwisko_serwisanta.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(366, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 46;
            this.label2.Text = "Nazwisko:";
            // 
            // tb_imie_serwisanta
            // 
            this.tb_imie_serwisanta.Location = new System.Drawing.Point(460, 78);
            this.tb_imie_serwisanta.Margin = new System.Windows.Forms.Padding(10);
            this.tb_imie_serwisanta.Name = "tb_imie_serwisanta";
            this.tb_imie_serwisanta.Size = new System.Drawing.Size(472, 20);
            this.tb_imie_serwisanta.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(400, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 50;
            this.label1.Text = "Imię:";
            // 
            // Frm_serwisanci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 597);
            this.Controls.Add(this.panel_dodaj_aktualizuj_serwisanta);
            this.Controls.Add(this.panel_serwisanci);
            this.Controls.Add(this.dgv_serwisanci);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_serwisanci";
            this.Text = "Frm_testowy";
            this.Load += new System.EventHandler(this.Frm_testowy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_serwisanci)).EndInit();
            this.panel_serwisanci.ResumeLayout(false);
            this.panel_dodaj_aktualizuj_serwisanta.ResumeLayout(false);
            this.panel_dodaj_aktualizuj_serwisanta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_serwisanci;
        private System.Windows.Forms.Panel panel_serwisanci;
        private System.Windows.Forms.Button btn_dodaj_serwisanta;
        private System.Windows.Forms.Button btn_aktualizuj_dane_serwisanta;
        private System.Windows.Forms.Button btn_usun_serwisanta;
        private System.Windows.Forms.Panel panel_dodaj_aktualizuj_serwisanta;
        public System.Windows.Forms.TextBox tb_email_serwisanta;
        public System.Windows.Forms.TextBox tb_nr_tel_serwisanta;
        private System.Windows.Forms.Button btn_aktualizuj_serwisanta;
        private System.Windows.Forms.Button btn_dodaj_serwisanta2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox tb_Nazwisko_serwisanta;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tb_imie_serwisanta;
        private System.Windows.Forms.Label label1;
    }
}