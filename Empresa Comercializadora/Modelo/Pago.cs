using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa_Comercializadora.Modelo
{
    public class Pago
    {
        public int IdPago { get; set; }
        public int IdPoliza { get; set; }
        public DateTime FechaPago { get; set; }
        public string FormaPago { get; set; }
        public decimal Monto { get; set; }
        public int NumeroCuota { get; set; }
    }
}
