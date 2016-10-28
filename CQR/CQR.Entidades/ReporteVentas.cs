using CQR.Entidades.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQR.Entidades
{
    public class ReporteVentas : EntidadBase
    {
        public int Id;
        public DateTime Fecha;
        public decimal Monto;
        public string Cliente;
        public string Servicio;

        public ReporteVentas()
        {

        }
       
    }
}
