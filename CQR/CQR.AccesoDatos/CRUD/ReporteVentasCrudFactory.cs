using CQR.AccesoDatos.CRUD.Base;
using CQR.AccesoDatos.DAO;
using CQR.AccesoDatos.Mapper;
using CQR.Entidades.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQR.AccesoDatos.CRUD
{
    public class ReporteVentasCrudFactory : CrudFactory
    {
        private ReporteVentasMapper _mapper;

        public ReporteVentasCrudFactory()
        {
            _mapper = new ReporteVentasMapper();
        }

        public override bool Create(EntidadBase entidad)
        {
            try
            {
                SqlDao.ExecuteProcedure(_mapper.GetCreateStatement(entidad));

                return true;
            }
            catch (Exception ex)
            {
                AdministrarExcepcion(ex);
                throw ex;
            }
        }

        public override bool Delete(EntidadBase entidad)
        {
            throw new NotImplementedException();
        }

        public bool DeleteByNombre(EntidadBase entidad)
        {
            try
            {
                SqlDao.ExecuteQueryProcedureBoolean(_mapper.GetDeleteByNombreStatement(entidad));
                return true;
            }
            catch (Exception ex)
            {
                AdministrarExcepcion(ex);
                throw ex;
            }
        }

        public override EntidadBase RCreate(EntidadBase entidad)
        {
            throw new NotImplementedException();
        }

        public override T Retrieve<T>(int id)
        {
            throw new NotImplementedException();
        }

        public override T Retrieve<T>(string id)
        {
            try
            {
                var lstResult = SqlDao.ExecuteQueryProcedure(_mapper.GetRetriveByIdStatement(id));
                var dic = new Dictionary<string, object>();

                if (lstResult.Count > 0)
                {
                    dic = lstResult[0];

                    var objs = _mapper.BuildObject(dic);

                    return (T)Convert.ChangeType(objs, typeof(T));
                }

                return default(T);
            }
            catch (Exception ex)
            {
                AdministrarExcepcion(ex);
                throw ex;
            }
        }

        public override List<T> RetrieveAll<T>()
        {
            try
            {
                var lstResult = SqlDao.ExecuteQueryProcedure(_mapper.GetRetrieveByallStatement());
                var dic = new List<Dictionary<string, object>>();

                List<T> list = new List<T>();

                if (lstResult.Count > 0)
                {
                    for (int i = 0; i < lstResult.Count; i++)
                    {
                        dic.Add(lstResult[i]);
                    }

                    var objs = _mapper.BuildObjects(dic);

                    for (int i = 0; i < lstResult.Count; i++)
                    {
                        list.Add((T)Convert.ChangeType(objs[i], typeof(T)));
                    }

                    return list;
                }

                return default(List<T>);
            }
            catch (Exception ex)
            {
                AdministrarExcepcion(ex);
                throw ex;
            }
        }

        public override bool Update(EntidadBase entidad)
        {
            throw new NotImplementedException();
        }

    }
}
