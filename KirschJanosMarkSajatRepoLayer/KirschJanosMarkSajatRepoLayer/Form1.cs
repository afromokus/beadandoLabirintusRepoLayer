using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KirschJanosMarkSajatRepoLayer.Adatbazis;

namespace KirschJanosMarkSajatRepoLayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void gombBetoltes_Click(object sender, EventArgs e)
        {
            AdatbazisKezelo ak = new AdatbazisKezelo();

            adatracsMegjelenito.DataSource = ak.getAccountokTabla();

        }
    }
}
