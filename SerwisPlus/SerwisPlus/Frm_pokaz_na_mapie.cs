using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SerwisPlus;

namespace SerwisPlus
{

    public partial class Frm_pokaz_na_mapie : Form
    {
        public string querryadress;
        public Frm_pokaz_na_mapie()
        {
            InitializeComponent();
            webBrowser1.Navigate(querryadress);

        }
    }
}
