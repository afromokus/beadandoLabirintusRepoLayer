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
using KirschJanosMarkSajatRepoLayer.Service;

namespace KirschJanosMarkSajatRepoLayer
{
    public partial class Form1 : Form
    {
        AccountService accountService;

        public Form1()
        {
            InitializeComponent();
            accountService = new AccountService();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void gombBetoltes_Click(object sender, EventArgs e)
        {
            adatracsMegjelenito.DataSource = accountService.betoltAdattabla("accountok");
        }
    }
}
