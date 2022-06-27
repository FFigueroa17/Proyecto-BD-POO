using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using FormPrincipal.Properties;

namespace FormPrincipal
{
    public class AreasDAO
    {
        public static List<Area> ObtenerTodos()
        {
            string cadena = Resources.cadena_conexion;
            List<Area> lista = new List<Area>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "SELECT A.id_area, A.nombre, A.descripcion, A.horario, A.id_responsable, R.nombre_responsable, A.numero_de_piso" + " FROM AREA A INNER JOIN RESPONSABLE R ON A.id_responsable = R.id_responsable";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Area col = new Area();
                        col.IDarea = Convert.ToInt32(reader["id_area"].ToString());
                        col.Nombre = reader["nombre"].ToString();
                        col.Descripcion = reader["descripcion"].ToString();
                        col.Horario = reader["horario"].ToString();
                        col.IDresponsable = Convert.ToInt32(reader["id_responsable"].ToString());
                        col.Responsable = reader["nombre_responsable"].ToString();
                        col.numeroPiso = Convert.ToInt32(reader["numero_de_piso"].ToString());
                        lista.Add(col);
                    }
                }
                connection.Close();
            }
            return lista;
        }

        public static int ObtenerIDresponsable(string nombreResponsable)
        {
            string cadena = Resources.cadena_conexion;
            int idResponsable = 0;

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "SELECT A.id_responsable, R.nombre_responsable " + " FROM AREA A INNER JOIN RESPONSABLE R ON A.id_responsable = R.id_responsable" + " WHERE R.nombre_responsable = @nombreResponsable";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombreResponsable", nombreResponsable);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Area col = new Area();
                        col.IDresponsable = Convert.ToInt32(reader["id_responsable"]);
                        idResponsable = col.IDresponsable;
                    }
                }
                connection.Close();
            }
            return idResponsable;
        }

        public static void CrearNuevo(Area col)
        {
            string cadena = Resources.cadena_conexion;

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "INSERT INTO AREA (nombre, descripcion, horario,id_responsable, numero_de_piso) " +
                               "VALUES (@nombre, @descripcion, @horario, @id_responsable ,@numero_de_piso)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", col.Nombre);
                command.Parameters.AddWithValue("@descripcion", col.Descripcion);
                command.Parameters.AddWithValue("@horario", col.Horario);
                command.Parameters.AddWithValue("@id_responsable", col.IDresponsable);
                command.Parameters.AddWithValue("@numero_de_piso", col.numeroPiso);

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
                    string query = "DELETE FROM AREA WHERE id_area = @id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", ID);
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

        public static bool ActualizarPorID(Area col)
        {
            bool exito = true;
            try
            {
                string cadena = Resources.cadena_conexion;
                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    string query = "UPDATE AREA SET nombre = @nuevonombre, descripcion = @nuevadescripcion, horario = @nuevohorario, id_responsable = @nuevoid_responsable, numero_de_piso = @nuevonumero_de_piso WHERE id_area = @id";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@id", col.IDarea);
                    command.Parameters.AddWithValue("@nuevonombre", col.Nombre);
                    command.Parameters.AddWithValue("@nuevadescripcion", col.Descripcion);
                    command.Parameters.AddWithValue("@nuevohorario", col.Horario);
                    command.Parameters.AddWithValue("@nuevoid_responsable", col.IDresponsable);
                    command.Parameters.AddWithValue("@nuevonumero_de_piso", col.numeroPiso);

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

        public static List<Area> ObtenerResponsables()
        {
            string cadena = Resources.cadena_conexion;
            List<Area> lista = new List<Area>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "SELECT A.id_responsable, R.nombre_responsable" + " FROM AREA A INNER JOIN RESPONSABLE R ON A.id_responsable = R.id_responsable" + " GROUP BY A.id_responsable, R.nombre_responsable";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Area col = new Area();
                        col.Responsable = reader["nombre_responsable"].ToString();
                        lista.Add(col);
                    }
                }
                connection.Close();
            }
            return lista;
        }
    }
}