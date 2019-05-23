using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PROYECTO_FINAL
{
    class BDconsultas
    {
        public static int AgregarSucursal(sucursal psucursal)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into sucursal (CodSucursal, NombreSucursal, DireccionSucursal, Latitud, Longitud, Telefonosucursal) values ('{0}','{1}','{2}','{3}','{4}','{5}')",
              psucursal.CodSucursal, psucursal.NombreSucursal, psucursal.DireccionSucural, psucursal.Latitud, psucursal.Longitud, psucursal.TelefonoSucursal), BDcomun.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;

        }
        public static List<sucursal> BuscarSucursal(string cod)
        {
            List<sucursal> _lista = new List<sucursal>();
            MySqlConnection conexion = BDcomun.ObtenerConexion();


            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM sucursal where CodSucursal = " + cod), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                sucursal psucursal = new sucursal();
                psucursal.CodSucursal= _reader.GetString(0);
                psucursal.NombreSucursal = _reader.GetString(1);
                psucursal.DireccionSucural = _reader.GetString(2);
                psucursal.Latitud = _reader.GetDouble(3);
                psucursal.Longitud = _reader.GetDouble(4);
                psucursal.TelefonoSucursal = _reader.GetInt32(5);


                _lista.Add(psucursal);
            }

            conexion.Close();
            return _lista;
        }
        public static List<sucursal> BuscarSucursales()
        {
            List<sucursal> _lista = new List<sucursal>();
            MySqlConnection conexion = BDcomun.ObtenerConexion();


            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM sucursal "), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                sucursal psucursal = new sucursal();
                psucursal.CodSucursal = _reader.GetString(0);
                psucursal.NombreSucursal = _reader.GetString(1);
                psucursal.DireccionSucural = _reader.GetString(2);
                psucursal.Latitud = _reader.GetDouble(3);
                psucursal.Longitud = _reader.GetDouble(4);
                psucursal.TelefonoSucursal = _reader.GetInt32(5);


                _lista.Add(psucursal);
            }

            conexion.Close();
            return _lista;
        }
    }
}
