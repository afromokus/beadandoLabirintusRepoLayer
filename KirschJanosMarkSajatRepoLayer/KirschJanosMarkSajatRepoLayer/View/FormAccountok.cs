﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KirschJanosMarkSajatRepoLayer.Adatbazis;
using KirschJanosMarkSajatRepoLayer.Model;
using KirschJanosMarkSajatRepoLayer.Service;
using KirschJanosMarkSajatRepoLayer.Model.TestFileok;

namespace KirschJanosMarkSajatRepoLayer
{
    public partial class FormAccountok : Form
    {
        AccountService accountService;

        public FormAccountok()
        {
            InitializeComponent();

            TestAdatokFeltoltAdatbazis tafa = new TestAdatokFeltoltAdatbazis();

            accountService = new AccountService();
            adatracsMegjelenito.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void gombBetoltes_Click(object sender, EventArgs e)
        {
            frissitAdatracs();
        }

        private void frissitAdatracs()
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
            try
            {
                int index = adatracsMegjelenito.SelectedRows[0].Index;
                if (index > -1)
                {
                    accountService.modositas(index);
                }

                frissitAdatracs();

            }
            catch (Exception kivetel)
            {
                Debug.WriteLine(kivetel.Message);
            }
        }

        private void gombTorles_Click(object sender, EventArgs e)
        {
            try
            {
                accountService.torolFelhasznalo(adatracsMegjelenito.SelectedRows[0].Index);
                frissitAdatracs();
            }
            catch (Exception kivetel)
            {
                MessageBox.Show("Nem jelölt ki elemet!");
            }
        }        
    }
}
