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
    public class ClienteMapper : EntityMapper, IObjectMapper, ISqlStament
    {
        private const string DB_COL_CEDULA = "CEDULA";
        private const string DB_COL_NOMBRE = "NOMBRE";
        private const string DB_COL_PLACA = "PLACA";
        private const string DB_COL_PROFESION = "PROFESION";
        private const string DB_COL_TELEFONO = "TELEFONO";
        private const string DB_COL_CORREO = "CORREO";
        private const string DB_COL_VISITAS = "VISITAS";
        private const string DB_COL_PREMIO = "PREMIO";
        private const string DB_COL_CONFIABLE = "CONFIABLE";


        public EntidadBase BuildObject(Dictionary<string, object> row)
        {
            var cliente = new Cliente
            {
                Cedula = GetStringValue(row, DB_COL_CEDULA),
                Nombre = GetStringValue(row, DB_COL_NOMBRE),
                PlacaActual = GetStringValue(row, DB_COL_PLACA),
                Profesion = GetStringValue(row, DB_COL_PROFESION),
                Telefono = GetStringValue(row, DB_COL_TELEFONO),
                Correo = GetStringValue(row, DB_COL_CORREO),
                Visitas = GetIntValue(row, DB_COL_VISITAS),
                Premio = GetIntValue(row, DB_COL_PREMIO),
                Vetado = GetBooleanValue(row, DB_COL_CONFIABLE)
            };
            return cliente;
        }

        public object BuildObjectQr(Dictionary<string, object> row)
        {
            var qr = new QrCode
            {
                Id = GetIntValue(row, "ID"),
                Cliente = GetStringValue(row, "CLIENTE"),
                Qrcode = (byte[])GetByteArrayValue(row, "QRCODE")
            };
            return qr;
        }


        public List<EntidadBase> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<EntidadBase>();

            foreach (var row in lstRows)
            {
                var cliente = new Cliente
                {
                    Cedula = GetStringValue(row, DB_COL_CEDULA),
                    Nombre = GetStringValue(row, DB_COL_NOMBRE),
                    PlacaActual = GetStringValue(row, DB_COL_PLACA),
                    Profesion = GetStringValue(row, DB_COL_PROFESION),
                    Telefono = GetStringValue(row, DB_COL_TELEFONO),
                    Correo = GetStringValue(row, DB_COL_CORREO),
                    Visitas = GetIntValue(row, DB_COL_VISITAS),
                    Premio = GetIntValue(row, DB_COL_PREMIO),
                    Vetado = GetBooleanValue(row, DB_COL_CONFIABLE)
                };
                lstResults.Add(cliente);
            }

            return lstResults;
        }


        public SqlOperation GetCreateStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_CLIENTE_PR" };

            var u = (Cliente)entidad;

            operation.AddVarcharParam(DB_COL_CEDULA, u.Cedula);
            operation.AddVarcharParam(DB_COL_NOMBRE, u.Nombre);
            operation.AddVarcharParam(DB_COL_PLACA, u.PlacaActual);
            operation.AddVarcharParam(DB_COL_PROFESION, u.Profesion);
            operation.AddVarcharParam(DB_COL_TELEFONO, u.Telefono);
            operation.AddVarcharParam(DB_COL_CORREO, u.Correo);

            return operation;
        }

        internal SqlOperation GetRetrieveBySearchLikeStatement(string textoIngresado)
        {
            var operation = new SqlOperation { ProcedureName = "SEARCH_CLIENTE_PR" };

            operation.AddVarcharParam(DB_COL_CEDULA, textoIngresado);

            return operation;
        }

        public SqlOperation GetCreateQrCodeStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_QRCODE_PR" };

            var u = (QrCode) entidad;
            
            operation.AddVarcharParam("CLIENTE", u.Cliente);
            operation.AddByteArrayParam("QRCODE", u.Qrcode);

            return operation;
        }

        public SqlOperation GetUpdateStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "UPD_CLIENTE_PR" };

            var u = (Cliente)entidad;

            operation.AddVarcharParam(DB_COL_CEDULA, u.Cedula);
            operation.AddVarcharParam(DB_COL_NOMBRE, u.Nombre);
            operation.AddVarcharParam(DB_COL_PLACA, u.PlacaActual);
            operation.AddVarcharParam(DB_COL_PROFESION, u.Profesion);
            operation.AddVarcharParam(DB_COL_TELEFONO, u.Telefono);
            operation.AddVarcharParam(DB_COL_CORREO, u.Correo);
            operation.AddIntParam(DB_COL_VISITAS, u.Visitas);
            operation.AddIntParam(DB_COL_PREMIO, u.Premio);
            operation.AddBooleanParam(DB_COL_CONFIABLE, u.Vetado);

            return operation;
        }

        public SqlOperation GetRetriveQrByCedulaClienteStatement(string cliente)
        {
            var operation = new SqlOperation { ProcedureName = "RET_QRCODE_PR" };

            // COL CLIENTE FROM QRCODE TABLE
            operation.AddVarcharParam("CLIENTE", cliente);

            return operation;
        }
        public SqlOperation GetRetriveByIdStatement(string id)
        {
            var operation = new SqlOperation { ProcedureName = "RET_CLIENTE_PR" };

            operation.AddVarcharParam(DB_COL_CEDULA, id);

            return operation;
        }

        public SqlOperation GetRetriveByIdStatement(int id)
        {
            var operation = new SqlOperation { ProcedureName = "RET_CLIENTE_PR" };

            operation.AddVarcharParam(DB_COL_CEDULA, Convert.ToString(id));

            return operation;
        }

        public SqlOperation GetRetrieveByallStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RETALL_CLIENTE_PR" };

            return operation;
        }

        public SqlOperation GetDeleteStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_CLIENTE_PR" };

            var u = (Cliente)entidad;

            operation.AddVarcharParam(DB_COL_CEDULA, u.Cedula);

            return operation;
        } 
        public SqlOperation GetDeleteQrCodeStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_QRCODE_PR" };

            var u = (QrCode)entidad;

            // COL CLIENTE FROM QRCODE TABLE
            operation.AddVarcharParam("CLIENTE", u.Cliente);

            return operation;
        }

    }
}
