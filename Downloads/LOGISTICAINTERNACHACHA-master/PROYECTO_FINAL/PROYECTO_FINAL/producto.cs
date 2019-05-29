using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FINAL
{
    class producto
    {
        public string CodProducto { get; set; }
        public string NombreProducto { get; set; }
        public string TipoProducto { get; set; }
        public int Cantidad { get; set; }

        public producto()
        {

        }
        public producto (string CodProducto, string NombreProducto, string TipoProducto, int Cantidad)
        {
            this.CodProducto = CodProducto;
            this.NombreProducto = NombreProducto;
            this.TipoProducto = TipoProducto;
            this.Cantidad = Cantidad;
        }

    }
}
