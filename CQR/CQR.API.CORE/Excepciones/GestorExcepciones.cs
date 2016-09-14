using CQR.API.CORE.Gestores;
using CQR.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQR.API.CORE.Excepciones
{
    public class GestorExcepciones
    {
        public GestorMensaje mensaje;

        public static List<Mensaje> lista;

        public GestorExcepciones(Usuario usuario)
        {
            mensaje = new GestorMensaje();

        }

        public CQR_Exception controlarExcepcion(CQR_Exception pexception)
        {

            CQR_Exception exception = pexception;
            if (lista == null)
            {
                cargarMensajes();

            }
            for (var i = 0; i < lista.Count; i++)
            {
                if (exception.Codigo == lista[i].Codigo)
                {
                    exception.Mensaje = lista[i].Msj;
                }
            }

            return exception;
        }

        public Exception controlarExcepcion(Exception pexception)
        {
            Exception exception = pexception;
            return exception;

        }
        public Exception ControlarException(Exception exception)
        {
            return new Exception();
        }

        public void cargarMensajes()
        {

            lista = mensaje.getMensajesException();

        }

    }
}
