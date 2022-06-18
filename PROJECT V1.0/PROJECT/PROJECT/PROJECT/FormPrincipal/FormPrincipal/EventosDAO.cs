﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using FormPrincipal.Properties;

namespace FormPrincipal
{
    public class EventosDAO
    {
        public static List<Evento> ObtenerTodos(){
                string cadena = Resources.cadena_conexion;
                List<Evento> lista = new List<Evento>();

                using (SqlConnection connection = new SqlConnection(cadena)){
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
                    using (SqlDataReader reader = command.ExecuteReader()){
                        while (reader.Read())
                        {
                            Evento eve = new Evento();
                            eve.IDEvento = Convert.ToInt32(reader["id_evento"].ToString());
                            eve.titulo = reader["titulo"].ToString();
                            eve.objetivo = reader["objetivo"].ToString();
                            eve.imagen = reader["imagen"].ToString();
                            eve.fechaIni = reader["fecha_hora_inicio"].ToString();
                            eve.fechaFin = reader["fecha_hora_fin"].ToString();
                            eve.asistencias = Convert.ToInt32(reader["cantidad_asistencias"].ToString());
                            eve.areaevento = reader["nombre"].ToString();
                            lista.Add(eve);
                        }   
                    }
                    connection.Close();
                }
                return lista;
        }
        
        public static void CrearNuevo(Evento eve)
        {
            string cadena = Resources.cadena_conexion;

            using (SqlConnection connection = new SqlConnection(cadena)){
                string query = "INSERT INTO EVENTO (titulo, imagen, fecha_hora_inicio, cantidad_asistencias, fecha_hora_fin, id_area) " + 
                               "VALUES(@titulo, @imagen, @fecha_hora_inicio, @cantidad_asistencias, @fecha_hora_fin, @id_area)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@titulo", eve.titulo);
                command.Parameters.AddWithValue("@imagen", eve.imagen); 
                command.Parameters.AddWithValue("@fecha_hora_inicio", eve.fechaIni);
                command.Parameters.AddWithValue("@cantidad_asistencias", eve.asistencias);
                command.Parameters.AddWithValue("@fecha_hora_fin", eve.fechaFin);
                command.Parameters.AddWithValue("@id_area", eve.idareaeve);
                //falta agregar el objetivo a su tabla
                
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                    
            }
        }
            
        /*public static bool EliminarPorID(int ID) 
        { 
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
                    string query = "UPDATE COLECCION SET nombre = @nuevonombre, id_genero = @nuevoid_genero, id_tipo = @nuevoid_tipo, numero_de_piso= @nuevonumero_de_piso WHERE id_coleccion = @id"; 
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
        } */
        
        public static List<Evento> ObtenerCombobox(){
                string cadena = Resources.cadena_conexion;
                List<Evento> lista = new List<Evento>();

                using (SqlConnection connection = new SqlConnection(cadena)){
                    string query = 
                        "SELECT id_area, nombre " +
                        "FROM AREA " +
                            "WHERE (id_area BETWEEN 3 AND 6) OR "  +
                                "(id_area BETWEEN 19 AND 26)";
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

        public static bool VerificarDisponibilidadFechas(Evento uwu)
        {
            bool verify = true, alguna = false, todos1 = true, todos2 = true;
            DateTime fechini = Convert.ToDateTime(uwu.fechInicio);
            DateTime fechfin = Convert.ToDateTime(uwu.fechFin);
            int idarea = uwu.idareaeve;

            try
            {
                foreach (var evento in ObtenerFechas())
                {
                    if ((fechini > evento.fechFin && fechfin < evento.fechInicio) && idarea == evento.idareaeve)
                    {
                        alguna = true;
                        todos1 = false;
                        todos2 = false;
                    }
                    else
                    {
                        if ((fechini < evento.fechFin && fechini < evento.fechInicio) && idarea == evento.idareaeve)//todos1
                        {
                            todos2 = false;
                        }
                        else
                        {
                            if ((fechini > evento.fechFin && fechfin > evento.fechInicio) && idarea == evento.idareaeve)//todos2
                            {
                                todos1 = false;
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
            }
            catch (Exception e)
            {
                verify = false;
            }

            if (alguna)
            {
                verify = true;
            }else if (todos1 || todos2)
            {
                verify = true;
            }
            
            return verify;
        }
        
        public static List<Evento> ObtenerFechas(){
                string cadena = Resources.cadena_conexion;
                List<Evento> lista = new List<Evento>();

                using (SqlConnection connection = new SqlConnection(cadena)){
                    string query =
                        "SELECT fecha_hora_inicio, fecha_hora_fin, AREA.id_area" +
                        "FROM EVENTO, AREA " +
                        "WHERE EVENTO.id_area = AREA.id_area " +
                        "ORDER BY fecha_hora_inicio ASC";
                    SqlCommand command = new SqlCommand(query, connection);
                
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader()){
                        while (reader.Read())
                        {
                            Evento eve = new Evento();
                            eve.idareaeve = Convert.ToInt32(reader["AREA.id_area"].ToString());
                            eve.fechInicio = Convert.ToDateTime(reader["fecha_hora_inicio"].ToString());
                            eve.fechFin = Convert.ToDateTime(reader["fecha_hora_fin"].ToString());
                            lista.Add(eve);
                        }   
                    }
                    connection.Close();
                }
                return lista;
        }
    }
}