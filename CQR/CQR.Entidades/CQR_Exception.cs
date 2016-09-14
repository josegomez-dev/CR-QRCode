using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQR.Entidades
{
    public class CQR_Exception
    {
        public string Mensaje { get; set; }

        public enum ExceptionCode
        {
            CorreoNotMatch,
            CedulaEnBlanco,
            ColorLineaRepetido,
            ContrasenaNotMatch,
            Fatal,
            MatriculaTrenNoEncontrado,
            MatriculaTrenRepetido,
            NoData,
            NombreEstacionRepetido,
            NombreLineaRepetido,
            TrenNotAsocLinea,
            CorreoNotExist,
            PuestoConPermiso,
            PermisosConPuesto,
            CedulaDuplicada,
            PermisoYaIngreso
        }

        public ExceptionCode Codigo { get; set; }
        public string Msj { get; set; }

        public CQR_Exception(ExceptionCode code)
        {
            Codigo = code;
        }
        public CQR_Exception(Exception ex)
        {
            Codigo = ExceptionCode.Fatal;
        }

    }
}
