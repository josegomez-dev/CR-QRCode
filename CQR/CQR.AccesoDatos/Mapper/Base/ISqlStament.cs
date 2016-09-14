using CQR.AccesoDatos.DAO;
using CQR.Entidades.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQR.AccesoDatos.Mapper.Base
{
    interface ISqlStament
    {
        SqlOperation GetCreateStatement(EntidadBase entidad);
        SqlOperation GetUpdateStatement(EntidadBase entidad);
        SqlOperation GetRetriveByIdStatement(String id);
        SqlOperation GetRetriveByIdStatement(int id);
        SqlOperation GetRetrieveByallStatement();
        SqlOperation GetDeleteStatement(EntidadBase entidad);

    }
}
