using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using FormPrincipal.Properties;

namespace FormPrincipal
{
    public static class ColeccionDAO
    {
        public static List<Coleccion> ObtenerTodos(){
                string cadena = Resources.cadena_conexion;
                List<Coleccion> lista = new List<Coleccion>();

                using (SqlConnection connection = new SqlConnection(cadena)){
                    string query = "SELECT CO.id_coleccion, CO.nombre, CO.id_genero, G.nombre_genero, CO.id_tipo, P.nombre_tipo, CO.numero_de_piso" + " FROM COLECCION CO INNER JOIN GENERO G ON CO.id_genero = g.id_genero INNER JOIN TIPO P ON CO.id_tipo = P.id_tipo";
                    SqlCommand command = new SqlCommand(query, connection);
                
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader()){
                        while (reader.Read())
                        {
                            Coleccion col = new Coleccion();
                            col.IDcoleccion = Convert.ToInt32(reader["id_coleccion"].ToString());
                            col.Nombre = reader["nombre"].ToString();
                            col.IDgenero = Convert.ToInt32(reader["id_genero"].ToString());
                            col.Genero = reader["nombre_genero"].ToString();
                            col.IDtipo = Convert.ToInt32(reader["id_tipo"].ToString());
                            col.Tipo = reader["nombre_tipo"].ToString();
                            col.numeroPiso = Convert.ToInt32(reader["numero_de_piso"].ToString());
                            lista.Add(col);
                        }   
                    }
                    connection.Close();
                }
                return lista;
            }
        
            public static int ObtenerID(string nombreGenero){
                string cadena = Resources.cadena_conexion;
                int idGenero = 0;
                
                using (SqlConnection connection = new SqlConnection(cadena)){
                    string query = "SELECT CO.id_genero, G.nombre_genero " + " FROM COLECCION CO INNER JOIN GENERO G ON CO.id_genero = g.id_genero" + " WHERE G.nombre_genero = @nombreGenero";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nombreGenero", nombreGenero);
                    
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader()){
                        while (reader.Read())
                        {
                            Coleccion col = new Coleccion();
                            col.IDgenero = Convert.ToInt32(reader["id_genero"]);
                            idGenero = col.IDgenero;
                        }
                    }
                    connection.Close();
                }
                return idGenero;
            }
            
            public static int ObtenerIDTipo (string nombreTipo){
                string cadena = Resources.cadena_conexion;
                int idTipo = 0; 
                
                using (SqlConnection connection = new SqlConnection(cadena)){
                    string query = "SELECT CO.id_tipo, P.nombre_tipo " + " FROM COLECCION CO INNER JOIN TIPO P ON CO.id_tipo = P.id_tipo" + " WHERE P.nombre_tipo = @nombreTipo";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nombreTipo", nombreTipo);
                    
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader()){
                        while (reader.Read())
                        {
                            Coleccion col = new Coleccion();
                            col.IDtipo = Convert.ToInt32(reader["id_tipo"]);
                            idTipo = col.IDtipo;
                        }
                    }
                    connection.Close();
                }
                return idTipo;
            }
            public static void CrearNuevo(Coleccion col)
            {
                string cadena = Resources.cadena_conexion;

                using (SqlConnection connection = new SqlConnection(cadena)){
                    string query = "INSERT INTO COLECCION (nombre, id_genero, id_tipo, numero_de_piso) " + 
                                   "VALUES (@nombre, @id_genero, @id_tipo, @numero_de_piso)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nombre", col.Nombre);
                    command.Parameters.AddWithValue("@id_genero", col.IDgenero);
                    command.Parameters.AddWithValue("@id_tipo", col.IDtipo);
                    command.Parameters.AddWithValue("@numero_de_piso", col.numeroPiso);
                
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    
                }
            }
            
            public static bool EliminarPorID(int ID) {
                bool exito = true;
                try {
                    string cadena = Resources.cadena_conexion;
                    using (SqlConnection connection = new SqlConnection(cadena)){
                        string query = "DELETE FROM COLECCION WHERE id_coleccion = @id";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@id", ID);
               
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                catch (Exception e) {
                    exito = false;
                }
                return exito;
            } 
            
            public static bool ActualizarPorID(Coleccion col) {
                bool exito = true;
                try {
                    string cadena = Resources.cadena_conexion;
                    using (SqlConnection connection = new SqlConnection(cadena)){
                        string query = "UPDATE COLECCION SET nombre = @nuevonombre, id_genero = @nuevoid_genero, id_tipo = @nuevoid_tipo, numero_de_piso = @nuevonumero_de_piso WHERE id_coleccion = @id";
                        SqlCommand command = new SqlCommand(query, connection);
                        
                        command.Parameters.AddWithValue("@id", col.IDcoleccion);
                        command.Parameters.AddWithValue("@nuevonombre", col.Nombre);
                        command.Parameters.AddWithValue("@nuevoid_genero", col.IDgenero);
                        command.Parameters.AddWithValue("@nuevoid_tipo", col.IDtipo);
                        command.Parameters.AddWithValue("@nuevonumero_de_piso", col.numeroPiso);
               
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                catch (Exception e) {
                    exito = false;
                }
                return exito;
            }
            
            public static List<Coleccion> ObtenerGeneros(){
                string cadena = Resources.cadena_conexion;
                List<Coleccion> lista = new List<Coleccion>();

                using (SqlConnection connection = new SqlConnection(cadena)){
                    string query = "SELECT CO.id_genero, G.nombre_genero " + " FROM COLECCION CO INNER JOIN GENERO G ON CO.id_genero = g.id_genero" + " GROUP BY CO.id_genero, G.nombre_genero";
                    SqlCommand command = new SqlCommand(query, connection);
                
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader()){
                        while (reader.Read())
                        {
                            Coleccion col = new Coleccion();
                            col.Genero = reader["nombre_genero"].ToString();
                            lista.Add(col);
                        }   
                    }
                    connection.Close();
                }
                return lista;
            }
            
            public static List<Coleccion> ObtenerTipos(){
                string cadena = Resources.cadena_conexion;
                List<Coleccion> lista = new List<Coleccion>();

                using (SqlConnection connection = new SqlConnection(cadena)){
                    string query = "SELECT CO.id_tipo, P.nombre_tipo " + " FROM COLECCION CO INNER JOIN TIPO P ON CO.id_tipo = P.id_tipo" + " GROUP BY CO.id_tipo, P.nombre_tipo";
                    SqlCommand command = new SqlCommand(query, connection);
                
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader()){
                        while (reader.Read())
                        {
                            Coleccion col = new Coleccion();
                            col.Tipo = reader["nombre_tipo"].ToString();
                            lista.Add(col);
                        }   
                    }
                    connection.Close();
                }
                return lista;
            }
    }
}