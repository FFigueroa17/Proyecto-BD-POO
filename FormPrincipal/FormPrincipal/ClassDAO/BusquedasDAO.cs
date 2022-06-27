using FormPrincipal.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormPrincipal
{
    public static class BusquedasDAO
    {

        // FUNCION BUSQUEDA POR TITULO COMPLETO
        public static List<EjemplarConsulta> FiltrarPorTitulo(string titulo)
        {
            string cadena = Resources.cadena_conexion;
            List<EjemplarConsulta> lista = new List<EjemplarConsulta>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query =
                    "SELECT EJ.id_ejemplar, EJ.nombre, EJ.portada, EJ.formato, EJ.fecha_publicacion, IDI.idioma, CO.nombre AS 'Colección', EDI.nomre_editorial, EJ.isbn, EJ.issn, EJ.doi, AU.nombre_autor , STRING_AGG(PA.palabra_clave, ', ') 'palabra_clave' " +
                    "FROM EJEMPLAR EJ " +
                    "INNER JOIN IDIOMA IDI ON EJ.id_idioma = IDI.id_idioma " +
                    "INNER JOIN COLECCION CO ON EJ.id_coleccion = CO.id_coleccion " +
                    "INNER JOIN EDITORIAL EDI ON EJ.id_editorial = EDI.id_editorial " +
                    "LEFT JOIN PALABRA_CLAVE PA ON PA.id_ejemplar = EJ.id_ejemplar " +
                    "LEFT JOIN EJEMPLARXAUTOR EJX ON EJX.id_ejemplar = EJ.id_ejemplar " +
                    "LEFT JOIN AUTOR AU ON EJX.id_autor = AU.id_autor " +
                    "WHERE EJ.nombre LIKE @titulobuscar " +
                    "GROUP BY EJ.id_ejemplar, EJ.nombre, EJ.portada, EJ.formato, EJ.fecha_publicacion, IDI.idioma, CO.nombre, EDI.nomre_editorial, EJ.isbn, EJ.issn, EJ.doi, AU.nombre_autor " +
                    "ORDER BY EJ.id_ejemplar";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@titulobuscar", titulo);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
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
                        ej.Coleccion = reader["Colección"].ToString();
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

        //FUNCION BUSQUEDA POR TITULO PARCIAL
      
        public static List<EjemplarConsulta> FiltrarPorTituloParcial(string titulo)
        {
            string cadena = Resources.cadena_conexion;
            List<EjemplarConsulta> lista = new List<EjemplarConsulta>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query =
                    "SELECT EJ.id_ejemplar, EJ.nombre, EJ.portada, EJ.formato, EJ.fecha_publicacion, IDI.idioma, CO.nombre AS 'Colección', EDI.nomre_editorial, EJ.isbn, EJ.issn, EJ.doi, AU.nombre_autor , STRING_AGG(PA.palabra_clave, ', ') 'palabra_clave' " +
                    "FROM EJEMPLAR EJ " +
                    "INNER JOIN IDIOMA IDI ON EJ.id_idioma = IDI.id_idioma " +
                    "INNER JOIN COLECCION CO ON EJ.id_coleccion = CO.id_coleccion " +
                    "INNER JOIN EDITORIAL EDI ON EJ.id_editorial = EDI.id_editorial " +
                    "LEFT JOIN PALABRA_CLAVE PA ON PA.id_ejemplar = EJ.id_ejemplar " +
                    "LEFT JOIN EJEMPLARXAUTOR EJX ON EJX.id_ejemplar = EJ.id_ejemplar " +
                    "LEFT JOIN AUTOR AU ON EJX.id_autor = AU.id_autor " +
                    "WHERE EJ.nombre LIKE @titulobuscar " +
                    "GROUP BY EJ.id_ejemplar, EJ.nombre, EJ.portada, EJ.formato, EJ.fecha_publicacion, IDI.idioma, CO.nombre, EDI.nomre_editorial, EJ.isbn, EJ.issn, EJ.doi, AU.nombre_autor " +
                    "ORDER BY EJ.id_ejemplar";
                
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@titulobuscar", titulo + '%');

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
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
                        ej.Coleccion = reader["Colección"].ToString();
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

        // FUNCION BUSQUEDA POR PALABRAS CLAVE

        public static List<EjemplarConsulta> FiltrarPorPalabrasClave(string reference)
        {
            string cadena = Resources.cadena_conexion;
            List<EjemplarConsulta> lista = new List<EjemplarConsulta>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query =
                    "SELECT EJ.id_ejemplar, EJ.nombre, EJ.portada, EJ.formato, EJ.fecha_publicacion, IDI.idioma, CO.nombre AS 'Colección', EDI.nomre_editorial, EJ.isbn, EJ.issn, EJ.doi, AU.nombre_autor , STRING_AGG(PA.palabra_clave, ', ') 'palabra_clave' " +
                    "FROM EJEMPLAR EJ " +
                    "INNER JOIN IDIOMA IDI ON EJ.id_idioma = IDI.id_idioma " +
                    "INNER JOIN COLECCION CO ON EJ.id_coleccion = CO.id_coleccion " +
                    "INNER JOIN EDITORIAL EDI ON EJ.id_editorial = EDI.id_editorial " +
                    "LEFT JOIN PALABRA_CLAVE PA ON PA.id_ejemplar = EJ.id_ejemplar " +
                    "LEFT JOIN EJEMPLARXAUTOR EJX ON EJX.id_ejemplar = EJ.id_ejemplar " +
                    "LEFT JOIN AUTOR AU ON EJX.id_autor = AU.id_autor " +
                    "WHERE PA.palabra_clave LIKE @palabrabuscada " +
                    "GROUP BY EJ.id_ejemplar, EJ.nombre, EJ.portada, EJ.formato, EJ.fecha_publicacion, IDI.idioma, CO.nombre, EDI.nomre_editorial, EJ.isbn, EJ.issn, EJ.doi, AU.nombre_autor " +
                    "ORDER BY EJ.id_ejemplar";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@palabrabuscada", reference + '%');

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
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
                        ej.Coleccion = reader["Colección"].ToString();
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

        // FUNCION BUSQUEDA POR AUTOR

        public static List<EjemplarConsulta> FiltrarPorAutor(string reference)
        {
            string cadena = Resources.cadena_conexion;
            List<EjemplarConsulta> lista = new List<EjemplarConsulta>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query =
                    "SELECT EJ.id_ejemplar, EJ.nombre, EJ.portada, EJ.formato, EJ.fecha_publicacion, IDI.idioma, CO.nombre AS 'Colección', EDI.nomre_editorial, EJ.isbn, EJ.issn, EJ.doi, AU.nombre_autor , STRING_AGG(PA.palabra_clave, ', ') 'palabra_clave' " +
                    "FROM EJEMPLAR EJ " +
                    "INNER JOIN IDIOMA IDI ON EJ.id_idioma = IDI.id_idioma " +
                    "INNER JOIN COLECCION CO ON EJ.id_coleccion = CO.id_coleccion " +
                    "INNER JOIN EDITORIAL EDI ON EJ.id_editorial = EDI.id_editorial " +
                    "LEFT JOIN PALABRA_CLAVE PA ON PA.id_ejemplar = EJ.id_ejemplar " +
                    "LEFT JOIN EJEMPLARXAUTOR EJX ON EJX.id_ejemplar = EJ.id_ejemplar " +
                    "LEFT JOIN AUTOR AU ON EJX.id_autor = AU.id_autor " +
                    "WHERE AU.nombre_autor LIKE @autorbuscado " +
                    "GROUP BY EJ.id_ejemplar, EJ.nombre, EJ.portada, EJ.formato, EJ.fecha_publicacion, IDI.idioma, CO.nombre, EDI.nomre_editorial, EJ.isbn, EJ.issn, EJ.doi, AU.nombre_autor " +
                    "ORDER BY EJ.id_ejemplar";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@autorbuscado", reference + '%');

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
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
                        ej.Coleccion = reader["Colección"].ToString();
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

        
        //FUNCION BUSQUEDA POR FORMATO

        public static List<EjemplarConsulta> FiltrarPorFormato(string reference)
        {
            string cadena = Resources.cadena_conexion;
            List<EjemplarConsulta> lista = new List<EjemplarConsulta>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query =
                    "SELECT EJ.id_ejemplar, EJ.nombre, EJ.portada, EJ.formato, EJ.fecha_publicacion, IDI.idioma, CO.nombre AS 'Colección', EDI.nomre_editorial, EJ.isbn, EJ.issn, EJ.doi, AU.nombre_autor , STRING_AGG(PA.palabra_clave, ', ') 'palabra_clave' " +
                    "FROM EJEMPLAR EJ " +
                    "INNER JOIN IDIOMA IDI ON EJ.id_idioma = IDI.id_idioma " +
                    "INNER JOIN COLECCION CO ON EJ.id_coleccion = CO.id_coleccion " +
                    "INNER JOIN EDITORIAL EDI ON EJ.id_editorial = EDI.id_editorial " +
                    "LEFT JOIN PALABRA_CLAVE PA ON PA.id_ejemplar = EJ.id_ejemplar " +
                    "LEFT JOIN EJEMPLARXAUTOR EJX ON EJX.id_ejemplar = EJ.id_ejemplar " +
                    "LEFT JOIN AUTOR AU ON EJX.id_autor = AU.id_autor " +
                    "WHERE EJ.formato LIKE @formatobuscado " +
                    "GROUP BY EJ.id_ejemplar, EJ.nombre, EJ.portada, EJ.formato, EJ.fecha_publicacion, IDI.idioma, CO.nombre, EDI.nomre_editorial, EJ.isbn, EJ.issn, EJ.doi, AU.nombre_autor " +
                    "ORDER BY EJ.id_ejemplar";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@formatobuscado", reference + '%');

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
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
                        ej.Coleccion = reader["Colección"].ToString();
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


    }
}
