using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FINAL
{
    class receta
    {
        public string CodInsumo { get; set; }
        public string CodProducto { get; set; }
        public int CantidadReceta { get; set; }

        public receta()
        {

        }
        public receta(int CantidadReceta, string CodInsumo, string CodProducto)
        {
            this.CodInsumo = CodInsumo;
            this.CodProducto = CodProducto;
            this.CantidadReceta = CantidadReceta;
        }
    }
}
