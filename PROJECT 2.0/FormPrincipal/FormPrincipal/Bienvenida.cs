using System;
using System.Data.SqlClient;
using System.Resources;
using System.Timers;
using System.Windows.Forms;

namespace FormPrincipal
{
    public partial class Bienvenida : Form
    {
        string user = "";
        public Bienvenida(string usuario)
        {
            
            InitializeComponent();
            user = usuario;
        }

        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            progressBar1.Value += 1;
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                this.Hide();
                Form1 fr1 = new Form1(user);
                fr1.Show();
            }
        }
        
        private void Bienvenida_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            timer1.Start();
        }
    }
}