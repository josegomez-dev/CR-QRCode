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
    public class GestorUsuario : GestorAPI
    {
        private UsuarioCrudFactory _crudFactory;

        public GestorUsuario(Usuario usuario) : base(usuario)
        {
            _crudFactory = new UsuarioCrudFactory();
        }

        public void Create(Usuario entidad)
        {
            if (!string.IsNullOrEmpty(Convert.ToString(entidad.Nick)))
            {
                _crudFactory.Create(entidad);
            }
            else
            {
                throw new Exception();
            }
        }
        
        public void Update(Usuario entidad)
        {
            if (!string.IsNullOrEmpty(Convert.ToString(entidad.Nick)))
            {
                _crudFactory.Update(entidad);
            }
            else
            {
                throw new Exception();
            }

        }

        public void Delete(Usuario entidad)
        {
            if (!string.IsNullOrEmpty(Convert.ToString(entidad.Nick)))
            {
                _crudFactory.Delete(entidad);
            }
            else
            {
                throw new Exception();
            }
        }

        public Usuario RetrievePorId(string nick)
        {
            var entidad = new Usuario { Nick = nick };

            return _crudFactory.Retrieve<Usuario>(Convert.ToString(entidad.Nick));
        }
        
        public List<Usuario> RetrieveAll()
        {
            return _crudFactory.RetrieveAll<Usuario>();
        }

        public List<Usuario> searchLike(string text)
        {
            return _crudFactory.SearchLike<Usuario>(text);
        }

    }
}
