using CQR.Entidades;
using CQR.AccesoDatos.CRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQR
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteCrudFactory clienteCrudFactory = new ClienteCrudFactory();

            var cliente = new Cliente()
            {
                Cedula = "007",
                Nombre = "James Bon",
                Telefono = "007",
                Correo = "jbonds@ucenfotec.ac.cr",
                Visitas = 0,
                Premio = 0
            };

            cliente.Visitas++;
            cliente.Premio++;

            try
            {
                clienteCrudFactory.Create(cliente);
                Console.WriteLine("CONOCE");
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                switch (ex.Number)
                {
                    case 2627:
                        Console.WriteLine("La cedula ya ha sido registrada");
                        break;
                    case 201: 
                        Console.WriteLine("Falta un parametro que no puede ser nulo");
                        break;
                    case 515:
                        Console.WriteLine("No se aceptan campos vacios");
                        break;
                    default:
                        Console.WriteLine(ex.Message);
                        break;
                }
            }
           

            while (true)
            {

            }

        }
    }
}
