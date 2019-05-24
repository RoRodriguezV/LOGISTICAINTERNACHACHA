using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FINAL
{
    class envio
    {
        
        public int CantidadEnvio { get; set; }
        public string FechaHora { get; set; }

        public envio()
        {

        }

        public envio(int cantidadenvio, string fecha)
        {
            this.CantidadEnvio = cantidadenvio;
            this.FechaHora = fecha;
        }
    }
}
