using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

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
                System.Windows.Forms.MessageBox.Show("Indítsa el a xamppot!");
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

    }
}
