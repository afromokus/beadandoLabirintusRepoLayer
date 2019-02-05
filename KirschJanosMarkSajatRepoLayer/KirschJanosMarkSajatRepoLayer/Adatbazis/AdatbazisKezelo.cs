using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

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
            csatlakozas.Open();
            csatlakozas.Close();

        }
    }
}
