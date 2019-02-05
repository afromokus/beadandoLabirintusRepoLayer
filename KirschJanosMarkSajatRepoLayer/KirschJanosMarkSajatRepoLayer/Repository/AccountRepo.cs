using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KirschJanosMarkSajatRepoLayer.Adatbazis;
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

        internal DataTable getTabla(string tablaNev)
        {
            AdatbazisKezelo ak = new AdatbazisKezelo();

            DataTable AdatTabla = ak.lekerAdatTabla(tablaNev);

            ak.bezaras();

            return AdatTabla;

        }
    }
}
