using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CQR.AccesoDatos.DAO
{
    public class SqlDao
    {
        //private static string CONNECTION_STRING = System.Configuration.ConfigurationManager.ConnectionStrings["TRV_DB"].ConnectionString.ToString();
        private static string CONNECTION_STRING = @"Data Source=DESKTOP-ASB0D8M\MSFREAKAZOID;Initial Catalog=CQR_DB;Integrated Security=True";

        public static void ExecuteProcedure(SqlOperation sqlOperation)
        {
            using (var conn = new SqlConnection(CONNECTION_STRING))
            using (var command = new SqlCommand(sqlOperation.ProcedureName, conn)
            {
                CommandType = CommandType.StoredProcedure
            })
            {
                foreach (var param in sqlOperation.Parameters)
                {
                    command.Parameters.Add(param);
                }
                try
                {

                    conn.Open();
                    command.ExecuteNonQuery();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        public static List<Dictionary<string, object>> ExecuteQueryProcedure(SqlOperation sqlOperation)
        {

            var lstResult = new List<Dictionary<string, object>>();

            using (var conn = new SqlConnection(CONNECTION_STRING))
            using (var command = new SqlCommand(sqlOperation.ProcedureName, conn)
            {
                CommandType = CommandType.StoredProcedure
            })
            {
                foreach (var param in sqlOperation.Parameters)
                {
                    command.Parameters.Add(param);
                }

                try
                {
                    conn.Open();

                    var reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var dict = new Dictionary<string, object>();

                            for (var lp = 0; lp < reader.FieldCount; lp++)
                            {
                                dict.Add(reader.GetName(lp), reader.GetValue(lp));
                            }
                            lstResult.Add(dict);
                        }
                    }

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }

            return lstResult;
        }

        public static bool ExecuteQueryProcedureBoolean(SqlOperation sqlOperation)
        {
            bool itWorked = false;

            using (var conn = new SqlConnection(CONNECTION_STRING))
            using (var command = new SqlCommand(sqlOperation.ProcedureName, conn)
            {
                CommandType = CommandType.StoredProcedure
            })
            try
            {
                {
                    foreach (var param in sqlOperation.Parameters)
                    {
                        command.Parameters.Add(param);
                    }


                    conn.Open();
                    var reader = command.ExecuteNonQuery();
                    if (reader > 0)
                    {
                        itWorked = true;
                    }

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return itWorked;
        }

        public static bool CanExecuteQueryProcedure(SqlOperation sqlOperation)
        {
            bool resul = false;
            var lstResult = new List<Dictionary<string, object>>();

            using (var conn = new SqlConnection(CONNECTION_STRING))
            using (var command = new SqlCommand(sqlOperation.ProcedureName, conn)
            {
                CommandType = CommandType.StoredProcedure
            })
                try
                {

                    {
                        // Entra solo si el procedimiento tiene parametros
                        foreach (var param in sqlOperation.Parameters)
                        {
                            command.Parameters.Add(param);
                        }



                        conn.Open();
                        var upt = command.ExecuteNonQuery();

                        if (upt > 0)
                        {
                            resul = true;
                        }
                    }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return resul;
        }

    }
}
