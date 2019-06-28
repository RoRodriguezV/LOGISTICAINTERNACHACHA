using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PRUEBA.Models;
using MySql.Data.MySqlClient;

namespace PRUEBA.Controllers
{
    public class PruebaController : ApiController
    {
        // GET: api/Prueba

        public IEnumerable<sucursal> Get()
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

        // GET: api/Prueba/5
        public sucursal Get(int id)
        {
            return  new sucursal
            {
                Location = $"Location {id}",
                Degree = id * 23 / 17,
                DateTime = DateTime.Now.ToUniversalTime()
            };
        }

     
        
    }
}
