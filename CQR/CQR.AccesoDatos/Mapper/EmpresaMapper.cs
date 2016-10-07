using CQR.AccesoDatos.Mapper.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQR.Entidades.Base;
using CQR.AccesoDatos.DAO;
using CQR.Entidades;

namespace CQR.AccesoDatos.Mapper
{
    public class EmpresaMapper : EntityMapper, IObjectMapper, ISqlStament
    {
        private const string DB_COL_CEDULA_JURIDICA = "CEDULA_JURIDICA";
        private const string DB_COL_NOMBRE = "NOMBRE";
        private const string DB_COL_TELEFONO = "TELEFONO";
        private const string DB_COL_UBICACION = "UBICACION";
        private const string DB_COL_SITIO = "SITIO";

        public EntidadBase BuildObject(Dictionary<string, object> row)
        {
            var Empresa = new Empresa
            {
                CedulaJuridica = GetStringValue(row, DB_COL_CEDULA_JURIDICA),
                Nombre = GetStringValue(row, DB_COL_NOMBRE),
                Telefono = GetStringValue(row, DB_COL_TELEFONO),
                Ubicacion = GetStringValue(row, DB_COL_UBICACION),
                Sitio = GetStringValue(row, DB_COL_SITIO)
            };
            return Empresa;
        }

        public List<EntidadBase> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<EntidadBase>();

            foreach (var row in lstRows)
            {
                var cliente = new Empresa
                {
                    CedulaJuridica = GetStringValue(row, DB_COL_CEDULA_JURIDICA),
                    Nombre = GetStringValue(row, DB_COL_NOMBRE),
                    Telefono = GetStringValue(row, DB_COL_TELEFONO),
                    Ubicacion = GetStringValue(row, DB_COL_UBICACION),
                    Sitio = GetStringValue(row, DB_COL_SITIO)
                };
                lstResults.Add(cliente);
            }

            return lstResults;
        }

        public SqlOperation GetCreateStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_EMPRESA_PR" };

            var u = (Empresa)entidad;

            operation.AddVarcharParam(DB_COL_CEDULA_JURIDICA, u.CedulaJuridica);
            operation.AddVarcharParam(DB_COL_NOMBRE, u.Nombre);
            operation.AddVarcharParam(DB_COL_TELEFONO, u.Telefono);
            operation.AddVarcharParam(DB_COL_UBICACION, u.Ubicacion);
            operation.AddVarcharParam(DB_COL_SITIO, u.Sitio);

            return operation;
        }

        public SqlOperation GetDeleteStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_EMPRESA_PR" };

            var u = (Empresa)entidad;

            operation.AddVarcharParam(DB_COL_CEDULA_JURIDICA, u.CedulaJuridica);

            return operation;
        }

        public SqlOperation GetRetrieveByallStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RETALL_EMPRESA_PR" };

            return operation;
        }

        public SqlOperation GetRetriveByIdStatement(int id)
        {
            var operation = new SqlOperation { ProcedureName = "RET_EMPRESA_PR" };

            operation.AddVarcharParam(DB_COL_CEDULA_JURIDICA, Convert.ToString(id));

            return operation;
        }

        public SqlOperation GetRetriveByIdStatement(string id)
        {
            var operation = new SqlOperation { ProcedureName = "RET_EMPRESA_PR" };

            operation.AddVarcharParam(DB_COL_CEDULA_JURIDICA, id);

            return operation;
        }

        public SqlOperation GetUpdateStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "UPD_EMPRESA_PR" };

            var u = (Empresa)entidad;

            operation.AddVarcharParam(DB_COL_CEDULA_JURIDICA, u.CedulaJuridica);
            operation.AddVarcharParam(DB_COL_NOMBRE, u.Nombre);
            operation.AddVarcharParam(DB_COL_TELEFONO, u.Telefono);
            operation.AddVarcharParam(DB_COL_UBICACION, u.Ubicacion);
            operation.AddVarcharParam(DB_COL_SITIO, u.Sitio);

            return operation;
        }
    }
}
