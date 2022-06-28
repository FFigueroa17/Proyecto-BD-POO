using System.ComponentModel;

namespace FormPrincipal
{
    partial class RecuperacionPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecuperacionPass));
            this.btnRecuperar = new System.Windows.Forms.Button();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblPeticion = new System.Windows.Forms.Label();
            this.pbCandado = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMensaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbCandado)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.BackColor = System.Drawing.Color.White;
            this.btnRecuperar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecuperar.FlatAppearance.BorderSize = 0;
            this.btnRecuperar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecuperar.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnRecuperar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRecuperar.Location = new System.Drawing.Point(129, 561);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Size = new System.Drawing.Size(211, 74);
            this.btnRecuperar.TabIndex = 0;
            this.btnRecuperar.Text = "Recuperar contraseña";
            this.btnRecuperar.UseVisualStyleBackColor = false;
            this.btnRecuperar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtCorreo.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtCorreo.Location = new System.Drawing.Point(28, 458);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(404, 27);
            this.txtCorreo.TabIndex = 1;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image) (resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(435, 17);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(28, 36);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitulo.Location = new System.Drawing.Point(64, 354);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(357, 50);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Recuperación de contraseña";
            // 
            // lblPeticion
            // 
            this.lblPeticion.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblPeticion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPeticion.Location = new System.Drawing.Point(28, 426);
            this.lblPeticion.Name = "lblPeticion";
            this.lblPeticion.Size = new System.Drawing.Size(338, 29);
            this.lblPeticion.TabIndex = 10;
            this.lblPeticion.Text = "Ingrese su correo electrónico:";
            // 
            // pbCandado
            // 
            this.pbCandado.Image = ((System.Drawing.Image) (resources.GetObject("pbCandado.Image")));
            this.pbCandado.Location = new System.Drawing.Point(137, 86);
            this.pbCandado.Name = "pbCandado";
            this.pbCandado.Size = new System.Drawing.Size(203, 255);
            this.pbCandado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCandado.TabIndex = 11;
            this.pbCandado.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (29)))), ((int) (((byte) (38)))), ((int) (((byte) (69)))));
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Location = new System.Drawing.Point(-2, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 57);
            this.panel1.TabIndex = 12;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblMensaje.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMensaje.Location = new System.Drawing.Point(28, 497);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(404, 49);
            this.lblMensaje.TabIndex = 13;
            this.lblMensaje.Text = "Mensaje";
            // 
            // RecuperacionPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (13)))), ((int) (((byte) (93)))), ((int) (((byte) (142)))));
            this.ClientSize = new System.Drawing.Size(473, 701);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.pbCandado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPeticion);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.btnRecuperar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RecuperacionPass";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "RecuperacionPass";
            this.Load += new System.EventHandler(this.RecuperacionPass_Load);
            ((System.ComponentModel.ISupportInitialize) (this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbCandado)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblMensaje;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.PictureBox pbCandado;

        private System.Windows.Forms.Label lblPeticion;

        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label lblTitulo;

        private System.Windows.Forms.Button btnRecuperar;
        private System.Windows.Forms.TextBox txtCorreo;

        #endregion
    }
}