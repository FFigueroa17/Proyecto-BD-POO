using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormPrincipal
{
    public partial class Ejemplares : Form
    {
        public string imagen;
        public Ejemplares()
        {
            InitializeComponent();
        }

        private void btnIngresarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\";
            getImage.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

            if (getImage.ShowDialog() == DialogResult.OK)
            {
                imagen = getImage.FileName;
            }
            else
            {
                MessageBox.Show("No selecciono ninguna imagen");
            }
        }

        private void Ejemplares_Load(object sender, EventArgs e)
        {
            tbEjemplares.Appearance = TabAppearance.FlatButtons;
            tbEjemplares.ItemSize = new Size(0, 1);
            tbEjemplares.SizeMode = TabSizeMode.Fixed;
            tbEjemplares.TabStop = false;
            
            cmbColeccion.DataSource = null;
            cmbColeccion.ValueMember = "IDcoleccion";
            cmbColeccion.DisplayMember = "Coleccion";
            cmbColeccion.DataSource = EjemplaresDAO.ObtenerColecciones();
            
            cmbEditorial.DataSource = null;
            cmbEditorial.ValueMember = "IDeditorial";
            cmbEditorial.DisplayMember = "Editorial";
            cmbEditorial.DataSource = EjemplaresDAO.ObtenerEditorial();
            
            cmbIdioma.DataSource = null;
            cmbIdioma.ValueMember = "IDidioma";
            cmbIdioma.DisplayMember = "Idioma";
            cmbIdioma.DataSource = EjemplaresDAO.ObtenerIdiomas();
            
            cmbColeccionAC.DataSource = null;
            cmbColeccionAC.ValueMember = "IDcoleccion";
            cmbColeccionAC.DisplayMember = "Coleccion";
            cmbColeccionAC.DataSource = EjemplaresDAO.ObtenerColecciones();
            
            cmbEditorialAC.DataSource = null;
            cmbEditorialAC.ValueMember = "IDeditorial";
            cmbEditorialAC.DisplayMember = "Editorial";
            cmbEditorialAC.DataSource = EjemplaresDAO.ObtenerEditorial();
            
            cmbIdiomaAC.DataSource = null;
            cmbIdiomaAC.ValueMember = "IDidioma";
            cmbIdiomaAC.DisplayMember = "Idioma";
            cmbIdiomaAC.DataSource = EjemplaresDAO.ObtenerIdiomas();
            
            cmbFormato.Text = "Físico";
            cmbFormatoAC.Text = "Físico";
        }

        private void btnEliminarEjemplares_Click(object sender, EventArgs e)
        {
            if (txtIDejemplar.Text.Length > 0)
            {
                int ID_a_borrar = Convert.ToInt32(txtIDejemplar.Text);

                if (EjemplaresDAO.EliminarPorID(ID_a_borrar))
                    MessageBox.Show("Ejemplar eliminado correctamente", "BINAES", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                else
                    MessageBox.Show("Ha ocurrido un error");
            }
            else
            {
                MessageBox.Show("Ingrese un ID de ejemplar correcto", "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
            
            MostrarEjemplaresAux();
            
            txtIDejemplar.Clear();
        }

        private void btnMostrarEjemplares_Click(object sender, EventArgs e)
        {
            MostrarEjemplaresAux();
        }

        private void btnAgregarEjemplares_Click(object sender, EventArgs e)
        {
            if (txtNombreEjemplar.Text.Length > 0)
            {
                Ejemplar ej = new Ejemplar();
                ej.NombreEjemplar = txtNombreEjemplar.Text;
                ej.Formato = cmbFormato.Text;
                ej.Portada = imagen;
                ej.FechaDePublicacion = dtpFechaDe.Value;
                ej.Autor = txtAutorEjemplares.Text;
                ej.ISBN = txtISBN.Text;
                ej.ISSN = txtISSN.Text;
                ej.DOI = txtDOI.Text;
                ej.palabrasClave = txtPalabraClave.Text;
                ej.IDidioma = EjemplaresDAO.ObtenerIDidoma(cmbIdioma.Text);
                ej.IDcoleccion = EjemplaresDAO.ObtenerIDcoleccion(cmbColeccion.Text);
                ej.IDeditorial = EjemplaresDAO.ObtenerIDeditorial(cmbEditorial.Text);
                
                EjemplaresDAO.CrearNuevo(ej);

                MessageBox.Show("Nuevo ejemplar agregado correctamente", "BINAES", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos", "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
            
            txtNombreEjemplar.Clear();
            
            MostrarEjemplaresAux();
            
            tbEjemplares.SelectedIndex = 0;
        }

        public void MostrarEjemplaresAux()
        {
            dgvEjemplares.RowTemplate.Height = 50;
            dgvEjemplares.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEjemplares.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dgvEjemplares.DataSource = null;
            dgvEjemplares.DataSource = EjemplaresDAO.ObtenerTodos();

            DataGridViewImageColumn columna = (DataGridViewImageColumn)dgvEjemplares.Columns["Portada"];
            columna.ImageLayout = DataGridViewImageCellLayout.Zoom;
            
            dgvEjemplares.Columns["Portada_Ejemplar"].Visible = false;
            
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            tbEjemplares.SelectedIndex = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tbEjemplares.SelectedIndex = 1;
        }

        private void btnActualizarP_Click(object sender, EventArgs e)
        {
            tbEjemplares.SelectedIndex = 2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtIDEjemplarAC.Text.Length > 0)
            {
                Ejemplar ej = new Ejemplar();
                ej.IDEjemplar = Convert.ToInt32(txtIDEjemplarAC.Text);
                ej.NombreEjemplar = txtNombreAC.Text;
                ej.Formato = cmbFormatoAC.Text;
                ej.Portada = imagen;
                ej.FechaDePublicacion = dtpFechaDePublicacionAC.Value;
                ej.Autor = txtAutorAC.Text;
                ej.ISBN = txtISBNAC.Text;
                ej.ISSN = txtISSNAC.Text;
                ej.DOI = txtDOIAC.Text;
                ej.palabrasClave = txtPalbrasClaveAC.Text;
                ej.IDidioma = EjemplaresDAO.ObtenerIDidoma(cmbIdiomaAC.Text);
                ej.IDcoleccion = EjemplaresDAO.ObtenerIDcoleccion(cmbColeccionAC.Text);
                ej.IDeditorial = EjemplaresDAO.ObtenerIDeditorial(cmbEditorialAC.Text);
                
                EjemplaresDAO.Actualizar(ej);

                MessageBox.Show("Ejemplar actualizado correctamente", "BINAES", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos", "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
            
            txtNombreEjemplar.Clear();
            
            MostrarEjemplaresAux();
            
            tbEjemplares.SelectedIndex = 0;
        }
    }
}