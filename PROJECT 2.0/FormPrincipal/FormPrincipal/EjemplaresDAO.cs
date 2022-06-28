using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using FormPrincipal.Properties;

namespace FormPrincipal
{
    public class EjemplaresDAO
    {
        
        public static List<EjemplarConsulta> ObtenerTodos(){
                string cadena = Resources.cadena_conexion;
                List<EjemplarConsulta> lista = new List<EjemplarConsulta>();

                using (SqlConnection connection = new SqlConnection(cadena)){
                    string query = " SELECT EJ.id_ejemplar, EJ.nombre, EJ.portada, EJ.formato, EJ.fecha_publicacion, IDI.idioma, CO.nombre, EDI.nomre_editorial, EJ.isbn, EJ.issn, EJ.doi, PA.palabra_clave, AU.nombre_autor " +
                        "FROM EJEMPLAR EJ " + 
                    "INNER JOIN IDIOMA IDI "  +
                    " ON EJ.id_idioma = IDI.id_idioma " +
                    " INNER JOIN COLECCION CO"+
                    " ON EJ.id_coleccion = CO.id_coleccion " +
                    " INNER JOIN EDITORIAL EDI"+
                    " ON EJ.id_editorial = EDI.id_editorial "+
                    " LEFT JOIN PALABRA_CLAVE PA "+
                    " ON PA.id_ejemplar = EJ.id_ejemplar "+ 
                        " LEFT JOIN EJEMPLARXAUTOR EJX "+
                    " ON EJX.id_ejemplar = EJ.id_ejemplar "+
                    " LEFT JOIN AUTOR AU "+
                    " ON EJX.id_autor = AU.id_autor";
                    SqlCommand command = new SqlCommand(query, connection);
                
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader()){
                        while (reader.Read())
                        {
                            EjemplarConsulta ej = new EjemplarConsulta();
                            ej.ID_ejemplar = Convert.ToInt32(reader["id_ejemplar"].ToString());
                            ej.Nombre_Ejemplar = reader["nombre"].ToString();
                            ej.Formato = reader["formato"].ToString();
                            ej.Portada_Ejemplar = reader["portada"].ToString();
                            ej.Portada = EjemplaresDAO.obtenerimagen(ej.Portada_Ejemplar);
                            ej.Idioma = reader["idioma"].ToString();
                            ej.Fecha_de_publicacion = Convert.ToDateTime(reader["fecha_publicacion"]);
                            ej.Coleccion = reader["nombre"].ToString();
                            ej.Editorial = reader["nomre_editorial"].ToString();
                            ej.ISBN = reader["isbn"].ToString();
                            ej.ISSN = reader["issn"].ToString();
                            ej.DOI = reader["doi"].ToString();
                            ej.Palabras_Clave = reader["palabra_clave"].ToString();
                            ej.Autor = reader["nombre_autor"].ToString();
                            lista.Add(ej);
                        }   
                    }
                    connection.Close();
                }
                return lista;
            }
        
            public static Bitmap obtenerimagen(string ruta){
                Bitmap imagen = new Bitmap(ruta);
                return imagen;
            }
        
            public static int ObtenerIDidoma(string nombreIidioma){
                string cadena = Resources.cadena_conexion;
                int idIdioma = 0;
                
                using (SqlConnection connection = new SqlConnection(cadena)){
                    string query = "SELECT EJ.id_idioma, IDI.idioma " + " FROM EJEMPLAR EJ INNER JOIN IDIOMA IDI ON EJ.id_idioma = IDI.id_idioma" + " WHERE IDI.idioma = @nombreIidioma";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nombreIidioma", nombreIidioma);
                    
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader()){
                        while (reader.Read())
                        {
                            Ejemplar ej = new Ejemplar();
                            ej.IDidioma = Convert.ToInt32(reader["id_idioma"]);
                            idIdioma = ej.IDidioma;
                        }
                    }
                    connection.Close();
                }
                return idIdioma;
            }
            
            public static int ObtenerIDcoleccion (string nombreColeccion){
                string cadena = Resources.cadena_conexion;
                int idColeccion = 0; 
                
                using (SqlConnection connection = new SqlConnection(cadena)){
                    string query = "SELECT EJ.id_coleccion, CO.nombre " + " FROM EJEMPLAR EJ INNER JOIN COLECCION CO ON EJ.id_coleccion = CO.id_coleccion" + " WHERE CO.nombre= @nombreColeccion";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nombreColeccion", nombreColeccion);
                    
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader()){
                        while (reader.Read())
                        {
                            Ejemplar ej = new Ejemplar();
                            ej.IDcoleccion = Convert.ToInt32(reader["id_coleccion"]);
                            idColeccion = ej.IDcoleccion;
                        }
                    }
                    connection.Close();
                }
                return idColeccion;
            }
            
            public static int ObtenerIDeditorial (string nombreEditorial){
                string cadena = Resources.cadena_conexion;
                int idEditorial = 0; 
                
                using (SqlConnection connection = new SqlConnection(cadena)){
                    string query = "SELECT EJ.id_editorial, EDI.nomre_editorial " + " FROM EJEMPLAR EJ INNER JOIN EDITORIAL EDI ON EJ.id_editorial = EDI.id_editorial" + " WHERE EDI.nomre_editorial = @nombreEditorial";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nombreEditorial", nombreEditorial);
                    
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader()){
                        while (reader.Read())
                        {
                            Ejemplar ej = new Ejemplar();
                            ej.IDeditorial = Convert.ToInt32(reader["id_editorial"]);
                            idEditorial = ej.IDeditorial;
                        }
                    }
                    connection.Close();
                }
                return idEditorial;
            }
            
            // INICIO CREAR NUEVO -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            public static void CrearNuevo(Ejemplar ej)
            {
                string cadena = Resources.cadena_conexion;

                using (SqlConnection connection = new SqlConnection(cadena)){
                    string query = "INSERT INTO EJEMPLAR (nombre, portada, formato, fecha_publicacion,id_idioma,id_coleccion, id_editorial, isbn, issn, doi)"
                    + "VALUES (@nombre, @portada, @formato, @fecha_publicacion, @id_idioma, @id_coleccion, @id_editorial, @isbn, @issn, @doi)";
                    
                    SqlCommand command = new SqlCommand(query, connection);
                    
                    command.Parameters.AddWithValue("@nombre", ej.NombreEjemplar);
                    command.Parameters.AddWithValue("@portada", ej.Portada);
                    command.Parameters.AddWithValue("@formato", ej.Formato);
                    command.Parameters.AddWithValue("@fecha_publicacion", ej.FechaDePublicacion);
                    command.Parameters.AddWithValue("@id_idioma", ej.IDidioma);
                    command.Parameters.AddWithValue("@id_coleccion", ej.IDcoleccion);
                    command.Parameters.AddWithValue("@id_editorial", ej.IDeditorial);
                    command.Parameters.AddWithValue("@isbn", ej.ISBN);
                    command.Parameters.AddWithValue("@issn", ej.ISSN);
                    command.Parameters.AddWithValue("@doi", ej.DOI);
                    
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    
                    Autor ObjetoAutor = new Autor(ej.Autor, EjemplaresDAO.ObtenerIdEjemplarAgregado());
                    CrearNuevoAutor(ObjetoAutor);
                    
                    Autor2 ObjetoAutor2 = new Autor2(EjemplaresDAO.ObtenerIdAutorAgregado(), EjemplaresDAO.ObtenerIdEjemplarAgregado());
                    CrearNuevoAutor2(ObjetoAutor2);
                    
                    PalabrasClave ObjetoPalabra = new PalabrasClave(ej.palabrasClave, EjemplaresDAO.ObtenerIdEjemplarAgregado());
                    CrearNuevaPalabraClave(ObjetoPalabra);
                }
            }
            
            public static int ObtenerIdEjemplarAgregado()
            {
                int idEjem = 0;

                string cadena = Resources.cadena_conexion;

                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    string query = 
                        "SELECT id_ejemplar " +
                        "FROM EJEMPLAR " + 
                        "WHERE EJEMPLAR.id_ejemplar = IDENT_CURRENT('EJEMPLAR')";

                    SqlCommand command = new SqlCommand(query, connection);
                
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader()){
                        while (reader.Read())
                        {
                            Ejemplar ej = new Ejemplar();
                            ej.IDEjemplar = Convert.ToInt32(reader["id_ejemplar"].ToString());
                            idEjem = ej.IDEjemplar;
                        }   
                    }
                    connection.Close();
                }

                return idEjem;
            }
            
            public static int ObtenerIdAutorAgregado()
            {
                int idAutor = 0;

                string cadena = Resources.cadena_conexion;

                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    string query = 
                        "SELECT id_autor " +
                        "FROM AUTOR " + 
                        "WHERE AUTOR.id_autor = IDENT_CURRENT('AUTOR')";

                    SqlCommand command = new SqlCommand(query, connection);
                
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader()){
                        while (reader.Read())
                        {
                            Autor2 aut = new Autor2();
                            aut.idAutor = Convert.ToInt32(reader["id_autor"].ToString());
                            idAutor = aut.idAutor;
                        }   
                    }
                    connection.Close();
                }

                return idAutor;
            }

            public static void CrearNuevaPalabraClave(PalabrasClave pb)
            {
                string cadena = Resources.cadena_conexion;

                using (SqlConnection connection = new SqlConnection(cadena)){
                    string query = "INSERT INTO PALABRA_CLAVE (palabra_clave, id_ejemplar)" + 
                                   " VALUES(@nombre, @id) ";
                    
                    SqlCommand command = new SqlCommand(query, connection);
                    
                    command.Parameters.AddWithValue("@nombre", pb.palabraClave);
                    command.Parameters.AddWithValue("@id", pb.idEjemplar);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    
                }
            }
            
            public static void CrearNuevoAutor(Autor aut)
            {
                string cadena = Resources.cadena_conexion;

                using (SqlConnection connection = new SqlConnection(cadena)){
                    string query = "INSERT INTO AUTOR (nombre_autor)" + 
                                   " VALUES(@nombre) ";
                    
                    SqlCommand command = new SqlCommand(query, connection);
                    
                    command.Parameters.AddWithValue("@nombre", aut.Nombre);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    
                }
            }
            
            public static void CrearNuevoAutor2(Autor2 aut2)
            {
                string cadena = Resources.cadena_conexion;

                using (SqlConnection connection = new SqlConnection(cadena)){
                    string query = "INSERT INTO EJEMPLARXAUTOR (id_ejemplar ,id_autor)" + 
                                   " VALUES (@id_ejemplar, @id_autor) ";
                    
                    SqlCommand command = new SqlCommand(query, connection);
                    
                    command.Parameters.AddWithValue("@id_ejemplar", aut2.idEjemplar);
                    command.Parameters.AddWithValue("@id_autor", aut2.idAutor);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    
                }
            }
            
            // FIN CREAR NUEVO -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            
            // INICIO ACTUALIZAR -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            public static void Actualizar(Ejemplar ej)
            {
                string cadena = Resources.cadena_conexion;

                using (SqlConnection connection = new SqlConnection(cadena)){
                    string query = "UPDATE EJEMPLAR SET nombre = @nuevonombre, portada = @nuevaportada, formato = @nuevoformato, fecha_publicacion = @nuevafecha_publicacion, id_idioma = @nuevoid_idioma, id_coleccion = @nuevoid_coleccion, id_editorial = @nuevoid_editorial, isbn = @nuevoisbn, issn = @nuevoissn, doi = @nuevodoi WHERE id_ejemplar = @id";

                    SqlCommand command = new SqlCommand(query, connection);
                    
                    command.Parameters.AddWithValue("@id", ej.IDEjemplar);
                    command.Parameters.AddWithValue("@nuevonombre", ej.NombreEjemplar);
                    command.Parameters.AddWithValue("@nuevaportada", ej.Portada);
                    command.Parameters.AddWithValue("@nuevoformato", ej.Formato);
                    command.Parameters.AddWithValue("@nuevafecha_publicacion", ej.FechaDePublicacion);
                    command.Parameters.AddWithValue("@nuevoid_idioma", ej.IDidioma);
                    command.Parameters.AddWithValue("@nuevoid_coleccion", ej.IDcoleccion);
                    command.Parameters.AddWithValue("@nuevoid_editorial", ej.IDeditorial);
                    command.Parameters.AddWithValue("@nuevoisbn", ej.ISBN);
                    command.Parameters.AddWithValue("@nuevoissn", ej.ISSN);
                    command.Parameters.AddWithValue("@nuevodoi", ej.DOI);
                    
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    
                    Autor ObjetoAutor = new Autor(ej.Autor, EjemplaresDAO.ObtenerIDAutor(ej.IDEjemplar));
                    ActualizarAutor(ObjetoAutor);

                    PalabrasClave ObjetoPalabra = new PalabrasClave(ej.palabrasClave, ej.IDEjemplar);
                    ActualizarPalabraClave(ObjetoPalabra);
                }
            }

            public static int ObtenerIDAutor (int IdEjemplar){
                string cadena = Resources.cadena_conexion;
                int idAutor = 0; 
                
                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    string query = "SELECT EJ.id_ejemplar, AU.id_autor " +
                                   " FROM EJEMPLAR EJ " +
                                   " LEFT JOIN EJEMPLARXAUTOR EJX " +
                                   " ON EJX.id_ejemplar = EJ.id_ejemplar " +
                                   " LEFT JOIN AUTOR AU " +
                                   " ON EJX.id_autor = AU.id_autor" +
                                   " WHERE EJ.id_ejemplar = @id_ejemplar";
                    
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id_ejemplar", IdEjemplar);
                    
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader()){
                        while (reader.Read())
                        {
                            Autor2 ej = new Autor2();
                            idAutor = Convert.ToInt32(reader["id_autor"]);
                        }
                    }
                    connection.Close();
                }
                return idAutor;
            }

            public static void ActualizarPalabraClave(PalabrasClave pb)
            {
                string cadena = Resources.cadena_conexion;

                using (SqlConnection connection = new SqlConnection(cadena)){
                    string query = "UPDATE PALABRA_CLAVE SET palabra_clave = @nuevapalabra_clave" + 
                                   " WHERE id_ejemplar = @id_ejemplar";
                    
                    SqlCommand command = new SqlCommand(query, connection);
                    
                    command.Parameters.AddWithValue("@nuevapalabra_clave", pb.palabraClave);
                    command.Parameters.AddWithValue("@id_ejemplar", pb.idEjemplar);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            
            public static void ActualizarAutor(Autor aut)
            {
                string cadena = Resources.cadena_conexion;

                using (SqlConnection connection = new SqlConnection(cadena)){
                    string query = "UPDATE AUTOR SET nombre_autor = @nuevonombre_autor" + 
                                   " WHERE id_autor = @id ";
                    
                    SqlCommand command = new SqlCommand(query, connection);
                    
                    command.Parameters.AddWithValue("@nuevonombre_autor", aut.Nombre);
                    command.Parameters.AddWithValue("@id", aut.idEjemplar);
                    
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }

            // FIN ACTUALIZAR -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            public static bool EliminarPorID(int ID) {
                bool exito = true;
                try {
                    string cadena = Resources.cadena_conexion;
                    using (SqlConnection connection = new SqlConnection(cadena)){
                        string query = "DELETE FROM EJEMPLAR WHERE id_ejemplar = @id";
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

            public static List<Ejemplar> ObtenerIdiomas(){
                string cadena = Resources.cadena_conexion;
                List<Ejemplar> lista = new List<Ejemplar>();

                using (SqlConnection connection = new SqlConnection(cadena)){
                    string query = "SELECT EJ.id_idioma, IDI.idioma " + " FROM EJEMPLAR EJ INNER JOIN IDIOMA IDI ON EJ.id_idioma = IDI.id_idioma" + " GROUP BY EJ.id_idioma, IDI.idioma";
                    SqlCommand command = new SqlCommand(query, connection);
                
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader()){
                        while (reader.Read())
                        {
                            Ejemplar ej = new Ejemplar();
                            ej.Idioma = reader["idioma"].ToString();
                            lista.Add(ej);
                        }   
                    }
                    connection.Close();
                }
                return lista;
            }
            
            public static List<Ejemplar> ObtenerColecciones(){
                string cadena = Resources.cadena_conexion;
                List<Ejemplar> lista = new List<Ejemplar>();

                using (SqlConnection connection = new SqlConnection(cadena)){
                    string query = "SELECT EJ.id_coleccion, CO.nombre " + " FROM EJEMPLAR EJ INNER JOIN COLECCION CO ON EJ.id_coleccion = CO.id_coleccion" + " GROUP BY EJ.id_coleccion, CO.nombre";
                    SqlCommand command = new SqlCommand(query, connection);
                
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader()){
                        while (reader.Read())
                        {
                            Ejemplar ej = new Ejemplar();
                            ej.Coleccion = reader["nombre"].ToString();
                            lista.Add(ej);
                        }   
                    }
                    connection.Close();
                }
                return lista;
            }
            
            public static List<Ejemplar> ObtenerEditorial(){
                string cadena = Resources.cadena_conexion;
                List<Ejemplar> lista = new List<Ejemplar>();

                using (SqlConnection connection = new SqlConnection(cadena)){
                    string query = "SELECT EJ.id_editorial, EDI.nomre_editorial " + " FROM EJEMPLAR EJ INNER JOIN EDITORIAL EDI ON EJ.id_editorial = EDI.id_editorial" + " GROUP BY EJ.id_editorial, EDI.nomre_editorial ";
                    SqlCommand command = new SqlCommand(query, connection);
                
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader()){
                        while (reader.Read())
                        {
                            Ejemplar ej = new Ejemplar();
                            ej.Editorial = reader["nomre_editorial"].ToString();
                            lista.Add(ej);
                        }   
                    }
                    connection.Close();
                }
                return lista;
            }
            
    }
}