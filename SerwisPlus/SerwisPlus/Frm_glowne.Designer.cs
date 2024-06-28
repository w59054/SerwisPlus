
namespace SerwisPlus
{
    partial class Frm_glowne
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_glowne));
            this.title_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menu_panel = new System.Windows.Forms.Panel();
            this.btn_serwisanci = new System.Windows.Forms.Button();
            this.btn_klienci = new System.Windows.Forms.Button();
            this.btn_wyjscie = new System.Windows.Forms.Button();
            this.btn_historia = new System.Windows.Forms.Button();
            this.btn_aktywne = new System.Windows.Forms.Button();
            this.btn_dodaj_zgloszenie = new System.Windows.Forms.Button();
            this.main_panel = new System.Windows.Forms.Panel();
            this.title_panel.SuspendLayout();
            this.menu_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_panel
            // 
            this.title_panel.BackColor = System.Drawing.Color.LightSlateGray;
            this.title_panel.Controls.Add(this.label1);
            resources.ApplyResources(this.title_panel, "title_panel");
            this.title_panel.Name = "title_panel";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // menu_panel
            // 
            this.menu_panel.BackColor = System.Drawing.Color.LightSlateGray;
            this.menu_panel.Controls.Add(this.btn_serwisanci);
            this.menu_panel.Controls.Add(this.btn_klienci);
            this.menu_panel.Controls.Add(this.btn_wyjscie);
            this.menu_panel.Controls.Add(this.btn_historia);
            this.menu_panel.Controls.Add(this.btn_aktywne);
            this.menu_panel.Controls.Add(this.btn_dodaj_zgloszenie);
            resources.ApplyResources(this.menu_panel, "menu_panel");
            this.menu_panel.Name = "menu_panel";
            // 
            // btn_serwisanci
            // 
            this.btn_serwisanci.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_serwisanci.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btn_serwisanci.FlatAppearance.BorderSize = 2;
            resources.ApplyResources(this.btn_serwisanci, "btn_serwisanci");
            this.btn_serwisanci.ForeColor = System.Drawing.Color.White;
            this.btn_serwisanci.Name = "btn_serwisanci";
            this.btn_serwisanci.UseVisualStyleBackColor = false;
            this.btn_serwisanci.Click += new System.EventHandler(this.btn_serwisanci_Click);
            // 
            // btn_klienci
            // 
            this.btn_klienci.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_klienci.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btn_klienci.FlatAppearance.BorderSize = 2;
            resources.ApplyResources(this.btn_klienci, "btn_klienci");
            this.btn_klienci.ForeColor = System.Drawing.Color.White;
            this.btn_klienci.Name = "btn_klienci";
            this.btn_klienci.UseVisualStyleBackColor = false;
            this.btn_klienci.Click += new System.EventHandler(this.btn_klienci_Click);
            // 
            // btn_wyjscie
            // 
            resources.ApplyResources(this.btn_wyjscie, "btn_wyjscie");
            this.btn_wyjscie.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_wyjscie.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btn_wyjscie.FlatAppearance.BorderSize = 2;
            this.btn_wyjscie.ForeColor = System.Drawing.Color.White;
            this.btn_wyjscie.Name = "btn_wyjscie";
            this.btn_wyjscie.UseVisualStyleBackColor = false;
            this.btn_wyjscie.Click += new System.EventHandler(this.btn_wyjscie_Click);
            // 
            // btn_historia
            // 
            this.btn_historia.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_historia.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btn_historia.FlatAppearance.BorderSize = 2;
            resources.ApplyResources(this.btn_historia, "btn_historia");
            this.btn_historia.ForeColor = System.Drawing.Color.White;
            this.btn_historia.Name = "btn_historia";
            this.btn_historia.UseVisualStyleBackColor = false;
            this.btn_historia.Click += new System.EventHandler(this.btn_historia_Click);
            // 
            // btn_aktywne
            // 
            this.btn_aktywne.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_aktywne.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btn_aktywne.FlatAppearance.BorderSize = 2;
            resources.ApplyResources(this.btn_aktywne, "btn_aktywne");
            this.btn_aktywne.ForeColor = System.Drawing.Color.White;
            this.btn_aktywne.Name = "btn_aktywne";
            this.btn_aktywne.UseVisualStyleBackColor = false;
            this.btn_aktywne.Click += new System.EventHandler(this.btn_aktywne_Click);
            // 
            // btn_dodaj_zgloszenie
            // 
            this.btn_dodaj_zgloszenie.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_dodaj_zgloszenie.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btn_dodaj_zgloszenie.FlatAppearance.BorderSize = 2;
            resources.ApplyResources(this.btn_dodaj_zgloszenie, "btn_dodaj_zgloszenie");
            this.btn_dodaj_zgloszenie.ForeColor = System.Drawing.Color.White;
            this.btn_dodaj_zgloszenie.Name = "btn_dodaj_zgloszenie";
            this.btn_dodaj_zgloszenie.UseVisualStyleBackColor = false;
            this.btn_dodaj_zgloszenie.Click += new System.EventHandler(this.btn_dodaj_zgloszenie_Click);
            // 
            // main_panel
            // 
            this.main_panel.BackgroundImage = global::SerwisPlus.Properties.Resources.Serwis;
            resources.ApplyResources(this.main_panel, "main_panel");
            this.main_panel.Name = "main_panel";
            // 
            // Frm_glowne
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SerwisPlus.Properties.Resources.Serwis;
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.menu_panel);
            this.Controls.Add(this.title_panel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Frm_glowne";
            this.title_panel.ResumeLayout(false);
            this.title_panel.PerformLayout();
            this.menu_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel title_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel menu_panel;
        private System.Windows.Forms.Button btn_dodaj_zgloszenie;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Button btn_aktywne;
        private System.Windows.Forms.Button btn_wyjscie;
        private System.Windows.Forms.Button btn_historia;
        private System.Windows.Forms.Button btn_klienci;
        private System.Windows.Forms.Button btn_serwisanci;
    }
}

