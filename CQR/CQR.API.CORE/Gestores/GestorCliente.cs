using CQR.AccesoDatos.CRUD;
using CQR.API.CORE.Gestores.Base;
using CQR.Entidades;
using CQR.Entidades.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//gestorApi
namespace CQR.API.CORE.Gestores
{
    public class GestorCliente : GestorAPI
    {
        private ClienteCrudFactory _crudFactory;

        public GestorCliente(Usuario usuario) : base(usuario)
        {
            _crudFactory = new ClienteCrudFactory();
        }
        
        public void Create(Cliente cliente)
        {
            if (!string.IsNullOrEmpty(Convert.ToString(cliente.Cedula)))
            {
                _crudFactory.Create(cliente);
            }
            else
            {
                throw new Exception();
            }
        }

        public void CreateQrCode(QrCode qr)
        {
            if (!string.IsNullOrEmpty(qr.Cliente))
            {
                _crudFactory.CreateQrCode(qr);
            }
            else
            {
                throw new Exception();
            }
        }


        public void Update(Cliente cliente)
        {
            if (!string.IsNullOrEmpty(Convert.ToString(cliente.Cedula)))
            {
                _crudFactory.Update(cliente);
            }
            else
            {
                throw new Exception();
            }

        }

        public void Delete(Cliente cliente, QrCode qr)
        {
            if (!string.IsNullOrEmpty(Convert.ToString(qr.Cliente)))
            {
                // DELETE QRCODE
                _crudFactory.DeleteQrCode(qr);
            
                if (!string.IsNullOrEmpty(Convert.ToString(cliente.Cedula)))
                {
                    // DELETE CLIENTE
                    _crudFactory.Delete(cliente);
                }
                else
                {
                    throw new Exception();
                }
            }
            else
            {
                throw new Exception();
            }

        }

        public void Delete(Cliente cliente)
        {
            if (!string.IsNullOrEmpty(Convert.ToString(cliente.Cedula)))
            {
                _crudFactory.Delete(cliente);
            }
            else
            {
                throw new Exception();
            }
        }

        public Cliente RetrievePorId(string id)
        {
            var cliente = new Cliente { Cedula = id };

            return _crudFactory.Retrieve<Cliente>(Convert.ToString(cliente.Cedula));
        }
        public QrCode RetrieveQRCodePorId(string cedulaCliente)
        {
            var qr = new QrCode { Cliente = cedulaCliente };

            return _crudFactory.RetrieveQr<QrCode>(qr.Cliente);
        }

        public List<Cliente> RetrieveAll()
        {
            return _crudFactory.RetrieveAll<Cliente>();
        }

        public List<Cliente> searchLike(string text)
        {
            return _crudFactory.SearchLike<Cliente>(text);
        }

    }
}
