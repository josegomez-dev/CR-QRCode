using CQR.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQR.API.CORE.Excepciones;

namespace CQR.API.CORE.Gestores.Base
{
    public class GestorAPI
    {
        protected Usuario UsuarioAuth { get; set; }
        //private GestorExcepcion gestor;

        protected GestorExcepciones gestorEx { get; set; }

        public GestorAPI(Usuario usuario)
        {
            UsuarioAuth = usuario;
            gestorEx = new GestorExcepciones(usuario);

        }

        public CQR_Exception ControlarExcepcion(CQR_Exception code)
        {
            if (gestorEx == null)
            {
                gestorEx = new GestorExcepciones(UsuarioAuth);

            }
            return gestorEx.controlarExcepcion(code);
        }
        public Exception ControlarExcepcion(Exception excepcion)
        {
            if (gestorEx == null)
            {
                this.gestorEx = new GestorExcepciones(UsuarioAuth);
            }
            return gestorEx.controlarExcepcion(excepcion);
        }

    }
}
