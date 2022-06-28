using System.ComponentModel;

namespace FormPrincipal
{
    partial class Inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.pbPortada = new System.Windows.Forms.PictureBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Timers.Timer();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.pbAdmin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize) (this.pbPortada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.timer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPortada
            // 
            this.pbPortada.Image = ((System.Drawing.Image) (resources.GetObject("pbPortada.Image")));
            this.pbPortada.Location = new System.Drawing.Point(309, 120);
            this.pbPortada.Name = "pbPortada";
            this.pbPortada.Size = new System.Drawing.Size(480, 504);
            this.pbPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPortada.TabIndex = 1;
            this.pbPortada.TabStop = false;
            // 
            // lblHora
            // 
            this.lblHora.BackColor = System.Drawing.SystemColors.Control;
            this.lblHora.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblHora.Location = new System.Drawing.Point(850, 9);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(206, 57);
            this.lblHora.TabIndex = 2;
            this.lblHora.Text = "Hora";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.SynchronizingObject = this;
            this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Elapsed);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(123, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "admin";
            // 
            // lblFecha
            // 
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblFecha.Location = new System.Drawing.Point(864, 66);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(180, 35);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbAdmin
            // 
            this.pbAdmin.Image = ((System.Drawing.Image) (resources.GetObject("pbAdmin.Image")));
            this.pbAdmin.Location = new System.Drawing.Point(35, 12);
            this.pbAdmin.Name = "pbAdmin";
            this.pbAdmin.Size = new System.Drawing.Size(82, 78);
            this.pbAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAdmin.TabIndex = 5;
            this.pbAdmin.TabStop = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 731);
            this.Controls.Add(this.pbAdmin);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.pbPortada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize) (this.pbPortada)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.timer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbAdmin)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox pbAdmin;

        private System.Windows.Forms.Label lblFecha;

        private System.Windows.Forms.Label label1;

        private System.Timers.Timer timer1;

        private System.Windows.Forms.Label lblHora;

        private System.Windows.Forms.PictureBox pbPortada;

        #endregion
    }
}