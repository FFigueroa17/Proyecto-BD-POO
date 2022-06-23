using System.ComponentModel;

namespace FormPrincipal
{
    partial class Usuarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbcUsuarios = new System.Windows.Forms.TabControl();
            this.tbpRegistrarIngreso = new System.Windows.Forms.TabPage();
            this.dgvIngresoSalidaUsuarios = new System.Windows.Forms.DataGridView();
            this.btnCambiarPestaña = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnIngreso = new System.Windows.Forms.Button();
            this.cmbAreasalida = new System.Windows.Forms.ComboBox();
            this.cmbAreaingreso = new System.Windows.Forms.ComboBox();
            this.lblareasalida = new System.Windows.Forms.Label();
            this.lblAreaingreso = new System.Windows.Forms.Label();
            this.txtidsalida = new System.Windows.Forms.TextBox();
            this.txtIdingreso = new System.Windows.Forms.TextBox();
            this.lblIduser2 = new System.Windows.Forms.Label();
            this.lblIduser = new System.Windows.Forms.Label();
            this.lblSalida = new System.Windows.Forms.Label();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.tbpRegistrarUsuario = new System.Windows.Forms.TabPage();
            this.btnAgregarUser = new System.Windows.Forms.Button();
            this.txtFotoUsuario = new System.Windows.Forms.TextBox();
            this.txtTelefonoUsuario = new System.Windows.Forms.TextBox();
            this.txtInstitucionUsuario = new System.Windows.Forms.TextBox();
            this.txtCorreoUsuario = new System.Windows.Forms.TextBox();
            this.txtDireccionUsuario = new System.Windows.Forms.TextBox();
            this.txtOcupacionUsuario = new System.Windows.Forms.TextBox();
            this.txtNombreNuevoUsuario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombreIng = new System.Windows.Forms.Label();
            this.tbcUsuarios.SuspendLayout();
            this.tbpRegistrarIngreso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvIngresoSalidaUsuarios)).BeginInit();
            this.tbpRegistrarUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(314, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 66);
            this.label1.TabIndex = 2;
            this.label1.Text = "USUARIOS";
            // 
            // tbcUsuarios
            // 
            this.tbcUsuarios.Controls.Add(this.tbpRegistrarIngreso);
            this.tbcUsuarios.Controls.Add(this.tbpRegistrarUsuario);
            this.tbcUsuarios.Location = new System.Drawing.Point(1, 58);
            this.tbcUsuarios.Name = "tbcUsuarios";
            this.tbcUsuarios.SelectedIndex = 0;
            this.tbcUsuarios.Size = new System.Drawing.Size(934, 526);
            this.tbcUsuarios.TabIndex = 3;
            // 
            // tbpRegistrarIngreso
            // 
            this.tbpRegistrarIngreso.BackColor = System.Drawing.SystemColors.Control;
            this.tbpRegistrarIngreso.Controls.Add(this.dgvIngresoSalidaUsuarios);
            this.tbpRegistrarIngreso.Controls.Add(this.btnCambiarPestaña);
            this.tbpRegistrarIngreso.Controls.Add(this.btnSalir);
            this.tbpRegistrarIngreso.Controls.Add(this.btnIngreso);
            this.tbpRegistrarIngreso.Controls.Add(this.cmbAreasalida);
            this.tbpRegistrarIngreso.Controls.Add(this.cmbAreaingreso);
            this.tbpRegistrarIngreso.Controls.Add(this.lblareasalida);
            this.tbpRegistrarIngreso.Controls.Add(this.lblAreaingreso);
            this.tbpRegistrarIngreso.Controls.Add(this.txtidsalida);
            this.tbpRegistrarIngreso.Controls.Add(this.txtIdingreso);
            this.tbpRegistrarIngreso.Controls.Add(this.lblIduser2);
            this.tbpRegistrarIngreso.Controls.Add(this.lblIduser);
            this.tbpRegistrarIngreso.Controls.Add(this.lblSalida);
            this.tbpRegistrarIngreso.Controls.Add(this.lblIngreso);
            this.tbpRegistrarIngreso.Location = new System.Drawing.Point(4, 25);
            this.tbpRegistrarIngreso.Name = "tbpRegistrarIngreso";
            this.tbpRegistrarIngreso.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRegistrarIngreso.Size = new System.Drawing.Size(926, 497);
            this.tbpRegistrarIngreso.TabIndex = 0;
            this.tbpRegistrarIngreso.Text = "tabPage1";
            // 
            // dgvIngresoSalidaUsuarios
            // 
            this.dgvIngresoSalidaUsuarios.AllowUserToOrderColumns = true;
            this.dgvIngresoSalidaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngresoSalidaUsuarios.Location = new System.Drawing.Point(63, 324);
            this.dgvIngresoSalidaUsuarios.Name = "dgvIngresoSalidaUsuarios";
            this.dgvIngresoSalidaUsuarios.RowTemplate.Height = 24;
            this.dgvIngresoSalidaUsuarios.Size = new System.Drawing.Size(809, 144);
            this.dgvIngresoSalidaUsuarios.TabIndex = 13;
            // 
            // btnCambiarPestaña
            // 
            this.btnCambiarPestaña.Location = new System.Drawing.Point(810, 6);
            this.btnCambiarPestaña.Name = "btnCambiarPestaña";
            this.btnCambiarPestaña.Size = new System.Drawing.Size(116, 50);
            this.btnCambiarPestaña.TabIndex = 12;
            this.btnCambiarPestaña.Text = "Registrar nuevo usuario";
            this.btnCambiarPestaña.UseVisualStyleBackColor = true;
            this.btnCambiarPestaña.Click += new System.EventHandler(this.btnCambiarPestaña_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(594, 252);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(154, 51);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnIngreso
            // 
            this.btnIngreso.Location = new System.Drawing.Point(174, 252);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(154, 51);
            this.btnIngreso.TabIndex = 10;
            this.btnIngreso.Text = "Ingresar";
            this.btnIngreso.UseVisualStyleBackColor = true;
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // cmbAreasalida
            // 
            this.cmbAreasalida.FormattingEnabled = true;
            this.cmbAreasalida.Location = new System.Drawing.Point(537, 187);
            this.cmbAreasalida.Name = "cmbAreasalida";
            this.cmbAreasalida.Size = new System.Drawing.Size(264, 24);
            this.cmbAreasalida.TabIndex = 9;
            // 
            // cmbAreaingreso
            // 
            this.cmbAreaingreso.FormattingEnabled = true;
            this.cmbAreaingreso.Location = new System.Drawing.Point(126, 187);
            this.cmbAreaingreso.Name = "cmbAreaingreso";
            this.cmbAreaingreso.Size = new System.Drawing.Size(264, 24);
            this.cmbAreaingreso.TabIndex = 8;
            // 
            // lblareasalida
            // 
            this.lblareasalida.Location = new System.Drawing.Point(537, 157);
            this.lblareasalida.Name = "lblareasalida";
            this.lblareasalida.Size = new System.Drawing.Size(157, 35);
            this.lblareasalida.TabIndex = 7;
            this.lblareasalida.Text = "Area de salida\r\n";
            // 
            // lblAreaingreso
            // 
            this.lblAreaingreso.Location = new System.Drawing.Point(126, 157);
            this.lblAreaingreso.Name = "lblAreaingreso";
            this.lblAreaingreso.Size = new System.Drawing.Size(157, 35);
            this.lblAreaingreso.TabIndex = 6;
            this.lblAreaingreso.Text = "Area ingresada";
            // 
            // txtidsalida
            // 
            this.txtidsalida.Location = new System.Drawing.Point(537, 118);
            this.txtidsalida.Name = "txtidsalida";
            this.txtidsalida.Size = new System.Drawing.Size(265, 22);
            this.txtidsalida.TabIndex = 5;
            // 
            // txtIdingreso
            // 
            this.txtIdingreso.Location = new System.Drawing.Point(126, 118);
            this.txtIdingreso.Name = "txtIdingreso";
            this.txtIdingreso.Size = new System.Drawing.Size(265, 22);
            this.txtIdingreso.TabIndex = 4;
            // 
            // lblIduser2
            // 
            this.lblIduser2.Location = new System.Drawing.Point(537, 94);
            this.lblIduser2.Name = "lblIduser2";
            this.lblIduser2.Size = new System.Drawing.Size(157, 35);
            this.lblIduser2.TabIndex = 3;
            this.lblIduser2.Text = "ID de usuario:";
            // 
            // lblIduser
            // 
            this.lblIduser.Location = new System.Drawing.Point(126, 94);
            this.lblIduser.Name = "lblIduser";
            this.lblIduser.Size = new System.Drawing.Size(157, 35);
            this.lblIduser.TabIndex = 2;
            this.lblIduser.Text = "ID de usuario:";
            // 
            // lblSalida
            // 
            this.lblSalida.Location = new System.Drawing.Point(537, 40);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(130, 28);
            this.lblSalida.TabIndex = 1;
            this.lblSalida.Text = "Registrar salida:";
            // 
            // lblIngreso
            // 
            this.lblIngreso.Location = new System.Drawing.Point(121, 40);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(251, 28);
            this.lblIngreso.TabIndex = 0;
            this.lblIngreso.Text = "Registrar ingreso:";
            // 
            // tbpRegistrarUsuario
            // 
            this.tbpRegistrarUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.tbpRegistrarUsuario.Controls.Add(this.btnAgregarUser);
            this.tbpRegistrarUsuario.Controls.Add(this.txtFotoUsuario);
            this.tbpRegistrarUsuario.Controls.Add(this.txtTelefonoUsuario);
            this.tbpRegistrarUsuario.Controls.Add(this.txtInstitucionUsuario);
            this.tbpRegistrarUsuario.Controls.Add(this.txtCorreoUsuario);
            this.tbpRegistrarUsuario.Controls.Add(this.txtDireccionUsuario);
            this.tbpRegistrarUsuario.Controls.Add(this.txtOcupacionUsuario);
            this.tbpRegistrarUsuario.Controls.Add(this.txtNombreNuevoUsuario);
            this.tbpRegistrarUsuario.Controls.Add(this.label8);
            this.tbpRegistrarUsuario.Controls.Add(this.label7);
            this.tbpRegistrarUsuario.Controls.Add(this.label6);
            this.tbpRegistrarUsuario.Controls.Add(this.label5);
            this.tbpRegistrarUsuario.Controls.Add(this.label4);
            this.tbpRegistrarUsuario.Controls.Add(this.label3);
            this.tbpRegistrarUsuario.Controls.Add(this.label2);
            this.tbpRegistrarUsuario.Controls.Add(this.lblNombreIng);
            this.tbpRegistrarUsuario.Location = new System.Drawing.Point(4, 25);
            this.tbpRegistrarUsuario.Name = "tbpRegistrarUsuario";
            this.tbpRegistrarUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRegistrarUsuario.Size = new System.Drawing.Size(926, 497);
            this.tbpRegistrarUsuario.TabIndex = 1;
            this.tbpRegistrarUsuario.Text = "tabPage2";
            // 
            // btnAgregarUser
            // 
            this.btnAgregarUser.Location = new System.Drawing.Point(356, 400);
            this.btnAgregarUser.Name = "btnAgregarUser";
            this.btnAgregarUser.Size = new System.Drawing.Size(199, 62);
            this.btnAgregarUser.TabIndex = 15;
            this.btnAgregarUser.Text = "Agregar";
            this.btnAgregarUser.UseVisualStyleBackColor = true;
            this.btnAgregarUser.Click += new System.EventHandler(this.btnAgregarUser_Click);
            // 
            // txtFotoUsuario
            // 
            this.txtFotoUsuario.Location = new System.Drawing.Point(601, 80);
            this.txtFotoUsuario.Name = "txtFotoUsuario";
            this.txtFotoUsuario.Size = new System.Drawing.Size(227, 22);
            this.txtFotoUsuario.TabIndex = 14;
            // 
            // txtTelefonoUsuario
            // 
            this.txtTelefonoUsuario.Location = new System.Drawing.Point(347, 335);
            this.txtTelefonoUsuario.Name = "txtTelefonoUsuario";
            this.txtTelefonoUsuario.Size = new System.Drawing.Size(227, 22);
            this.txtTelefonoUsuario.TabIndex = 13;
            // 
            // txtInstitucionUsuario
            // 
            this.txtInstitucionUsuario.Location = new System.Drawing.Point(347, 212);
            this.txtInstitucionUsuario.Name = "txtInstitucionUsuario";
            this.txtInstitucionUsuario.Size = new System.Drawing.Size(227, 22);
            this.txtInstitucionUsuario.TabIndex = 12;
            // 
            // txtCorreoUsuario
            // 
            this.txtCorreoUsuario.Location = new System.Drawing.Point(347, 80);
            this.txtCorreoUsuario.Name = "txtCorreoUsuario";
            this.txtCorreoUsuario.Size = new System.Drawing.Size(227, 22);
            this.txtCorreoUsuario.TabIndex = 11;
            // 
            // txtDireccionUsuario
            // 
            this.txtDireccionUsuario.Location = new System.Drawing.Point(91, 335);
            this.txtDireccionUsuario.Name = "txtDireccionUsuario";
            this.txtDireccionUsuario.Size = new System.Drawing.Size(227, 22);
            this.txtDireccionUsuario.TabIndex = 10;
            // 
            // txtOcupacionUsuario
            // 
            this.txtOcupacionUsuario.Location = new System.Drawing.Point(93, 212);
            this.txtOcupacionUsuario.Name = "txtOcupacionUsuario";
            this.txtOcupacionUsuario.Size = new System.Drawing.Size(227, 22);
            this.txtOcupacionUsuario.TabIndex = 9;
            // 
            // txtNombreNuevoUsuario
            // 
            this.txtNombreNuevoUsuario.Location = new System.Drawing.Point(93, 80);
            this.txtNombreNuevoUsuario.Name = "txtNombreNuevoUsuario";
            this.txtNombreNuevoUsuario.Size = new System.Drawing.Size(227, 22);
            this.txtNombreNuevoUsuario.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(601, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 30);
            this.label8.TabIndex = 7;
            this.label8.Text = "Código QR";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(601, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 30);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fotografía";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(347, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 30);
            this.label6.TabIndex = 5;
            this.label6.Text = "Teléfono +503 [2,6,7]";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(347, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Institución";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(347, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Correo";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(91, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dirección";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(91, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ocupación";
            // 
            // lblNombreIng
            // 
            this.lblNombreIng.Location = new System.Drawing.Point(91, 59);
            this.lblNombreIng.Name = "lblNombreIng";
            this.lblNombreIng.Size = new System.Drawing.Size(102, 30);
            this.lblNombreIng.TabIndex = 0;
            this.lblNombreIng.Text = "Nombre";
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(939, 583);
            this.Controls.Add(this.tbcUsuarios);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.tbcUsuarios.ResumeLayout(false);
            this.tbpRegistrarIngreso.ResumeLayout(false);
            this.tbpRegistrarIngreso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvIngresoSalidaUsuarios)).EndInit();
            this.tbpRegistrarUsuario.ResumeLayout(false);
            this.tbpRegistrarUsuario.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnAgregarUser;

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNombreNuevoUsuario;
        private System.Windows.Forms.TextBox txtOcupacionUsuario;
        private System.Windows.Forms.TextBox txtDireccionUsuario;
        private System.Windows.Forms.TextBox txtCorreoUsuario;
        private System.Windows.Forms.TextBox txtInstitucionUsuario;
        private System.Windows.Forms.TextBox txtTelefonoUsuario;
        private System.Windows.Forms.TextBox txtFotoUsuario;

        private System.Windows.Forms.Label lblNombreIng;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.DataGridView dgvIngresoSalidaUsuarios;

        private System.Windows.Forms.Button btnCambiarPestaña;

        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.Button btnSalir;

        private System.Windows.Forms.ComboBox cmbAreaingreso;
        private System.Windows.Forms.ComboBox cmbAreasalida;

        private System.Windows.Forms.Label lblAreaingreso;
        private System.Windows.Forms.Label lblareasalida;

        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.Label lblIduser;
        private System.Windows.Forms.Label lblIduser2;
        private System.Windows.Forms.TextBox txtIdingreso;
        private System.Windows.Forms.TextBox txtidsalida;

        private System.Windows.Forms.TabControl tbcUsuarios;
        private System.Windows.Forms.TabPage tbpRegistrarIngreso;
        private System.Windows.Forms.TabPage tbpRegistrarUsuario;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}