using CQR.Entidades.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQR.Entidades
{
    public class Servicio : EntidadBase
    {
        public int Id;
        public string Nombre;
        public string Descripcion;
        public double Costo;

        public Servicio()
        {

        }

    }
}
