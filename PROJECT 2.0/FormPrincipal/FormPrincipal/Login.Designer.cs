using System.ComponentModel;

namespace FormPrincipal
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnOlvidado = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (29)))), ((int) (((byte) (38)))), ((int) (((byte) (69)))));
            this.panel1.Controls.Add(this.pbLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 461);
            this.panel1.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Image = ((System.Drawing.Image) (resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(3, 107);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(309, 233);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (42)))), ((int) (((byte) (52)))), ((int) (((byte) (93)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtUsuario.Location = new System.Drawing.Point(380, 128);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(479, 37);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Text = "Usuario";
            this.txtUsuario.Enter += new System.EventHandler(this.textBox1_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (42)))), ((int) (((byte) (52)))), ((int) (((byte) (93)))));
            this.txtContrasenia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContrasenia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtContrasenia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtContrasenia.Location = new System.Drawing.Point(380, 207);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(479, 37);
            this.txtContrasenia.TabIndex = 2;
            this.txtContrasenia.Text = "Contraseña";
            this.txtContrasenia.Enter += new System.EventHandler(this.textBox2_Enter);
            this.txtContrasenia.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // lblLogin
            // 
            this.lblLogin.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (42)))), ((int) (((byte) (52)))), ((int) (((byte) (93)))));
            this.lblLogin.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLogin.Location = new System.Drawing.Point(566, 54);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(138, 56);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "LOGIN";
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (13)))), ((int) (((byte) (93)))), ((int) (((byte) (142)))));
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIngresar.Location = new System.Drawing.Point(381, 315);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(479, 54);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image) (resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(851, 10);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(34, 32);
            this.btnMinimizar.TabIndex = 6;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image) (resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(891, 10);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(22, 30);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblMensaje.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMensaje.Location = new System.Drawing.Point(381, 283);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(479, 18);
            this.lblMensaje.TabIndex = 8;
            this.lblMensaje.Text = "Mensaje";
            // 
            // lblVersion
            // 
            this.lblVersion.ForeColor = System.Drawing.Color.Snow;
            this.lblVersion.Location = new System.Drawing.Point(602, 416);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(53, 27);
            this.lblVersion.TabIndex = 9;
            this.lblVersion.Text = "v1.0";
            // 
            // btnOlvidado
            // 
            this.btnOlvidado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOlvidado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOlvidado.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnOlvidado.ForeColor = System.Drawing.Color.Snow;
            this.btnOlvidado.Location = new System.Drawing.Point(512, 372);
            this.btnOlvidado.Name = "btnOlvidado";
            this.btnOlvidado.Size = new System.Drawing.Size(260, 34);
            this.btnOlvidado.TabIndex = 10;
            this.btnOlvidado.Text = "¿Ha olvidado su contraseña?";
            this.btnOlvidado.Click += new System.EventHandler(this.label3_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (42)))), ((int) (((byte) (52)))), ((int) (((byte) (93)))));
            this.ClientSize = new System.Drawing.Size(925, 461);
            this.Controls.Add(this.btnOlvidado);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(925, 461);
            this.Menu = this.mainMenu1;
            this.Name = "Login";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label btnOlvidado;

        private System.Windows.Forms.Label lblVersion;

        private System.Windows.Forms.MainMenu mainMenu1;

        private System.Windows.Forms.Label lblMensaje;

        private System.Windows.Forms.PictureBox btnCerrar;

        private System.Windows.Forms.PictureBox btnMinimizar;

        private System.Windows.Forms.Button btnIngresar;

        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.Label lblLogin;

        private System.Windows.Forms.TextBox txtUsuario;

        private System.Windows.Forms.PictureBox pbLogo;

        private System.Windows.Forms.Panel panel1;

        #endregion
    }
}