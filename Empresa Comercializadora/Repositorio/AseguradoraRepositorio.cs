using Empresa_Comercializadora.Modelo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa_Comercializadora.Repositorio
{
    public class AseguradoraRepositorio
    {
        string conexion = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;

        // Listar todas las aseguradoras (para ComboBox)
        public List<Aseguradora> ListarTodas()
        {
            List<Aseguradora> lista = new List<Aseguradora>();

            using (SqlConnection cn = new SqlConnection(conexion))
            {
                string sql = "SELECT * FROM Aseguradoras ORDER BY Nombre";
                SqlCommand cmd = new SqlCommand(sql, cn);

                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new Aseguradora
                    {
                        IdAseguradora = (int)reader["IdAseguradora"],
                        Nombre = reader["Nombre"].ToString(),
                        Direccion = reader["Direccion"].ToString(),
                        Telefono = reader["Telefono"].ToString(),
                        Correo = reader["Correo"].ToString(),
                        SitioWeb = reader["SitioWeb"].ToString()
                    });
                }
            }

            return lista;
        }

        // Obtener DataTable para DataGridView
        public DataTable ListarDataTable()
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                string sql = "SELECT * FROM Aseguradoras ORDER BY Nombre";
                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // Obtener aseguradora por ID
        public Aseguradora ObtenerPorId(int idAseguradora)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                string sql = "SELECT * FROM Aseguradoras WHERE IdAseguradora = @Id";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@Id", idAseguradora);

                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Aseguradora
                    {
                        IdAseguradora = (int)reader["IdAseguradora"],
                        Nombre = reader["Nombre"].ToString(),
                        Direccion = reader["Direccion"].ToString(),
                        Telefono = reader["Telefono"].ToString(),
                        Correo = reader["Correo"].ToString(),
                        SitioWeb = reader["SitioWeb"].ToString()
                    };
                }
            }
            return null;

        }
    }
}
