using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPrincipal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void abrirFormulario(object form2)
        {
            if (this.PanelContainer.Controls.Count > 0)
            {
               this.PanelContainer.Controls.RemoveAt(0);
            }
            Form f2 = form2 as Form;
            f2.TopLevel = false;
            f2.Dock = DockStyle.Fill;
            this.PanelContainer.Controls.Add(f2);
            this.PanelContainer.Tag = f2;
            f2.Show();
        }
        private void btINICIO_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Inicio());
        }

        private void btPISOS_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Pisos());
        }

        private void btAREAS_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Areas());
        }

        private void btEVENTOS_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Eventos());
        }

        private void btCOLECCIONES_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Colecciones());
        }

        private void btEJEMPLARES_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Ejemplares());
        }

        private void btUSUARIOS_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Usuarios());
        }

        private void btPRESTAMOS_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Prestamos());
        }

        private void btRESERVAS_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Reservas());
        }
    }
}