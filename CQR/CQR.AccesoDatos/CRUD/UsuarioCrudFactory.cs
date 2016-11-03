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
    public class UsuarioCrudFactory : CrudFactory
    {
        private UsuarioMapper _mapper;

        public UsuarioCrudFactory()
        {
            _mapper = new UsuarioMapper();
        }
        public override bool Create(EntidadBase entidad)
        {
            try
            {
                SqlDao.ExecuteQueryProcedureBoolean(_mapper.GetCreateStatement(entidad));
                return true;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                AdministrarExcepcion(ex);
                throw ex;
            }
            catch (Exception ex)
            {
                AdministrarExcepcion(ex);
                throw ex;
            }

        }

        public override bool Delete(EntidadBase entidad)
        {
            try
            {
                SqlDao.ExecuteQueryProcedureBoolean(_mapper.GetDeleteStatement(entidad));
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

        public List<T> SearchLike<T>(string textoIngresado)
        {
            try
            {
                var lstResult = SqlDao.ExecuteQueryProcedure(_mapper.GetRetrieveBySearchLikeStatement(textoIngresado));
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

            }
            catch (Exception ex)
            {
                AdministrarExcepcion(ex);
                throw ex;
            }

            return default(List<T>);
        }

        public override T Retrieve<T>(string cedula)
        {
            try
            {
                var lstResult = SqlDao.ExecuteQueryProcedure(_mapper.GetRetriveByIdStatement(cedula));
                var dic = new Dictionary<string, object>();
                if (lstResult.Count > 0)
                {
                    dic = lstResult[0];

                    return (T)Convert.ChangeType(_mapper.BuildObject(dic), typeof(T));
                }

                return default(T);
            }
            catch (Exception ex)
            {
                //Administrar Conexion Data Base

                AdministrarExcepcion(ex);
                throw ex;
            }
        }

        public override List<T> RetrieveAll<T>()
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

        public override bool Update(EntidadBase entidad)
        {
            try
            {
                SqlDao.CanExecuteQueryProcedure(_mapper.GetUpdateStatement(entidad));
                return true;
            }
            catch (Exception ex)
            {
                AdministrarExcepcion(ex);
                throw ex;
            }
        }

    }
}
