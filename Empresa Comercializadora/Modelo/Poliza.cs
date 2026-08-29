using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa_Comercializadora.Modelo
{
    public class Poliza
    {
        public int IdPoliza { get; set; }
        public int IdCliente { get; set; }
        public int IdSeguro { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Estado { get; set; }
        public decimal Monto { get; set; }
        public string Observaciones { get; set; }
    }
}
