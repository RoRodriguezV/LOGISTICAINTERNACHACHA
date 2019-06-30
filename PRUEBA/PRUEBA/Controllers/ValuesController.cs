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
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<detallestock> Get()
        {

            List<detallestock> _lista = new List<detallestock>();
            MySqlConnection conexion = BDcomun.ObtenerConexion();


            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM detallestock "), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                detallestock pdetalle = new detallestock();
                pdetalle.CodSucursal = _reader.GetString(0);
                pdetalle.CodProducto = _reader.GetString(1);
                pdetalle.CantidadDetalle = _reader.GetInt32(2);
                pdetalle.NombreProducto = _reader.GetString(3);
              


                _lista.Add(pdetalle);
            }

            conexion.Close();
            return _lista;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
