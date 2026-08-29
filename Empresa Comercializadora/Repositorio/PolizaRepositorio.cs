using Empresa_Comercializadora.Modelo;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using iText = iTextSharp.text;
using ITextFont = iTextSharp.text.Font;
using ITextRect = iTextSharp.text.Rectangle;

namespace Empresa_Comercializadora.Repositorio
{
    public class PolizaRepositorio
    {
        string conexion = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;

        //Metodo para agragar una poliza a la base de datos
        public void AgregarPoliza(Poliza poliza)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                string sql = "INSERT INTO Polizas (IdPoliza, IdCliente, IdSeguro, FechaInicio, FechaFin, Estado, Monto, Observaciones) " +
                           "VALUES (@IdPoliza, @IdCliente, @IdSeguro, @FechaInicio, @FechaFin, @Estado, @Monto, @Observaciones)";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@IdPoliza", poliza.IdPoliza);
                cmd.Parameters.AddWithValue("@IdCliente", poliza.IdCliente);
                cmd.Parameters.AddWithValue("@IdSeguro", poliza.IdSeguro);
                cmd.Parameters.AddWithValue("@FechaInicio", poliza.FechaInicio);
                cmd.Parameters.AddWithValue("@FechaFin", poliza.FechaFin);
                cmd.Parameters.AddWithValue("@Estado", poliza.Estado);
                cmd.Parameters.AddWithValue("@Monto", poliza.Monto);
                cmd.Parameters.AddWithValue("@Observaciones", poliza.Observaciones);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }//metodo

        //Metodo para listar
        public DataTable ListarPolizas()
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                string sql = "SELECT * FROM Polizas";
                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                da.Fill(dt);
            }
            return dt;
        }//metodo

        //Metodo para actualizar una poliza
        public void ActualizarPoliza(Poliza poliza)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                string sql = "UPDATE Polizas SET Estado=@Estado, Monto=@Monto, FechaFin=@FechaFin, Observaciones=@Observaciones " +
                               "WHERE IdPoliza=@IdPoliza";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@Estado", poliza.Estado);
                cmd.Parameters.AddWithValue("@Monto", poliza.Monto);
                cmd.Parameters.AddWithValue("@FechaFin", poliza.FechaFin);
                cmd.Parameters.AddWithValue("@Observaciones", poliza.Observaciones);
                cmd.Parameters.AddWithValue("@IdPoliza", poliza.IdPoliza);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //Metodo para eliminar una poliza
        public void EliminarPoliza(int idPoliza)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                string sql = "DELETE FROM Polizas WHERE IdPoliza=@IdPoliza";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@IdPoliza", idPoliza);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //Metodo para controlar el estado de una poliza
        public void CambiarEstadoPoliza(int idPoliza, string nuevoEstado)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                string sql = "UPDATE Polizas SET Estado=@Estado WHERE IdPoliza=@IdPoliza";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@Estado", nuevoEstado);
                cmd.Parameters.AddWithValue("@IdPoliza", idPoliza);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //Metodo para cancelar una poliza por vencimiento
        public void CancelarPolizasVencidas()
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                string sql = @"UPDATE Polizas SET Estado = 'Cancelada' WHERE FechaFin < CAST(GETDATE() AS DATE) AND Estado <> 'Cancelada';";

                SqlCommand cmd = new SqlCommand(sql, cn);
                cn.Open();
                int filas = cmd.ExecuteNonQuery();

                if (filas > 0)
                {
                    Console.WriteLine($"{filas} pólizas fueron canceladas automáticamente por vencimiento.");
                }
            }
        }

        //Metodo para generar certificado en PDF
        public void GenerarCertificadoPDF(int idPoliza, string rutaArchivo)
        {
            // 1️ OBTENER DATOS DE LA PÓLIZA
            string sql = @"SELECT p.IdPoliza, c.Nombre + ' ' + c.Apellido AS Cliente, 
                                s.Tipo, p.FechaInicio, p.FechaFin, p.Monto, p.Estado
                         FROM Polizas p
                         INNER JOIN Clientes c ON p.IdCliente = c.IdCliente
                         INNER JOIN Seguros s ON p.IdSeguro = s.IdSeguro
                         WHERE p.IdPoliza = @IdPoliza";

            string cliente = "", tipo = "", estado = "";
            DateTime fechaInicio = DateTime.MinValue, fechaFin = DateTime.MinValue;
            decimal monto = 0;
            int id = 0;

            using (SqlConnection cn = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@IdPoliza", idPoliza);
                cn.Open();
                SqlDataReader lector = cmd.ExecuteReader();
                if (lector.Read())
                {
                    id = (int)lector["IdPoliza"];
                    cliente = lector["Cliente"].ToString();
                    tipo = lector["Tipo"].ToString();
                    fechaInicio = (DateTime)lector["FechaInicio"];
                    fechaFin = (DateTime)lector["FechaFin"];
                    monto = (decimal)lector["Monto"];
                    estado = lector["Estado"].ToString();
                }
            }

            // 2️ CREAR DOCUMENTO PDF
            Document doc = new Document(PageSize.A4, 50, 50, 80, 50);
            PdfWriter.GetInstance(doc, new FileStream(rutaArchivo, FileMode.Create));
            doc.Open();

            // 3️ AGREGAR ENCABEZADO Y LOGO
            string logoPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Imagenes", "Logo.png");
            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(logoPath);
            logo.ScaleAbsolute(100, 100);
            logo.Alignment = Element.ALIGN_RIGHT;
            doc.Add(logo);

            Paragraph titulo = new Paragraph(
                "CERTIFICADO DE PÓLIZA DE SEGURO",
                new ITextFont(iText.Font.FontFamily.HELVETICA, 20, iText.Font.BOLD, iText.BaseColor.BLUE)
            );
            titulo.Alignment = iText.Element.ALIGN_CENTER;
            doc.Add(titulo);

            doc.Add(new Paragraph("\nFecha de emisión: " + DateTime.Now.ToShortDateString()));
            doc.Add(new Paragraph(" "));

            // 4️⃣ DATOS PRINCIPALES
            PdfPTable tabla = new PdfPTable(2);
            tabla.WidthPercentage = 100;
            tabla.SpacingBefore = 20;

            void Celda(string texto, bool esEncabezado = false)
            {
                var font = esEncabezado
                    ? new ITextFont(iText.Font.FontFamily.HELVETICA, 12, iText.Font.BOLD)
                    : new ITextFont(iText.Font.FontFamily.HELVETICA, 12);
                PdfPCell celda = new PdfPCell(new Phrase(texto, font));
                celda.Border = ITextRect.NO_BORDER;
                tabla.AddCell(celda);
            }

            Celda("Número de Póliza:", true); Celda(id.ToString());
            Celda("Cliente:", true); Celda(cliente);
            Celda("Tipo de Seguro:", true); Celda(tipo);
            Celda("Fecha Inicio:", true); Celda(fechaInicio.ToShortDateString());
            Celda("Fecha Fin:", true); Celda(fechaFin.ToShortDateString());
            Celda("Monto Asegurado:", true); Celda("$ " + monto.ToString("N2"));
            Celda("Estado:", true); Celda(estado);

            doc.Add(tabla);

            // 5️⃣ PIE DE PÁGINA
            doc.Add(new Paragraph("\n\nEste documento certifica que la póliza mencionada se encuentra registrada en el sistema de la empresa aseguradora.",
                new ITextFont(iText.Font.FontFamily.HELVETICA, 10, iText.Font.ITALIC)));

            doc.Add(new Paragraph("\n\n______________________________________"));
            doc.Add(new Paragraph("Firma Autorizada - Empresa de Seguros"));

            doc.Close();

            Console.WriteLine("Certificado generado exitosamente en: " + rutaArchivo);
        }

        public Poliza ObtenerPorId(int idPoliza)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                string sql = "SELECT * FROM Polizas WHERE IdPoliza = @IdPoliza";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@IdPoliza", idPoliza);

                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Poliza
                    {
                        IdPoliza = (int)reader["IdPoliza"],
                        IdCliente = (int)reader["IdCliente"],
                        IdSeguro = (int)reader["IdSeguro"],
                        FechaInicio = (DateTime)reader["FechaInicio"],
                        FechaFin = (DateTime)reader["FechaFin"],
                        Estado = reader["Estado"].ToString(),
                        Monto = (decimal)reader["Monto"],
                        Observaciones = reader["Observaciones"].ToString()
                    };
                }
                return null;
            }
        }
    }
}
