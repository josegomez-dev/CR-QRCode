using CQR.AccesoDatos.Mapper.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQR.Entidades.Base;
using CQR.Entidades;
using CQR.AccesoDatos.DAO;

namespace CQR.AccesoDatos.Mapper
{
    public class UsuarioMapper : EntityMapper, IObjectMapper, ISqlStament
    {
        private const string DB_COL_NOMBRE = "NOMBRE";
        private const string DB_COL_NICK = "NICK";
        private const string DB_COL_CLAVE = "CLAVE";
        private const string DB_COL_EMAIL = "EMAIL";
        private const string DB_COL_TELEFONO = "TELEFONO";
        private const string DB_COL_ROL = "ID_ROL";
        

        public EntidadBase BuildObject(Dictionary<string, object> row)
        {
            var usuario = new Usuario
            {
                Nombre = GetStringValue(row, DB_COL_NOMBRE),
                Nick = GetStringValue(row, DB_COL_NICK),
                Clave = GetStringValue(row, DB_COL_CLAVE),
                Email = GetStringValue(row, DB_COL_EMAIL),
                Telefono = GetStringValue(row, DB_COL_TELEFONO),
                Rol = GetIntValue(row, DB_COL_ROL)
            };
            return usuario;
        }
        
        public List<EntidadBase> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<EntidadBase>();

            foreach (var row in lstRows)
            {
                var usuario = new Usuario
                {
                    Nombre = GetStringValue(row, DB_COL_NOMBRE),
                    Nick = GetStringValue(row, DB_COL_NICK),
                    Clave = GetStringValue(row, DB_COL_CLAVE),
                    Email = GetStringValue(row, DB_COL_EMAIL),
                    Telefono = GetStringValue(row, DB_COL_TELEFONO),
                    Rol = GetIntValue(row, DB_COL_ROL)
                };
                lstResults.Add(usuario);
            }

            return lstResults;
        }


        public SqlOperation GetCreateStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_USUARIO_PR" };

            var u = (Usuario)entidad;

            operation.AddVarcharParam(DB_COL_NOMBRE, u.Nombre);
            operation.AddVarcharParam(DB_COL_NICK, u.Nick);
            operation.AddVarcharParam(DB_COL_CLAVE, u.Clave);
            operation.AddVarcharParam(DB_COL_EMAIL, u.Email);
            operation.AddVarcharParam(DB_COL_TELEFONO, u.Telefono);
            operation.AddIntParam(DB_COL_ROL, u.Rol);

            return operation;
        }
        
        public SqlOperation GetUpdateStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "UPD_USUARIO_PR" };

            var u = (Usuario)entidad;

            operation.AddVarcharParam(DB_COL_NOMBRE, u.Nombre);
            operation.AddVarcharParam(DB_COL_NICK, u.Nick);
            operation.AddVarcharParam(DB_COL_CLAVE, u.Clave);
            operation.AddVarcharParam(DB_COL_EMAIL, u.Email);
            operation.AddVarcharParam(DB_COL_TELEFONO, u.Telefono);
            operation.AddIntParam(DB_COL_ROL, u.Rol);

            return operation;
        }
        internal SqlOperation GetRetrieveBySearchLikeStatement(string textoIngresado)
        {
            var operation = new SqlOperation { ProcedureName = "SEARCH_USUARIO_PR" };

            operation.AddVarcharParam(DB_COL_NICK, textoIngresado);

            return operation;
        }

        public SqlOperation GetRetriveByIdStatement(string nick)
        {
            var operation = new SqlOperation { ProcedureName = "RET_USUARIO_PR" };

            operation.AddVarcharParam(DB_COL_NICK, nick);

            return operation;
        }

        public SqlOperation GetRetriveByIdStatement(int id)
        {
            var operation = new SqlOperation { ProcedureName = "RET_USUARIO_PR" };

            operation.AddVarcharParam(DB_COL_NICK, Convert.ToString(id));

            return operation;
        }

        public SqlOperation GetRetrieveByallStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RETALL_USUARIOS_PR" };

            return operation;
        }

        public SqlOperation GetDeleteStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_USUARIO_PR" };

            var u = (Usuario)entidad;

            operation.AddVarcharParam(DB_COL_NICK, u.Nick);

            return operation;
        }
        

    }
}
