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
    public class GestorReporteVentas : GestorAPI
    {
        private ReporteVentasCrudFactory _crudFactory;

        public GestorReporteVentas(Usuario usuario) : base(usuario)
        {
            _crudFactory = new ReporteVentasCrudFactory();
        }

        public void Create(ReporteVentas entidad)
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

        public void Delete(ReporteVentas entidad)
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
        

        public ReporteVentas RetrievePorId(string id)
        {
            var entidad = new Servicio { Id = Convert.ToInt32(id) };

            return _crudFactory.Retrieve<ReporteVentas>(Convert.ToString(entidad.Id));
        }

        public List<ReporteVentas> RetrieveAll()
        {
            return _crudFactory.RetrieveAll<ReporteVentas>();
        }
    }
}
