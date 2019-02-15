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
using KirschJanosMarkSajatRepoLayer.ModelAccount;

namespace KirschJanosMarkSajatRepoLayer
{
    public partial class FormAccountok : Form
    {
        AccountService accountService;

        public FormAccountok()
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

        private void gombUj_Click(object sender, EventArgs e)
        {
            Account account = new Account(4, "ujFelhNev", "ujJelszo", "ujEmail", "jog", 1, 3);
            accountService.hozzaadasUjAccount(account);
            adatracsMegjelenito.DataSource = accountService.lekerRepoTabla();
        }

        private void gombModosit_Click(object sender, EventArgs e)
        {

        }
    }
}
