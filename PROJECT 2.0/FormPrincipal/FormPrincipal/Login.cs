using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using FormPrincipal.Properties;

namespace FormPrincipal
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
            }
        }


        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (txtContrasenia.Text == "Contraseña")
            {
                txtContrasenia.Text = "";
                txtContrasenia.UseSystemPasswordChar = true;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (txtContrasenia.Text == "")
            {
                txtContrasenia.Text = "Contraseña";
                txtContrasenia.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        private void abrirFormulario(object form1)
        {
            Form f1 = form1 as Form;
            f1.Show();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool valid = loginVerificador();
            if (valid == true)
            {
                this.Hide();
                Bienvenida bien = new Bienvenida(txtUsuario.Text);
                bien.ShowDialog();
            }

            else
            {
                lblMensaje.Text = "Credenciales no válidas.";
            }
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            lblMensaje.Text = "";
        }

        private bool loginVerificador()
        {
            bool valid = true;
            string cadena = Resources.cadena_conexion;

            using (SqlConnection connection = new SqlConnection(cadena)){
                string query = "SELECT USUARIO, CONTRASENIA FROM ADMINISTRADOR WHERE USUARIO='" +
                txtUsuario.Text + "' AND CONTRASENIA='" + txtContrasenia.Text + "'";
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

        private void label3_Click(object sender, EventArgs e)
        {
            RecuperacionPass recuperacion = new RecuperacionPass();
            recuperacion.ShowDialog();
            
        }
    }
}