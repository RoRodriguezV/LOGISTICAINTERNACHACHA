using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FINAL
{
    class pedido
    {
        public string Codigo_Origen { get; set; }
        public string Codigo_Destino { get; set; }
        public string Codigo_Producto { get; set; }
        public string Cantidad { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }

        public pedido() { }

        public pedido(string pEstado, string pCodigo_Origen, string pCodigo_Destino, string pCodigo_Producto, string pCantidad, DateTime pFecha)

        {
            this.Codigo_Origen = pCodigo_Origen;
            this.Codigo_Destino = pCodigo_Destino;
            this.Codigo_Producto = pCodigo_Producto;
            this.Cantidad = pCantidad;
            this.Fecha = pFecha;
            this.Estado = pEstado;
        }
    }
}
