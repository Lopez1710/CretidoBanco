using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creditos.Entidades
{
    public class Cliente
    {
        public int Numero_De_Cuenta { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int? DUI { get; set; }
        public int? Codigo_De_Seguridad { get; set; }
        public string Direccion { get; set; }
        public decimal? Deuda { get; set; }
        public decimal? Cuota { get; set; }
        public int? Pagos_Realizados { get; set; }
    }
}
