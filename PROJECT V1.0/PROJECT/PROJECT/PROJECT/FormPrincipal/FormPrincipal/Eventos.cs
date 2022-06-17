using System;
using System.Windows.Forms;

namespace FormPrincipal
{
    public partial class Eventos : Form
    {
        public Eventos()
        {
            InitializeComponent();
        }

        private void btnActualizarEvento_Click(object sender, EventArgs e)
        {
            /*if (txtTituloEvento.Text.Length > 0 && txtFechHorFinEvento.Text.Length > 0 && txtFechHorIniEvento.Text.Length > 0 
                && txtAsistenciasEvento.Text.Length > 0 && txtIDElimEditEvento.Text.Length > 0)
            {
                Coleccion col = new Coleccion();
                col.IDcoleccion = Convert.ToInt32(txtIDcoleccion.Text);
                col.Nombre = txtNombe.Text;
                col.IDgenero = Convert.ToInt32(txtGenero.Text);
                col.IDtipo = Convert.ToInt32(txtTipo.Text);
                col.numeroPiso = Convert.ToInt32(txtPiso.Text);


                if (ColeccionDAO.ActualizarPorID(col))
                    MessageBox.Show("Coleccion actualizada correctamente", "BINAES", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                else
                    MessageBox.Show("Ha ocurrido un error");
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            dgvEventos.DataSource = null;
            dgvEventos.DataSource = ColeccionDAO.ObtenerTodos();

            Limpiarevent();
        }

        public void Limpiarevent()
        {
            txtAsistenciasEvento.Clear();
            txtTituloEvento.Clear();
            txtFechHorFinEvento.Clear();
            txtFechHorIniEvento.Clear();
            txtIDElimEditEvento.Clear();
        }*/
        }


        private void btnMostrarEvento_Click(object sender, EventArgs e)
        {
            dgvEventos.DataSource = null;
            dgvEventos.DataSource = EventosDAO.ObtenerTodos();
        }
    }
}