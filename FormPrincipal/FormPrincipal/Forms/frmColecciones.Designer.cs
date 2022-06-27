using System.ComponentModel;

namespace FormPrincipal
{
    partial class frmColecciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblColecciones = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbColecciones = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNombre = new System.Windows.Forms.Panel();
            this.cmbPiso = new System.Windows.Forms.ComboBox();
            this.cmbIDtipo = new System.Windows.Forms.ComboBox();
            this.cmbIDgenero = new System.Windows.Forms.ComboBox();
            this.pnlDataGridView = new System.Windows.Forms.Panel();
            this.pnlAgregar = new System.Windows.Forms.Panel();
            this.pnlMostrar = new System.Windows.Forms.Panel();
            this.txtIDcoleccion = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dgvColeccion = new System.Windows.Forms.DataGridView();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblPiso = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNombe = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblPisoTextM = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblPisoM = new System.Windows.Forms.Label();
            this.panel27 = new System.Windows.Forms.Panel();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.panel43 = new System.Windows.Forms.Panel();
            this.btnEliminarVista = new System.Windows.Forms.Button();
            this.panel42 = new System.Windows.Forms.Panel();
            this.btnActualizarVista = new System.Windows.Forms.Button();
            this.lblColeccionTipoM = new System.Windows.Forms.Label();
            this.panel41 = new System.Windows.Forms.Panel();
            this.lblTipoColeccionM = new System.Windows.Forms.Label();
            this.lblColeccionTexto = new System.Windows.Forms.Label();
            this.lblColeccionTextoM = new System.Windows.Forms.Label();
            this.panel40 = new System.Windows.Forms.Panel();
            this.lblGeneroColeccionM = new System.Windows.Forms.Label();
            this.panel39 = new System.Windows.Forms.Panel();
            this.lblColeccionNombreM = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnActualizarColeccionesM = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.cmbNumeroPisoM = new System.Windows.Forms.ComboBox();
            this.cmbTipoM = new System.Windows.Forms.ComboBox();
            this.cmbGeneroM = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreColeccionesM = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.tbColecciones.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColeccion)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblColecciones
            // 
            this.lblColecciones.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColecciones.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblColecciones.Location = new System.Drawing.Point(278, 5);
            this.lblColecciones.Margin = new System.Windows.Forms.Padding(0);
            this.lblColecciones.Name = "lblColecciones";
            this.lblColecciones.Size = new System.Drawing.Size(187, 28);
            this.lblColecciones.TabIndex = 1;
            this.lblColecciones.Text = "COLECCIONES";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(716, 14);
            this.panel2.TabIndex = 40;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.panel3.Controls.Add(this.lblColecciones);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(-12, -2);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(716, 61);
            this.panel3.TabIndex = 41;
            // 
            // tbColecciones
            // 
            this.tbColecciones.Controls.Add(this.tabPage1);
            this.tbColecciones.Controls.Add(this.tabPage2);
            this.tbColecciones.Controls.Add(this.tabPage3);
            this.tbColecciones.Location = new System.Drawing.Point(1, 39);
            this.tbColecciones.Name = "tbColecciones";
            this.tbColecciones.SelectedIndex = 0;
            this.tbColecciones.Size = new System.Drawing.Size(702, 434);
            this.tbColecciones.TabIndex = 48;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.pnlNombre);
            this.tabPage1.Controls.Add(this.cmbPiso);
            this.tabPage1.Controls.Add(this.cmbIDtipo);
            this.tabPage1.Controls.Add(this.cmbIDgenero);
            this.tabPage1.Controls.Add(this.pnlDataGridView);
            this.tabPage1.Controls.Add(this.pnlAgregar);
            this.tabPage1.Controls.Add(this.pnlMostrar);
            this.tabPage1.Controls.Add(this.txtIDcoleccion);
            this.tabPage1.Controls.Add(this.lblNombre);
            this.tabPage1.Controls.Add(this.dgvColeccion);
            this.tabPage1.Controls.Add(this.lblGenero);
            this.tabPage1.Controls.Add(this.lblTipo);
            this.tabPage1.Controls.Add(this.lblPiso);
            this.tabPage1.Controls.Add(this.btnActualizar);
            this.tabPage1.Controls.Add(this.btnAgregar);
            this.tabPage1.Controls.Add(this.txtNombe);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(694, 408);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel5.Location = new System.Drawing.Point(474, 229);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 18);
            this.panel5.TabIndex = 71;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel4.Location = new System.Drawing.Point(474, 167);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 18);
            this.panel4.TabIndex = 70;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Location = new System.Drawing.Point(474, 105);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 18);
            this.panel1.TabIndex = 66;
            // 
            // pnlNombre
            // 
            this.pnlNombre.BackColor = System.Drawing.Color.DarkTurquoise;
            this.pnlNombre.Location = new System.Drawing.Point(474, 45);
            this.pnlNombre.Margin = new System.Windows.Forms.Padding(2);
            this.pnlNombre.Name = "pnlNombre";
            this.pnlNombre.Size = new System.Drawing.Size(10, 18);
            this.pnlNombre.TabIndex = 64;
            // 
            // cmbPiso
            // 
            this.cmbPiso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.cmbPiso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPiso.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbPiso.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPiso.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmbPiso.FormattingEnabled = true;
            this.cmbPiso.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbPiso.Location = new System.Drawing.Point(474, 252);
            this.cmbPiso.Name = "cmbPiso";
            this.cmbPiso.Size = new System.Drawing.Size(199, 25);
            this.cmbPiso.TabIndex = 69;
            // 
            // cmbIDtipo
            // 
            this.cmbIDtipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.cmbIDtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIDtipo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbIDtipo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIDtipo.ForeColor = System.Drawing.Color.White;
            this.cmbIDtipo.FormattingEnabled = true;
            this.cmbIDtipo.Location = new System.Drawing.Point(474, 188);
            this.cmbIDtipo.Name = "cmbIDtipo";
            this.cmbIDtipo.Size = new System.Drawing.Size(199, 25);
            this.cmbIDtipo.TabIndex = 68;
            // 
            // cmbIDgenero
            // 
            this.cmbIDgenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.cmbIDgenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIDgenero.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbIDgenero.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIDgenero.ForeColor = System.Drawing.Color.White;
            this.cmbIDgenero.FormattingEnabled = true;
            this.cmbIDgenero.Location = new System.Drawing.Point(474, 126);
            this.cmbIDgenero.Name = "cmbIDgenero";
            this.cmbIDgenero.Size = new System.Drawing.Size(199, 25);
            this.cmbIDgenero.TabIndex = 67;
            // 
            // pnlDataGridView
            // 
            this.pnlDataGridView.BackColor = System.Drawing.Color.DarkTurquoise;
            this.pnlDataGridView.Location = new System.Drawing.Point(14, 31);
            this.pnlDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDataGridView.Name = "pnlDataGridView";
            this.pnlDataGridView.Size = new System.Drawing.Size(10, 311);
            this.pnlDataGridView.TabIndex = 65;
            // 
            // pnlAgregar
            // 
            this.pnlAgregar.BackColor = System.Drawing.Color.DarkTurquoise;
            this.pnlAgregar.Location = new System.Drawing.Point(507, 310);
            this.pnlAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAgregar.Name = "pnlAgregar";
            this.pnlAgregar.Size = new System.Drawing.Size(7, 32);
            this.pnlAgregar.TabIndex = 63;
            // 
            // pnlMostrar
            // 
            this.pnlMostrar.BackColor = System.Drawing.Color.DarkTurquoise;
            this.pnlMostrar.Location = new System.Drawing.Point(163, 360);
            this.pnlMostrar.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMostrar.Name = "pnlMostrar";
            this.pnlMostrar.Size = new System.Drawing.Size(7, 32);
            this.pnlMostrar.TabIndex = 61;
            // 
            // txtIDcoleccion
            // 
            this.txtIDcoleccion.BackColor = System.Drawing.Color.Gainsboro;
            this.txtIDcoleccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDcoleccion.ForeColor = System.Drawing.Color.Black;
            this.txtIDcoleccion.Location = new System.Drawing.Point(474, 348);
            this.txtIDcoleccion.Name = "txtIDcoleccion";
            this.txtIDcoleccion.Size = new System.Drawing.Size(199, 20);
            this.txtIDcoleccion.TabIndex = 57;
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.lblNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(474, 45);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(199, 18);
            this.lblNombre.TabIndex = 56;
            this.lblNombre.Text = "    Nombre";
            // 
            // dgvColeccion
            // 
            this.dgvColeccion.AllowUserToAddRows = false;
            this.dgvColeccion.AllowUserToDeleteRows = false;
            this.dgvColeccion.AllowUserToResizeColumns = false;
            this.dgvColeccion.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvColeccion.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvColeccion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.dgvColeccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvColeccion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvColeccion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvColeccion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvColeccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvColeccion.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvColeccion.EnableHeadersVisualStyles = false;
            this.dgvColeccion.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.dgvColeccion.Location = new System.Drawing.Point(27, 31);
            this.dgvColeccion.Name = "dgvColeccion";
            this.dgvColeccion.ReadOnly = true;
            this.dgvColeccion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvColeccion.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvColeccion.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.dgvColeccion.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvColeccion.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.dgvColeccion.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvColeccion.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvColeccion.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dgvColeccion.RowTemplate.ReadOnly = true;
            this.dgvColeccion.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvColeccion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvColeccion.Size = new System.Drawing.Size(389, 311);
            this.dgvColeccion.TabIndex = 55;
            this.dgvColeccion.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvColeccion_CellContentDoubleClick);
            // 
            // lblGenero
            // 
            this.lblGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.lblGenero.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.ForeColor = System.Drawing.Color.White;
            this.lblGenero.Location = new System.Drawing.Point(474, 105);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(199, 18);
            this.lblGenero.TabIndex = 54;
            this.lblGenero.Text = "   Genero";
            // 
            // lblTipo
            // 
            this.lblTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.lblTipo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.White;
            this.lblTipo.Location = new System.Drawing.Point(474, 167);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(199, 18);
            this.lblTipo.TabIndex = 53;
            this.lblTipo.Text = "   Tipo";
            // 
            // lblPiso
            // 
            this.lblPiso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.lblPiso.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPiso.ForeColor = System.Drawing.Color.White;
            this.lblPiso.Location = new System.Drawing.Point(474, 229);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(199, 18);
            this.lblPiso.TabIndex = 52;
            this.lblPiso.Text = "  Numero de piso";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(163, 360);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(135, 32);
            this.btnActualizar.TabIndex = 51;
            this.btnActualizar.Text = "Mostrar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregar.Location = new System.Drawing.Point(507, 310);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(135, 32);
            this.btnAgregar.TabIndex = 49;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNombe
            // 
            this.txtNombe.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNombe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombe.ForeColor = System.Drawing.Color.Black;
            this.txtNombe.Location = new System.Drawing.Point(474, 66);
            this.txtNombe.Name = "txtNombe";
            this.txtNombe.Size = new System.Drawing.Size(199, 20);
            this.txtNombe.TabIndex = 48;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.lblPisoTextM);
            this.tabPage2.Controls.Add(this.panel6);
            this.tabPage2.Controls.Add(this.lblPisoM);
            this.tabPage2.Controls.Add(this.panel27);
            this.tabPage2.Controls.Add(this.btnRegresar);
            this.tabPage2.Controls.Add(this.panel43);
            this.tabPage2.Controls.Add(this.btnEliminarVista);
            this.tabPage2.Controls.Add(this.panel42);
            this.tabPage2.Controls.Add(this.btnActualizarVista);
            this.tabPage2.Controls.Add(this.lblColeccionTipoM);
            this.tabPage2.Controls.Add(this.panel41);
            this.tabPage2.Controls.Add(this.lblTipoColeccionM);
            this.tabPage2.Controls.Add(this.lblColeccionTexto);
            this.tabPage2.Controls.Add(this.lblColeccionTextoM);
            this.tabPage2.Controls.Add(this.panel40);
            this.tabPage2.Controls.Add(this.lblGeneroColeccionM);
            this.tabPage2.Controls.Add(this.panel39);
            this.tabPage2.Controls.Add(this.lblColeccionNombreM);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(694, 408);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // lblPisoTextM
            // 
            this.lblPisoTextM.BackColor = System.Drawing.Color.Transparent;
            this.lblPisoTextM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPisoTextM.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPisoTextM.ForeColor = System.Drawing.Color.Black;
            this.lblPisoTextM.Location = new System.Drawing.Point(263, 292);
            this.lblPisoTextM.Name = "lblPisoTextM";
            this.lblPisoTextM.Size = new System.Drawing.Size(199, 18);
            this.lblPisoTextM.TabIndex = 212;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel6.Location = new System.Drawing.Point(263, 260);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 18);
            this.panel6.TabIndex = 211;
            // 
            // lblPisoM
            // 
            this.lblPisoM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.lblPisoM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPisoM.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPisoM.ForeColor = System.Drawing.Color.White;
            this.lblPisoM.Location = new System.Drawing.Point(263, 260);
            this.lblPisoM.Name = "lblPisoM";
            this.lblPisoM.Size = new System.Drawing.Size(199, 18);
            this.lblPisoM.TabIndex = 210;
            this.lblPisoM.Text = "   Piso";
            this.lblPisoM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel27
            // 
            this.panel27.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel27.Location = new System.Drawing.Point(299, 343);
            this.panel27.Margin = new System.Windows.Forms.Padding(2);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(7, 35);
            this.panel27.TabIndex = 209;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegresar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(299, 343);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(135, 35);
            this.btnRegresar.TabIndex = 208;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // panel43
            // 
            this.panel43.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel43.Location = new System.Drawing.Point(112, 343);
            this.panel43.Margin = new System.Windows.Forms.Padding(2);
            this.panel43.Name = "panel43";
            this.panel43.Size = new System.Drawing.Size(7, 35);
            this.panel43.TabIndex = 206;
            // 
            // btnEliminarVista
            // 
            this.btnEliminarVista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnEliminarVista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarVista.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarVista.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarVista.ForeColor = System.Drawing.Color.White;
            this.btnEliminarVista.Location = new System.Drawing.Point(112, 343);
            this.btnEliminarVista.Name = "btnEliminarVista";
            this.btnEliminarVista.Size = new System.Drawing.Size(135, 35);
            this.btnEliminarVista.TabIndex = 205;
            this.btnEliminarVista.Text = "Eliminar";
            this.btnEliminarVista.UseVisualStyleBackColor = false;
            this.btnEliminarVista.Click += new System.EventHandler(this.btnEliminarVista_Click);
            // 
            // panel42
            // 
            this.panel42.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel42.Location = new System.Drawing.Point(481, 343);
            this.panel42.Margin = new System.Windows.Forms.Padding(2);
            this.panel42.Name = "panel42";
            this.panel42.Size = new System.Drawing.Size(7, 35);
            this.panel42.TabIndex = 204;
            // 
            // btnActualizarVista
            // 
            this.btnActualizarVista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnActualizarVista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarVista.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizarVista.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarVista.ForeColor = System.Drawing.Color.White;
            this.btnActualizarVista.Location = new System.Drawing.Point(481, 343);
            this.btnActualizarVista.Name = "btnActualizarVista";
            this.btnActualizarVista.Size = new System.Drawing.Size(135, 35);
            this.btnActualizarVista.TabIndex = 203;
            this.btnActualizarVista.Text = "Actualizar";
            this.btnActualizarVista.UseVisualStyleBackColor = false;
            this.btnActualizarVista.Click += new System.EventHandler(this.btnActualizarVista_Click);
            // 
            // lblColeccionTipoM
            // 
            this.lblColeccionTipoM.BackColor = System.Drawing.Color.Transparent;
            this.lblColeccionTipoM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblColeccionTipoM.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColeccionTipoM.ForeColor = System.Drawing.Color.Black;
            this.lblColeccionTipoM.Location = new System.Drawing.Point(263, 218);
            this.lblColeccionTipoM.Name = "lblColeccionTipoM";
            this.lblColeccionTipoM.Size = new System.Drawing.Size(199, 18);
            this.lblColeccionTipoM.TabIndex = 202;
            // 
            // panel41
            // 
            this.panel41.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel41.Location = new System.Drawing.Point(263, 186);
            this.panel41.Margin = new System.Windows.Forms.Padding(2);
            this.panel41.Name = "panel41";
            this.panel41.Size = new System.Drawing.Size(10, 18);
            this.panel41.TabIndex = 201;
            // 
            // lblTipoColeccionM
            // 
            this.lblTipoColeccionM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.lblTipoColeccionM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTipoColeccionM.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoColeccionM.ForeColor = System.Drawing.Color.White;
            this.lblTipoColeccionM.Location = new System.Drawing.Point(263, 186);
            this.lblTipoColeccionM.Name = "lblTipoColeccionM";
            this.lblTipoColeccionM.Size = new System.Drawing.Size(199, 18);
            this.lblTipoColeccionM.TabIndex = 200;
            this.lblTipoColeccionM.Text = "   Tipo";
            this.lblTipoColeccionM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblColeccionTexto
            // 
            this.lblColeccionTexto.BackColor = System.Drawing.Color.Transparent;
            this.lblColeccionTexto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblColeccionTexto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColeccionTexto.ForeColor = System.Drawing.Color.Black;
            this.lblColeccionTexto.Location = new System.Drawing.Point(266, 150);
            this.lblColeccionTexto.Name = "lblColeccionTexto";
            this.lblColeccionTexto.Size = new System.Drawing.Size(199, 18);
            this.lblColeccionTexto.TabIndex = 199;
            // 
            // lblColeccionTextoM
            // 
            this.lblColeccionTextoM.BackColor = System.Drawing.Color.Transparent;
            this.lblColeccionTextoM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblColeccionTextoM.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColeccionTextoM.ForeColor = System.Drawing.Color.Black;
            this.lblColeccionTextoM.Location = new System.Drawing.Point(263, 84);
            this.lblColeccionTextoM.Name = "lblColeccionTextoM";
            this.lblColeccionTextoM.Size = new System.Drawing.Size(199, 18);
            this.lblColeccionTextoM.TabIndex = 198;
            // 
            // panel40
            // 
            this.panel40.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel40.Location = new System.Drawing.Point(263, 118);
            this.panel40.Margin = new System.Windows.Forms.Padding(2);
            this.panel40.Name = "panel40";
            this.panel40.Size = new System.Drawing.Size(10, 18);
            this.panel40.TabIndex = 197;
            // 
            // lblGeneroColeccionM
            // 
            this.lblGeneroColeccionM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.lblGeneroColeccionM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGeneroColeccionM.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneroColeccionM.ForeColor = System.Drawing.Color.White;
            this.lblGeneroColeccionM.Location = new System.Drawing.Point(263, 118);
            this.lblGeneroColeccionM.Name = "lblGeneroColeccionM";
            this.lblGeneroColeccionM.Size = new System.Drawing.Size(199, 18);
            this.lblGeneroColeccionM.TabIndex = 196;
            this.lblGeneroColeccionM.Text = "   Genero";
            // 
            // panel39
            // 
            this.panel39.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel39.Location = new System.Drawing.Point(263, 51);
            this.panel39.Margin = new System.Windows.Forms.Padding(2);
            this.panel39.Name = "panel39";
            this.panel39.Size = new System.Drawing.Size(10, 18);
            this.panel39.TabIndex = 195;
            // 
            // lblColeccionNombreM
            // 
            this.lblColeccionNombreM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.lblColeccionNombreM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblColeccionNombreM.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColeccionNombreM.ForeColor = System.Drawing.Color.White;
            this.lblColeccionNombreM.Location = new System.Drawing.Point(263, 51);
            this.lblColeccionNombreM.Name = "lblColeccionNombreM";
            this.lblColeccionNombreM.Size = new System.Drawing.Size(199, 18);
            this.lblColeccionNombreM.TabIndex = 194;
            this.lblColeccionNombreM.Text = "   Nombre";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.panel11);
            this.tabPage3.Controls.Add(this.btnActualizarColeccionesM);
            this.tabPage3.Controls.Add(this.panel7);
            this.tabPage3.Controls.Add(this.panel8);
            this.tabPage3.Controls.Add(this.panel9);
            this.tabPage3.Controls.Add(this.panel10);
            this.tabPage3.Controls.Add(this.cmbNumeroPisoM);
            this.tabPage3.Controls.Add(this.cmbTipoM);
            this.tabPage3.Controls.Add(this.cmbGeneroM);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.txtNombreColeccionesM);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(694, 408);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel11.Location = new System.Drawing.Point(282, 341);
            this.panel11.Margin = new System.Windows.Forms.Padding(2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(7, 32);
            this.panel11.TabIndex = 85;
            // 
            // btnActualizarColeccionesM
            // 
            this.btnActualizarColeccionesM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnActualizarColeccionesM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarColeccionesM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizarColeccionesM.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarColeccionesM.ForeColor = System.Drawing.Color.White;
            this.btnActualizarColeccionesM.Location = new System.Drawing.Point(282, 341);
            this.btnActualizarColeccionesM.Name = "btnActualizarColeccionesM";
            this.btnActualizarColeccionesM.Size = new System.Drawing.Size(135, 32);
            this.btnActualizarColeccionesM.TabIndex = 84;
            this.btnActualizarColeccionesM.Text = "Actualizar";
            this.btnActualizarColeccionesM.UseVisualStyleBackColor = false;
            this.btnActualizarColeccionesM.Click += new System.EventHandler(this.btnActualizarColeccionesM_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel7.Location = new System.Drawing.Point(249, 260);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 18);
            this.panel7.TabIndex = 83;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel8.Location = new System.Drawing.Point(249, 191);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 18);
            this.panel8.TabIndex = 82;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel9.Location = new System.Drawing.Point(249, 119);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(10, 18);
            this.panel9.TabIndex = 78;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel10.Location = new System.Drawing.Point(249, 43);
            this.panel10.Margin = new System.Windows.Forms.Padding(2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(10, 18);
            this.panel10.TabIndex = 77;
            // 
            // cmbNumeroPisoM
            // 
            this.cmbNumeroPisoM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.cmbNumeroPisoM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumeroPisoM.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbNumeroPisoM.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNumeroPisoM.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmbNumeroPisoM.FormattingEnabled = true;
            this.cmbNumeroPisoM.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbNumeroPisoM.Location = new System.Drawing.Point(249, 292);
            this.cmbNumeroPisoM.Name = "cmbNumeroPisoM";
            this.cmbNumeroPisoM.Size = new System.Drawing.Size(199, 25);
            this.cmbNumeroPisoM.TabIndex = 81;
            // 
            // cmbTipoM
            // 
            this.cmbTipoM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.cmbTipoM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoM.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbTipoM.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoM.ForeColor = System.Drawing.Color.White;
            this.cmbTipoM.FormattingEnabled = true;
            this.cmbTipoM.Location = new System.Drawing.Point(252, 214);
            this.cmbTipoM.Name = "cmbTipoM";
            this.cmbTipoM.Size = new System.Drawing.Size(199, 25);
            this.cmbTipoM.TabIndex = 80;
            // 
            // cmbGeneroM
            // 
            this.cmbGeneroM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.cmbGeneroM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGeneroM.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbGeneroM.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGeneroM.ForeColor = System.Drawing.Color.White;
            this.cmbGeneroM.FormattingEnabled = true;
            this.cmbGeneroM.Location = new System.Drawing.Point(249, 150);
            this.cmbGeneroM.Name = "cmbGeneroM";
            this.cmbGeneroM.Size = new System.Drawing.Size(199, 25);
            this.cmbGeneroM.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(249, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 18);
            this.label3.TabIndex = 76;
            this.label3.Text = "    Nombre";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(249, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 18);
            this.label4.TabIndex = 75;
            this.label4.Text = "   Genero";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(249, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 18);
            this.label5.TabIndex = 74;
            this.label5.Text = "   Tipo";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(249, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 18);
            this.label6.TabIndex = 73;
            this.label6.Text = "  Numero de piso";
            // 
            // txtNombreColeccionesM
            // 
            this.txtNombreColeccionesM.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNombreColeccionesM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreColeccionesM.ForeColor = System.Drawing.Color.Black;
            this.txtNombreColeccionesM.Location = new System.Drawing.Point(249, 74);
            this.txtNombreColeccionesM.Name = "txtNombreColeccionesM";
            this.txtNombreColeccionesM.Size = new System.Drawing.Size(199, 20);
            this.txtNombreColeccionesM.TabIndex = 72;
            // 
            // frmColecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 474);
            this.Controls.Add(this.tbColecciones);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmColecciones";
            this.Text = "Colecciones";
            this.Load += new System.EventHandler(this.Colecciones_Load);
            this.panel3.ResumeLayout(false);
            this.tbColecciones.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColeccion)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;

        private System.Windows.Forms.Label lblColecciones;

        #endregion

        private System.Windows.Forms.TabControl tbColecciones;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlNombre;
        private System.Windows.Forms.ComboBox cmbPiso;
        private System.Windows.Forms.ComboBox cmbIDtipo;
        private System.Windows.Forms.ComboBox cmbIDgenero;
        private System.Windows.Forms.Panel pnlDataGridView;
        private System.Windows.Forms.Panel pnlAgregar;
        private System.Windows.Forms.Panel pnlMostrar;
        private System.Windows.Forms.TextBox txtIDcoleccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView dgvColeccion;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNombe;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Panel panel43;
        private System.Windows.Forms.Button btnEliminarVista;
        private System.Windows.Forms.Panel panel42;
        private System.Windows.Forms.Button btnActualizarVista;
        private System.Windows.Forms.Label lblColeccionTipoM;
        private System.Windows.Forms.Panel panel41;
        private System.Windows.Forms.Label lblTipoColeccionM;
        private System.Windows.Forms.Label lblColeccionTexto;
        private System.Windows.Forms.Label lblColeccionTextoM;
        private System.Windows.Forms.Panel panel40;
        private System.Windows.Forms.Label lblGeneroColeccionM;
        private System.Windows.Forms.Panel panel39;
        private System.Windows.Forms.Label lblColeccionNombreM;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnActualizarColeccionesM;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ComboBox cmbNumeroPisoM;
        private System.Windows.Forms.ComboBox cmbTipoM;
        private System.Windows.Forms.ComboBox cmbGeneroM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombreColeccionesM;
        private System.Windows.Forms.Label lblPisoTextM;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblPisoM;
    }
}