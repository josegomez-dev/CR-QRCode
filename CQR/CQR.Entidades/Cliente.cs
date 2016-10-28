using CQR.Entidades.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQR.Entidades
{
    public class Cliente : EntidadBase
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string PlacaActual { get; set; }
        public string Profesion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public int Visitas { get; set; }
        public int Premio { get; set; }
        public bool Vetado { get; set; }

        public Cliente()
        {

        }

    }
}
