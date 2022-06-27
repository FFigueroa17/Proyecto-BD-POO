using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace FormPrincipal
{
    public partial class frmEventos : Form
    {
        public frmEventos()
        {
            InitializeComponent();
        }

        private void btnActualizarEvento_Click(object sender, EventArgs e)
        {

            if (txttituloact.Text.Length > 0 && txtasisact.Text.Length > 0 &&
                txtIDActualizar.Text.Length > 0 && txtImagenAct.Text.Length > 0
                && txtobjact.Text.Length > 0)
            {
                Evento eve = new Evento();
                eve.titulo = txttituloact.Text;
                eve.fechInicio = Convert.ToDateTime(dtpInicioact.Value);
                eve.fechFin = Convert.ToDateTime(dtpFinact.Value);
                eve.asistencias = Convert.ToInt32(txtasisact.Text);
                eve.objetivo = txtobjact.Text;
                eve.IDEvento = Convert.ToInt32(txtIDActualizar.Text);
                eve.imagen = txtImagenAct.Text;
                eve.idareaeve = Convert.ToInt32(cmbareaAct.SelectedValue);

                //VERIFICAR DISPONIBILIDAD
                if (EventosDAO.VerificarDisponibilidadFechas(eve))
                {
                    if (EventosDAO.ActualizarPorID(eve))
                    {
                        MessageBox.Show("Coleccion actualizada correctamente", "BINAES", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        //mostrar datos en el dtg
                        dgvEventos.RowTemplate.Height = 50;
                        dgvEventos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dgvEventos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                        dgvEventos.DataSource = null;
                        dgvEventos.DataSource = EventosDAO.ObtenerTodos();
                        DataGridViewImageColumn columna = (DataGridViewImageColumn)dgvEventos.Columns["imagenevento"];
                        columna.ImageLayout = DataGridViewImageCellLayout.Zoom;
                        dgvEventos.Columns["imagen"].Visible = false;

                        LimpiareventACT();
                        tbcEventos.SelectedIndex = 0;
                    }
                    else
                        MessageBox.Show("Ha ocurrido un error");
                }
                else
                    MessageBox.Show("Verificar fechas disponibles.", "BINAES", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            txtIDElimEditEvento.Text = "";
        }

        public void Limpiarevent() //agregar campos faltantes
        {
            txtAsistenciasEvento.Clear();
            txtTituloEvento.Clear();
            txtObjetivo.Clear();
            txtAddimageAgregar.Clear();
        }

        public void LimpiareventACT() //agregar campos faltantes
        {
            txttituloact.Clear();
            txtImagenAct.Clear();
            txtIDActualizar.Clear();
            txtobjact.Clear();
            txtasisact.Clear();
        }


        private void btnAgregarEvento_Click(object sender, EventArgs e)
        {
            if (txtTituloEvento.Text.Length > 0 && txtAsistenciasEvento.Text.Length > 0
                && txtObjetivo.Text.Length > 0 && txtAddimageAgregar.Text.Length > 0)
            {
                Evento eve = new Evento();
                eve.titulo = txtTituloEvento.Text;
                eve.imagen = txtAddimageAgregar.Text;
                eve.fechInicio = dtpInicio.Value; //txtFechHorIniEvento.Text; fechaIni
                eve.asistencias = Convert.ToInt32(txtAsistenciasEvento.Text);
                eve.fechFin = dtpFin.Value; //txtFechHorFinEvento.Text; fechaFin
                eve.idareaeve = Convert.ToInt32(cmbAreaEvento.SelectedValue);
                eve.objetivo = txtObjetivo.Text;


                if ((eve.idareaeve == 3 && eve.asistencias <= 358) ||
                    ((eve.idareaeve >= 4 && eve.idareaeve <= 6) &&
                     eve.asistencias <= 200)) //auditorio max: 358, proyecc max: 200
                {
                    //VERIFICAR DISPONIBILIDAD
                    if (EventosDAO.VerificarDisponibilidadFechas(eve))
                    {
                        EventosDAO.CrearNuevo(eve);
                        MessageBox.Show("Nuevo evento agregado correctamente.", "BINAES", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        Limpiarevent();
                    }
                    else
                        MessageBox.Show("Verificar fechas disponibles.", "BINAES", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                }
                else if
                    (eve.idareaeve >= 19 &&
                     eve.idareaeve <=
                     26) //id de biblio del 19 al 26, solo se permiten eventos en biblio, auditorio y sala de proyeccion
                {
                    //VERIFICAR DISPONIBILIDAD
                    if (EventosDAO.VerificarDisponibilidadFechas(eve))
                    {
                        EventosDAO.CrearNuevo(eve);
                        MessageBox.Show("Nuevo evento agregado correctamente.", "BINAES", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        Limpiarevent();
                    }
                    else
                        MessageBox.Show("Verificar fechas disponibles.", "BINAES", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show(
                        "Verificar área y cantidad de asistencias. Auditorio: 358max; Sala de Proyecciones: 200max.",
                        "BINAES", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            //mostrar datos en el dtg
            dgvEventos.RowTemplate.Height = 50;
            dgvEventos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEventos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dgvEventos.DataSource = null;
            dgvEventos.DataSource = EventosDAO.ObtenerTodos();
            DataGridViewImageColumn columna = (DataGridViewImageColumn)dgvEventos.Columns["imagenevento"];
            columna.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvEventos.Columns["imagen"].Visible = false;
        }

        //CARGAR COMBO BOX AL CARGAR FORMULARIO
        private void Eventos_Load(object sender, EventArgs e)
        {
            //alterar tab control 
            tbcEventos.Appearance = TabAppearance.FlatButtons;
            tbcEventos.ItemSize = new System.Drawing.Size(0,1);//??????????????
            tbcEventos.SizeMode = TabSizeMode.Fixed;
            tbcEventos.TabStop = false;

            //AGREGAR VALORES AL COMBO BOX
            DataTable areas = new DataTable("Areas");
            areas.Columns.Add("Area", typeof(string));
            areas.Columns.Add("ID", typeof(int));

            foreach (var evento in EventosDAO.ObtenerCombobox())
            {
                DataRow row = areas.NewRow();
                row["Area"] = string.Format(evento.areaevento);
                row["ID"] = evento.idareaeve;
                areas.Rows.Add(row);
            }

            this.cmbAreaEvento.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbAreaEvento.DataSource = areas;
            this.cmbAreaEvento.DisplayMember = "Area";
            this.cmbAreaEvento.ValueMember = "ID";

            //combo box ventana actualizar
            cmbareaAct.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbareaAct.DataSource = areas;
            cmbareaAct.DisplayMember = "Area";
            cmbareaAct.ValueMember = "ID";

            //hacer invisibles los text box q almacenan ids
            txtIDActualizar.Visible = false;
            txtImagenAct.Visible = false;
            txtAddimageAgregar.Visible = false;
            txtIDElimEditEvento.Visible = false;

            //tamaño del label de objetivo
            
        }

        private void btnEliminarEvento_Click(object sender, EventArgs e)
        {
            if (txtIDElimEditEvento.Text.Length > 0)
            {
                int ID_a_borrar = Convert.ToInt32(txtIDElimEditEvento.Text);

                if (EventosDAO.EliminarPorID(ID_a_borrar))
                {
                    MessageBox.Show("Evento eliminado correctamente", "BINAES", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    //mostrar datos en el dtg
                    dgvEventos.RowTemplate.Height = 50;
                    dgvEventos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvEventos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    dgvEventos.DataSource = null;
                    dgvEventos.DataSource = EventosDAO.ObtenerTodos();
                    DataGridViewImageColumn columna = (DataGridViewImageColumn)dgvEventos.Columns["imagenevento"];
                    columna.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    dgvEventos.Columns["imagen"].Visible = false;

                    Limpiarevent();
                    tbcEventos.SelectedIndex = 0;
                }else
                    MessageBox.Show("Ha ocurrido un error");

                txtIDElimEditEvento.Text = "";
                mostrarEventos();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        //variable string para guardar nombre de la imagen
        public string imageneve;

        private void btnAddImageact_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\";
            getImage.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";


            if (getImage.ShowDialog() == DialogResult.OK)
            {
                try
                {//VERIFICAR PARA CAMBIAR IMAGEN CON EL MISMO NOMBRE
                    string ruta_degug = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
                    string ruta_recursos = Path.GetDirectoryName(Path.GetDirectoryName(ruta_degug) + @"\Recursos\" + getImage.SafeFileName);

                    File.Copy(getImage.FileName, ruta_recursos, true);
                    getImage.FileName = getImage.SafeFileName;
                    
                    txtImagenAct.Text = getImage.FileName;
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al copiar la imagen, imagen ya existente", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                /*try
                {//VERIFICAR PARA CAMBIAR IMAGEN CON EL MISMO NOMBRE
                    string ruta_degug = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
                    string ruta_recursos = Path.GetDirectoryName(Path.GetDirectoryName(ruta_degug) + @"\Recursos\");

                    string Imagename = getImage.SafeFileName;

                    SaveFileDialog x = new SaveFileDialog();
                    x.InitialDirectory = ruta_recursos;
                    x.FileName = Imagename;
                    x.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";

                    string rutatotal = ruta_recursos + Imagename;
                    x.InitialDirectory = rutatotal;
                    
                    if (x.ShowDialog() != DialogResult.Cancel)
                    {
                        string varimg = x.FileName;
                        Bitmap ima = new Bitmap(EventosDAO.obtenerImagen(Imagename));//insertar imagen en tipo bitmap
                        ima.Save(varimg);

                        txtImagenAct.Text = Imagename;
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar imagen", "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al copiar la imagen, imagen ya existente", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/
                /*try
                {//VERIFICAR PARA CAMBIAR IMAGEN CON EL MISMO NOMBRE
                    string ruta_degug = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
                    string ruta_recursos = Path.GetDirectoryName(Path.GetDirectoryName(ruta_degug) + @"\Recursos\");

                    File.Copy(getImage.FileName, Path.GetDirectoryName(Path.GetDirectoryName(ruta_degug)) + @"\Recursos\" + getImage.SafeFileName);
                    getImage.FileName = getImage.SafeFileName;

                    txtImagenAct.Text = getImage.FileName;
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al copiar la imagen, imagen ya existente", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/
            }
            else
            {
                MessageBox.Show("No selecciono ninguna imagen");
            }
        }

        private void btnTabActualizar_Click(object sender, EventArgs e)
        {
            //llenar text box y datos de actualizar con los valores originales
            txttituloact.Text = lblTituloEventoshow.Text;
            txtobjact.Text = lblObjetivoShow.Text;
            txtasisact.Text = lblAsisShow.Text;
            Evento act = EventosDAO.ObtenerFechasAct(Convert.ToInt32(txtIDElimEditEvento.Text));
            dtpInicioact.Value = act.fechInicio;
            dtpFinact.Value = act.fechFin;
            txtImagenAct.Text = EventosDAO.ObtenerNombreImagen(Convert.ToInt32(txtIDElimEditEvento.Text));//hacer consulta a la base--------------------------------

            tbcEventos.SelectedIndex = 2;
            //mandar id del evento al text box en Actualizar
            txtIDActualizar.Text = txtIDElimEditEvento.Text;
        }

        private void btnVolverTabMostrar_Click(object sender, EventArgs e)
        {
            tbcEventos.SelectedIndex = 0;
        }

        private void btnVolverVistaItemSeleccionado_Click(object sender, EventArgs e)
        {
            tbcEventos.SelectedIndex = 1;
            LimpiareventACT();
        }

        private void btnVolverFromAgergar_Click(object sender, EventArgs e)
        {
            tbcEventos.SelectedIndex = 0;
            Limpiarevent();
        }

        private void btnGoToAgregar_Click(object sender, EventArgs e)
        {
            tbcEventos.SelectedIndex = 3;
        }

        private void btnMostrarEvento_Click_1(object sender, EventArgs e)
        {
            //mostrar datos en el dtg
            mostrarEventos();
        }

        public void mostrarEventos()
        {
            dgvEventos.RowTemplate.Height = 50;
            dgvEventos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEventos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dgvEventos.DataSource = null;
            dgvEventos.DataSource = EventosDAO.ObtenerTodos();
            DataGridViewImageColumn columna = (DataGridViewImageColumn)dgvEventos.Columns["imagenevento"];
            columna.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvEventos.Columns["imagen"].Visible = false;
        }

        private void btnAgregarImagen_Click_1(object sender, EventArgs e)
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

                    txtAddimageAgregar.Text = getImage.FileName;
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

        private void dgvEventos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Para evitar errores en encabezados 

            if (e.RowIndex != -1)
            {
                //Obtener el libro seleccionado
                Evento2 even = dgvEventos.SelectedRows[0].DataBoundItem as Evento2;
                //error y no se por q
                
                //mostrar la informacion en los textbox

                lblTituloEventoshow.Text = even.titulo;
                lblIniShow.Text = even.fechaIni;
                lblFinShow.Text = even.fechaFin;
                lblAsisShow.Text = Convert.ToString(even.asistencias);
                lblObjetivoShow.Text = even.objetivo;
                picEventoShow.Image = even.imagenevento;

                //ocultando textbox "id"
                txtIDElimEditEvento.AppendText(even.IdEvento.ToString());
                txtIDElimEditEvento.Visible = false;

                //cambiar de pesta;ana
                tbcEventos.SelectedIndex = 1;

            }
        }
    }
}