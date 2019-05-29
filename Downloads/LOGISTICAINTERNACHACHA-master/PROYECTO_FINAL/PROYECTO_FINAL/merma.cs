using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FINAL
{
    class merma
    {
        public int CantidadMerma;
        public DateTime FechaInicio;
        public DateTime FechaFin;

        public merma()
        {

        }

        public merma (int cantidad, DateTime fechaini, DateTime fechafin)
        {
            this.CantidadMerma = cantidad;
            this.FechaInicio = fechaini;
            this.FechaFin = fechafin;
        }
    }
}
