using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FINAL
{
    class insumo
    {
        public string CodInsumo;
        public string NombreInsumo;
        public string TipoInsumo;
        public int CantidadInsumo;


        public insumo()
        {

        }

        public insumo(string CodInsumo, string NombreInsumo, string TipoInsumo, int cantiinsumo)
        {
            this.CodInsumo = CodInsumo;
            this.NombreInsumo = NombreInsumo;
            this.TipoInsumo = TipoInsumo;
            this.CantidadInsumo = cantiinsumo;
        }
    }
    
}
