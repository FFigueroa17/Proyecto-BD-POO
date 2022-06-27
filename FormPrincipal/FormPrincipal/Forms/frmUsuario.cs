using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace FormPrincipal
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
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
            txtRutaQRCreado.Clear();
            txtFotoUserAgregada.Clear();
        }


        private void Usuarios_Load(object sender, EventArgs e)
        {
            tbcUsuarios.Appearance = TabAppearance.FlatButtons;
            tbcUsuarios.ItemSize = new Size(0, 1);
            tbcUsuarios.SizeMode = TabSizeMode.Fixed;
            tbcUsuarios.TabStop = false;


            //---MOSTRAR USUARIOS----
            dgvIngresoSalidaUsuarios.RowTemplate.Height = 50;
            dgvIngresoSalidaUsuarios.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvIngresoSalidaUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dgvIngresoSalidaUsuarios.DataSource = null;
            dgvIngresoSalidaUsuarios.DataSource = UsuariosDAO.ObtenerTodos();
            DataGridViewImageColumn columna = (DataGridViewImageColumn)dgvIngresoSalidaUsuarios.Columns["imagenuser"];
            columna.ImageLayout = DataGridViewImageCellLayout.Zoom;
            DataGridViewImageColumn columnaqr = (DataGridViewImageColumn)dgvIngresoSalidaUsuarios.Columns["qr"];
            columnaqr.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvIngresoSalidaUsuarios.Columns["fotografiauser"].Visible = false;
            dgvIngresoSalidaUsuarios.Columns["qrruta"].Visible = false;
            dgvIngresoSalidaUsuarios.Columns["qr"].Visible = false;

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

            //hacer text box q contienen ruta de imagen y qr invisibles
            txtFotoUserAgregada.Visible = false;
            txtRutaQRCreado.Visible = false;
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
                dgvIngresoSalidaUsuarios.RowTemplate.Height = 50;
                dgvIngresoSalidaUsuarios.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvIngresoSalidaUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                dgvIngresoSalidaUsuarios.DataSource = null;
                dgvIngresoSalidaUsuarios.DataSource = UsuariosDAO.ObtenerTodos();
                DataGridViewImageColumn columna = (DataGridViewImageColumn)dgvIngresoSalidaUsuarios.Columns["imagenuser"];
                columna.ImageLayout = DataGridViewImageCellLayout.Zoom;
                DataGridViewImageColumn columnaqr = (DataGridViewImageColumn)dgvIngresoSalidaUsuarios.Columns["qr"];
                columnaqr.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dgvIngresoSalidaUsuarios.Columns["fotografiauser"].Visible = false;
                dgvIngresoSalidaUsuarios.Columns["qrruta"].Visible = false;
                dgvIngresoSalidaUsuarios.Columns["qr"].Visible = false;
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
                dgvIngresoSalidaUsuarios.RowTemplate.Height = 50;
                dgvIngresoSalidaUsuarios.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvIngresoSalidaUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                dgvIngresoSalidaUsuarios.DataSource = null;
                dgvIngresoSalidaUsuarios.DataSource = UsuariosDAO.ObtenerTodos();
                DataGridViewImageColumn columna = (DataGridViewImageColumn)dgvIngresoSalidaUsuarios.Columns["imagenuser"];
                columna.ImageLayout = DataGridViewImageCellLayout.Zoom;
                DataGridViewImageColumn columnaqr = (DataGridViewImageColumn)dgvIngresoSalidaUsuarios.Columns["qr"];
                columnaqr.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dgvIngresoSalidaUsuarios.Columns["fotografiauser"].Visible = false;
                dgvIngresoSalidaUsuarios.Columns["qrruta"].Visible = false;
                dgvIngresoSalidaUsuarios.Columns["qr"].Visible = false;
                LimpiarSalida();
            }
        }
        //---------

        private void btnAgregarUser_Click(object sender, EventArgs e)
        {
            //agregar comprobacion, q todos los campos esten llenos
            if(txtCorreoUsuario.Text.Length > 0 && txtNombreNuevoUsuario.Text.Length > 0 
                && txtFotoUserAgregada.Text.Length > 0 && txtOcupacionUsuario.Text.Length > 0 
                && txtDireccionUsuario.Text.Length > 0 && txtInstitucionUsuario.Text.Length > 0
                && txtTelefonoUsuario.Text.Length > 0 && txtRutaQRCreado.Text.Length > 0)
            {
                Usuario user = new Usuario();
                user.nombreUser = txtNombreNuevoUsuario.Text;
                user.ocupacionuser = txtOcupacionUsuario.Text;
                user.direccionuser = txtDireccionUsuario.Text;
                user.correouser = txtCorreoUsuario.Text;
                user.institucionuser = txtInstitucionUsuario.Text;
                user.fotografiauser = txtFotoUserAgregada.Text;   //imageeeeeeeeeeeeeeeeeeeeen
                user.telefonouser = txtTelefonoUsuario.Text;
                user.rutaqr = txtRutaQRCreado.Text;

                UsuariosDAO.CrearNuevoUsuario(user);
                MessageBox.Show("Nuevo usuario registrado correctamente.", "BINAES", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LimpiarAgregarUsuario();
            }
            else
            {
                MessageBox.Show("Llenar todos los campos, seleccionar imagen y crear QR", "BINAES", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            //---MOSTRAR USUARIOS----
            dgvIngresoSalidaUsuarios.RowTemplate.Height = 50;
            dgvIngresoSalidaUsuarios.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvIngresoSalidaUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dgvIngresoSalidaUsuarios.DataSource = null;
            dgvIngresoSalidaUsuarios.DataSource = UsuariosDAO.ObtenerTodos();
            DataGridViewImageColumn columna = (DataGridViewImageColumn)dgvIngresoSalidaUsuarios.Columns["imagenuser"];
            columna.ImageLayout = DataGridViewImageCellLayout.Zoom;
            DataGridViewImageColumn columnaqr = (DataGridViewImageColumn)dgvIngresoSalidaUsuarios.Columns["qr"];
            columnaqr.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvIngresoSalidaUsuarios.Columns["fotografiauser"].Visible = false;
            dgvIngresoSalidaUsuarios.Columns["qrruta"].Visible = false;
            dgvIngresoSalidaUsuarios.Columns["qr"].Visible = false;
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
            getImage.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";


            if (getImage.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string ruta_degug = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);

                    File.Copy(getImage.FileName, Path.GetDirectoryName(Path.GetDirectoryName(ruta_degug)) + @"\Recursos\" + getImage.SafeFileName);
                    getImage.FileName = getImage.SafeFileName;

                    txtFotoUserAgregada.Text = getImage.FileName;
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al copiar la imagen, imagen ya existente", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No selecciono ninguna imagen");
            }
        }

        private void tbpRegistrarUsuario_Click(object sender, EventArgs e)
        {
            //nada missclick
        }

        private void btnCrearQR_Click(object sender, EventArgs e)
        {
            if (txtNombreNuevoUsuario.Text.Length > 0)
            {
                //creacion
                Zen.Barcode.CodeQrBarcodeDraw codqr = Zen.Barcode.BarcodeDrawFactory.CodeQr;
                picQR.Image = codqr.Draw(txtNombreNuevoUsuario.Text, 40);
                
                //autoguardado
                //comprobar despues
                //guardar ruta del qr en txtrutaqr
                try
                {
                    OpenFileDialog getImage = new OpenFileDialog();
                    getImage.InitialDirectory = "C:\\";
                    getImage.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";

                    string ruta_degug = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
                    string qr_ruta = Path.GetDirectoryName(Path.GetDirectoryName(ruta_degug)) + @"\Recursos\QR\";

                    txtRutaQRCreado.Text = qr_ruta;//guarda la ruta donde van a quedar los qr
                    
                }
                catch
                {
                    MessageBox.Show("Ha ocurrido un error al guardar el código QR.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese los demas campos para generar QR", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void btnGuardarQR_Click(object sender, EventArgs e)
        {
            //insertar guardado del video del qr
            try
            {
                string route = txtRutaQRCreado.Text;
                string QRname = "QR" + Convert.ToString(UsuariosDAO.ConUsers()) + ".jpg";

                SaveFileDialog x = new SaveFileDialog();
                x.InitialDirectory = route;
                x.FileName = QRname;
                x.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";

                if(x.ShowDialog() != DialogResult.Cancel)
                {
                    string varimg = x.FileName;
                    Bitmap ima = new Bitmap(picQR.Image);
                    ima.Save(varimg, ImageFormat.Png);

                    txtRutaQRCreado.Text = QRname;
                }
                else
                {
                    MessageBox.Show("Error al guardar QR.", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Error al guardar QR.", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}