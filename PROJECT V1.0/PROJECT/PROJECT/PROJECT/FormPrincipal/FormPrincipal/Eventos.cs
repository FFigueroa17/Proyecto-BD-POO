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
            if (txtTituloEvento.Text.Length > 0 && txtAsistenciasEvento.Text.Length > 0 && txtIDElimEditEvento.Text.Length > 0 
                && txtObjetivo.Text.Length > 0)
            {
                Evento eve = new Evento();
                eve.titulo = txtTituloEvento.Text;
                eve.fechInicio = Convert.ToDateTime(dtpInicio.Value);
                eve.fechFin = Convert.ToDateTime(dtpFin.Value);
                eve.asistencias = Convert.ToInt32(txtAsistenciasEvento.Text);
                eve.objetivo = txtObjetivo.Text;
                eve.IDEvento = Convert.ToInt32(txtIDElimEditEvento.Text);
                eve.imagen = txtImagenEvento.Text;
                eve.idareaeve = Convert.ToInt32(cmbAreaEvento.SelectedValue);
                
                //VERIFICAR DISPONIBILIDAD
                if (EventosDAO.VerificarDisponibilidadFechas(eve))
                {
                    if (EventosDAO.ActualizarPorID(eve)){
                        MessageBox.Show("Coleccion actualizada correctamente", "BINAES", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        Limpiarevent();
                    }else
                        MessageBox.Show("Ha ocurrido un error");
                }else
                    MessageBox.Show("Verificar fechas disponibles.", "BINAES", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            dgvEventos.DataSource = null;
            dgvEventos.DataSource = EventosDAO.ObtenerTodos();
            
        }

        public void Limpiarevent()//agregar campos faltantes
        {
            txtAsistenciasEvento.Clear();
            txtTituloEvento.Clear();
            txtIDElimEditEvento.Clear();
            txtObjetivo.Clear();
            txtImagenEvento.Clear();
        }


        private void btnMostrarEvento_Click(object sender, EventArgs e)
        {
            dgvEventos.DataSource = null;
            dgvEventos.DataSource = EventosDAO.ObtenerTodos();
        }

        private void btnAgregarEvento_Click(object sender, EventArgs e)
        {
            if (txtTituloEvento.Text.Length > 0 && txtAsistenciasEvento.Text.Length > 0 
                                                && txtImagenEvento.Text.Length > 0 && txtObjetivo.Text.Length > 0)
            {
                Evento eve = new Evento();
                eve.titulo = txtTituloEvento.Text;
                eve.imagen = txtImagenEvento.Text;
                eve.fechInicio = dtpInicio.Value;//txtFechHorIniEvento.Text; fechaIni
                eve.asistencias = Convert.ToInt32(txtAsistenciasEvento.Text);
                eve.fechFin = dtpFin.Value;//txtFechHorFinEvento.Text; fechaFin
                eve.idareaeve = Convert.ToInt32(cmbAreaEvento.SelectedValue);
                eve.objetivo = txtObjetivo.Text;
                

                if ((eve.idareaeve == 3 && eve.asistencias <= 358) ||
                    ((eve.idareaeve >= 4 && eve.idareaeve <= 6) && eve.asistencias <= 200))//auditorio max: 358, proyecc max: 200
                {
                    //VERIFICAR DISPONIBILIDAD
                    if (EventosDAO.VerificarDisponibilidadFechas(eve))
                    {
                        EventosDAO.CrearNuevo(eve);
                        MessageBox.Show("Nuevo evento agregado correctamente.", "BINAES", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        Limpiarevent();
                    }else
                        MessageBox.Show("Verificar fechas disponibles.", "BINAES", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                }else if (eve.idareaeve >= 19 && eve.idareaeve <= 26)//id de biblio del 19 al 26, solo se permiten eventos en biblio, auditorio y sala de proyeccion
                {
                    //VERIFICAR DISPONIBILIDAD
                    if (EventosDAO.VerificarDisponibilidadFechas(eve))
                    {
                        EventosDAO.CrearNuevo(eve);
                        MessageBox.Show("Nuevo evento agregado correctamente.", "BINAES", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        Limpiarevent();
                    }else
                        MessageBox.Show("Verificar fechas disponibles.", "BINAES", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
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
                MessageBox.Show("Debe llenar todos los campos.", "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
            
            dgvEventos.DataSource = null;
            dgvEventos.DataSource = EventosDAO.ObtenerTodos();
        }
        
        //CARGAR COMBO BOX AL CARGAR FORMULARIO
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

        private void btnEliminarEvento_Click(object sender, EventArgs e)
        {
            if (txtIDElimEditEvento.Text.Length > 0)
            {
                int ID_a_borrar = Convert.ToInt32(txtIDElimEditEvento.Text);

                if (EventosDAO.EliminarPorID(ID_a_borrar))
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
            
            dgvEventos.DataSource = null;
            dgvEventos.DataSource = EventosDAO.ObtenerTodos();
            
            Limpiarevent();
        }
        
    }
}