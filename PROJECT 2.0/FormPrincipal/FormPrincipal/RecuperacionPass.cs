using System;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormPrincipal.Properties;

namespace FormPrincipal
{
    public partial class RecuperacionPass : Form
    {
        public RecuperacionPass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool valid = loginVerificador();
            if (valid == true)
            {
                EnviarNuevoCorreo(txtCorreo.Text);
            }

            else
            {
                lblMensaje.Text = "Este correo no se encuentra en la base de datos.";
            }
        }
        
        private bool loginVerificador()
        {
            bool valid = true;
            string cadena = Resources.cadena_conexion;

            using (SqlConnection connection = new SqlConnection(cadena)){
                string query = "SELECT CORREO FROM ADMINISTRADOR WHERE CORREO='" +
                               txtCorreo.Text  +  "'";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader()){
                    if (reader.Read())
                    {
                        valid = true;
                    }

                    else
                    {
                        valid = false;
                    }
                }
                connection.Close();
            }
            return valid;
        }
        
        public void EnviarNuevoCorreo(string correo)
        {
            string cadena = Resources.cadena_conexion;
            string Pass = "";

            using (SqlConnection connection = new SqlConnection(cadena)){
                string query = "SELECT CONTRASENIA FROM ADMINISTRADOR WHERE CORREO='" +
                               txtCorreo.Text  +  "'";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader()){
                    while (reader.Read())
                    {
                        Pass = reader["Contrasenia"].ToString();
                    }   
                }
                connection.Close();
            
                
                string mensaje = string.Empty;
            string destinatario = correo;
            string remitente = "system.binaes@outlook.com";
            string asunto = "Soporte - Recuperación de contraseña";
            string cuerpo = "Estimado administrador, su contraseña es:  " + Pass;
            MailMessage ms = new MailMessage(remitente, destinatario, asunto, cuerpo);

            SmtpClient smtp = new SmtpClient("smtp.office365.com", 587);
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("system.binaes@outlook.com", "binaes2022");

            try
            {
                Task.Run(() =>
                {
                    smtp.Send(ms);
                    ms.Dispose();
                    MessageBox.Show("Correo enviado. Revise su bandeja de entrada.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                });
            }

            catch (Exception ex)
            {
                lblMensaje.Text = "Error.";
            } 
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void RecuperacionPass_Load(object sender, EventArgs e)
        {
            lblMensaje.Text = "";
        }
    }
}