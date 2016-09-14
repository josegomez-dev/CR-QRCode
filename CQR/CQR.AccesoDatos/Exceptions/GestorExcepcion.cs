using CQR.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQR.AccesoDatos.Exceptions
{
    public class GestorExcepcion
    {
        private static GestorExcepcion _instance;

        public GestorExcepcion() { }

        public static GestorExcepcion GetInstance()
        {
            return _instance ?? (_instance = new GestorExcepcion());
        }

        public CQR_Exception ControlarExcepcion(Exception pex)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\alego\Desktop\Log_Exceptions_CQR.txt", true))
            {
                file.WriteLine("--------------");
                file.WriteLine("Hora: " + DateTime.Now.ToString("h:mm:ss tt"));
                file.WriteLine("Fecha: " + DateTime.Now.ToString("M/d/yyyy"));
                file.WriteLine("Excepcion: " + pex.Message);
                file.WriteLine("--------------");
            }

            return default(CQR_Exception);
        }

        public System.Data.SqlClient.SqlException ControlarExcepcion(System.Data.SqlClient.SqlException pex)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\alego\Desktop\Log_Exceptions_CQR.txt", true))
            {
                file.WriteLine("--------------");
                file.WriteLine("Hora: " + DateTime.Now.ToString("h:mm:ss tt"));
                file.WriteLine("Fecha: " + DateTime.Now.ToString("M/d/yyyy"));
                file.WriteLine("Excepcion: " + pex.Message);
                file.WriteLine("--------------");
            }

            return default(System.Data.SqlClient.SqlException);
        }

    }
}
