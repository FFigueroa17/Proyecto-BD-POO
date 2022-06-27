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
    public partial class frmRecuperacionPass : Form
    {
        public frmRecuperacionPass()
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
            try
            {
                bool valid = true;
                string cadena = Resources.cadena_conexion;

                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    string query = "SELECT CORREO FROM ADMINISTRADOR WHERE CORREO='" +
                                   txtCorreo.Text + "'";
                    SqlCommand command = new SqlCommand(query, connection);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
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
            catch (Exception)
            {
                return false;
            }
        }
        
        public void EnviarNuevoCorreo(string correo)
        {
           MessageBox.Show("Correo enviado. Revise su bandeja de entrada.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
           this.Hide();
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