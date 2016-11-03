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
    public class GestorPermiso : GestorAPI
    {
        private PermisoCrudFactory _crudFactory;

        public GestorPermiso(Usuario usuario) : base(usuario)
        {
            _crudFactory = new PermisoCrudFactory();
        }

        public void Create(Permiso entidad)
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

        public void Update(Permiso entidad)
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

        public void Delete(Permiso entidad)
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

        public Permiso RetrievePorId(string id)
        {
            var entidad = new Permiso { Id = Convert.ToInt32(id) };

            return _crudFactory.Retrieve<Permiso>(Convert.ToString(entidad.Id));
        }
        public Permiso RetrievePorId(int id)
        {
            var entidad = new Permiso { Id = id };

            return _crudFactory.Retrieve<Permiso>(Convert.ToString(entidad.Id));
        }

        public List<Permiso> RetrieveAll()
        {
            return _crudFactory.RetrieveAll<Permiso>();
        }

        public List<Permiso> RetrieveAllPorRol(Rol rol)
        {
            return _crudFactory.RetrieveAllByRol<Permiso>(rol);
        }
    }
}
