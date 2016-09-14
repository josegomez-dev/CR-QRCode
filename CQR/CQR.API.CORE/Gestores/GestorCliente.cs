using CQR.AccesoDatos.CRUD;
using CQR.API.CORE.Gestores.Base;
using CQR.Entidades;
using CQR.Entidades.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQR.API.CORE.Gestores
{
    public class GestorCliente : GestorAPI
    {
        private ClienteCrudFactory _crudFactory;
        public GestorCliente(Usuario usuario) : base(usuario)
        {
            _crudFactory = new ClienteCrudFactory();
        }
        
        public void Create(Cliente cliente)
        {
            if (!string.IsNullOrEmpty(Convert.ToString(cliente.Cedula)))
            {
                _crudFactory.Create(cliente);
            }
            else
            {
                throw new Exception();
            }
        }

        public void Update(Cliente cliente)
        {
            if (!string.IsNullOrEmpty(Convert.ToString(cliente.Cedula)))
            {
                _crudFactory.Update(cliente);
            }
            else
            {
                throw new Exception();
            }

        }

        public void Delete(Cliente cliente)
        {
            if (!string.IsNullOrEmpty(Convert.ToString(cliente.Cedula)))
            {
                _crudFactory.Delete(cliente);
            }
            else
            {
                throw new Exception();
            }

        }

        public Cliente RetrievePorId(string id)
        {
            var cliente = new Cliente { Cedula = id };

            return _crudFactory.Retrieve<Cliente>(Convert.ToString(cliente.Cedula));
        }

        public List<Cliente> RetrieveAll()
        {
            return _crudFactory.RetrieveAll<Cliente>();
        }
       
    }
}
