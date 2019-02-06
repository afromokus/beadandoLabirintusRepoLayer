using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KirschJanosMarkSajatRepoLayer.Adatbazis;
using KirschJanosMarkSajatRepoLayer.Repository;
using KirschJanosMarkSajatRepoLayer.ModelAccount;
using System.Data;

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
    }
}
