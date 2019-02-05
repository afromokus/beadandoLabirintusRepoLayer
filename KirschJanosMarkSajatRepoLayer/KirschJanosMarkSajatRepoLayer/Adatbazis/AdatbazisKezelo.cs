﻿using System;
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
        DataTable lab3dTabla;

        DataTable accountokTabla;
        


        public AdatbazisKezelo()
        {
            csatlakozas = new MySqlConnection();
            parancs = new MySqlCommand("");            

            csatlakozas.ConnectionString = "SERVER = 127.0.0.1; DATABASE = lab3d; Uid = root; pwd = ; port = 3306";
            csatlakozas.Open();

            accountokTabla = getToDatatable("accountok");

            csatlakozas.Close();

        }

        private DataTable getToDatatable(string tablaNev)
        {
            DataTable lab3dTabla = new DataTable();
            MySqlDataAdapter adatIlleszto;

            parancs = new MySqlCommand("SELECT * FROM " + tablaNev);
            adatIlleszto = new MySqlDataAdapter(parancs);
            adatIlleszto.SelectCommand.Connection = csatlakozas;
            adatIlleszto.Fill(lab3dTabla);

            return lab3dTabla;
        }

        public DataTable getAccountokTabla()
        {
            return accountokTabla;
        }

    }
}
