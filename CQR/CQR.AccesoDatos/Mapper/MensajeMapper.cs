using CQR.AccesoDatos.Mapper.Base;
using CQR.Entidades;
using CQR.Entidades.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQR.AccesoDatos.DAO;

namespace CQR.AccesoDatos.Mapper
{
    public class MensajeMapper : EntityMapper, ISqlStament, IObjectMapper
    {
        private const string DB_COL_CODIGO = "CODIGO";
        private const string DB_COL_MENSAJE = "MENSAJE";

        public EntidadBase BuildObject(Dictionary<string, object> row)
        {
            var mensaje = new Mensaje
            {
                Codigo = GetExceptionCodeValue(row, DB_COL_CODIGO),
                Msj = GetStringValue(row, DB_COL_MENSAJE)
            };

            return mensaje;
        }

        public List<EntidadBase> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<EntidadBase>();

            foreach (var row in lstRows)
            {
                var msj = new Mensaje
                {
                    Codigo = GetExceptionCodeValue(row, DB_COL_CODIGO),
                    Msj = GetStringValue(row, DB_COL_MENSAJE)
                };

                lstResults.Add(msj);
            }

            return lstResults;
        }

        public SqlOperation GetCreateStatement(EntidadBase entidad)
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetDeleteStatement(EntidadBase entidad)
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetRetrieveByallStatement()
        {
            return new SqlOperation { ProcedureName = "RETALL_EXCEPCIONES_PR" };
        }

        public SqlOperation GetRetriveByIdStatement(int id)
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetRetriveByIdStatement(string id)
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetUpdateStatement(EntidadBase entidad)
        {
            throw new NotImplementedException();
        }
    }
}
