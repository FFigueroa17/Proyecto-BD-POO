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
    public partial class frmPrincipal : Form
    {
        private string usuario = "";
        public frmPrincipal(string user)
        {
            InitializeComponent();
            usuario = user;
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
            abrirFormulario(new frmInicio(usuario));
            btnInicio.BackColor = Color.Orange;
            btnPisos.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnAreas.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnEventos.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnColecciones.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnEjemplares.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnPrestamos.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnReservas.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
        }

        private void btPISOS_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmPisos());
            btnInicio.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnPisos.BackColor = Color.DarkTurquoise;
            btnAreas.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnEventos.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnColecciones.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnEjemplares.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnPrestamos.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnReservas.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
        }

        private void btAREAS_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmAreas());
            btnInicio.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnPisos.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnAreas.BackColor = Color.DarkTurquoise;
            btnEventos.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnColecciones.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnEjemplares.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnPrestamos.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnReservas.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
        }

        private void btEVENTOS_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmEventos());
            btnInicio.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnPisos.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnAreas.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnEventos.BackColor = Color.DarkTurquoise;
            btnColecciones.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnEjemplares.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnPrestamos.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnReservas.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
        }

        private void btCOLECCIONES_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmColecciones());
            btnInicio.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnPisos.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnAreas.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnEventos.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnColecciones.BackColor = Color.DarkTurquoise;
            btnEjemplares.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnPrestamos.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnReservas.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
        }

        private void btEJEMPLARES_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmEjemplares());
            btnInicio.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnPisos.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnAreas.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnEventos.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnColecciones.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnEjemplares.BackColor = Color.DarkTurquoise;
            btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnPrestamos.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnReservas.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
        }

        private void btUSUARIOS_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmUsuario());
            btnInicio.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnPisos.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnAreas.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnEventos.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnColecciones.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnEjemplares.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnUsuarios.BackColor = Color.DarkTurquoise;
            btnPrestamos.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnReservas.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
        }

        private void btPRESTAMOS_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmPrestamos());
            btnInicio.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnPisos.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnAreas.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnEventos.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnColecciones.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnEjemplares.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnPrestamos.BackColor = Color.DarkTurquoise;
            btnReservas.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
        }

        private void btRESERVAS_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmReservas());
            btnInicio.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnPisos.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnAreas.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnEventos.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnColecciones.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnEjemplares.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnPrestamos.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            btnReservas.BackColor = Color.DarkTurquoise;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            abrirFormulario(new frmInicio(usuario));
            btnInicio.BackColor = Color.Orange;

            ttpBusquedas.SetToolTip(picBusquedas, "Haz click para buscar un ejemplar");
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btSALIR_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
        }

        private void picBusquedas_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmBusquedas());
        }
    }
}