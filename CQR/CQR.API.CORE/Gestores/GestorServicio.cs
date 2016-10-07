using CQR.AccesoDatos.CRUD;
using CQR.API.CORE.Gestores.Base;
using CQR.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQR.API.CORE.Gestores
{
    public class GestorServicio : GestorAPI
    {
        private ServicioCrudFactory _crudFactory;

        public GestorServicio(Usuario usuario) : base(usuario)
        {
            _crudFactory = new ServicioCrudFactory();
        }

        public void Create(Servicio servicio)
        {
            if (!string.IsNullOrEmpty(Convert.ToString(servicio.Id)))
            {
                _crudFactory.Create(servicio);
            }
            else
            {
                throw new Exception();
            }
        }

        public void Update(Servicio servicio)
        {
            if (!string.IsNullOrEmpty(Convert.ToString(servicio.Id)))
            {
                _crudFactory.Update(servicio);
            }
            else
            {
                throw new Exception();
            }

        }

        public void Delete(Servicio servicio)
        {
            if (!string.IsNullOrEmpty(Convert.ToString(servicio.Id)))
            {
                _crudFactory.Delete(servicio);
            }
            else
            {
                throw new Exception();
            }
        }

        public void DeleteByNombre(Servicio servicio)
        {
            if (!string.IsNullOrEmpty(Convert.ToString(servicio.Nombre)))
            {
                _crudFactory.DeleteByNombre(servicio);
            }
            else
            {
                throw new Exception();
            }
        }

        public Servicio RetrievePorId(string id)
        {
            var servicio = new Servicio { Id = Convert.ToInt32(id) };

            return _crudFactory.Retrieve<Servicio>(Convert.ToString(servicio.Id));
        }

        public List<Servicio> RetrieveAll()
        {
            return _crudFactory.RetrieveAll<Servicio>();
        }

    }
}
