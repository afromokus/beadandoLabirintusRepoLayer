using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KirschJanosMarkSajatRepoLayer.Adatbazis;
using KirschJanosMarkSajatRepoLayer.ModelAccount;
using System.Data;

namespace KirschJanosMarkSajatRepoLayer.Repository
{
    class AccountRepo
    {
        List<Account> accountok;

        public AccountRepo()
        {
            accountok = new List<Account>();
            betoltAccountListaAdatbazisbol();
        }

        private void betoltAccountListaAdatbazisbol()
        {
            AdatbazisKezelo ak = new AdatbazisKezelo();
            DataTable adatTabla = ak.lekerAdatTabla("accountok");
            ak.bezaras();

            foreach (DataRow adatSor in adatTabla.Rows)
            {
                accountok.Add(new Account(Convert.ToInt32(adatSor["az"]), adatSor["felhNev"].ToString(), adatSor["jelszo"].ToString(), 
                    adatSor["email_cim"].ToString(), adatSor["jog"].ToString(), Convert.ToInt32(adatSor["szint"]), Convert.ToInt32(adatSor["regio_az"])));
            }

        }

        internal DataTable betoltTabla()
        {
            DataTable accountTabla = new DataTable();

            accountTabla.Columns.Add("Azonosító", typeof(int));
            accountTabla.Columns.Add("Felhasználói név", typeof(string));
            accountTabla.Columns.Add("Jelszó", typeof(string));
            accountTabla.Columns.Add("E-mail cím", typeof(string));
            accountTabla.Columns.Add("Jog", typeof(string));
            accountTabla.Columns.Add("Szint", typeof(int));
            accountTabla.Columns.Add("Régió azonosító", typeof(int));

            foreach (Account a in accountok)
            {
                accountTabla.Rows.Add(a.Az, a.FelhNev, a.Jelszo, a.EmailCim, a.Jog, a.Szint, a.Regio_az);
            }

            return accountTabla;
        }

        internal void hozzaadUjAccount(Account account)
        {
            accountok.Add(account);
        }

        internal bool marLetezikFelhNev(Account account)
        {
            foreach (Account a in accountok)
            {
                if (a.FelhNev == account.FelhNev)
                {
                    return true;
                }
            }

            return false;
        }

        internal DataTable lekerTablatAdatbazisbol(string tablaNev)
        {
            AdatbazisKezelo ak = new AdatbazisKezelo();

            DataTable AdatTabla = ak.lekerAdatTabla(tablaNev);

            ak.bezaras();

            return AdatTabla;

        }
    }
}
