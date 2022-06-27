using System.ComponentModel;

namespace FormPrincipal
{
    partial class frmUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbcUsuarios = new System.Windows.Forms.TabControl();
            this.tbpRegistrarIngreso = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblareasalida = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblAreaingreso = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblIduser = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblIduser2 = new System.Windows.Forms.Label();
            this.btnCambiarPestaña = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblSalida = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel24 = new System.Windows.Forms.Panel();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnIngreso = new System.Windows.Forms.Button();
            this.dgvIngresoSalidaUsuarios = new System.Windows.Forms.DataGridView();
            this.cmbAreasalida = new System.Windows.Forms.ComboBox();
            this.cmbAreaingreso = new System.Windows.Forms.ComboBox();
            this.txtidsalida = new System.Windows.Forms.TextBox();
            this.txtIdingreso = new System.Windows.Forms.TextBox();
            this.tbpRegistrarUsuario = new System.Windows.Forms.TabPage();
            this.txtRutaQRCreado = new System.Windows.Forms.TextBox();
            this.txtFotoUserAgregada = new System.Windows.Forms.TextBox();
            this.btnCrearQR = new System.Windows.Forms.Button();
            this.btnAgregarfotoUser = new System.Windows.Forms.Button();
            this.btnGuardarQR = new System.Windows.Forms.Button();
            this.btnAgregarUser = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.panel15 = new System.Windows.Forms.Panel();
            this.lblQradd = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.lblfotoadd = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.lblteladd = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.lblInstitucionAdd = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lblCorreoAdd = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lblDireccionAdd = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblOcupacionAdd = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblNombreIng = new System.Windows.Forms.Label();
            this.picQR = new System.Windows.Forms.PictureBox();
            this.txtTelefonoUsuario = new System.Windows.Forms.TextBox();
            this.txtInstitucionUsuario = new System.Windows.Forms.TextBox();
            this.txtCorreoUsuario = new System.Windows.Forms.TextBox();
            this.txtDireccionUsuario = new System.Windows.Forms.TextBox();
            this.txtOcupacionUsuario = new System.Windows.Forms.TextBox();
            this.txtNombreNuevoUsuario = new System.Windows.Forms.TextBox();
            this.panel16 = new System.Windows.Forms.Panel();
            this.lblAreas = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.panel22 = new System.Windows.Forms.Panel();
            this.tbcUsuarios.SuspendLayout();
            this.tbpRegistrarIngreso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresoSalidaUsuarios)).BeginInit();
            this.tbpRegistrarUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).BeginInit();
            this.panel16.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcUsuarios
            // 
            this.tbcUsuarios.Controls.Add(this.tbpRegistrarIngreso);
            this.tbcUsuarios.Controls.Add(this.tbpRegistrarUsuario);
            this.tbcUsuarios.Location = new System.Drawing.Point(1, 47);
            this.tbcUsuarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbcUsuarios.Name = "tbcUsuarios";
            this.tbcUsuarios.SelectedIndex = 0;
            this.tbcUsuarios.Size = new System.Drawing.Size(718, 427);
            this.tbcUsuarios.TabIndex = 3;
            // 
            // tbpRegistrarIngreso
            // 
            this.tbpRegistrarIngreso.BackColor = System.Drawing.SystemColors.Control;
            this.tbpRegistrarIngreso.Controls.Add(this.panel18);
            this.tbpRegistrarIngreso.Controls.Add(this.panel7);
            this.tbpRegistrarIngreso.Controls.Add(this.lblareasalida);
            this.tbpRegistrarIngreso.Controls.Add(this.panel6);
            this.tbpRegistrarIngreso.Controls.Add(this.lblAreaingreso);
            this.tbpRegistrarIngreso.Controls.Add(this.panel5);
            this.tbpRegistrarIngreso.Controls.Add(this.lblIduser);
            this.tbpRegistrarIngreso.Controls.Add(this.panel4);
            this.tbpRegistrarIngreso.Controls.Add(this.lblIduser2);
            this.tbpRegistrarIngreso.Controls.Add(this.btnCambiarPestaña);
            this.tbpRegistrarIngreso.Controls.Add(this.panel3);
            this.tbpRegistrarIngreso.Controls.Add(this.lblSalida);
            this.tbpRegistrarIngreso.Controls.Add(this.panel2);
            this.tbpRegistrarIngreso.Controls.Add(this.panel1);
            this.tbpRegistrarIngreso.Controls.Add(this.panel24);
            this.tbpRegistrarIngreso.Controls.Add(this.lblIngreso);
            this.tbpRegistrarIngreso.Controls.Add(this.btnSalir);
            this.tbpRegistrarIngreso.Controls.Add(this.btnIngreso);
            this.tbpRegistrarIngreso.Controls.Add(this.dgvIngresoSalidaUsuarios);
            this.tbpRegistrarIngreso.Controls.Add(this.cmbAreasalida);
            this.tbpRegistrarIngreso.Controls.Add(this.cmbAreaingreso);
            this.tbpRegistrarIngreso.Controls.Add(this.txtidsalida);
            this.tbpRegistrarIngreso.Controls.Add(this.txtIdingreso);
            this.tbpRegistrarIngreso.Location = new System.Drawing.Point(4, 22);
            this.tbpRegistrarIngreso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbpRegistrarIngreso.Name = "tbpRegistrarIngreso";
            this.tbpRegistrarIngreso.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbpRegistrarIngreso.Size = new System.Drawing.Size(710, 401);
            this.tbpRegistrarIngreso.TabIndex = 0;
            this.tbpRegistrarIngreso.Text = "tabPage1";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel7.Location = new System.Drawing.Point(366, 131);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 18);
            this.panel7.TabIndex = 110;
            // 
            // lblareasalida
            // 
            this.lblareasalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.lblareasalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblareasalida.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblareasalida.ForeColor = System.Drawing.Color.White;
            this.lblareasalida.Location = new System.Drawing.Point(374, 131);
            this.lblareasalida.Name = "lblareasalida";
            this.lblareasalida.Size = new System.Drawing.Size(192, 18);
            this.lblareasalida.TabIndex = 109;
            this.lblareasalida.Text = "  Area Salida";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel6.Location = new System.Drawing.Point(58, 127);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 18);
            this.panel6.TabIndex = 108;
            // 
            // lblAreaingreso
            // 
            this.lblAreaingreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.lblAreaingreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAreaingreso.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaingreso.ForeColor = System.Drawing.Color.White;
            this.lblAreaingreso.Location = new System.Drawing.Point(65, 127);
            this.lblAreaingreso.Name = "lblAreaingreso";
            this.lblAreaingreso.Size = new System.Drawing.Size(192, 18);
            this.lblAreaingreso.TabIndex = 107;
            this.lblAreaingreso.Text = "Area Ingresada";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel5.Location = new System.Drawing.Point(58, 73);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 18);
            this.panel5.TabIndex = 106;
            // 
            // lblIduser
            // 
            this.lblIduser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.lblIduser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblIduser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIduser.ForeColor = System.Drawing.Color.White;
            this.lblIduser.Location = new System.Drawing.Point(65, 73);
            this.lblIduser.Name = "lblIduser";
            this.lblIduser.Size = new System.Drawing.Size(192, 18);
            this.lblIduser.TabIndex = 105;
            this.lblIduser.Text = "  ID de Usuario";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel4.Location = new System.Drawing.Point(365, 73);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 18);
            this.panel4.TabIndex = 104;
            // 
            // lblIduser2
            // 
            this.lblIduser2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.lblIduser2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblIduser2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIduser2.ForeColor = System.Drawing.Color.White;
            this.lblIduser2.Location = new System.Drawing.Point(373, 73);
            this.lblIduser2.Name = "lblIduser2";
            this.lblIduser2.Size = new System.Drawing.Size(192, 18);
            this.lblIduser2.TabIndex = 103;
            this.lblIduser2.Text = "  ID de Usuario";
            // 
            // btnCambiarPestaña
            // 
            this.btnCambiarPestaña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnCambiarPestaña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCambiarPestaña.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCambiarPestaña.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarPestaña.ForeColor = System.Drawing.Color.White;
            this.btnCambiarPestaña.Location = new System.Drawing.Point(603, 95);
            this.btnCambiarPestaña.Name = "btnCambiarPestaña";
            this.btnCambiarPestaña.Size = new System.Drawing.Size(87, 41);
            this.btnCambiarPestaña.TabIndex = 102;
            this.btnCambiarPestaña.Text = "Registrar Nuevo Usuario";
            this.btnCambiarPestaña.UseVisualStyleBackColor = false;
            this.btnCambiarPestaña.Click += new System.EventHandler(this.btnCambiarPestaña_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel3.Location = new System.Drawing.Point(367, 31);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 18);
            this.panel3.TabIndex = 101;
            // 
            // lblSalida
            // 
            this.lblSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.lblSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSalida.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalida.ForeColor = System.Drawing.Color.White;
            this.lblSalida.Location = new System.Drawing.Point(374, 31);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(192, 18);
            this.lblSalida.TabIndex = 100;
            this.lblSalida.Text = "  Registrar Salida";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel2.Location = new System.Drawing.Point(398, 195);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(12, 41);
            this.panel2.TabIndex = 99;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Location = new System.Drawing.Point(93, 195);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(12, 41);
            this.panel1.TabIndex = 98;
            // 
            // panel24
            // 
            this.panel24.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel24.Location = new System.Drawing.Point(58, 31);
            this.panel24.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(10, 18);
            this.panel24.TabIndex = 97;
            // 
            // lblIngreso
            // 
            this.lblIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.lblIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblIngreso.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreso.ForeColor = System.Drawing.Color.White;
            this.lblIngreso.Location = new System.Drawing.Point(65, 31);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(192, 18);
            this.lblIngreso.TabIndex = 96;
            this.lblIngreso.Text = "  Registrar Ingreso";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(398, 195);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(135, 41);
            this.btnSalir.TabIndex = 85;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnIngreso
            // 
            this.btnIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnIngreso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIngreso.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngreso.ForeColor = System.Drawing.Color.White;
            this.btnIngreso.Location = new System.Drawing.Point(93, 195);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(135, 41);
            this.btnIngreso.TabIndex = 84;
            this.btnIngreso.Text = "Ingresar";
            this.btnIngreso.UseVisualStyleBackColor = false;
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // dgvIngresoSalidaUsuarios
            // 
            this.dgvIngresoSalidaUsuarios.AllowUserToAddRows = false;
            this.dgvIngresoSalidaUsuarios.AllowUserToDeleteRows = false;
            this.dgvIngresoSalidaUsuarios.AllowUserToResizeColumns = false;
            this.dgvIngresoSalidaUsuarios.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            this.dgvIngresoSalidaUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvIngresoSalidaUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.dgvIngresoSalidaUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvIngresoSalidaUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIngresoSalidaUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvIngresoSalidaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIngresoSalidaUsuarios.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvIngresoSalidaUsuarios.EnableHeadersVisualStyles = false;
            this.dgvIngresoSalidaUsuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.dgvIngresoSalidaUsuarios.Location = new System.Drawing.Point(36, 258);
            this.dgvIngresoSalidaUsuarios.Margin = new System.Windows.Forms.Padding(0);
            this.dgvIngresoSalidaUsuarios.Name = "dgvIngresoSalidaUsuarios";
            this.dgvIngresoSalidaUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIngresoSalidaUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvIngresoSalidaUsuarios.RowHeadersVisible = false;
            this.dgvIngresoSalidaUsuarios.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.dgvIngresoSalidaUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvIngresoSalidaUsuarios.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.dgvIngresoSalidaUsuarios.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvIngresoSalidaUsuarios.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.dgvIngresoSalidaUsuarios.RowTemplate.ReadOnly = true;
            this.dgvIngresoSalidaUsuarios.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIngresoSalidaUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIngresoSalidaUsuarios.Size = new System.Drawing.Size(622, 123);
            this.dgvIngresoSalidaUsuarios.TabIndex = 83;
            // 
            // cmbAreasalida
            // 
            this.cmbAreasalida.FormattingEnabled = true;
            this.cmbAreasalida.Location = new System.Drawing.Point(367, 151);
            this.cmbAreasalida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbAreasalida.Name = "cmbAreasalida";
            this.cmbAreasalida.Size = new System.Drawing.Size(199, 21);
            this.cmbAreasalida.TabIndex = 9;
            // 
            // cmbAreaingreso
            // 
            this.cmbAreaingreso.FormattingEnabled = true;
            this.cmbAreaingreso.Location = new System.Drawing.Point(58, 151);
            this.cmbAreaingreso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbAreaingreso.Name = "cmbAreaingreso";
            this.cmbAreaingreso.Size = new System.Drawing.Size(199, 21);
            this.cmbAreaingreso.TabIndex = 8;
            // 
            // txtidsalida
            // 
            this.txtidsalida.Location = new System.Drawing.Point(367, 95);
            this.txtidsalida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtidsalida.Name = "txtidsalida";
            this.txtidsalida.Size = new System.Drawing.Size(200, 20);
            this.txtidsalida.TabIndex = 5;
            // 
            // txtIdingreso
            // 
            this.txtIdingreso.Location = new System.Drawing.Point(58, 95);
            this.txtIdingreso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdingreso.Name = "txtIdingreso";
            this.txtIdingreso.Size = new System.Drawing.Size(200, 20);
            this.txtIdingreso.TabIndex = 4;
            // 
            // tbpRegistrarUsuario
            // 
            this.tbpRegistrarUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.tbpRegistrarUsuario.Controls.Add(this.panel22);
            this.tbpRegistrarUsuario.Controls.Add(this.panel21);
            this.tbpRegistrarUsuario.Controls.Add(this.panel20);
            this.tbpRegistrarUsuario.Controls.Add(this.panel19);
            this.tbpRegistrarUsuario.Controls.Add(this.txtRutaQRCreado);
            this.tbpRegistrarUsuario.Controls.Add(this.txtFotoUserAgregada);
            this.tbpRegistrarUsuario.Controls.Add(this.btnCrearQR);
            this.tbpRegistrarUsuario.Controls.Add(this.btnAgregarfotoUser);
            this.tbpRegistrarUsuario.Controls.Add(this.btnGuardarQR);
            this.tbpRegistrarUsuario.Controls.Add(this.btnAgregarUser);
            this.tbpRegistrarUsuario.Controls.Add(this.btnRegresar);
            this.tbpRegistrarUsuario.Controls.Add(this.panel15);
            this.tbpRegistrarUsuario.Controls.Add(this.lblQradd);
            this.tbpRegistrarUsuario.Controls.Add(this.panel14);
            this.tbpRegistrarUsuario.Controls.Add(this.lblfotoadd);
            this.tbpRegistrarUsuario.Controls.Add(this.panel13);
            this.tbpRegistrarUsuario.Controls.Add(this.lblteladd);
            this.tbpRegistrarUsuario.Controls.Add(this.panel12);
            this.tbpRegistrarUsuario.Controls.Add(this.lblInstitucionAdd);
            this.tbpRegistrarUsuario.Controls.Add(this.panel11);
            this.tbpRegistrarUsuario.Controls.Add(this.lblCorreoAdd);
            this.tbpRegistrarUsuario.Controls.Add(this.panel10);
            this.tbpRegistrarUsuario.Controls.Add(this.lblDireccionAdd);
            this.tbpRegistrarUsuario.Controls.Add(this.panel9);
            this.tbpRegistrarUsuario.Controls.Add(this.lblOcupacionAdd);
            this.tbpRegistrarUsuario.Controls.Add(this.panel8);
            this.tbpRegistrarUsuario.Controls.Add(this.lblNombreIng);
            this.tbpRegistrarUsuario.Controls.Add(this.picQR);
            this.tbpRegistrarUsuario.Controls.Add(this.txtTelefonoUsuario);
            this.tbpRegistrarUsuario.Controls.Add(this.txtInstitucionUsuario);
            this.tbpRegistrarUsuario.Controls.Add(this.txtCorreoUsuario);
            this.tbpRegistrarUsuario.Controls.Add(this.txtDireccionUsuario);
            this.tbpRegistrarUsuario.Controls.Add(this.txtOcupacionUsuario);
            this.tbpRegistrarUsuario.Controls.Add(this.txtNombreNuevoUsuario);
            this.tbpRegistrarUsuario.Location = new System.Drawing.Point(4, 22);
            this.tbpRegistrarUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbpRegistrarUsuario.Name = "tbpRegistrarUsuario";
            this.tbpRegistrarUsuario.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbpRegistrarUsuario.Size = new System.Drawing.Size(710, 401);
            this.tbpRegistrarUsuario.TabIndex = 1;
            this.tbpRegistrarUsuario.Text = "tabPage2";
            this.tbpRegistrarUsuario.Click += new System.EventHandler(this.tbpRegistrarUsuario_Click);
            // 
            // txtRutaQRCreado
            // 
            this.txtRutaQRCreado.Location = new System.Drawing.Point(251, 38);
            this.txtRutaQRCreado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRutaQRCreado.Name = "txtRutaQRCreado";
            this.txtRutaQRCreado.ReadOnly = true;
            this.txtRutaQRCreado.Size = new System.Drawing.Size(171, 20);
            this.txtRutaQRCreado.TabIndex = 131;
            // 
            // txtFotoUserAgregada
            // 
            this.txtFotoUserAgregada.Location = new System.Drawing.Point(451, 23);
            this.txtFotoUserAgregada.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFotoUserAgregada.Name = "txtFotoUserAgregada";
            this.txtFotoUserAgregada.ReadOnly = true;
            this.txtFotoUserAgregada.Size = new System.Drawing.Size(171, 20);
            this.txtFotoUserAgregada.TabIndex = 130;
            // 
            // btnCrearQR
            // 
            this.btnCrearQR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnCrearQR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearQR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCrearQR.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearQR.ForeColor = System.Drawing.Color.White;
            this.btnCrearQR.Location = new System.Drawing.Point(532, 355);
            this.btnCrearQR.Name = "btnCrearQR";
            this.btnCrearQR.Size = new System.Drawing.Size(143, 27);
            this.btnCrearQR.TabIndex = 129;
            this.btnCrearQR.Text = "Crear Código QR";
            this.btnCrearQR.UseVisualStyleBackColor = false;
            this.btnCrearQR.Click += new System.EventHandler(this.btnCrearQR_Click);
            // 
            // btnAgregarfotoUser
            // 
            this.btnAgregarfotoUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnAgregarfotoUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarfotoUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarfotoUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarfotoUser.ForeColor = System.Drawing.Color.White;
            this.btnAgregarfotoUser.Location = new System.Drawing.Point(479, 85);
            this.btnAgregarfotoUser.Name = "btnAgregarfotoUser";
            this.btnAgregarfotoUser.Size = new System.Drawing.Size(164, 30);
            this.btnAgregarfotoUser.TabIndex = 128;
            this.btnAgregarfotoUser.Text = "Agregar Imagen";
            this.btnAgregarfotoUser.UseVisualStyleBackColor = false;
            this.btnAgregarfotoUser.Click += new System.EventHandler(this.btnAgregarfotoUser_Click);
            // 
            // btnGuardarQR
            // 
            this.btnGuardarQR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnGuardarQR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarQR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardarQR.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarQR.ForeColor = System.Drawing.Color.White;
            this.btnGuardarQR.Location = new System.Drawing.Point(412, 355);
            this.btnGuardarQR.Name = "btnGuardarQR";
            this.btnGuardarQR.Size = new System.Drawing.Size(114, 27);
            this.btnGuardarQR.TabIndex = 127;
            this.btnGuardarQR.Text = "Guardar QR";
            this.btnGuardarQR.UseVisualStyleBackColor = false;
            this.btnGuardarQR.Click += new System.EventHandler(this.btnGuardarQR_Click);
            // 
            // btnAgregarUser
            // 
            this.btnAgregarUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnAgregarUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarUser.ForeColor = System.Drawing.Color.White;
            this.btnAgregarUser.Location = new System.Drawing.Point(248, 355);
            this.btnAgregarUser.Name = "btnAgregarUser";
            this.btnAgregarUser.Size = new System.Drawing.Size(120, 27);
            this.btnAgregarUser.TabIndex = 126;
            this.btnAgregarUser.Text = "Agregar";
            this.btnAgregarUser.UseVisualStyleBackColor = false;
            this.btnAgregarUser.Click += new System.EventHandler(this.btnAgregarUser_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegresar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(15, 355);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(102, 27);
            this.btnRegresar.TabIndex = 125;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel15.Location = new System.Drawing.Point(479, 162);
            this.panel15.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(10, 18);
            this.panel15.TabIndex = 124;
            // 
            // lblQradd
            // 
            this.lblQradd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.lblQradd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblQradd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQradd.ForeColor = System.Drawing.Color.White;
            this.lblQradd.Location = new System.Drawing.Point(486, 162);
            this.lblQradd.Name = "lblQradd";
            this.lblQradd.Size = new System.Drawing.Size(157, 18);
            this.lblQradd.TabIndex = 123;
            this.lblQradd.Text = "  Código QR";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel14.Location = new System.Drawing.Point(479, 55);
            this.panel14.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(10, 18);
            this.panel14.TabIndex = 122;
            // 
            // lblfotoadd
            // 
            this.lblfotoadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.lblfotoadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblfotoadd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfotoadd.ForeColor = System.Drawing.Color.White;
            this.lblfotoadd.Location = new System.Drawing.Point(486, 55);
            this.lblfotoadd.Name = "lblfotoadd";
            this.lblfotoadd.Size = new System.Drawing.Size(157, 18);
            this.lblfotoadd.TabIndex = 121;
            this.lblfotoadd.Text = "  Fotografía";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel13.Location = new System.Drawing.Point(251, 267);
            this.panel13.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(10, 18);
            this.panel13.TabIndex = 120;
            // 
            // lblteladd
            // 
            this.lblteladd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.lblteladd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblteladd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblteladd.ForeColor = System.Drawing.Color.White;
            this.lblteladd.Location = new System.Drawing.Point(258, 267);
            this.lblteladd.Name = "lblteladd";
            this.lblteladd.Size = new System.Drawing.Size(164, 18);
            this.lblteladd.TabIndex = 119;
            this.lblteladd.Text = "  Teléfono +503[2,6,7]";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel12.Location = new System.Drawing.Point(251, 160);
            this.panel12.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(10, 18);
            this.panel12.TabIndex = 118;
            // 
            // lblInstitucionAdd
            // 
            this.lblInstitucionAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.lblInstitucionAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInstitucionAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstitucionAdd.ForeColor = System.Drawing.Color.White;
            this.lblInstitucionAdd.Location = new System.Drawing.Point(258, 160);
            this.lblInstitucionAdd.Name = "lblInstitucionAdd";
            this.lblInstitucionAdd.Size = new System.Drawing.Size(164, 18);
            this.lblInstitucionAdd.TabIndex = 117;
            this.lblInstitucionAdd.Text = "  Institución";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel11.Location = new System.Drawing.Point(251, 60);
            this.panel11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(10, 18);
            this.panel11.TabIndex = 116;
            // 
            // lblCorreoAdd
            // 
            this.lblCorreoAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.lblCorreoAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCorreoAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoAdd.ForeColor = System.Drawing.Color.White;
            this.lblCorreoAdd.Location = new System.Drawing.Point(258, 60);
            this.lblCorreoAdd.Name = "lblCorreoAdd";
            this.lblCorreoAdd.Size = new System.Drawing.Size(164, 18);
            this.lblCorreoAdd.TabIndex = 115;
            this.lblCorreoAdd.Text = "  Correo";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel10.Location = new System.Drawing.Point(59, 267);
            this.panel10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(10, 18);
            this.panel10.TabIndex = 114;
            // 
            // lblDireccionAdd
            // 
            this.lblDireccionAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.lblDireccionAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDireccionAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionAdd.ForeColor = System.Drawing.Color.White;
            this.lblDireccionAdd.Location = new System.Drawing.Point(66, 267);
            this.lblDireccionAdd.Name = "lblDireccionAdd";
            this.lblDireccionAdd.Size = new System.Drawing.Size(164, 18);
            this.lblDireccionAdd.TabIndex = 113;
            this.lblDireccionAdd.Text = "  Dirección";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel9.Location = new System.Drawing.Point(60, 160);
            this.panel9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(10, 18);
            this.panel9.TabIndex = 112;
            // 
            // lblOcupacionAdd
            // 
            this.lblOcupacionAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.lblOcupacionAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOcupacionAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcupacionAdd.ForeColor = System.Drawing.Color.White;
            this.lblOcupacionAdd.Location = new System.Drawing.Point(67, 160);
            this.lblOcupacionAdd.Name = "lblOcupacionAdd";
            this.lblOcupacionAdd.Size = new System.Drawing.Size(164, 18);
            this.lblOcupacionAdd.TabIndex = 111;
            this.lblOcupacionAdd.Text = "  Ocupación";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel8.Location = new System.Drawing.Point(60, 60);
            this.panel8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 18);
            this.panel8.TabIndex = 110;
            // 
            // lblNombreIng
            // 
            this.lblNombreIng.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.lblNombreIng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombreIng.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreIng.ForeColor = System.Drawing.Color.White;
            this.lblNombreIng.Location = new System.Drawing.Point(67, 60);
            this.lblNombreIng.Name = "lblNombreIng";
            this.lblNombreIng.Size = new System.Drawing.Size(164, 18);
            this.lblNombreIng.TabIndex = 109;
            this.lblNombreIng.Text = "  Nombre";
            // 
            // picQR
            // 
            this.picQR.BackColor = System.Drawing.Color.Transparent;
            this.picQR.Location = new System.Drawing.Point(510, 213);
            this.picQR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picQR.MaximumSize = new System.Drawing.Size(112, 122);
            this.picQR.MinimumSize = new System.Drawing.Size(112, 122);
            this.picQR.Name = "picQR";
            this.picQR.Size = new System.Drawing.Size(112, 122);
            this.picQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picQR.TabIndex = 19;
            this.picQR.TabStop = false;
            // 
            // txtTelefonoUsuario
            // 
            this.txtTelefonoUsuario.Location = new System.Drawing.Point(251, 287);
            this.txtTelefonoUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTelefonoUsuario.Name = "txtTelefonoUsuario";
            this.txtTelefonoUsuario.Size = new System.Drawing.Size(171, 20);
            this.txtTelefonoUsuario.TabIndex = 13;
            // 
            // txtInstitucionUsuario
            // 
            this.txtInstitucionUsuario.Location = new System.Drawing.Point(251, 187);
            this.txtInstitucionUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInstitucionUsuario.Name = "txtInstitucionUsuario";
            this.txtInstitucionUsuario.Size = new System.Drawing.Size(171, 20);
            this.txtInstitucionUsuario.TabIndex = 12;
            // 
            // txtCorreoUsuario
            // 
            this.txtCorreoUsuario.Location = new System.Drawing.Point(251, 80);
            this.txtCorreoUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCorreoUsuario.Name = "txtCorreoUsuario";
            this.txtCorreoUsuario.Size = new System.Drawing.Size(171, 20);
            this.txtCorreoUsuario.TabIndex = 11;
            // 
            // txtDireccionUsuario
            // 
            this.txtDireccionUsuario.Location = new System.Drawing.Point(59, 287);
            this.txtDireccionUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDireccionUsuario.Name = "txtDireccionUsuario";
            this.txtDireccionUsuario.Size = new System.Drawing.Size(171, 20);
            this.txtDireccionUsuario.TabIndex = 10;
            // 
            // txtOcupacionUsuario
            // 
            this.txtOcupacionUsuario.Location = new System.Drawing.Point(61, 187);
            this.txtOcupacionUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOcupacionUsuario.Name = "txtOcupacionUsuario";
            this.txtOcupacionUsuario.Size = new System.Drawing.Size(171, 20);
            this.txtOcupacionUsuario.TabIndex = 9;
            // 
            // txtNombreNuevoUsuario
            // 
            this.txtNombreNuevoUsuario.Location = new System.Drawing.Point(61, 80);
            this.txtNombreNuevoUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreNuevoUsuario.Name = "txtNombreNuevoUsuario";
            this.txtNombreNuevoUsuario.Size = new System.Drawing.Size(171, 20);
            this.txtNombreNuevoUsuario.TabIndex = 8;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.panel16.Controls.Add(this.lblAreas);
            this.panel16.Controls.Add(this.panel17);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel16.Location = new System.Drawing.Point(0, 0);
            this.panel16.Margin = new System.Windows.Forms.Padding(2);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(704, 47);
            this.panel16.TabIndex = 74;
            // 
            // lblAreas
            // 
            this.lblAreas.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAreas.Location = new System.Drawing.Point(278, 0);
            this.lblAreas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAreas.Name = "lblAreas";
            this.lblAreas.Size = new System.Drawing.Size(173, 41);
            this.lblAreas.TabIndex = 1;
            this.lblAreas.Text = "USUARIOS";
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel17.Location = new System.Drawing.Point(0, 42);
            this.panel17.Margin = new System.Windows.Forms.Padding(2);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(716, 10);
            this.panel17.TabIndex = 40;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel18.Location = new System.Drawing.Point(600, 95);
            this.panel18.Margin = new System.Windows.Forms.Padding(2);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(12, 41);
            this.panel18.TabIndex = 111;
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel19.Location = new System.Drawing.Point(532, 355);
            this.panel19.Margin = new System.Windows.Forms.Padding(2);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(10, 27);
            this.panel19.TabIndex = 132;
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel20.Location = new System.Drawing.Point(248, 355);
            this.panel20.Margin = new System.Windows.Forms.Padding(2);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(12, 27);
            this.panel20.TabIndex = 133;
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel21.Location = new System.Drawing.Point(15, 355);
            this.panel21.Margin = new System.Windows.Forms.Padding(2);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(12, 27);
            this.panel21.TabIndex = 134;
            // 
            // panel22
            // 
            this.panel22.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel22.Location = new System.Drawing.Point(412, 355);
            this.panel22.Margin = new System.Windows.Forms.Padding(2);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(10, 27);
            this.panel22.TabIndex = 135;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(704, 474);
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.tbcUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmUsuario";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.tbcUsuarios.ResumeLayout(false);
            this.tbpRegistrarIngreso.ResumeLayout(false);
            this.tbpRegistrarIngreso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresoSalidaUsuarios)).EndInit();
            this.tbpRegistrarUsuario.ResumeLayout(false);
            this.tbpRegistrarUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).EndInit();
            this.panel16.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.TextBox txtNombreNuevoUsuario;
        private System.Windows.Forms.TextBox txtOcupacionUsuario;
        private System.Windows.Forms.TextBox txtDireccionUsuario;
        private System.Windows.Forms.TextBox txtCorreoUsuario;
        private System.Windows.Forms.TextBox txtInstitucionUsuario;
        private System.Windows.Forms.TextBox txtTelefonoUsuario;

        private System.Windows.Forms.ComboBox cmbAreaingreso;
        private System.Windows.Forms.ComboBox cmbAreasalida;
        private System.Windows.Forms.TextBox txtIdingreso;
        private System.Windows.Forms.TextBox txtidsalida;

        private System.Windows.Forms.TabControl tbcUsuarios;
        private System.Windows.Forms.TabPage tbpRegistrarIngreso;
        private System.Windows.Forms.TabPage tbpRegistrarUsuario;

        #endregion

        private System.Windows.Forms.PictureBox picQR;
        private System.Windows.Forms.DataGridView dgvIngresoSalidaUsuarios;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblareasalida;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblAreaingreso;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblIduser;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblIduser2;
        private System.Windows.Forms.Button btnCambiarPestaña;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.TextBox txtRutaQRCreado;
        private System.Windows.Forms.TextBox txtFotoUserAgregada;
        private System.Windows.Forms.Button btnCrearQR;
        private System.Windows.Forms.Button btnAgregarfotoUser;
        private System.Windows.Forms.Button btnGuardarQR;
        private System.Windows.Forms.Button btnAgregarUser;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label lblQradd;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label lblfotoadd;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label lblteladd;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label lblInstitucionAdd;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label lblCorreoAdd;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label lblDireccionAdd;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblOcupacionAdd;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblNombreIng;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label lblAreas;
        private System.Windows.Forms.Panel panel17;
    }
}