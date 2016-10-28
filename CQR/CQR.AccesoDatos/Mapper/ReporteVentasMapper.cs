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
    public class ReporteVentasMapper : EntityMapper, IObjectMapper, ISqlStament
    {
        private const string DB_COL_ID = "ID";
        private const string DB_COL_FECHA = "FECHA";
        private const string DB_COL_MONTO = "MONTO";
        private const string DB_COL_CLIENTE = "CLIENTE";
        private const string DB_COL_SERVICIO = "SERVICIO";

        public EntidadBase BuildObject(Dictionary<string, object> row)
        {
            var reporte = new ReporteVentas
            {
                Id = GetIntValue(row, DB_COL_ID),
                Fecha = GetDateValue(row, DB_COL_FECHA),
                Monto = GetDecimalValue(row, DB_COL_MONTO),
                Cliente = GetStringValue(row, DB_COL_CLIENTE),
                Servicio = GetStringValue(row, DB_COL_SERVICIO)
            };
            return reporte;
        }

        public List<EntidadBase> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<EntidadBase>();

            foreach (var row in lstRows)
            {
                var reporte = new ReporteVentas
                {
                    Id = GetIntValue(row, DB_COL_ID),
                    Fecha = GetDateValue(row, DB_COL_FECHA),
                    Monto = GetDecimalValue(row, DB_COL_MONTO),
                    Cliente = GetStringValue(row, DB_COL_CLIENTE),
                    Servicio = GetStringValue(row, DB_COL_SERVICIO)
                };
                lstResults.Add(reporte);
            }

            return lstResults;
        }

        public SqlOperation GetCreateStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_REPORTEVENTAS_PR" };

            var u = (ReporteVentas)entidad;

            operation.AddDateTimeParam(DB_COL_FECHA, u.Fecha);
            operation.AddDecimalParam(DB_COL_MONTO, u.Monto);
            operation.AddVarcharParam(DB_COL_CLIENTE, u.Cliente);
            operation.AddVarcharParam(DB_COL_SERVICIO, u.Servicio);

            return operation;
        }

        public SqlOperation GetDeleteStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_REPORTEVENTAS_PR" };

            var u = (ReporteVentas)entidad;

            operation.AddIntParam(DB_COL_ID, u.Id);

            return operation;
        }
        public SqlOperation GetDeleteByNombreStatement(EntidadBase entidad)
        {
            return null;
        }
        public SqlOperation GetRetrieveByallStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RETALL_REPORTEVENTAS_PR" };

            return operation;
        }

        public SqlOperation GetRetriveByIdStatement(int id)
        {
            var operation = new SqlOperation { ProcedureName = "RET_REPORTEVENTAS_PR" };

            operation.AddVarcharParam(DB_COL_ID, Convert.ToString(id));

            return operation;
        }

        public SqlOperation GetRetriveByIdStatement(string id)
        {
            var operation = new SqlOperation { ProcedureName = "RET_REPORTEVENTAS_PR" };

            operation.AddVarcharParam(DB_COL_ID, id);

            return operation;
        }

        public SqlOperation GetUpdateStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "UPD_REPORTEVENTAS_PR" };

            var u = (ReporteVentas)entidad;

            operation.AddIntParam(DB_COL_ID, u.Id);
            operation.AddDateTimeParam(DB_COL_FECHA, u.Fecha);
            operation.AddDecimalParam(DB_COL_MONTO, u.Monto);
            operation.AddVarcharParam(DB_COL_CLIENTE, u.Cliente);
            operation.AddVarcharParam(DB_COL_SERVICIO, u.Servicio);
            
            return operation;
        }
    }
}
