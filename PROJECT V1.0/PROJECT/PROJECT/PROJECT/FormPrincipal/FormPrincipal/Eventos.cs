using System;
using System.Data;
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

            Limpiarevent();*/
        }

        public void Limpiarevent()
        {
            txtAsistenciasEvento.Clear();
            txtTituloEvento.Clear();
            txtFechHorFinEvento.Clear();
            txtFechHorIniEvento.Clear();
            txtIDElimEditEvento.Clear();
        }


        private void btnMostrarEvento_Click(object sender, EventArgs e)
        {
            dgvEventos.DataSource = null;
            dgvEventos.DataSource = EventosDAO.ObtenerTodos();
        }

        private void btnAgregarEvento_Click(object sender, EventArgs e)
        {
            if (txtTituloEvento.Text.Length > 0 && txtFechHorFinEvento.Text.Length > 0 && txtFechHorIniEvento.Text.Length > 0 
                && txtAsistenciasEvento.Text.Length > 0 && txtImagenEvento.Text.Length > 0)
            {
                Evento eve = new Evento();
                eve.titulo = txtTituloEvento.Text;
                eve.imagen = txtImagenEvento.Text; 
                eve.fechaIni = txtFechHorIniEvento.Text;
                eve.asistencias = Convert.ToInt32(txtAsistenciasEvento.Text);
                eve.fechaFin = txtFechHorFinEvento.Text;
                eve.idareaeve = Convert.ToInt32(cmbAreaEvento.SelectedValue);//error aqui
                

                if ((eve.idareaeve == 3 && eve.asistencias <= 358) ||
                    ((eve.idareaeve >= 4 && eve.idareaeve <= 6) && eve.asistencias <= 200))//auditorio max: 358, proyecc max: 200
                {
                    //VERIFICAR DISPONIBILIDAD
                    EventosDAO.CrearNuevo(eve);
                    MessageBox.Show("Nuevo evento agregado correctamente", "BINAES", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }else if (eve.idareaeve >= 19 && eve.idareaeve <= 26)//id de biblio del 19 al 26, solo se permiten eventos en biblio, auditorio y sala de proyeccion
                {
                    //VERIFICAR DISPONIBILIDAD
                    EventosDAO.CrearNuevo(eve);
                    MessageBox.Show("Nuevo evento agregado correctamente", "BINAES", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Verificar área y cantidad de asistencias. Auditorio: 358max; Sala de Proyecciones: 200max.",
                        "BINAES", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos", "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
            
            Limpiarevent();
            dgvEventos.DataSource = null;
            dgvEventos.DataSource = EventosDAO.ObtenerTodos();
        }

        private void Eventos_Load(object sender, EventArgs e)
        {
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
        }
    }
}