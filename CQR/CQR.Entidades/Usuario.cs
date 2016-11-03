using CQR.Entidades.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQR.Entidades
{
    
    public class Usuario : EntidadBase
    {
        public string Nombre;
        public string Nick;
        public string Clave;
        public string Email;
        public string Telefono;
        public int Rol;

        public Usuario() { }
        
    }
}
