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
    public class UsuarioRepositorio
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;

        public string ValidarLoginYObtenerRol(string usuario, string contrasena)
        {
            // 1. Consulta: Pedimos el Rol, no solo contamos. Incluimos la validación de Estado='Activo'.
            string query = "SELECT Rol FROM Usuarios WHERE Usuario = @usuario AND Contrasena = @contrasena AND Estado = 'Activo'";
            string rol = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        
                        command.Parameters.AddWithValue("@usuario", usuario);
                        command.Parameters.AddWithValue("@contrasena", contrasena);

                        // ExecuteScalar es útil aquí: devuelve el primer valor (Rol) de la primera fila.
                        object resultado = command.ExecuteScalar();

                        if (resultado != null)
                        {
                            rol = resultado.ToString();
                        }
                    }
                }
                return rol; 
            }
            catch (Exception ex)
            {
                
                Console.WriteLine("Error de conexión o de base de datos: " + ex.Message);
                return null; // Devuelve null en caso de error de sistema.
            }
        }

        public bool CrearUsuario(int id, string nombre, string apellido, string correo, string usuario, string contrasena, string rol, string estado)
        {
           
            string query =
                "INSERT INTO Usuarios (IdUsuario, Nombre, Apellido, Correo, Usuario, Contrasena, Rol, Estado) " +
                "VALUES (@id, @nombre, @apellido, @correo, @usuario, @contrasena, @rol, @estado)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                       
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@nombre", nombre);
                        command.Parameters.AddWithValue("@apellido", apellido);
                        command.Parameters.AddWithValue("@correo", correo);
                        command.Parameters.AddWithValue("@usuario", usuario);
                        command.Parameters.AddWithValue("@contrasena", contrasena);
                        command.Parameters.AddWithValue("@rol", rol);
                        command.Parameters.AddWithValue("@estado", estado);

                        
                        int filasAfectadas = command.ExecuteNonQuery();

                        return filasAfectadas > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
             
                Console.WriteLine("Error SQL (Crear Usuario): " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general (Crear Usuario): " + ex.Message);
                return false;
            }
        }

        public bool ActualizarUsuario(int id, string nombre, string apellido, string correo, string usuario, string contrasena, string rol, string estado)
        {
            string query = "UPDATE Usuarios SET Nombre = @nombre, Apellido = @apellido, Correo = @correo," + 
                "Usuario = @usuario, Contrasena = @contrasena, Rol = @rol, Estado = @estado WHERE IdUsuario = @id";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@nombre", nombre);
                        command.Parameters.AddWithValue("@apellido", apellido);
                        command.Parameters.AddWithValue("@correo", correo);
                        command.Parameters.AddWithValue("@usuario", usuario);
                        command.Parameters.AddWithValue("@contrasena", contrasena);
                        command.Parameters.AddWithValue("@rol", rol);
                        command.Parameters.AddWithValue("@estado", estado);


                        int filasAfectadas = command.ExecuteNonQuery();

                        return filasAfectadas > 0;
                    }
                }
            }
            catch (SqlException ex)
            {

                Console.WriteLine("Error SQL (Actualizar Usuario): " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general (Actualizar Usuario): " + ex.Message);
                return false;
            }
        }

        //Metodo para buscar usuario
        public Usuario ObtenerPorId(int idUsuario)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                string sql = "SELECT * FROM Usuarios WHERE IdUsuario = @IdUsuario";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Usuario
                    {
                        IdUsuario = (int)reader["IdUsuario"],
                        Nombre = reader["Nombre"].ToString(),
                        Apellido = reader["Apellido"].ToString(),
                        Correo = reader["Correo"].ToString(),
                        Contrasena = reader["Contrasena"].ToString(),
                        Rol = reader["Rol"].ToString(),
                        Estado = reader["Estado"].ToString(),
                        FechaRegistro = (DateTime)reader["FechaRegistro"]
                    };
                }
                return null;
            }
        }

    }
}
