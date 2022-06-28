using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using FormPrincipal.Properties;


namespace FormPrincipal
{
    public partial class Inicio : Form
    {
        string nom_user = "";
        public Inicio(string user)
        {
            InitializeComponent();
            nom_user = user;

        }

        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            lblHora.Text = DateTime.Now.ToShortTimeString();
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            lblHora.Text = "";
            lblFecha.Text = "";
            label1.Text = nom_user;
        }
    }
}