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
    public class ServicioMapper : EntityMapper, IObjectMapper, ISqlStament
    {
        private const string DB_COL_ID = "ID";
        private const string DB_COL_NOMBRE = "NOMBRE";
        private const string DB_COL_DESCRIPCION = "DESCRIPCION";
        private const string DB_COL_COSTO = "COSTO";

        public EntidadBase BuildObject(Dictionary<string, object> row)
        {
            var servicio = new Servicio
            {
                Id = GetIntValue(row, DB_COL_ID),
                Nombre = GetStringValue(row, DB_COL_NOMBRE),
                Descripcion = GetStringValue(row, DB_COL_DESCRIPCION),
                Costo = GetDoubleValue(row, DB_COL_COSTO)
            };
            return servicio;
        }

        public List<EntidadBase> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<EntidadBase>();

            foreach (var row in lstRows)
            {
                var servicio = new Servicio
                {
                    Id = GetIntValue(row, DB_COL_ID),
                    Nombre = GetStringValue(row, DB_COL_NOMBRE),
                    Descripcion = GetStringValue(row, DB_COL_DESCRIPCION),
                    Costo = GetDoubleValue(row, DB_COL_COSTO)
                };
                lstResults.Add(servicio);
            }

            return lstResults;
        }

        public SqlOperation GetCreateStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_SERVICIO_PR" };

            var u = (Servicio)entidad;

            operation.AddIntParam(DB_COL_ID, u.Id);
            operation.AddVarcharParam(DB_COL_NOMBRE, u.Nombre);
            operation.AddVarcharParam(DB_COL_DESCRIPCION, u.Descripcion);
            operation.AddDoubleParam(DB_COL_COSTO, u.Costo);

            return operation;
        }

        public SqlOperation GetDeleteStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_SERVICIO_PR" };

            var u = (Servicio)entidad;

            operation.AddIntParam(DB_COL_ID, u.Id);

            return operation;
        }
        public SqlOperation GetDeleteByNombreStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_SERVICIO_BY_NOMBRE_PR" };

            var u = (Servicio)entidad;

            operation.AddVarcharParam(DB_COL_NOMBRE, u.Nombre);

            return operation;
        }
        public SqlOperation GetRetrieveByallStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RETALL_SERVICIOS_PR" };

            return operation;
        }

        public SqlOperation GetRetriveByIdStatement(int id)
        {
            var operation = new SqlOperation { ProcedureName = "RET_SERVICIO_PR" };

            operation.AddVarcharParam(DB_COL_ID, Convert.ToString(id));

            return operation;
        }

        public SqlOperation GetRetriveByIdStatement(string id)
        {
            var operation = new SqlOperation { ProcedureName = "RET_SERVICIO_PR" };

            operation.AddVarcharParam(DB_COL_ID, id);

            return operation;
        }

        public SqlOperation GetUpdateStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "UPD_SERVICIO_PR" };

            var u = (Servicio)entidad;

            operation.AddIntParam(DB_COL_ID, u.Id);
            operation.AddVarcharParam(DB_COL_NOMBRE, u.Nombre);
            operation.AddVarcharParam(DB_COL_DESCRIPCION, u.Descripcion);
            operation.AddDoubleParam(DB_COL_COSTO, u.Costo);
            
            return operation;
        }

    }
}
