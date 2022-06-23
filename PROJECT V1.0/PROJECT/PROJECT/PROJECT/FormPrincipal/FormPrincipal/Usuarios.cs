using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FormPrincipal
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }
        //-----SECCION DE LIMPIEZA DE DATOS-----------------
        public void LimpiarIngreso()//agregar campos faltantes
        {
            txtIdingreso.Clear();
        }
        
        public void LimpiarSalida()//agregar campos faltantes
        {
            txtidsalida.Clear();
        }
        
        public void LimpiarAgregarUsuario()//agregar campos faltantes
        {
            txtNombreNuevoUsuario.Clear();
            txtCorreoUsuario.Clear();
            txtDireccionUsuario.Clear();
            txtInstitucionUsuario.Clear();
            txtTelefonoUsuario.Clear();
            txtOcupacionUsuario.Clear();
            txtFotoUsuario.Clear();
        }


        private void Usuarios_Load(object sender, EventArgs e)
        {
            tbcUsuarios.Appearance = TabAppearance.FlatButtons;
            tbcUsuarios.ItemSize = new Size(0, 1);
            tbcUsuarios.SizeMode = TabSizeMode.Fixed;
            tbcUsuarios.TabStop = false;
            
            //---MOSTRAR USUARIOS----
            dgvIngresoSalidaUsuarios.DataSource = null;
            dgvIngresoSalidaUsuarios.DataSource = UsuariosDAO.ObtenerTodos();
            DataGridViewImageColumn columna = (DataGridViewImageColumn)dgvIngresoSalidaUsuarios.Columns["imagenuser"];
            columna.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvIngresoSalidaUsuarios.Columns["fotografiauser"].Visible = false;
            
            //AGREGAR VALORES AL COMBO BOX
            DataTable areas = new DataTable("Areas");
            areas.Columns.Add("Area", typeof(string));
            areas.Columns.Add("ID", typeof(int));
            
            foreach (var evento in UsuariosDAO.ObtenerCombobox())
            {
                DataRow row = areas.NewRow();
                row["Area"] = string.Format(evento.areaevento);
                row["ID"] = evento.idareaeve;
                areas.Rows.Add(row);
            }
            
            this.cmbAreaingreso.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbAreaingreso.DataSource = areas;
            this.cmbAreaingreso.DisplayMember = "Area";
            this.cmbAreaingreso.ValueMember = "ID";
            
            this.cmbAreasalida.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbAreasalida.DataSource = areas;
            this.cmbAreasalida.DisplayMember = "Area";
            this.cmbAreasalida.ValueMember = "ID";
        }
        
        //--------REGISTRAR HORA ENTRADA------------

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            if (txtIdingreso.Text.Length > 0)
            {
                Usuario user = new Usuario();
                user.id_user = Convert.ToInt32(txtIdingreso.Text);
                user.id_area_ingreso = Convert.ToInt32(cmbAreaingreso.SelectedValue);
                user.fecha_hora_entrada = DateTime.Now;
                
                UsuariosDAO.CrearNuevoIngreso(user);
                MessageBox.Show("Nuevo ingreso agregado correctamente.", "BINAES", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                
                //---MOSTRAR USUARIOS----
                dgvIngresoSalidaUsuarios.DataSource = null;
                dgvIngresoSalidaUsuarios.DataSource = UsuariosDAO.ObtenerTodos();
                LimpiarIngreso();
            }
        }
        
        //-----REGISTRAR HORA DE SALIDA
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (txtidsalida.Text.Length > 0)
            {
                Usuario user = new Usuario();
                user.id_user = Convert.ToInt32(txtidsalida.Text);
                user.id_area_ingreso = Convert.ToInt32(cmbAreasalida.SelectedValue);
                user.fecha_hora_salida = DateTime.Now;
                
                UsuariosDAO.CrearNuevaSalida(user);
                MessageBox.Show("Nueva salida registrada correctamente.", "BINAES", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                
                //---MOSTRAR USUARIOS----
                dgvIngresoSalidaUsuarios.DataSource = null;
                dgvIngresoSalidaUsuarios.DataSource = UsuariosDAO.ObtenerTodos();
                LimpiarSalida();
            }
        }
        //---------

        private void btnAgregarUser_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.nombreUser = txtNombreNuevoUsuario.Text;
            user.ocupacionuser = txtOcupacionUsuario.Text;
            user.direccionuser = txtDireccionUsuario.Text;
            user.correouser = txtCorreoUsuario.Text;
            user.institucionuser = txtInstitucionUsuario.Text;
            user.fotografiauser = imagen;   //imageeeeeeeeeeeeeeeeeeeeen
            user.telefonouser = txtTelefonoUsuario.Text;
            
            UsuariosDAO.CrearNuevoUsuario(user);
            MessageBox.Show("Nuevo usuario registrado correctamente.", "BINAES", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                
            //---MOSTRAR USUARIOS----
            dgvIngresoSalidaUsuarios.DataSource = null;
            dgvIngresoSalidaUsuarios.DataSource = UsuariosDAO.ObtenerTodos();
            LimpiarAgregarUsuario();
        }

        //-----CAMBIAR DE PESTAÑA-------------------------------
        private void btnCambiarPestaña_Click(object sender, EventArgs e)
        {
            //ver q ondas
            tbcUsuarios.SelectedIndex = 1;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            tbcUsuarios.SelectedIndex = 0;
        }

        //-----BOTON AGREGAR IMAGEN
        public string imagen;
        private void btnAgregarfotoUser_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\";
            getImage.Filter = "Image Files(.jpg; *.jpeg; *.gif; *.bmp)|.jpg; *.jpeg; *.gif; *.bmp";

            if (getImage.ShowDialog() == DialogResult.OK)
            {
                imagen = getImage.FileName;
            }
            else
            {
                MessageBox.Show("No selecciono ninguna imagen");
            }
        }
    }
}