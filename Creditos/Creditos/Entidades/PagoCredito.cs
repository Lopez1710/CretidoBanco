using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creditos.Entidades
{
    public class PagoCredito
    {
        public int iDPago { get; set; }
        public decimal? Pago { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Numero_De_Cuenta_Fk { get; set; }
    }
}
