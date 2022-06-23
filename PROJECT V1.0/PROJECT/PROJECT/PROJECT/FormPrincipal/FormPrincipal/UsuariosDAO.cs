using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.CompilerServices;
using FormPrincipal.Properties;

namespace FormPrincipal
{
    public class UsuariosDAO
    {
        //------MOSTRAR USUARIOS----------------
        public static List<UsuarioShow> ObtenerTodos(){
            string cadena = Resources.cadena_conexion;
            List<UsuarioShow> lista = new List<UsuarioShow>();

            using (SqlConnection connection = new SqlConnection(cadena)){
                string query = "SELECT USUARIO.id_usuario, USUARIO.nombre AS 'Usuario', USUARIO.fotografia, AREA.nombre AS 'Area', " +
                               " INGRESA.fecha_hora_entrada, INGRESA.fecha_hora_salida " +
                               " FROM USUARIO " +
                               " INNER JOIN INGRESA " +
                               " ON USUARIO.id_usuario = INGRESA.id_usuario " +
                               " INNER JOIN AREA " +
                               " ON AREA.id_area = INGRESA.id_area";
                SqlCommand command = new SqlCommand(query, connection);
                
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader()){
                    while (reader.Read())
                    {
                        UsuarioShow user = new UsuarioShow();
                        user.id_user = Convert.ToInt32(reader["id_usuario"].ToString());
                        user.nombreUser = reader["Usuario"].ToString();
                        user.area = reader["Area"].ToString();
                        user.fotografiauser = reader["fotografia"].ToString();
                        user.imagenuser = UsuariosDAO.obtenerImagen(user.fotografiauser);
                        user.Fecha_hora_entrada = Convert.ToDateTime(reader["fecha_hora_entrada"]);
                        user.Fecha_hora_salida = Convert.ToDateTime(reader["fecha_hora_salida"]);
                        lista.Add(user);
                    }   
                }
                connection.Close();
            }
            return lista;
        }
        
        //FUNCION PARA OBTENER IMAGEN--------------------
        public static Bitmap obtenerImagen(string ruta)
        {
            Bitmap fotico = null;
            fotico = new Bitmap(ruta);

            return fotico;
        }
        
        //--------OBTENER COMBOBOXES---------------
        //pd: utiliza la clase Evento, se reutilizo el combobox creado en "EventosDAO" ya que es el mismo pero sin limites
        public static List<Evento> ObtenerCombobox(){
            string cadena = Resources.cadena_conexion;
            List<Evento> lista = new List<Evento>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query =
                    "SELECT id_area, nombre " +
                    "FROM AREA ";
                SqlCommand command = new SqlCommand(query, connection);
                
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader()){
                    while (reader.Read())
                    {
                        Evento eve = new Evento();
                        eve.idareaeve = Convert.ToInt32(reader["id_area"].ToString());
                        eve.areaevento = reader["nombre"].ToString();
                        lista.Add(eve);
                    }   
                }
                connection.Close();
            }
            return lista;
        }
        
        //----AGREGAR NUEVO ELEMENTO, SOLO ENTRADA--------------------
        public static void CrearNuevoIngreso(Usuario user)
        {
            string cadena = Resources.cadena_conexion;

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query =
                    "INSERT INTO INGRESA(fecha_hora_entrada, fecha_hora_salida, id_usuario, id_area) " +
                    "VALUES(@fecha_hora_entrada, '1999-12-31 23:59:00.000', @id_usuario, @id_area)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@fecha_hora_entrada", user.fecha_hora_entrada);
                command.Parameters.AddWithValue("@id_usuario", user.id_user); 
                command.Parameters.AddWithValue("@id_area", user.id_area_ingreso);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        //----AGREGAR NUEVA SALIDA--------------------
        //CORROBORAR QUERY ZZZZZZZZZZZZZZZZZZZZZZZZZZZZ----------------------------- 
        public static void CrearNuevaSalida(Usuario user)
        {
            string cadena = Resources.cadena_conexion;

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query =
                    "UPDATE INGRESA SET fecha_hora_salida = @fecha_hora_salida " +
                    "WHERE fecha_hora_salida = '1999-12-31 23:59:00.000' AND id_usuario = @id_usuario AND id_area = @id_area";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@fecha_hora_salida", user.fecha_hora_salida);
                command.Parameters.AddWithValue("@id_usuario", user.id_user); 
                command.Parameters.AddWithValue("@id_area", user.id_area_ingreso);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        
        //---------AGREGAR NUEVO USUARIO---------------------
        public static void CrearNuevoUsuario(Usuario user)
        {
            string cadena = Resources.cadena_conexion;

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query =
                    "INSERT INTO USUARIO(nombre, ocupacion, direccion, correo, institucion, fotografia, telefono) " +
                    "VALUES (@nombre, @ocupacion, @direccion, @correo, @institucion, @fotografia, @telefono)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", user.nombreUser);
                command.Parameters.AddWithValue("@ocupacion", user.ocupacionuser); 
                command.Parameters.AddWithValue("@direccion", user.direccionuser);
                command.Parameters.AddWithValue("@correo", user.correouser);
                command.Parameters.AddWithValue("@institucion", user.institucionuser);
                command.Parameters.AddWithValue("@fotografia", user.fotografiauser);
                command.Parameters.AddWithValue("@telefono", user.telefonouser);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        //-----
    }
}