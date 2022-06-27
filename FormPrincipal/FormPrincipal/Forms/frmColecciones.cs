using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FormPrincipal
{
    public partial class frmColecciones : Form
    {
        public frmColecciones()
        {
            InitializeComponent();
        }
        
        //Funcion para agregar colecciones

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombe.Text.Length > 0)
            {
                //Crear nueva coleccion
                Coleccion col = new Coleccion();
                //Obteniendo datos de la coleccion
                col.Nombre = txtNombe.Text;
                col.IDgenero = ColeccionDAO.ObtenerID(cmbIDgenero.Text);
                col.IDtipo = ColeccionDAO.ObtenerIDTipo(cmbIDtipo.Text);
                col.numeroPiso = Convert.ToInt32(cmbPiso.Text);

                ColeccionDAO.CrearNuevo(col);
                MessageBox.Show("Nueva coleccion agregada correctamente", "BINAES", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos", "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
                        
            MostrarColecciones();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MostrarColecciones();
        }

        //FUNCION PARA MOSTRAR DATOS EN EL DATA GRID VIEW
        public void MostrarColecciones()
        {
            dgvColeccion.RowTemplate.Height = 50;
            dgvColeccion.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvColeccion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dgvColeccion.DataSource = null;
            dgvColeccion.DataSource = ColeccionDAO.ObtenerTodos();

            dgvColeccion.Columns["IDtipo"].Visible = false;
            dgvColeccion.Columns["IDgenero"].Visible = false;
        }
        
        private void Colecciones_Load(object sender, EventArgs e)
        {
            
            //Ocultando pestanas del TAB CONTROL
            tbColecciones.Appearance = TabAppearance.FlatButtons;
            tbColecciones.ItemSize = new Size(0, 1);
            tbColecciones.SizeMode = TabSizeMode.Fixed;
            tbColecciones.TabStop = false;

            //Configurando COMBO BOX's
            cmbIDgenero.DataSource = null;
            cmbIDgenero.ValueMember = "IDgenero";
            cmbIDgenero.DisplayMember = "Genero";
            cmbIDgenero.DataSource = ColeccionDAO.ObtenerGeneros();
            
            cmbIDtipo.DataSource = null;
            cmbIDtipo.ValueMember = "IDtipo";
            cmbIDtipo.DisplayMember = "Tipo";
            cmbIDtipo.DataSource = ColeccionDAO.ObtenerTipos();

            cmbGeneroM.DataSource = null;
            cmbGeneroM.ValueMember = "IDgenero";
            cmbGeneroM.DisplayMember = "Genero";
            cmbGeneroM.DataSource = ColeccionDAO.ObtenerGeneros();

            cmbTipoM.DataSource = null;
            cmbTipoM.ValueMember = "IDtipo";
            cmbTipoM.DisplayMember = "Tipo";
            cmbTipoM.DataSource = ColeccionDAO.ObtenerTipos();

            //configurando COMBO BOX
            cmbPiso.Text = "1";
            cmbNumeroPisoM.Text = "1";

            //Ocultando TEXT BOX
            txtIDcoleccion.Visible = false;
        }

        private void dgvColeccion_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtIDcoleccion.Text = "";
                //Obtener el libro seleccionado
                Coleccion ej = dgvColeccion.SelectedRows[0].DataBoundItem as Coleccion;

                //mostrar la informacion en los textbox
                lblColeccionTextoM.Text = ej.Nombre;
                lblColeccionTexto.Text = ej.Genero;
                lblColeccionTipoM.Text = ej.Tipo;
                lblPisoTextM.Text = ej.numeroPiso.ToString();

                //mandando ID
                txtIDcoleccion.AppendText(ej.IDcoleccion.ToString());

                //cambiar de pesta;ana
                tbColecciones.SelectedIndex = 1;

            }
        }

        private void btnActualizarVista_Click(object sender, EventArgs e)
        {
            tbColecciones.SelectedIndex = 2;
        }

        private void btnEliminarVista_Click(object sender, EventArgs e)
        {
            if (txtIDcoleccion.Text.Length > 0)
            {
                int ID_a_borrar = Convert.ToInt32(txtIDcoleccion.Text);

                if (ColeccionDAO.EliminarPorID(ID_a_borrar))
                    MessageBox.Show("Coleccion eliminada correctamente", "BINAES", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                else
                    MessageBox.Show("Ha ocurrido un error");
            }
            else
            {
                MessageBox.Show("Ingrese un ID de coleccion correcto", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            txtIDcoleccion.Text = "";

            tbColecciones.SelectedIndex = 0;
            MostrarColecciones();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            tbColecciones.SelectedIndex = 0;
        }
        
        //Funcion para actualizar
        private void btnActualizarColeccionesM_Click(object sender, EventArgs e)
        {
            if (txtNombreColeccionesM.Text.Length > 0)
            {
                Coleccion col = new Coleccion();
                col.IDcoleccion = Convert.ToInt32(txtIDcoleccion.Text);
                col.Nombre = txtNombreColeccionesM.Text;
                col.IDgenero = ColeccionDAO.ObtenerID(cmbGeneroM.Text);
                col.IDtipo = ColeccionDAO.ObtenerIDTipo(cmbTipoM.Text);
                col.numeroPiso = Convert.ToInt32(cmbNumeroPisoM.Text);


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

            txtIDcoleccion.Text = "";
            tbColecciones.SelectedIndex = 0;
            MostrarColecciones();

            txtNombreColeccionesM.Clear();
        }
    }
}