using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using KirschJanosMarkSajatRepoLayer.Model;
using KirschJanosMarkSajatRepoLayer.Repository;

namespace KirschJanosMarkSajatRepoLayer.Adatbazis
{
    class AdatbazisKezelo
    {
        MySqlConnection csatlakozas;
        MySqlCommand parancs;  


        public AdatbazisKezelo()
        {
            csatlakozas = new MySqlConnection();
            parancs = new MySqlCommand("");

            csatlakozas.ConnectionString = "SERVER = 127.0.0.1; DATABASE = lab3d; Uid = root; pwd = ; port = 3306";
            try
            {
                csatlakozas.Open();
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Indítsa el a xamppot (MYSQL szervert nem sikerült elérni)!");
                Environment.Exit(1);
            }

        }

        internal DataTable lekerAdatTabla(string tablaNev)
        {
            DataTable lab3dTabla = new DataTable();
            MySqlDataAdapter adatIlleszto;

            try
            {

                parancs = new MySqlCommand("SELECT * FROM " + tablaNev);
                adatIlleszto = new MySqlDataAdapter(parancs);
                adatIlleszto.SelectCommand.Connection = csatlakozas;
                adatIlleszto.Fill(lab3dTabla);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Az adatbázisban nem található " + tablaNev + " tábla!");
            }

            return lab3dTabla;
        }

        public void bezaras()
        {
            csatlakozas.Close();
        }

        public void hozzaadAdatbazishoz(Account account)
        {
                parancsAdatbazisVegrehajt("INSERT INTO `accountok` " +
                    "(`az`, `felhNev`, `jelszo`, `email_cim`, `jog`, `szint`, `regio_az`) " +
                    "VALUES ('" + account.Az + "', '" + account.FelhNev + "', '" + account.Jelszo + "', '" +
                    account.EmailCim + "', '" + account.Jog + "', '" + account.Szint + "', '" + account.Regio_az + "')");
        }

        public void parancsAdatbazisVegrehajt(string sqlSzoveg)
        {
            parancs.Connection = csatlakozas;   
            parancs.CommandText = sqlSzoveg;
            parancs.ExecuteNonQuery();
        }

        internal void frissitAccount(Account a, int az)
        {
             parancsAdatbazisVegrehajt("UPDATE accountok " +
                 "SET az = " + a.Az + ", felhNev = " + a.FelhNev + ", jelszo = " + a.Jelszo + ", email_cim = " + 
                 ", jog = " + a.Jog + ", szint = " + a.Szint + ", regio_az = " + a. Regio_az +
                 "WHERE az = " + az +"; ");
            System.Windows.Forms.MessageBox.Show(az + "");
        }

        public void feltoltRepoAdatbazisba(List<Account> accountok)
        {
            int i = 0;
            parancsAdatbazisVegrehajt("DROP TABLE accountok;" +
                "CREATE TABLE `accountok` (  `az` int(11) NOT NULL," +
                "  `felhNev` varchar(30) COLLATE utf8_hungarian_ci DEFAULT NULL," +
                "  `jelszo` varchar(28) COLLATE utf8_hungarian_ci DEFAULT NULL," +
                "  `email_cim` varchar(50) COLLATE utf8_hungarian_ci DEFAULT NULL," +
                "  `jog` varchar(20) COLLATE utf8_hungarian_ci DEFAULT NULL," +
                "  `szint` int(11) NOT NULL," +
                "  `regio_az` smallint(6) DEFAULT NULL" +
                ") ENGINE = InnoDB DEFAULT CHARSET = utf8 COLLATE = utf8_hungarian_ci;");
            
            for(i = 0; i < accountok.Count; i++)
            {                
                parancsAdatbazisVegrehajt(
                "INSERT INTO `accountok` (`az`, `felhNev`, `jelszo`, `email_cim`, `jog`, `szint`, `regio_az`) VALUES" +
                "(" + accountok[i].Az + ", '" + accountok[i].FelhNev + "', ' " + accountok[i].Jelszo + "', '" + 
                accountok[i].EmailCim + "', '" + accountok[i].FelhNev + "', " +
                accountok[i].Szint + ", " + accountok[i].Regio_az + ")");
            }
        }

    }
}
