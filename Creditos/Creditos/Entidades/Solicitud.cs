using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creditos.Entidades
{
    public class Solicitud
    {
        public int iDSolicitud { get; set; }
        public decimal? CantidadP { get; set; }
        public int? Plasos { get; set; }
        public int? Numero_De_Cuenta_FK { get; set; }
        public string Interes { get; set; }
        public string Tipo_De_Garantia { get; set; }
        public int? Id_Estado { get; set; }
    }
}
