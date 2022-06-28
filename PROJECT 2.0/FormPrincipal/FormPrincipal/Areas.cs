using System;
using System.Windows.Forms;

namespace FormPrincipal
{
    public partial class Areas : Form
    {
        public Areas()
        {
            InitializeComponent();
        }
        
        public void Limpiar()
        {
            txtIDarea.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtHorario.Clear();
        }


        private void Areas_Load(object sender, EventArgs e)
        {
            cmbResponsable.DataSource = null;
            cmbResponsable.ValueMember = "IDresponsable";
            cmbResponsable.DisplayMember = "Responsable";
            cmbResponsable.DataSource = AreasDAO.ObtenerResponsables();
        }


        private void btnActualizar2_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length > 0)
            {
                Area col = new Area();
                col.IDarea = Convert.ToInt32(txtIDarea.Text);
                col.Nombre = txtNombre.Text;
                col.Descripcion = txtDescripcion.Text;
                col.Horario = txtHorario.Text;
                col.IDresponsable = AreasDAO.ObtenerIDresponsable(cmbResponsable.Text);
                col.numeroPiso = Convert.ToInt32(cmbPiso.Text);
                
                
                if (AreasDAO.ActualizarPorID(col))
                    MessageBox.Show("Area actualizada correctamente", "BINAES", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                else
                    MessageBox.Show("Ha ocurrido un error");
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos", "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
            
            dgvAreas.DataSource = null;
            dgvAreas.DataSource = AreasDAO.ObtenerTodos();
            
            Limpiar();
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtIDarea.Text.Length > 0)
            {
                int ID_a_borrar = Convert.ToInt32(txtIDarea.Text);

                if (AreasDAO.EliminarPorID(ID_a_borrar))
                    MessageBox.Show("Area eliminada correctamente", "BINAES", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                else
                    MessageBox.Show("Ha ocurrido un error");
            }
            else
            {
                MessageBox.Show("Ingrese un ID de area correcto", "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
            
            dgvAreas.DataSource = null;
            dgvAreas.DataSource = AreasDAO.ObtenerTodos();
            
            Limpiar();
        }
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length > 0)
            {
                Area col = new Area();
                col.Nombre = txtNombre.Text;
                col.Descripcion = txtDescripcion.Text;
                col.Horario = txtHorario.Text;
                col.IDresponsable = AreasDAO.ObtenerIDresponsable(cmbResponsable.Text);
                col.numeroPiso = Convert.ToInt32(cmbPiso.Text);

                AreasDAO.CrearNuevo(col);
                MessageBox.Show("Nueva area agregada correctamente", "BINAES", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos", "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
            
            Limpiar();
            dgvAreas.DataSource = null;
            dgvAreas.DataSource = AreasDAO.ObtenerTodos();
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dgvAreas.DataSource = null;
            dgvAreas.DataSource = AreasDAO.ObtenerTodos();
        }
    }
}