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

        public void Create(Servicio entidad)
        {
            if (!string.IsNullOrEmpty(Convert.ToString(entidad.Id)))
            {
                _crudFactory.Create(entidad);
            }
            else
            {
                throw new Exception();
            }
        }

        public void Update(Servicio entidad)
        {
            if (!string.IsNullOrEmpty(Convert.ToString(entidad.Id)))
            {
                _crudFactory.Update(entidad);
            }
            else
            {
                throw new Exception();
            }

        }

        public void Delete(Servicio entidad)
        {
            if (!string.IsNullOrEmpty(Convert.ToString(entidad.Id)))
            {
                _crudFactory.Delete(entidad);
            }
            else
            {
                throw new Exception();
            }
        }

        public void DeleteByNombre(Servicio entidad)
        {
            if (!string.IsNullOrEmpty(Convert.ToString(entidad.Nombre)))
            {
                _crudFactory.DeleteByNombre(entidad);
            }
            else
            {
                throw new Exception();
            }
        }

        public Servicio RetrievePorId(string id)
        {
            var entidad = new Servicio { Id = Convert.ToInt32(id) };

            return _crudFactory.Retrieve<Servicio>(Convert.ToString(entidad.Id));
        }

        public List<Servicio> RetrieveAll()
        {
            return _crudFactory.RetrieveAll<Servicio>();
        }

    }
}
