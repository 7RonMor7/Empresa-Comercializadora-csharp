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
    public class PagoRepositorio
    {
        string conexion = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;

        //Metodo para registrar un pago
        public void Registrar(Pago pago)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                string sql = "INSERT INTO Pagos (IdPago, IdPoliza, FechaPago, FormaPago, Monto, NumeroCuota) " +
                               "VALUES (@IdPago, @IdPoliza, @FechaPago, @FormaPago, @Monto, @NumeroCuota)";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@IdPago", pago.IdPago);
                cmd.Parameters.AddWithValue("@IdPoliza", pago.IdPoliza);
                cmd.Parameters.AddWithValue("@FechaPago", pago.FechaPago);
                cmd.Parameters.AddWithValue("@FormaPago", pago.FormaPago);
                cmd.Parameters.AddWithValue("@Monto", pago.Monto);
                cmd.Parameters.AddWithValue("@NumeroCuota", pago.NumeroCuota);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable Listar()
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                string sql = "SELECT * FROM Pagos";
                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable Filtrar(string criterio, string valor)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                string sql = $"SELECT * FROM Pagos WHERE {criterio} LIKE @Valor";
                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                da.SelectCommand.Parameters.AddWithValue("@Valor", "%" + valor + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public Pago ObtenerPorId(int idPago)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                string sql = "SELECT * FROM Pagos WHERE IdPago = @IdPago";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@IdPago", idPago);

                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Pago
                    {
                        IdPago = (int)reader["IdPago"],
                        IdPoliza = (int)reader["IdPoliza"],                    
                        FechaPago = (DateTime)reader["FechaPago"],
                        FormaPago = reader["FormaPago"].ToString(),
                        Monto = (decimal)reader["Monto"],
                        NumeroCuota = (int)reader["NumeroCuota"]
                    };
                }
                return null;
            }
        }

        public DataTable FiltrarPagos(string cliente, string tipoSeguro, DateTime? fechaPago)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                string query = @"SELECT pa.IdPago, c.Nombre AS Cliente, s.Tipo AS Seguro,
                                pa.FechaPago, pa.FormaPago, pa.Monto, pa.NumeroCuota
                         FROM Pagos pa
                         INNER JOIN Polizas p ON pa.IdPoliza = p.IdPoliza
                         INNER JOIN Clientes c ON p.IdCliente = c.IdCliente
                         INNER JOIN Seguros s ON p.IdSeguro = s.IdSeguro
                         WHERE (@Cliente = '' OR c.Nombre LIKE '%' + @Cliente + '%')
                         AND (@TipoSeguro = '' OR s.Tipo LIKE '%' + @TipoSeguro + '%')
                         AND (@FechaPago IS NULL OR CONVERT(date, pa.FechaPago) = CONVERT(date, @FechaPago))";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Cliente", cliente ?? "");
                cmd.Parameters.AddWithValue("@TipoSeguro", tipoSeguro ?? "");
                cmd.Parameters.AddWithValue("@FechaPago", (object)fechaPago ?? DBNull.Value);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
