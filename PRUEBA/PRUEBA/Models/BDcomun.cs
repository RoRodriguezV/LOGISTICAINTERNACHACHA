using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace PRUEBA.Models
{
    public class BDcomun
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=proyectochachas; Uid=root; pwd=;");

            conectar.Open();
            return conectar;
        }
    }
}