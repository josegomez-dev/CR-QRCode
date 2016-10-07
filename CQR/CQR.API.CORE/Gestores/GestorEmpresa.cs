using CQR.AccesoDatos.CRUD;
using CQR.API.CORE.Gestores.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQR.Entidades;

namespace CQR.API.CORE.Gestores
{
    public class GestorEmpresa : GestorAPI
    {
        private EmpresaCrudFactory _crudFactory;

        public GestorEmpresa(Usuario usuario) : base(usuario)
        {
            _crudFactory = new EmpresaCrudFactory();
        }

        public void Create(Empresa empresa)
        {
            if (!string.IsNullOrEmpty(Convert.ToString(empresa.CedulaJuridica)))
            {
                _crudFactory.Create(empresa);
            }
            else
            {
                throw new Exception();
            }
        }

        public void Update(Empresa empresa)
        {
            if (!string.IsNullOrEmpty(Convert.ToString(empresa.CedulaJuridica)))
            {
                _crudFactory.Update(empresa);
            }
            else
            {
                throw new Exception();
            }

        }

        public void Delete(Empresa empresa)
        {
            if (!string.IsNullOrEmpty(Convert.ToString(empresa.CedulaJuridica)))
            {
                _crudFactory.Delete(empresa);
            }
            else
            {
                throw new Exception();
            }

        }

        public Empresa RetrievePorId(string id)
        {
            var empresa = new Empresa { CedulaJuridica = id };

            return _crudFactory.Retrieve<Empresa>(Convert.ToString(empresa.CedulaJuridica));
        }

        public List<Empresa> RetrieveAll()
        {
            return _crudFactory.RetrieveAll<Empresa>();
        }

    }
}
