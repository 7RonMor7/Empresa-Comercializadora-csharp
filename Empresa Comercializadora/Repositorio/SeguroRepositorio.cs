using Empresa_Comercializadora.Modelo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa_Comercializadora.Repositorio
{
    public class SeguroRepositorio
    {
        string conexion = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;

        // CREATE - Registrar nuevo seguro
        public void Registrar(Seguro seguro)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                string sql = @"INSERT INTO Seguros (IdAseguradora, Tipo, Cobertura, Costo, 
                               DuracionMeses, Beneficios, Exclusiones, Condiciones) 
                               VALUES (@IdAseguradora, @Tipo, @Cobertura, @Costo, 
                               @DuracionMeses, @Beneficios, @Exclusiones, @Condiciones)";

                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@IdAseguradora", seguro.IdAseguradora);
                cmd.Parameters.AddWithValue("@Tipo", seguro.Tipo);
                cmd.Parameters.AddWithValue("@Cobertura", seguro.Cobertura);
                cmd.Parameters.AddWithValue("@Costo", seguro.Costo);
                cmd.Parameters.AddWithValue("@DuracionMeses", seguro.DuracionMeses);
                cmd.Parameters.AddWithValue("@Beneficios", seguro.Beneficios ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Exclusiones", seguro.Exclusiones ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Condiciones", seguro.Condiciones ?? (object)DBNull.Value);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // READ - Listar todos los seguros con nombre de aseguradora
        public DataTable Listar()
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                string sql = @"SELECT s.IdSeguro, s.IdAseguradora, a.Nombre AS Aseguradora, 
                               s.Tipo, s.Cobertura, s.Costo, s.DuracionMeses, 
                               s.Beneficios, s.Exclusiones, s.Condiciones
                               FROM Seguros s
                               INNER JOIN Aseguradoras a ON s.IdAseguradora = a.IdAseguradora
                               ORDER BY s.IdSeguro DESC";

                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // UPDATE - Actualizar seguro existente
        public void Actualizar(Seguro seguro)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                string sql = @"UPDATE Seguros SET 
                               IdAseguradora = @IdAseguradora,
                               Tipo = @Tipo,
                               Cobertura = @Cobertura,
                               Costo = @Costo,
                               DuracionMeses = @DuracionMeses,
                               Beneficios = @Beneficios,
                               Exclusiones = @Exclusiones,
                               Condiciones = @Condiciones
                               WHERE IdSeguro = @IdSeguro";

                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@IdSeguro", seguro.IdSeguro);
                cmd.Parameters.AddWithValue("@IdAseguradora", seguro.IdAseguradora);
                cmd.Parameters.AddWithValue("@Tipo", seguro.Tipo);
                cmd.Parameters.AddWithValue("@Cobertura", seguro.Cobertura);
                cmd.Parameters.AddWithValue("@Costo", seguro.Costo);
                cmd.Parameters.AddWithValue("@DuracionMeses", seguro.DuracionMeses);
                cmd.Parameters.AddWithValue("@Beneficios", seguro.Beneficios ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Exclusiones", seguro.Exclusiones ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Condiciones", seguro.Condiciones ?? (object)DBNull.Value);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // DELETE - Eliminar seguro
        public void Eliminar(int idSeguro)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                string sql = "DELETE FROM Seguros WHERE IdSeguro = @IdSeguro";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@IdSeguro", idSeguro);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Obtener un seguro específico por ID
        public Seguro ObtenerPorId(int idSeguro)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                string sql = @"SELECT s.*, a.Nombre AS NombreAseguradora 
                               FROM Seguros s
                               INNER JOIN Aseguradoras a ON s.IdAseguradora = a.IdAseguradora
                               WHERE s.IdSeguro = @IdSeguro";

                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@IdSeguro", idSeguro);

                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Seguro
                    {
                        IdSeguro = (int)reader["IdSeguro"],
                        IdAseguradora = (int)reader["IdAseguradora"],
                        NombreAseguradora = reader["NombreAseguradora"].ToString(),
                        Tipo = reader["Tipo"].ToString(),
                        Cobertura = reader["Cobertura"].ToString(),
                        Costo = (decimal)reader["Costo"],
                        DuracionMeses = (int)reader["DuracionMeses"],
                        Beneficios = reader["Beneficios"] != DBNull.Value ? reader["Beneficios"].ToString() : "",
                        Exclusiones = reader["Exclusiones"] != DBNull.Value ? reader["Exclusiones"].ToString() : "",
                        Condiciones = reader["Condiciones"] != DBNull.Value ? reader["Condiciones"].ToString() : ""
                    };
                }
                return null;
            }
        }

        // BÚSQUEDA AVANZADA con múltiples criterios
        public DataTable BuscarAvanzado(string tipo, string aseguradora, decimal? costoMin,
                                        decimal? costoMax, int? duracionMin, int? duracionMax)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                string sql = @"SELECT s.IdSeguro, a.Nombre AS Aseguradora, s.Tipo, 
                               s.Cobertura, s.Costo, s.DuracionMeses
                               FROM Seguros s
                               INNER JOIN Aseguradoras a ON s.IdAseguradora = a.IdAseguradora
                               WHERE 1=1";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;

                // Filtro por tipo
                if (!string.IsNullOrEmpty(tipo) && tipo != "Todos")
                {
                    sql += " AND s.Tipo = @Tipo";
                    cmd.Parameters.AddWithValue("@Tipo", tipo);
                }

                // Filtro por aseguradora
                if (!string.IsNullOrEmpty(aseguradora))
                {
                    sql += " AND a.Nombre LIKE @Aseguradora";
                    cmd.Parameters.AddWithValue("@Aseguradora", "%" + aseguradora + "%");
                }

                // Filtro por costo mínimo
                if (costoMin.HasValue)
                {
                    sql += " AND s.Costo >= @CostoMin";
                    cmd.Parameters.AddWithValue("@CostoMin", costoMin.Value);
                }

                // Filtro por costo máximo
                if (costoMax.HasValue)
                {
                    sql += " AND s.Costo <= @CostoMax";
                    cmd.Parameters.AddWithValue("@CostoMax", costoMax.Value);
                }

                // Filtro por duración mínima
                if (duracionMin.HasValue)
                {
                    sql += " AND s.DuracionMeses >= @DuracionMin";
                    cmd.Parameters.AddWithValue("@DuracionMin", duracionMin.Value);
                }

                // Filtro por duración máxima
                if (duracionMax.HasValue)
                {
                    sql += " AND s.DuracionMeses <= @DuracionMax";
                    cmd.Parameters.AddWithValue("@DuracionMax", duracionMax.Value);
                }

                sql += " ORDER BY s.Costo ASC";
                cmd.CommandText = sql;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // Búsqueda simple por texto en cobertura
        public DataTable BuscarPorCobertura(string textoBusqueda)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                string sql = @"SELECT s.IdSeguro, a.Nombre AS Aseguradora, s.Tipo, 
                               s.Cobertura, s.Costo, s.DuracionMeses
                               FROM Seguros s
                               INNER JOIN Aseguradoras a ON s.IdAseguradora = a.IdAseguradora
                               WHERE s.Cobertura LIKE @Texto OR s.Beneficios LIKE @Texto";

                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                da.SelectCommand.Parameters.AddWithValue("@Texto", "%" + textoBusqueda + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

    }
}
