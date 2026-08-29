using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa_Comercializadora.Modelo
{
    public class Aseguradora
    {
        public int IdAseguradora { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string SitioWeb { get; set; }

        public Aseguradora()
        {
            // Constructor vacío
        }

        public Aseguradora(int idAseguradora, string nombre, string direccion,
                          string telefono, string correo, string sitioWeb)
        {
            IdAseguradora = idAseguradora;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            Correo = correo;
            SitioWeb = sitioWeb;
        }

        public override string ToString()
        {
            return Nombre; // Para mostrar en ComboBox
        }
    }
}
