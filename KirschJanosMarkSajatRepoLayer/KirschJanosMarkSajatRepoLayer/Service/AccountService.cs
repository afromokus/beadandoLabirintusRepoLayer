using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KirschJanosMarkSajatRepoLayer.Adatbazis;
using KirschJanosMarkSajatRepoLayer.Repository;
using System.Data;
using KirschJanosMarkSajatRepoLayer.Model;

namespace KirschJanosMarkSajatRepoLayer.Service
{
    class AccountService
    {
        AccountRepo ar;

        public AccountService()
        {
            ar = new AccountRepo();
        }

        public DataTable betoltAdattabla(string tablaNev)
        {
            return ar.lekerTablatAdatbazisbol(tablaNev);
        }

        internal void hozzaadasUjAccount(Account account)
        {
            if (!ar.marLetezikFelhNev(account))
            {
                ar.hozzaadUjAccount(account);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show(account.FelhNev + " felhasználónév már használatban van!");
            }
        }

        internal DataTable lekerRepoTabla()
        {
            return ar.betoltTabla();
        }

        public void modositas(int index)
        {
            ModositoAblak ma = new ModositoAblak(ar.getAccount(index));

            if (ma.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (ma.mindenAdatErvenyes())
                {
                    ar.felulirAccount(new Account(Convert.ToInt32(ma.TextBoxAz.Text),ma.TextBoxFelhNev.Text, ma.TextBoxJelszo.Text, ma.TextBoxEmail.Text, ma.TextBoxJog.Text,
                        Convert.ToInt32(ma.TextBoxSzint.Text), Convert.ToInt32(ma.TextBoxRegioAz.Text)), index);
                }
            }
        }

        internal void torolFelhasznalo(int index)
        {
            ar.torolFelhasznalo(index);
        }
    }
}
