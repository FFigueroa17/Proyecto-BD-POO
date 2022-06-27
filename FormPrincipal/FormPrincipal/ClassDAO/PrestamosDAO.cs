using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using FormPrincipal.Properties;

namespace FormPrincipal
{
    public class PrestamosDAO
    {
        public static List<PrestamoConsulta> ObtenerTodos()
        {
            string cadena = Resources.cadena_conexion;
            List<PrestamoConsulta> lista = new List<PrestamoConsulta>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "SELECT RE.id_prestamo, EJ.portada,  EJ.nombre 'Título Ejemplar', US.nombre, RE.fecha_hora_prestamo AS 'Prestamo', RE.id_usuario, RE.id_ejemplar, RE.fecha_hora_devolucion AS 'Devolución' " +
                                "FROM PRESTAMO RE " +
                                "INNER JOIN EJEMPLAR EJ " +
                                    "ON RE.id_ejemplar = EJ.id_ejemplar " +
                                "INNER JOIN USUARIO US " +
                                    "ON RE.id_usuario = US.id_usuario " +
                                "ORDER BY id_prestamo ASC ";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        PrestamoConsulta prestamo = new PrestamoConsulta();
                        prestamo.id_prestamo = Convert.ToInt32(reader["id_prestamo"].ToString());
                        prestamo.Ejemplar = reader["Título Ejemplar"].ToString();
                        prestamo.fotografia = reader["portada"].ToString();
                        prestamo.Portada = obtenerimagen(prestamo.fotografia);
                        prestamo.Usuario = reader["nombre"].ToString();
                        prestamo.Prestamo = Convert.ToDateTime(reader["Prestamo"].ToString());
                        prestamo.Devolución = Convert.ToDateTime(reader["Devolución"].ToString());
                        prestamo.id_usuario = Convert.ToInt32(reader["id_usuario"].ToString());
                        prestamo.id_ejemplar = Convert.ToInt32(reader["id_ejemplar"].ToString());
                        lista.Add(prestamo);
                    }
                }
                connection.Close();
            }
            return lista;
        }

        public static Bitmap obtenerimagen(string ruta)
        {
            Bitmap fotico = null;
            try
            {
                OpenFileDialog getImage = new OpenFileDialog();
                getImage.InitialDirectory = "C:\\";
                getImage.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|.*jpg; *.jpeg; *.gif; *.bmp; *.png";

                string ruta_degug = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
                string v = Path.GetDirectoryName(Path.GetDirectoryName(ruta_degug)) + @"\Recursos\" + ruta;
                fotico = new Bitmap(v);

            }
            catch
            {
                MessageBox.Show("No se han encontrado todas las imagenes de los ejemplares", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return fotico;
        }

        public static void CrearNuevo(Prestamo col)
        {
            string cadena = Resources.cadena_conexion;

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "INSERT INTO PRESTAMO (fecha_hora_prestamo, fecha_hora_devolucion, id_usuario,id_ejemplar) " +
                               " VALUES (@fecha_hora_prestamo, @fecha_hora_devolucion, @id_usuario, @id_ejemplar)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@fecha_hora_prestamo", Convert.ToDateTime(col.fecha_hora_prestamo));
                command.Parameters.AddWithValue("@fecha_hora_devolucion", Convert.ToDateTime(col.fecha_hora_devolucion));
                command.Parameters.AddWithValue("@id_usuario", Convert.ToInt32(col.id_usuario));
                command.Parameters.AddWithValue("@id_ejemplar", Convert.ToInt32(col.id_ejemplar));

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

            }
        }

        public static bool EliminarPorID(int ID)
        {
            bool exito = true;
            try
            {
                string cadena = Resources.cadena_conexion;
                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    string query = "DELETE FROM PRESTAMO WHERE id_prestamo = @id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", ID.ToString());

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                exito = false;
            }
            return exito;
        }

        public static bool ActualizarPorID(Prestamo col)
        {
            bool exito = true;
            try
            {
                string cadena = Resources.cadena_conexion;
                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    string query = "UPDATE PRESTAMO SET fecha_hora_prestamo = @nueva_fecha_hora_prestamo,fecha_hora_devolucion = @nueva_fecha_hora_devolucion, id_usuario = @nuevo_id_usuario, id_ejemplar = @nuevo_id_ejemplar WHERE id_prestamo = @id_prestamo";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@id_prestamo", Convert.ToInt32(col.id_prestamo));
                    command.Parameters.AddWithValue("@nueva_fecha_hora_prestamo", Convert.ToDateTime(col.fecha_hora_prestamo));
                    command.Parameters.AddWithValue("@nueva_fecha_hora_devolucion", Convert.ToDateTime(col.fecha_hora_devolucion));
                    command.Parameters.AddWithValue("@nuevo_id_usuario", Convert.ToInt32(col.id_usuario));
                    command.Parameters.AddWithValue("@nuevo_id_ejemplar", Convert.ToInt32(col.id_ejemplar));

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                exito = false;
            }
            return exito;
        }

        //OBTENER ID'S EJEMPLARES Y USUARIOS

        public static int ObtenerIDEjemplar(string reference)
        {
            string cadena = Resources.cadena_conexion;
            int idEjemplar = 0;

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = " SELECT EJEMPLAR.nombre, EJEMPLAR.id_ejemplar " +
                                " FROM EJEMPLAR " +
                                " WHERE EJEMPLAR.nombre = @nombre";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", reference);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ReservaConsulta ej = new ReservaConsulta();
                        ej.id_ejemplar = Convert.ToInt32(reader["id_ejemplar"]);
                        idEjemplar = ej.id_ejemplar;
                    }
                }
                connection.Close();
            }
            return idEjemplar;
        }

        public static int ObtenerIDUsuario(string reference)
        {
            string cadena = Resources.cadena_conexion;
            int idUsuario = 0;

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = " SELECT USUARIO.nombre, USUARIO.id_usuario" +
                                " FROM USUARIO" +
                                " WHERE USUARIO.nombre = @nombre";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", reference);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ReservaConsulta ej = new ReservaConsulta();
                        ej.id_usuario = Convert.ToInt32(reader["id_usuario"]);
                        idUsuario = ej.id_usuario;
                    }
                }
                connection.Close();
            }
            return idUsuario;
        }

        //FIN OBTENER ID'S EJEMPLARES Y USUARIOS

        //OBTENER EJEMPLARES Y USUARIOS PARA POPULAR LOS COMBOBOX

        public static List<ReservaConsulta> ObtenerEjemplares()
        {
            string cadena = Resources.cadena_conexion;
            List<ReservaConsulta> lista = new List<ReservaConsulta>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "SELECT EJEMPLAR.nombre " +
                               " FROM EJEMPLAR";

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ReservaConsulta ej = new ReservaConsulta();
                        ej.Ejemplar = reader["nombre"].ToString();
                        lista.Add(ej);
                    }
                }
                connection.Close();
            }
            return lista;
        }

        public static List<ReservaConsulta> ObtenerUsuarios()
        {
            string cadena = Resources.cadena_conexion;
            List<ReservaConsulta> lista = new List<ReservaConsulta>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "SELECT USUARIO.nombre " +
                                " FROM USUARIO";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ReservaConsulta ej = new ReservaConsulta();
                        ej.Usuario = reader["nombre"].ToString();
                        lista.Add(ej);
                    }
                }
                connection.Close();
            }
            return lista;
        }

        // FIN OBTENER DATOS
    }
}