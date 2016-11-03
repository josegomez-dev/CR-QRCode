using CQR.AccesoDatos.DAO;
using CQR.AccesoDatos.Mapper.Base;
using CQR.Entidades;
using CQR.Entidades.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQR.AccesoDatos.Mapper
{
    public class RolMapper : EntityMapper, IObjectMapper, ISqlStament
    {
        private const string DB_COL_ID = "CODIGO";
        private const string DB_COL_NOMBRE = "NOMBRE";
        private const string DB_COL_DESCRIPCION = "DESCRIPCION";

        public EntidadBase BuildObject(Dictionary<string, object> row)
        {
            var entidad = new Rol
            {
                Id = GetIntValue(row, DB_COL_ID),
                Nombre = GetStringValue(row, DB_COL_NOMBRE),
                Descripcion = GetStringValue(row, DB_COL_DESCRIPCION)
            };
            return entidad;
        }

        public List<EntidadBase> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<EntidadBase>();

            foreach (var row in lstRows)
            {
                var entidad = new Rol
                {
                    Id = GetIntValue(row, DB_COL_ID),
                    Nombre = GetStringValue(row, DB_COL_NOMBRE),
                    Descripcion = GetStringValue(row, DB_COL_DESCRIPCION)
                };
                lstResults.Add(entidad);
            }

            return lstResults;
        }

        public SqlOperation GetRetrieveByallStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RETALL_ROLES_PR" };

            return operation;
        }

        public SqlOperation GetRetriveByIdStatement(int id)
        {
            var operation = new SqlOperation { ProcedureName = "RET_ROL_PR" };

            operation.AddIntParam(DB_COL_ID, id);

            return operation;
        }

        public SqlOperation GetRetriveByIdStatement(string id)
        {
            var operation = new SqlOperation { ProcedureName = "RET_ROL_PR" };

            operation.AddIntParam(DB_COL_ID, Convert.ToInt32(id));

            return operation;
        }

        public SqlOperation GetCreateStatement(EntidadBase entidad)
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetUpdateStatement(EntidadBase entidad)
        {
            throw new NotImplementedException();
        }

        internal SqlOperation GetRetriveByNombreStatement(string nombre)
        {
            var operation = new SqlOperation { ProcedureName = "RET_ROL_BY_NOMBRE_PR" };

            operation.AddVarcharParam(DB_COL_NOMBRE, nombre);

            return operation;
        }

        public SqlOperation GetDeleteStatement(EntidadBase entidad)
        {
            throw new NotImplementedException();
        }
    }
}
