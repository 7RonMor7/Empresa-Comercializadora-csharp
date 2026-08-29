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
    public class ClienteRepositorio
    {
        string conexion = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;

        // LISTAR todos los clientes
        public DataTable Listar()
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                string sql = @"SELECT IdCliente, Nombre, Apellido, Direccion, 
                               Telefono, Correo, HistorialCrediticio, FechaRegistro
                               FROM Clientes
                               ORDER BY Apellido, Nombre";

                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // OBTENER un cliente por ID
        public Cliente ObtenerPorId(int idCliente)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                string sql = "SELECT * FROM Clientes WHERE IdCliente = @IdCliente";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@IdCliente", idCliente);

                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Cliente
                    {
                        IdCliente = (int)reader["IdCliente"],
                        Nombre = reader["Nombre"].ToString(),
                        Apellido = reader["Apellido"].ToString(),
                        Direccion = reader["Direccion"] != DBNull.Value ? reader["Direccion"].ToString() : "",
                        Telefono = reader["Telefono"] != DBNull.Value ? reader["Telefono"].ToString() : "",
                        Correo = reader["Correo"] != DBNull.Value ? reader["Correo"].ToString() : "",
                        HistorialCrediticio = reader["HistorialCrediticio"].ToString(),
                        FechaRegistro = (DateTime)reader["FechaRegistro"]
                    };
                }
                return null;
            }
        }

        // REGISTRAR nuevo cliente
        public void Registrar(Cliente cliente)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                string sql = @"INSERT INTO Clientes (IdCliente, Nombre, Apellido, Direccion, Telefono, 
                               Correo, HistorialCrediticio, FechaRegistro) 
                               VALUES (@IdCliente, @Nombre, @Apellido, @Direccion, @Telefono, 
                               @Correo, @HistorialCrediticio, GETDATE())";

                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@IdCliente", cliente.IdCliente);
                cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", cliente.Apellido);
                cmd.Parameters.AddWithValue("@Direccion", cliente.Direccion ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Correo", cliente.Correo ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@HistorialCrediticio", cliente.HistorialCrediticio);
                //cmd.Parameters.AddWithValue("@FechaRegistro", cliente.FechaRegistro);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // ACTUALIZAR cliente existente
        public void Actualizar(Cliente cliente)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                string sql = @"UPDATE Clientes SET 
                               Nombre = @Nombre,
                               Apellido = @Apellido,
                               Direccion = @Direccion,
                               Telefono = @Telefono,
                               Correo = @Correo,
                               HistorialCrediticio = @HistorialCrediticio
                               WHERE IdCliente = @IdCliente";

                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@IdCliente", cliente.IdCliente);
                cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", cliente.Apellido);
                cmd.Parameters.AddWithValue("@Direccion", cliente.Direccion ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Correo", cliente.Correo ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@HistorialCrediticio", cliente.HistorialCrediticio);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // ELIMINAR cliente
        public void Eliminar(int idCliente)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                string sql = "DELETE FROM Clientes WHERE IdCliente = @IdCliente";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@IdCliente", idCliente);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
