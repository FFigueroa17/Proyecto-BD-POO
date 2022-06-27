using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FormPrincipal
{
    public partial class frmBusquedas : Form
    {
        public frmBusquedas()
        {
            InitializeComponent();
        }

        // FUNCION PARA BUSQUEDAS

        private void picBusquedasBtn_Click(object sender, System.EventArgs e)
        {
            if (txtBusquedas.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor para buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbBusquedas.Text == "Título completo")
            {
                configurarDataGriView(BusquedasDAO.FiltrarPorTitulo(txtBusquedas.Text));
            }
            else if (cmbBusquedas.Text.Trim() == "Título parcial")
            {
                configurarDataGriView(BusquedasDAO.FiltrarPorTituloParcial(txtBusquedas.Text));
            }
            else if (cmbBusquedas.Text == "Palabras clave")
            {
                configurarDataGriView(BusquedasDAO.FiltrarPorPalabrasClave(txtBusquedas.Text));
            }
            else if (cmbBusquedas.Text == "Autor")
            {
                configurarDataGriView(BusquedasDAO.FiltrarPorAutor(txtBusquedas.Text));
            }
            else if (cmbBusquedas.Text == "Formato")
            {
                configurarDataGriView(BusquedasDAO.FiltrarPorFormato(txtBusquedas.Text));
            }
            else
            {
                MessageBox.Show("No se encontraron resultados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // FUNCION PARA CONFIGURAR EL DATA GRID VIEW

        private void configurarDataGriView(List<EjemplarConsulta> Ejemplares)
        {
            try
            {
                //CONFIGURAR LA TABLA
                dgvBusquedasEjemplares.RowTemplate.Height = 50;
                dgvBusquedasEjemplares.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvBusquedasEjemplares.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                //DARLE DATOS A LA TABLA
                dgvBusquedasEjemplares.DataSource = null;
                dgvBusquedasEjemplares.DataSource = Ejemplares;

                //CONFIGURAR COLUMNA "PORTADA"
                DataGridViewImageColumn columna = (DataGridViewImageColumn)dgvBusquedasEjemplares.Columns["Portada"];
                columna.ImageLayout = DataGridViewImageCellLayout.Zoom;

                //OCULTAR COLUMNAS NO IMPORTANTES
                dgvBusquedasEjemplares.Columns["Portada_Ejemplar"].Visible = false;
            }
            catch(Exception)
            {
                MessageBox.Show("Error al cargar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void frmBusquedas_Load(object sender, System.EventArgs e)
        {
            try
            {
                cmbBusquedas.Text = "Título completo";

                configurarDataGriView(EjemplaresDAO.ObtenerTodos());

                //OCULTAR TABS DEL TAB CONTROL
                tbBusquedas.Appearance = TabAppearance.FlatButtons;
                tbBusquedas.ItemSize = new Size(0, 1);
                tbBusquedas.SizeMode = TabSizeMode.Fixed;
                tbBusquedas.TabStop = false;

                ttpBusquedas.SetToolTip(tabPage1, "Haz doble para consultar más información ");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvBusquedasEjemplares_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                //Obtener el libro seleccionado
                EjemplarConsulta ej = dgvBusquedasEjemplares.SelectedRows[0].DataBoundItem as EjemplarConsulta;

                //mostrar la informacion en los textbox

                lblTituloTexto.Text = ej.Nombre_Ejemplar;
                lblColeccionTexto.Text = ej.Coleccion;
                lblGeneroTexto.Text = ej.Formato;
                lblAutorTexto.Text = ej.Autor;
                picPortada.Image = ej.Portada;

                //cambiar de pesta;ana
                tbBusquedas.SelectedIndex = 1;
            }
        }

        private void btnRegresar_Click(object sender, System.EventArgs e)
        {
            tbBusquedas.SelectedIndex = 0;
        }
    }
}