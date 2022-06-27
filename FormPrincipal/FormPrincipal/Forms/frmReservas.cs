using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;
using FormPrincipal.Properties;

namespace FormPrincipal
{
    public partial class frmReservas : Form
    {
        public frmReservas()
        {
            InitializeComponent();
        }
        
        public string Flag(DateTime prueba1, DateTime prueba2, int id)
        {
            bool exito = true;
            string cadena = Resources.cadena_conexion;
            string count = "";

            using (SqlConnection connection = new SqlConnection(cadena)){
                
                string query = "select count(*) 'Conteo' from RESERVA WHERE id_ejemplar = '" +id + "' AND CONVERT(datetime,'" +prueba1+ "',103) >= fecha_hora_prestamo AND CONVERT(datetime,'" +prueba1+ "',103) <= fecha_hora_devolucion";
               
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader()){
                    while (reader.Read())
                    {
                        count = reader["Conteo"].ToString();
                    }   
                }
                connection.Close();
            }
            return count;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime prueba1 = Convert.ToDateTime(dtpPrestamo.Value.Date + dtpPrestamoH.Value.TimeOfDay);
                DateTime prueba2 = Convert.ToDateTime(dtpDevolucion.Value.Date + dtpDevolucionH.Value.TimeOfDay);
                int id = ReservasDAO.ObtenerIDEjemplar(cmbEjemplar.Text);
                lblPrueba1.Text = Convert.ToString(prueba1);
                lblPrueba2.Text = Convert.ToString(prueba2);
                string verify = Flag(prueba1, prueba2, id);

                if (dtpReserva.Value != null && dtpPrestamo.Value != null && dtpDevolucion.Value != null)
                {
                    if (verify == "0")
                    {
                        Reserva col = new Reserva();
                        col.fecha_hora_reserva = dtpReserva.Value.Date + dtpReservaH.Value.TimeOfDay;
                        col.fecha_hora_prestamo = dtpPrestamo.Value.Date + dtpPrestamoH.Value.TimeOfDay;
                        col.fecha_hora_devolucion = dtpDevolucion.Value.Date + dtpDevolucionH.Value.TimeOfDay;
                        col.id_usuario = ReservasDAO.ObtenerIDUsuario(cmbUsuario.Text);
                        col.id_ejemplar = ReservasDAO.ObtenerIDEjemplar(cmbEjemplar.Text);

                        ReservasDAO.CrearNuevo(col);
                        MessageBox.Show("Nueva reserva agregada correctamente", "BINAES", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Este ejemplar ya se encuentra reservado, introduzca nuevas fechas.", "BINAES", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Debe llenar todos los campos", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                MostrarReservasAux();
            }
            catch (Exception)
            {
                MessageBox.Show("Prestamo no disponible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarReservasAux();
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtReservaMod.Text.Length > 0)
            {
                int ID_a_borrar = Convert.ToInt32(txtReservaMod.Text);

                if (ReservasDAO.EliminarPorID(ID_a_borrar))
                    MessageBox.Show("Reserva eliminada correctamente", "BINAES", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                else
                    MessageBox.Show("Ha ocurrido un error");
            }
            else
            {
                MessageBox.Show("Ingrese un ID de reserva correcto", "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }

            MostrarReservasAux();
        }
        
        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            dtpReservaH.Value = DateTime.Now;
        }

        public void MostrarReservasAux()
        {
            try
            {
                dgvReservas.RowTemplate.Height = 50;
                dgvReservas.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvReservas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                dgvReservas.DataSource = null;
                dgvReservas.DataSource = ReservasDAO.ObtenerTodos();

                DataGridViewImageColumn columna = (DataGridViewImageColumn)dgvReservas.Columns["Portada"];
                columna.ImageLayout = DataGridViewImageCellLayout.Zoom;

                dgvReservas.Columns["id_usuario"].Visible = false;
                dgvReservas.Columns["id_ejemplar"].Visible = false;
                dgvReservas.Columns["fotografia"].Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error en la carga de datos", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void dgvReservas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    //Obtener el libro seleccionado
                    ReservaConsulta ej = dgvReservas.SelectedRows[0].DataBoundItem as ReservaConsulta;

                    //mostrar la informacion en los textbox

                    lblTituloM.Text = ej.Ejemplar;
                    lblReservaM.Text = ej.Reserva.ToString();
                    lblPrestamoM.Text = ej.Prestamo.ToString();
                    lblDevolucionM.Text = ej.Devolución.ToString();
                    picPortada.Image = ej.Portada;

                    //ocultando textbox "id"
                    txtReservaMod.AppendText(ej.id_reserva.ToString());

                    //cambiar de pesta;ana
                    tbReservas.SelectedIndex = 1;

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error en la carga de datos", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void frmReservas_Load(object sender, EventArgs e)
        {
            try
            {
                tbReservas.Appearance = TabAppearance.FlatButtons;
                tbReservas.ItemSize = new Size(0, 1);
                tbReservas.SizeMode = TabSizeMode.Fixed;
                tbReservas.TabStop = false;

                cmbEjemplar.DataSource = null;
                cmbEjemplar.ValueMember = "nombre";
                cmbEjemplar.DisplayMember = "Ejemplar";
                cmbEjemplar.DataSource = ReservasDAO.ObtenerEjemplares();

                cmbUsuario.DataSource = null;
                cmbUsuario.ValueMember = "nombre";
                cmbUsuario.DisplayMember = "Usuario";
                cmbUsuario.DataSource = ReservasDAO.ObtenerUsuarios();

                cmbEjemplarAC.DataSource = null;
                cmbEjemplarAC.ValueMember = "nombre";
                cmbEjemplarAC.DisplayMember = "Ejemplar";
                cmbEjemplarAC.DataSource = ReservasDAO.ObtenerEjemplares();

                cmbUsuarioAC.DataSource = null;
                cmbUsuarioAC.ValueMember = "nombre";
                cmbUsuarioAC.DisplayMember = "Usuario";
                cmbUsuarioAC.DataSource = ReservasDAO.ObtenerUsuarios();

                txtReservaMod.Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error en la carga de datos", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void btnActualizarAC_Click(object sender, EventArgs e)
        {
            if (dtpReservaAC.Value != null && dtpPrestamoAC.Value != null && dtpDevolucionAC.Value != null)
            {
                Reserva col = new Reserva();
                col.id_reserva = Convert.ToInt32(txtReservaMod.Text);
                col.fecha_hora_reserva = dtpReservaAC.Value.Date + dtpReservaHAC.Value.TimeOfDay;
                col.fecha_hora_prestamo = dtpPrestamoAC.Value.Date + dtpPrestamoHAC.Value.TimeOfDay;
                col.fecha_hora_devolucion = dtpDevolucionAC.Value.Date + dtpDevolucionHAC.Value.TimeOfDay;
                col.id_usuario = ReservasDAO.ObtenerIDUsuario(cmbUsuarioAC.Text);
                col.id_ejemplar = ReservasDAO.ObtenerIDEjemplar(cmbEjemplarAC.Text);

                ReservasDAO.ActualizarPorID(col);
                MessageBox.Show("Reserva actualizada correctamente", "BINAES", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            MostrarReservasAux();
        }

        private void btnActualizarVista_Click(object sender, EventArgs e)
        {
            tbReservas.SelectedIndex = 2;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            tbReservas.SelectedIndex = 0;
        }

        private void btnRegresarAC_Click(object sender, EventArgs e)
        {
            tbReservas.SelectedIndex = 0;
        }
    }
}