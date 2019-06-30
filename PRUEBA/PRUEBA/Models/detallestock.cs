using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PRUEBA.Models
{
    public class detallestock
    {
        public string CodSucursal { get; set; }
        public string CodProducto { get; set; }
        public int CantidadDetalle { get; set; }
        public string NombreProducto { get; set; }
        public detallestock()
        {

        }
        public detallestock(string CodSucursal, string CodProducto, int CantidadDetalle, string NombreProducto)
        {

            this.CodSucursal = CodSucursal;
            this.CodProducto = CodProducto;
            this.CantidadDetalle = CantidadDetalle;
            this.NombreProducto = NombreProducto;
            

        }

    }
}