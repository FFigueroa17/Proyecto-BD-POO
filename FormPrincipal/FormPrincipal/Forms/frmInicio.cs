using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;


namespace FormPrincipal
{
    public partial class frmInicio : Form
    {
        string nom_user = "";
        public frmInicio(string user)
        {
            InitializeComponent();
            nom_user = user;
        }
        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            hora.Text = DateTime.Now.ToShortTimeString();
            fecha.Text = DateTime.Now.ToShortDateString();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            hora.Text = "";
            fecha.Text = "";
            lblNombre.Text = nom_user;
        }
    }
}