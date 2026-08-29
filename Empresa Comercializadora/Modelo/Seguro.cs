using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa_Comercializadora.Modelo
{
    public class Seguro
    {
        public int IdSeguro { get; set; }
        public int IdAseguradora { get; set; }
        public string Tipo { get; set; }
        public string Cobertura { get; set; }
        public decimal Costo { get; set; }
        public int DuracionMeses { get; set; }
        public string Beneficios { get; set; }
        public string Exclusiones { get; set; }
        public string Condiciones { get; set; }

        // no esta en bd pero lo llenamos manualmente
        public string NombreAseguradora { get; set; }  // Para el detalle
        public string Aseguradora { get; set; }        // Para el DataGridView


        public Seguro()
        {
            // Constructor vacío
        }

        public Seguro(int idSeguro, int idAseguradora, string tipo, string cobertura,
                      decimal costo, int duracionMeses, string beneficios,
                      string exclusiones, string condiciones)
        {
            IdSeguro = idSeguro;
            IdAseguradora = idAseguradora;
            Tipo = tipo;
            Cobertura = cobertura;
            Costo = costo;
            DuracionMeses = duracionMeses;
            Beneficios = beneficios;
            Exclusiones = exclusiones;
            Condiciones = condiciones;
        }
    }
}

