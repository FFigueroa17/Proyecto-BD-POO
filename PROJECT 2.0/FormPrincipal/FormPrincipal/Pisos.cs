using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using FormPrincipal.Properties;

namespace FormPrincipal
{
    public partial class Pisos : Form
    {
        public Pisos()
        {
            InitializeComponent();
        }
        
        public static List<AreaxPiso> ObtenerPiso1(){
            string cadena = Resources.cadena_conexion;
            List<AreaxPiso> lista = new List<AreaxPiso>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query =
                    "SELECT A.id_area, A.nombre from AREA A where numero_de_piso = 1";
                SqlCommand command = new SqlCommand(query, connection);
                
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader()){
                    while (reader.Read())
                    {
                        AreaxPiso are = new AreaxPiso();
                        are.IDarea = Convert.ToInt32(reader["id_area"].ToString());
                        are.Nombre = reader["nombre"].ToString();
                        lista.Add(are);
                    }   
                }
                connection.Close();
            }
            return lista;
        }
        
        public static List<AreaxPiso> ObtenerPiso2(){
            string cadena = Resources.cadena_conexion;
            List<AreaxPiso> lista = new List<AreaxPiso>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query =
                    "SELECT A.id_area, A.nombre from AREA A where numero_de_piso = 2";
                SqlCommand command = new SqlCommand(query, connection);
                
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader()){
                    while (reader.Read())
                    {
                        AreaxPiso are = new AreaxPiso();
                        are.IDarea = Convert.ToInt32(reader["id_area"].ToString());
                        are.Nombre = reader["nombre"].ToString();
                        lista.Add(are);
                    }   
                }
                connection.Close();
            }
            return lista;
        }
        
        public static List<AreaxPiso> ObtenerPiso3(){
            string cadena = Resources.cadena_conexion;
            List<AreaxPiso> lista = new List<AreaxPiso>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query =
                    "SELECT A.id_area, A.nombre from AREA A where numero_de_piso = 3";
                SqlCommand command = new SqlCommand(query, connection);
                
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader()){
                    while (reader.Read())
                    {
                        AreaxPiso are = new AreaxPiso();
                        are.IDarea = Convert.ToInt32(reader["id_area"].ToString());
                        are.Nombre = reader["nombre"].ToString();
                        lista.Add(are);
                    }   
                }
                connection.Close();
            }
            return lista;
        }
        
        public static List<AreaxPiso> ObtenerPiso4(){
            string cadena = Resources.cadena_conexion;
            List<AreaxPiso> lista = new List<AreaxPiso>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query =
                    "SELECT A.id_area, A.nombre from AREA A where numero_de_piso = 4";
                SqlCommand command = new SqlCommand(query, connection);
                
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader()){
                    while (reader.Read())
                    {
                        AreaxPiso are = new AreaxPiso();
                        are.IDarea = Convert.ToInt32(reader["id_area"].ToString());
                        are.Nombre = reader["nombre"].ToString();
                        lista.Add(are);
                    }   
                }
                connection.Close();
            }
            return lista;
        }

        public class AreaxPiso
        {
            public int IDarea { get; set; }
            public string Nombre { get; set; }
   

            public AreaxPiso()
            {
                this.IDarea = 0;
                this.Nombre = "";
            }

            public AreaxPiso(int darea, string nombre)
            {
                IDarea = darea;
                Nombre = nombre;
            }
        }

        private void Pisos_Load(object sender, EventArgs e)
        {
            dgvPiso1.DataSource = ObtenerPiso1();
            
            dgvPiso2.DataSource = ObtenerPiso2();
            
            dgvPiso3.DataSource = ObtenerPiso3();
            
            dgvPiso4.DataSource = ObtenerPiso4();
        }
    }
}