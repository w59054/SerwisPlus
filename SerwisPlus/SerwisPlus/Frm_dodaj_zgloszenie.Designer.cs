
namespace SerwisPlus
{
    partial class Frm_dodaj_zgloszenie
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
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_opis = new System.Windows.Forms.TextBox();
            this.dtp_data = new System.Windows.Forms.DateTimePicker();
            this.cb_typ_zgloszenia = new System.Windows.Forms.ComboBox();
            this.btn_dodaj_nowe_zgloszenie = new System.Windows.Forms.Button();
            this.cb_klienci = new System.Windows.Forms.ComboBox();
            this.tbklienciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serwis_plus_DBDataSet = new SerwisPlus.Serwis_plus_DBDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_id_klienta = new System.Windows.Forms.Label();
            this.tb_klienciTableAdapter = new SerwisPlus.Serwis_plus_DBDataSetTableAdapters.tb_klienciTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbklienciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serwis_plus_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(266, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wybierz klienta :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(274, 264);
            this.label6.Margin = new System.Windows.Forms.Padding(10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Typ zgłoszenia :";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(266, 304);
            this.label7.Margin = new System.Windows.Forms.Padding(10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Data zgłoszenia :";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(339, 343);
            this.label8.Margin = new System.Windows.Forms.Padding(10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Opis :";
            // 
            // tb_opis
            // 
            this.tb_opis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_opis.Location = new System.Drawing.Point(439, 343);
            this.tb_opis.Margin = new System.Windows.Forms.Padding(10);
            this.tb_opis.Multiline = true;
            this.tb_opis.Name = "tb_opis";
            this.tb_opis.Size = new System.Drawing.Size(472, 113);
            this.tb_opis.TabIndex = 8;
            // 
            // dtp_data
            // 
            this.dtp_data.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_data.CustomFormat = "yyyyMMdd";
            this.dtp_data.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtp_data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_data.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.dtp_data.Location = new System.Drawing.Point(439, 309);
            this.dtp_data.Margin = new System.Windows.Forms.Padding(10);
            this.dtp_data.Name = "dtp_data";
            this.dtp_data.Size = new System.Drawing.Size(200, 22);
            this.dtp_data.TabIndex = 7;
            this.dtp_data.Value = new System.DateTime(2022, 11, 28, 0, 0, 0, 0);
            // 
            // cb_typ_zgloszenia
            // 
            this.cb_typ_zgloszenia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_typ_zgloszenia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_typ_zgloszenia.FormattingEnabled = true;
            this.cb_typ_zgloszenia.Items.AddRange(new object[] {
            "Serwis Gwarancyjny",
            "Serwis Pogwarancyjny",
            "Przegląd Gwarancyjny",
            "Usługa"});
            this.cb_typ_zgloszenia.Location = new System.Drawing.Point(439, 262);
            this.cb_typ_zgloszenia.Margin = new System.Windows.Forms.Padding(10);
            this.cb_typ_zgloszenia.Name = "cb_typ_zgloszenia";
            this.cb_typ_zgloszenia.Size = new System.Drawing.Size(472, 21);
            this.cb_typ_zgloszenia.TabIndex = 6;
            // 
            // btn_dodaj_nowe_zgloszenie
            // 
            this.btn_dodaj_nowe_zgloszenie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_dodaj_nowe_zgloszenie.Location = new System.Drawing.Point(759, 489);
            this.btn_dodaj_nowe_zgloszenie.Name = "btn_dodaj_nowe_zgloszenie";
            this.btn_dodaj_nowe_zgloszenie.Size = new System.Drawing.Size(152, 39);
            this.btn_dodaj_nowe_zgloszenie.TabIndex = 9;
            this.btn_dodaj_nowe_zgloszenie.Text = "Daj nowe zgłoszenie";
            this.btn_dodaj_nowe_zgloszenie.UseVisualStyleBackColor = true;
            this.btn_dodaj_nowe_zgloszenie.Click += new System.EventHandler(this.btn_dodaj_nowe_zgloszenie_Click);
            // 
            // cb_klienci
            // 
            this.cb_klienci.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_klienci.DataSource = this.tbklienciBindingSource;
            this.cb_klienci.DisplayMember = "Nazwa_firmy";
            this.cb_klienci.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_klienci.FormattingEnabled = true;
            this.cb_klienci.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cb_klienci.Location = new System.Drawing.Point(439, 124);
            this.cb_klienci.Margin = new System.Windows.Forms.Padding(10);
            this.cb_klienci.Name = "cb_klienci";
            this.cb_klienci.Size = new System.Drawing.Size(472, 21);
            this.cb_klienci.TabIndex = 10;
            this.cb_klienci.ValueMember = "Id";
            // 
            // tbklienciBindingSource
            // 
            this.tbklienciBindingSource.DataMember = "tb_klienci";
            this.tbklienciBindingSource.DataSource = this.serwis_plus_DBDataSet;
            // 
            // serwis_plus_DBDataSet
            // 
            this.serwis_plus_DBDataSet.DataSetName = "Serwis_plus_DBDataSet";
            this.serwis_plus_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(306, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Id klienta :";
            // 
            // lb_id_klienta
            // 
            this.lb_id_klienta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_id_klienta.AutoSize = true;
            this.lb_id_klienta.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbklienciBindingSource, "Id", true));
            this.lb_id_klienta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_id_klienta.Location = new System.Drawing.Point(435, 165);
            this.lb_id_klienta.Margin = new System.Windows.Forms.Padding(10);
            this.lb_id_klienta.Name = "lb_id_klienta";
            this.lb_id_klienta.Size = new System.Drawing.Size(73, 19);
            this.lb_id_klienta.TabIndex = 12;
            this.lb_id_klienta.Text = "Id klienta";
            // 
            // tb_klienciTableAdapter
            // 
            this.tb_klienciTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_dodaj_zgloszenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1228, 727);
            this.ControlBox = false;
            this.Controls.Add(this.lb_id_klienta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_klienci);
            this.Controls.Add(this.btn_dodaj_nowe_zgloszenie);
            this.Controls.Add(this.cb_typ_zgloszenia);
            this.Controls.Add(this.dtp_data);
            this.Controls.Add(this.tb_opis);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_dodaj_zgloszenie";
            this.Text = "Zgloszenie dodaj";
            this.Load += new System.EventHandler(this.Frm_dodaj_zgloszenie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbklienciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serwis_plus_DBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_opis;
        private System.Windows.Forms.DateTimePicker dtp_data;
        private System.Windows.Forms.ComboBox cb_typ_zgloszenia;
        private System.Windows.Forms.Button btn_dodaj_nowe_zgloszenie;
        private System.Windows.Forms.ComboBox cb_klienci;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_id_klienta;
        private Serwis_plus_DBDataSet serwis_plus_DBDataSet;
        private System.Windows.Forms.BindingSource tbklienciBindingSource;
        private Serwis_plus_DBDataSetTableAdapters.tb_klienciTableAdapter tb_klienciTableAdapter;
    }
}