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
    public class GestorRol : GestorAPI
    {
        private RolCrudFactory _crudFactory;

        public GestorRol(Usuario usuario) : base(usuario)
        {
            _crudFactory = new RolCrudFactory();
        }

        public void Create(Rol entidad)
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

        public void Update(Rol entidad)
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

        public void Delete(Rol entidad)
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

        public Rol RetrievePorId(string id)
        {
            var entidad = new Rol { Id = Convert.ToInt32(id) };

            return _crudFactory.Retrieve<Rol>(Convert.ToString(entidad.Id));
        }
        public Rol RetrievePorId(int id)
        {
            var entidad = new Rol { Id = id };

            return _crudFactory.Retrieve<Rol>(Convert.ToString(entidad.Id));
        }

        public List<Rol> RetrieveAll()
        {
            return _crudFactory.RetrieveAll<Rol>();
        }

        public Rol RetrievePorNombre(string nombre)
        {
            var entidad = new Rol { Nombre = nombre };

            return _crudFactory.RetrieveByNombre<Rol>(entidad.Nombre);
        }
    }
}
