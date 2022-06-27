using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormPrincipal.Properties;

namespace FormPrincipal
{
    public partial class frmPrestamos : Form
    {
        public frmPrestamos()
        {
            InitializeComponent();
        }

        public string Flag(DateTime prueba1, DateTime prueba2, int id)
        {
            bool exito = true;
            string cadena = Resources.cadena_conexion;
            string count = "";

            using (SqlConnection connection = new SqlConnection(cadena)){
                string query = "select count(*) 'Conteo' from PRESTAMO WHERE id_ejemplar = '" +id + "' AND CONVERT(datetime,'" +prueba1+ "',103) >= fecha_hora_prestamo AND CONVERT(datetime,'" +prueba1+ "',103) <= fecha_hora_devolucion";
               
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

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarReservasAux();
        }

        public void MostrarReservasAux()
        {
            try
            {
                dgvPrestamos.RowTemplate.Height = 50;
                dgvPrestamos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvPrestamos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                dgvPrestamos.DataSource = null;
                dgvPrestamos.DataSource = PrestamosDAO.ObtenerTodos();

                DataGridViewImageColumn columna = (DataGridViewImageColumn)dgvPrestamos.Columns["Portada"];
                columna.ImageLayout = DataGridViewImageCellLayout.Zoom;

                dgvPrestamos.Columns["id_usuario"].Visible = false;
                dgvPrestamos.Columns["id_ejemplar"].Visible = false;
                dgvPrestamos.Columns["fotografia"].Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error en la carga de datos", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime prueba1 = Convert.ToDateTime(dtpPrestamo.Value.Date + dtpPrestamoH.Value.TimeOfDay);
                DateTime prueba2 = Convert.ToDateTime(dtpDevolucion.Value.Date + dtpDevolucionH.Value.TimeOfDay);
                int id = PrestamosDAO.ObtenerIDEjemplar(cmbEjemplar.Text);
                lblPrueba1.Text = Convert.ToString(prueba1);
                lblPrueba2.Text = Convert.ToString(prueba2);
                string verify = Flag(prueba1, prueba2, id);

                if (dtpPrestamo.Value != null && dtpDevolucion.Value != null)
                {
                    if (verify == "0")
                    {
                        Prestamo col = new Prestamo();
                        col.fecha_hora_prestamo = dtpPrestamo.Value.Date + dtpPrestamoH.Value.TimeOfDay;
                        col.fecha_hora_devolucion = dtpDevolucion.Value.Date + dtpDevolucionH.Value.TimeOfDay;
                        col.id_usuario = PrestamosDAO.ObtenerIDUsuario(cmbUsuario.Text);
                        col.id_ejemplar = PrestamosDAO.ObtenerIDEjemplar(cmbEjemplar.Text);

                        PrestamosDAO.CrearNuevo(col);
                        MessageBox.Show("Nuevo prestamo agregado correctamente", "BINAES", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }

                    else
                    {
                        MessageBox.Show("Este ejemplar se encuentra en prestamo.", "BINAES", MessageBoxButtons.OK,
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
                MessageBox.Show("Debe ingresar datos primero", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPrestamoMod.Text.Length > 0)
                {
                    int ID_a_borrar = Convert.ToInt32(txtPrestamoMod.Text);

                    if (PrestamosDAO.EliminarPorID(ID_a_borrar))
                        MessageBox.Show("Prestamo eliminado correctamente", "BINAES", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Ha ocurrido un error");
                }
                else
                {
                    MessageBox.Show("Ingrese un ID de prestamo correcto", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                MostrarReservasAux();
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error al eliminar datos", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            tbPrestamos.SelectedIndex = 0;
            txtPrestamoMod.Text = "";
        }

        private void btnActualizarVista_Click(object sender, EventArgs e)
        {
            tbPrestamos.SelectedIndex = 2;
        }

        private void btnRegresarAC_Click(object sender, EventArgs e)
        {
            tbPrestamos.SelectedIndex = 0;
            txtPrestamoMod.Text = "";
        }

        private void btnActualizarAC_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtpPrestamoAC.Value != null && dtpDevolucionAC.Value != null)
                {
                    Prestamo col = new Prestamo();
                    col.id_prestamo = Convert.ToInt32(txtPrestamoMod.Text);
                    col.fecha_hora_prestamo = dtpPrestamoAC.Value.Date + dtpPrestamoHAC.Value.TimeOfDay;
                    col.fecha_hora_devolucion = dtpDevolucionAC.Value.Date + dtpDevolucionHAC.Value.TimeOfDay;
                    col.id_usuario = PrestamosDAO.ObtenerIDUsuario(cmbUsuarioAC.Text);
                    col.id_ejemplar = PrestamosDAO.ObtenerIDEjemplar(cmbEjemplarAC.Text);

                    PrestamosDAO.ActualizarPorID(col);
                    MessageBox.Show("Prestamo actualizado correctamente", "BINAES", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
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
                MessageBox.Show("Ha ocurrido un error al actualizar los datos", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void dgvPrestamos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    //Obtener el libro seleccionado
                    PrestamoConsulta ej = dgvPrestamos.SelectedRows[0].DataBoundItem as PrestamoConsulta;

                    //mostrar la informacion en los textbox

                    lblTituloM.Text = ej.Ejemplar;
                    lblUsuarioM.Text = ej.Usuario;
                    lblPrestamoM.Text = ej.Prestamo.ToString();
                    lblDevolucionM.Text = ej.Devolución.ToString();
                    picPortada.Image = ej.Portada;

                    //ocultando textbox "id"
                    txtPrestamoMod.AppendText(ej.id_prestamo.ToString());

                    //cambiar de pesta;ana
                    tbPrestamos.SelectedIndex = 1;

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error al cargar los datos", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void frmPrestamos_Load(object sender, EventArgs e)
        {
            try
            {
                tbPrestamos.Appearance = TabAppearance.FlatButtons;
                tbPrestamos.ItemSize = new Size(0, 1);
                tbPrestamos.SizeMode = TabSizeMode.Fixed;
                tbPrestamos.TabStop = false;

                cmbEjemplar.DataSource = null;
                cmbEjemplar.ValueMember = "nombre";
                cmbEjemplar.DisplayMember = "Ejemplar";
                cmbEjemplar.DataSource = PrestamosDAO.ObtenerEjemplares();

                cmbUsuario.DataSource = null;
                cmbUsuario.ValueMember = "nombre";
                cmbUsuario.DisplayMember = "Usuario";
                cmbUsuario.DataSource = PrestamosDAO.ObtenerUsuarios();

                cmbEjemplarAC.DataSource = null;
                cmbEjemplarAC.ValueMember = "nombre";
                cmbEjemplarAC.DisplayMember = "Ejemplar";
                cmbEjemplarAC.DataSource = PrestamosDAO.ObtenerEjemplares();

                cmbUsuarioAC.DataSource = null;
                cmbUsuarioAC.ValueMember = "nombre";
                cmbUsuarioAC.DisplayMember = "Usuario";
                cmbUsuarioAC.DataSource = PrestamosDAO.ObtenerUsuarios();

                txtPrestamoMod.Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error en la carga de datos", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
    }
}