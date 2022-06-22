using System;
using System.Windows.Forms;

namespace FormPrincipal
{
    public partial class Prestamos : Form
    {
        public Prestamos()
        {
            InitializeComponent();
        }
        
        public void Limpiar()
        {
            txtIDUsuario.Clear();
            txtIDEjemplar.Clear();
        }


        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvPrestamos.DataSource = null;
            dgvPrestamos.DataSource = PrestamosDAO.ObtenerTodos();
        }
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (dtpPrestamo.Value != null && dtpDevolucion.Value != null && txtIDUsuario.Text.Length >0 && 
                txtIDEjemplar.Text.Length > 0)
            {
                Prestamo col = new Prestamo();
                col.fecha_hora_prestamo = dtpPrestamo.Value.Date + dtpPrestamoH.Value.TimeOfDay;
                col.fecha_hora_devolucion = dtpDevolucion.Value.Date + dtpDevolucionH.Value.TimeOfDay;
                col.id_usuario = Convert.ToInt32(txtIDUsuario.Text);
                col.id_ejemplar = Convert.ToInt32(txtIDEjemplar.Text);

                PrestamosDAO.CrearNuevo(col);
                MessageBox.Show("Nuevo prestamo agregado correctamente", "BINAES", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos", "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
           
            Limpiar();
            dgvPrestamos.DataSource = null;
            dgvPrestamos.DataSource = PrestamosDAO.ObtenerTodos();
        }

        private void btnActualizar2_Click(object sender, EventArgs e)
        {
            if (dtpPrestamo.Value != null  && dtpDevolucion.Value != null && txtIDUsuario.Text.Length >0 && 
                txtIDEjemplar.Text.Length > 0)
            {
                Prestamo col = new Prestamo();
                col.id_prestamo = Convert.ToInt32(txtPrestamoMod.Text);
                col.fecha_hora_prestamo = dtpPrestamo.Value.Date + dtpPrestamoH.Value.TimeOfDay;
                col.fecha_hora_devolucion = dtpDevolucion.Value.Date + dtpDevolucionH.Value.TimeOfDay;
                col.id_usuario = Convert.ToInt32(txtIDUsuario.Text);
                col.id_ejemplar = Convert.ToInt32(txtIDEjemplar.Text);

                PrestamosDAO.ActualizarPorID(col);
                MessageBox.Show("Prestamo actualizado correctamente", "BINAES", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos", "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
           
            dgvPrestamos.DataSource = null;
            dgvPrestamos.DataSource = PrestamosDAO.ObtenerTodos();
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
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
            
            dgvPrestamos.DataSource = null;
            dgvPrestamos.DataSource = PrestamosDAO.ObtenerTodos();
            
            Limpiar();
        }
    }
}