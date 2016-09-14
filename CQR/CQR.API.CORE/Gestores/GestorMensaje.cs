using CQR.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQR.AccesoDatos.CRUD;

namespace CQR.API.CORE.Gestores
{
    public class GestorMensaje
    {
        private MensajeCrudFactory _crudFactory;

        public GestorMensaje()
        {
            _crudFactory = new MensajeCrudFactory();
        }

        public List<Mensaje> getMensajesException()
        {
            return _crudFactory.RetrieveAll<Mensaje>();
        }

    }
}
