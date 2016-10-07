using CQR.Entidades.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQR.Entidades
{
    public class Empresa : EntidadBase
    {
        public string CedulaJuridica;
        public string Nombre;
        public string Telefono;
        public string Ubicacion;
        public string Sitio;

        public Empresa()
        {

        }

    }
}
