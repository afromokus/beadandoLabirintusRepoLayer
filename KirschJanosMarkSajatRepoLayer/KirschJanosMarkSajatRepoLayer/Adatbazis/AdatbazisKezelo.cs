using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using KirschJanosMarkSajatRepoLayer.Model;

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

        internal void felulirAccount(Account account, int index)
        {
            parancsAdatbazisVegrehajt("UPDATE `accountok` SET `az` = '" + account.Az + "', `felhNev` = '" + account.FelhNev + "', " +
                "`jelszo` = '" + account.Jelszo + "', `email_cim` = '" + account.EmailCim + "', `jog` = '" + account.Jog + "', `szint` = '" + account.Szint + "'," +
                " `regio_az` = '" + account.Regio_az + "' WHERE `accountok`.`az` = 4");
            if (account.Az != index)
            {
                parancsAdatbazisVegrehajt("DELETE FROM `accountok` WHERE `accountok`.`az` = " + (index + 1) + ";");
            }
        }
    }
}
