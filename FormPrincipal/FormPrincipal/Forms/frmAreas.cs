using System;
using System.Windows.Forms;

namespace FormPrincipal
{
    public partial class frmAreas : Form
    {
        public frmAreas()
        {
            InitializeComponent();
        }
        
        public void LimpiarAct()
        {
            txtActArea.Clear();
            txtActDesArea.Clear();
            txtHorarioareaAct.Clear();  
            txtIDAreaAct.Clear();
        }

        public void LimpiarAdd()
        {
            txtNombre.Clear();
            txtHorario.Clear();
            txtDescripcion.Clear();
        }


        private void Areas_Load(object sender, EventArgs e)
        {
            //alterar tab control 
            tbcAreas.Appearance = TabAppearance.FlatButtons;
            tbcAreas.ItemSize = new System.Drawing.Size(0, 1);//??????????????
            tbcAreas.SizeMode = TabSizeMode.Fixed;
            tbcAreas.TabStop = false;

            //ventana agregar, combobox
            cmbResponsable.DataSource = null;
            cmbResponsable.ValueMember = "IDresponsable";
            cmbResponsable.DisplayMember = "Responsable";
            cmbResponsable.DataSource = AreasDAO.ObtenerResponsables();
            cmbResponsable.DropDownStyle = ComboBoxStyle.DropDownList;

            //ventana actualizar, combobox
            cmbResponsableAct.DataSource = null;
            cmbResponsableAct.ValueMember = "IDresponsable";
            cmbResponsableAct.DisplayMember = "Responsable";
            cmbResponsableAct.DataSource = AreasDAO.ObtenerResponsables();
            cmbResponsableAct.DropDownStyle = ComboBoxStyle.DropDownList;

            //hacer invisible txt de ids
            txtIDAreaAct.Visible = false;
            txtIDEliminar.Visible = false;
            cmbPiso.Text = "1";
            cmbPisoAct.Text = "1";
        }


        private void btnActualizar2_Click(object sender, EventArgs e)
        {
            if (txtIDAreaAct.Text.Length > 0)
            {
                Area col = new Area();
                col.IDarea = Convert.ToInt32(txtIDAreaAct.Text);
                col.Nombre = txtActArea.Text;
                col.Descripcion = txtActDesArea.Text;
                col.Horario = txtHorarioareaAct.Text;
                col.IDresponsable = AreasDAO.ObtenerIDresponsable(cmbResponsableAct.Text);
                col.numeroPiso = Convert.ToInt32(cmbPisoAct.Text);
                
                
                if (AreasDAO.ActualizarPorID(col))
                {
                    MessageBox.Show("Area actualizada correctamente", "BINAES", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    MostrarDGV();
                    tbcAreas.SelectedIndex = 0;
                    LimpiarAct();
                }
                else
                    MessageBox.Show("Ha ocurrido un error");
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos", "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }

            txtIDAreaAct.Clear();
            txtIDAreaAct.Text = "";

            //Limpiar(); funcion para limpiar esta area
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtIDAreaAct.Text.Length > 0)
            {
                int ID_a_borrar = Convert.ToInt32(txtIDAreaAct.Text);

                if (AreasDAO.EliminarPorID(ID_a_borrar))
                {
                    MessageBox.Show("Area eliminada correctamente", "BINAES", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    tbcAreas.SelectedIndex = 0;
                }
                else
                    MessageBox.Show("Ha ocurrido un error");
            }
            else
            {
                MessageBox.Show("Ingrese un ID de area correcto", "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }

            txtIDAreaAct.Clear();
            tbcAreas.SelectedIndex = 0;
            MostrarDGV();

            //Limpiar(); hacer funcion para limpiar esto y volver al dtg
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
                LimpiarAdd();
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos", "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }

            tbcAreas.SelectedIndex = 0;
            MostrarDGV();

            //Limpiar(); CAMBIAR PARA LIMPIAR ESTA VENTANA

        }

        public void MostrarDGV()
        {
            dgvAreas.DataSource = null;
            dgvAreas.DataSource = AreasDAO.ObtenerTodos();
            //mostrar datos en el dtg
            dgvAreas.RowTemplate.Height = 50;
            dgvAreas.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAreas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dgvAreas.DataSource = null;
            dgvAreas.DataSource = AreasDAO.ObtenerTodos();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MostrarDGV();
            
        }

        private void btnGoToAgregarArea_Click(object sender, EventArgs e)
        {
            tbcAreas.SelectedIndex = 3;
        }

        private void btnVolverdgvFromAdd_Click(object sender, EventArgs e)
        {
            tbcAreas.SelectedIndex = 0;
            //Limpiarevent(); CREAR FUNCION Q LIMPIE LOS TEXT BOX DE AQUI
        }

        private void dgvAreas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtIDAreaAct.Text = "";
                txtIDEliminar.Text = "";
                //Obtener el libro seleccionado
                Area are = dgvAreas.SelectedRows[0].DataBoundItem as Area;
                //error y no se por q

                //mostrar la informacion en los textbox

                lblNombreAreaShow.Text = are.Nombre;
                lblHorarioAreaShow.Text = are.Horario;
                lblDescripcionAreaShow.Text = are.Descripcion;
                lblRespAreaShow.Text = are.Responsable;
                lblNumPisoAreashow.Text = are.numeroPiso.ToString();

                //mandando textbox "id"
                txtIDEliminar.AppendText(are.IDarea.ToString());
                txtIDAreaAct.AppendText(are.IDarea.ToString());

                //cambiar de pesta;ana
                tbcAreas.SelectedIndex = 1;

            }
        }

        private void btnVolverDgv_Click(object sender, EventArgs e)
        {
            tbcAreas.SelectedIndex = 0;
        }

        private void btnGotoActArea_Click(object sender, EventArgs e)
        {
            //llenar text box y datos de actualizar con los valores originales
            txtActArea.Text = lblNombreAreaShow.Text;
            txtActDesArea.Text = lblDescripcionAreaShow.Text;
            txtHorarioareaAct.Text = lblHorarioAreaShow.Text;
            
            tbcAreas.SelectedIndex = 2;
            //mandar id del evento al text box en Actualizar
            txtIDAreaAct.Text = txtIDEliminar.Text;
        }

        private void btnVolverVistaArea_Click(object sender, EventArgs e)
        {
            tbcAreas.SelectedIndex = 0;
            txtIDAreaAct.Clear();
        }
    }
}