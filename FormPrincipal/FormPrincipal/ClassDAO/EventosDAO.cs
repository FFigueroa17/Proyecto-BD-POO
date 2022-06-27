using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Security.AccessControl;
using System.Windows.Forms;
using FormPrincipal.Properties;

namespace FormPrincipal
{
    public class EventosDAO
    {
        //--------FUNCION PARA MOSTRAR LOS DATOS DE LA TABLA EVENTO CON SU OBJETIVO-----------------------------
        public static List<Evento2> ObtenerTodos()
        {
            string cadena = Resources.cadena_conexion;
            List<Evento2> lista = new List<Evento2>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query =
                    "SELECT E.id_evento, titulo, imagen, fecha_hora_inicio, fecha_hora_fin, cantidad_asistencias, objetivo, nombre " +
                    "FROM EVENTO AS E " +
                        "INNER JOIN AREA " +
                            "ON AREA.id_area = E.id_area " +
                        "INNER JOIN OBJETIVO " +
                            "ON OBJETIVO.id_evento = E.id_evento " +
                    "GROUP BY E.id_evento, titulo, imagen, fecha_hora_inicio, fecha_hora_fin, cantidad_asistencias, objetivo, nombre " +
                    "ORDER BY E.id_evento ASC";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Evento2 eve = new Evento2(); //Evento eve = new Evento();
                        eve.IdEvento = Convert.ToInt32(reader["id_evento"].ToString());
                        eve.titulo = reader["titulo"].ToString();
                        eve.objetivo = reader["objetivo"].ToString();
                        eve.imagen = reader["imagen"].ToString();
                        eve.fechaIni = reader["fecha_hora_inicio"].ToString();
                        eve.fechaFin = reader["fecha_hora_fin"].ToString();
                        eve.asistencias = Convert.ToInt32(reader["cantidad_asistencias"].ToString());
                        eve.areaEvento = reader["nombre"].ToString();
                        eve.imagenevento = obtenerImagen(eve.imagen);
                        lista.Add(eve);
                    }
                }
                connection.Close();
            }
            return lista;
        }

        //FUNCION PARA OBTENER IMAGEN--------------------
        public static Bitmap obtenerImagen(string ruta)
        {//VERIFICAR RUTAS FINALES
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
                MessageBox.Show("No se han encontrado todas las imagenes de los eventos.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return fotico;
        }

        //--------FUNCION PARA AGREGAR NUEVO EVENTO----------------------------------------------------------------
        public static void CrearNuevo(Evento eve)
        {
            string cadena = Resources.cadena_conexion;

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "INSERT INTO EVENTO (titulo, imagen, fecha_hora_inicio, cantidad_asistencias, fecha_hora_fin, id_area) " +
                               "VALUES(@titulo, @imagen, @fecha_hora_inicio, @cantidad_asistencias, @fecha_hora_fin, @id_area)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@titulo", eve.titulo);
                command.Parameters.AddWithValue("@imagen", eve.imagen);
                command.Parameters.AddWithValue("@fecha_hora_inicio", eve.fechInicio);
                command.Parameters.AddWithValue("@cantidad_asistencias", eve.asistencias);
                command.Parameters.AddWithValue("@fecha_hora_fin", eve.fechFin);
                command.Parameters.AddWithValue("@id_area", eve.idareaeve);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                Objetivo obje = new Objetivo(eve.objetivo, EventosDAO.ObtenerIdEventoAgregado());
                AgregarObjetivo(obje);
            }
        }

        //-------FUNCION AGREGAR DATO EN LA TABLA OBJETIVO------------------------------------------
        public static void AgregarObjetivo(Objetivo obj)
        {
            string cadena = Resources.cadena_conexion;

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "INSERT INTO OBJETIVO (objetivo, id_evento) " +
                               "VALUES(@objetivo, @id_evento)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@objetivo", obj.objetivo);
                command.Parameters.AddWithValue("@id_evento", obj.idevento);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        //------FUNCION Q OBTIENE POR MEDIO DE UNA CONSULTA, EL ULTIMO ID_EVENTO INGRESADO EN LA TABLA EVENTO---------
        public static int ObtenerIdEventoAgregado()
        {
            int aidi = 0;

            string chain = Resources.cadena_conexion;

            using (SqlConnection connection = new SqlConnection(chain))
            {
                string query2 =
                    "SELECT id_evento " +
                    "FROM EVENTO " +
                    "WHERE EVENTO.id_evento = IDENT_CURRENT('EVENTO')";

                SqlCommand command2 = new SqlCommand(query2, connection);

                connection.Open();
                using (SqlDataReader reader = command2.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Evento eve = new Evento();
                        eve.IDEvento = Convert.ToInt32(reader["id_evento"].ToString());
                        aidi = eve.IDEvento;
                    }
                }
                connection.Close();
            }

            return aidi;
        }

        //------FUNCION PARA ELIMINAR EN BASE AL ID INGRESADO/RECIBIDO------------------------
        public static bool EliminarPorID(int ID)
        {
            bool exito = true;
            try
            {
                string cadena = Resources.cadena_conexion;
                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    string query = "DELETE FROM EVENTO " + "WHERE id_evento = @id";
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

        //---------FUNCION PARA ACTUALIZAR INFO EN FILA/EVENTO EXISTENTE---------------------------------
        public static bool ActualizarPorID(Evento eve)
        {
            bool exito = true;
            try
            {
                string cadena = Resources.cadena_conexion;
                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    string query =
                        "UPDATE EVENTO " +
                        "SET titulo = @newtitle, imagen = @newimage, fecha_hora_inicio = @newIni, cantidad_asistencias= @newasis, " +
                        "fecha_hora_fin = @newEnd, id_area = @idareaeven " +
                        "WHERE id_evento = @id";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@id", eve.IDEvento);
                    command.Parameters.AddWithValue("@newtitle", eve.titulo);
                    command.Parameters.AddWithValue("@newimage", eve.imagen);
                    command.Parameters.AddWithValue("@newIni", eve.fechInicio);
                    command.Parameters.AddWithValue("@newasis", eve.asistencias);
                    command.Parameters.AddWithValue("@newEnd", eve.fechFin);
                    command.Parameters.AddWithValue("@idareaeven", eve.idareaeve);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    Objetivo obj = new Objetivo(eve.objetivo, eve.IDEvento);
                    ActualizarOBJPorID(obj);
                }
            }
            catch (Exception e)
            {
                exito = false;
            }
            return exito;
        }

        //----ACTUALIZAR TABLA OBJETIVO-----------------
        public static void ActualizarOBJPorID(Objetivo obj)
        {

            try
            {
                string cadena = Resources.cadena_conexion;
                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    string query =
                        "UPDATE OBJETIVO " +
                        "SET objetivo = @newobjetive " +
                        "WHERE id_evento = @id";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@id", obj.idevento);
                    command.Parameters.AddWithValue("@newobjetive", obj.objetivo);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al insertar objetivo");
            }

        }

        //-----FUNCION PARA OBTENER DATOS DEL COMBO BOX EVENTO------------------------------
        public static List<Evento> ObtenerCombobox()
        {
            string cadena = Resources.cadena_conexion;
            List<Evento> lista = new List<Evento>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query =
                    "SELECT id_area, nombre " +
                    "FROM AREA " +
                        "WHERE (id_area BETWEEN 3 AND 6) OR " +
                            "(id_area BETWEEN 19 AND 26)";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
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

        //-----------FUNCION PARA VERIFICAR EL RANGO DE FECHAS RESERVADAS DE LOS EVENTOS------------------------
        public static bool VerificarDisponibilidadFechas(Evento uwu)
        {
            bool verify = false, alguna = false, todos1 = true, todos2 = true;
            int contareasdif = 0, contsameareamay = 0, contsameareamin = 0, loops = 0;
            DateTime fechini = uwu.fechInicio;
            DateTime fechfin = uwu.fechFin;
            int idarea = uwu.idareaeve;
            List<Evento> lista = ObtenerFechas();

            try
            {
                //----PRUEBA DE VERIFICACION DE FECHAS CON BUCLE FOR-----------------

                int lis = lista.Count;//contar elementos de la lista

                for (int i = 1; i <= lis; i++)
                {
                    if ((DateTime.Compare(fechini, lista[i].fechFin/*evento.fechFin*/) > 0
                         && DateTime.Compare(fechfin, lista[i + 1].fechInicio) < 0) && idarea == lista[i].idareaeve)
                    {
                        alguna = true;
                        todos1 = false;
                        todos2 = false;
                    }
                    else
                    {
                        if ((DateTime.Compare(fechini, lista[i].fechFin) < 0
                             && DateTime.Compare(fechfin, lista[i].fechInicio) < 0) && idarea == lista[i].idareaeve)//todos1
                        {
                            //todos2 = false;
                            contsameareamin++;
                        }
                        else
                        {
                            if ((DateTime.Compare(fechini, lista[i].fechFin) > 0
                                 && DateTime.Compare(fechfin, lista[i].fechInicio) > 0) && idarea == lista[i].idareaeve)//todos2
                            {
                                contsameareamay++;
                                //todos1 = false;
                            }
                            else
                            {
                                if (idarea != lista[i].idareaeve)
                                {
                                    contareasdif++;
                                }
                                else
                                {
                                    todos1 = false;
                                    todos2 = false;
                                    alguna = false;
                                }
                            }
                        }
                    }
                    //contador
                    loops++;//calcula la cantidad de datos/veces q se ha recorrido el bucle
                }

                loops = loops - contareasdif;//veces recorrido - veces q se comparo con un area diferente
                if (loops == contsameareamin)
                {
                    todos2 = false;
                }
                else if (loops == contsameareamay)
                {
                    todos1 = false;
                }
                else if (loops == 0)
                {
                    verify = true;
                }
                //---TERMINA PRUEBAAA-------------------------------
            }
            catch (Exception e)
            {
                verify = false;
            }

            if (alguna)
            {
                verify = true;
            }
            else if (todos1 || todos2)
            {
                verify = true;
            }

            return verify;
        }

        //-----FUNCION PARA OBTENER LAS FECHAS RESERVADA DE EVENTOS EN ORDEN ASCENDENTE-------------------------
        public static List<Evento> ObtenerFechas()
        {
            string cadena = Resources.cadena_conexion;
            List<Evento> lista = new List<Evento>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query =
                    "SELECT fecha_hora_inicio, fecha_hora_fin, AREA.id_area " +
                    "FROM EVENTO, AREA " +
                    "WHERE EVENTO.id_area = AREA.id_area " +
                    "ORDER BY fecha_hora_inicio ASC";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Evento eve = new Evento();
                        eve.idareaeve = Convert.ToInt32(reader["id_area"].ToString());
                        eve.fechInicio = Convert.ToDateTime(reader["fecha_hora_inicio"].ToString());
                        eve.fechFin = Convert.ToDateTime(reader["fecha_hora_fin"].ToString());
                        lista.Add(eve);
                    }
                }
                connection.Close();
            }

            return lista;
        }

        //--------CONSULTAR NOMBRE DE IMAGEN PARA ACTUALIZAR-------------------
        public static string ObtenerNombreImagen(int id_evento)
        {
            string ima = "", cadena = Resources.cadena_conexion;

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query =
                    "SELECT imagen FROM EVENTO WHERE id_evento = @id";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@id", id_evento);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ima = reader["imagen"].ToString();
                    }
                }
                connection.Close();
            }

            return ima;
        }

        //-----OBTENER FECHAS----------------
        public static Evento ObtenerFechasAct(int id_evento)
        {
            string cadena = Resources.cadena_conexion;
            Evento eve = new Evento();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query =
                    "SELECT fecha_hora_fin, fecha_hora_inicio FROM EVENTO WHERE id_evento = @id";
                
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@id", id_evento);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        eve.fechFin = Convert.ToDateTime(reader["fecha_hora_fin"].ToString());
                        eve.fechInicio = Convert.ToDateTime(reader["fecha_hora_inicio"].ToString());
                    }
                }
                connection.Close();
            }

            return eve;
        }
    }
}