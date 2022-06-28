using System.ComponentModel;

namespace FormPrincipal
{
    partial class Colecciones
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
            this.btnActualizar2 = new System.Windows.Forms.Button();
            this.lblIDcoleccion = new System.Windows.Forms.Label();
            this.txtIDcoleccion = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dgvColeccion = new System.Windows.Forms.DataGridView();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblPiso = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNombe = new System.Windows.Forms.TextBox();
            this.pnlEliminar = new System.Windows.Forms.Panel();
            this.pnlMostrar = new System.Windows.Forms.Panel();
            this.pnlActualizar = new System.Windows.Forms.Panel();
            this.pnlAgregar = new System.Windows.Forms.Panel();
            this.pnlDataGridView = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbIDgenero = new System.Windows.Forms.ComboBox();
            this.cmbIDtipo = new System.Windows.Forms.ComboBox();
            this.cmbPiso = new System.Windows.Forms.ComboBox();
            this.pnlNombre = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize) (this.dgvColeccion)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblColecciones
            // 
            this.lblColecciones.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblColecciones.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblColecciones.Location = new System.Drawing.Point(246, 0);
            this.lblColecciones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblColecciones.Name = "lblColecciones";
            this.lblColecciones.Size = new System.Drawing.Size(253, 40);
            this.lblColecciones.TabIndex = 1;
            this.lblColecciones.Text = "COLECCIONES";
            // 
            // btnActualizar2
            // 
            this.btnActualizar2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            this.btnActualizar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizar2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnActualizar2.ForeColor = System.Drawing.Color.White;
            this.btnActualizar2.Location = new System.Drawing.Point(286, 348);
            this.btnActualizar2.Name = "btnActualizar2";
            this.btnActualizar2.Size = new System.Drawing.Size(135, 32);
            this.btnActualizar2.TabIndex = 34;
            this.btnActualizar2.Text = "Actualizar";
            this.btnActualizar2.UseVisualStyleBackColor = false;
            this.btnActualizar2.Click += new System.EventHandler(this.btnActualizar2_Click);
            // 
            // lblIDcoleccion
            // 
            this.lblIDcoleccion.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            this.lblIDcoleccion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblIDcoleccion.ForeColor = System.Drawing.Color.White;
            this.lblIDcoleccion.Location = new System.Drawing.Point(482, 357);
            this.lblIDcoleccion.Name = "lblIDcoleccion";
            this.lblIDcoleccion.Size = new System.Drawing.Size(148, 35);
            this.lblIDcoleccion.TabIndex = 33;
            this.lblIDcoleccion.Text = "   ID coleccion \r\n   (eliminar o editar)";
            // 
            // txtIDcoleccion
            // 
            this.txtIDcoleccion.BackColor = System.Drawing.Color.Gainsboro;
            this.txtIDcoleccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDcoleccion.ForeColor = System.Drawing.Color.Black;
            this.txtIDcoleccion.Location = new System.Drawing.Point(479, 403);
            this.txtIDcoleccion.Name = "txtIDcoleccion";
            this.txtIDcoleccion.Size = new System.Drawing.Size(199, 20);
            this.txtIDcoleccion.TabIndex = 32;
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            this.lblNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(479, 100);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(199, 18);
            this.lblNombre.TabIndex = 31;
            this.lblNombre.Text = "    Nombre";
            // 
            // dgvColeccion
            // 
            this.dgvColeccion.AllowUserToAddRows = false;
            this.dgvColeccion.AllowUserToDeleteRows = false;
            this.dgvColeccion.AllowUserToResizeColumns = false;
            this.dgvColeccion.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.dgvColeccion.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvColeccion.BackgroundColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            this.dgvColeccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvColeccion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvColeccion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvColeccion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvColeccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvColeccion.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvColeccion.EnableHeadersVisualStyles = false;
            this.dgvColeccion.GridColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            this.dgvColeccion.Location = new System.Drawing.Point(32, 86);
            this.dgvColeccion.Name = "dgvColeccion";
            this.dgvColeccion.ReadOnly = true;
            this.dgvColeccion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvColeccion.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvColeccion.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            this.dgvColeccion.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvColeccion.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            this.dgvColeccion.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvColeccion.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            this.dgvColeccion.RowTemplate.ReadOnly = true;
            this.dgvColeccion.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvColeccion.Size = new System.Drawing.Size(389, 239);
            this.dgvColeccion.TabIndex = 30;
            // 
            // lblGenero
            // 
            this.lblGenero.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            this.lblGenero.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblGenero.ForeColor = System.Drawing.Color.White;
            this.lblGenero.Location = new System.Drawing.Point(479, 160);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(199, 18);
            this.lblGenero.TabIndex = 29;
            this.lblGenero.Text = "   ID Genero";
            // 
            // lblTipo
            // 
            this.lblTipo.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            this.lblTipo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblTipo.ForeColor = System.Drawing.Color.White;
            this.lblTipo.Location = new System.Drawing.Point(479, 222);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(199, 18);
            this.lblTipo.TabIndex = 28;
            this.lblTipo.Text = "   ID Tipo";
            // 
            // lblPiso
            // 
            this.lblPiso.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            this.lblPiso.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblPiso.ForeColor = System.Drawing.Color.White;
            this.lblPiso.Location = new System.Drawing.Point(479, 284);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(199, 18);
            this.lblPiso.TabIndex = 27;
            this.lblPiso.Text = "  Numero de piso";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(286, 395);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(135, 32);
            this.btnActualizar.TabIndex = 26;
            this.btnActualizar.Text = "Mostrar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(32, 395);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(135, 32);
            this.btnEliminar.TabIndex = 25;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregar.Location = new System.Drawing.Point(29, 348);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(135, 32);
            this.btnAgregar.TabIndex = 24;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNombe
            // 
            this.txtNombe.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNombe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombe.ForeColor = System.Drawing.Color.Black;
            this.txtNombe.Location = new System.Drawing.Point(479, 121);
            this.txtNombe.Name = "txtNombe";
            this.txtNombe.Size = new System.Drawing.Size(199, 20);
            this.txtNombe.TabIndex = 20;
            // 
            // pnlEliminar
            // 
            this.pnlEliminar.BackColor = System.Drawing.Color.DarkTurquoise;
            this.pnlEliminar.Location = new System.Drawing.Point(29, 395);
            this.pnlEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.pnlEliminar.Name = "pnlEliminar";
            this.pnlEliminar.Size = new System.Drawing.Size(7, 32);
            this.pnlEliminar.TabIndex = 35;
            // 
            // pnlMostrar
            // 
            this.pnlMostrar.BackColor = System.Drawing.Color.DarkTurquoise;
            this.pnlMostrar.Location = new System.Drawing.Point(286, 395);
            this.pnlMostrar.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMostrar.Name = "pnlMostrar";
            this.pnlMostrar.Size = new System.Drawing.Size(7, 32);
            this.pnlMostrar.TabIndex = 36;
            // 
            // pnlActualizar
            // 
            this.pnlActualizar.BackColor = System.Drawing.Color.DarkTurquoise;
            this.pnlActualizar.Location = new System.Drawing.Point(286, 348);
            this.pnlActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.pnlActualizar.Name = "pnlActualizar";
            this.pnlActualizar.Size = new System.Drawing.Size(7, 32);
            this.pnlActualizar.TabIndex = 37;
            // 
            // pnlAgregar
            // 
            this.pnlAgregar.BackColor = System.Drawing.Color.DarkTurquoise;
            this.pnlAgregar.Location = new System.Drawing.Point(29, 348);
            this.pnlAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAgregar.Name = "pnlAgregar";
            this.pnlAgregar.Size = new System.Drawing.Size(7, 32);
            this.pnlAgregar.TabIndex = 38;
            // 
            // pnlDataGridView
            // 
            this.pnlDataGridView.BackColor = System.Drawing.Color.DarkTurquoise;
            this.pnlDataGridView.Location = new System.Drawing.Point(26, 86);
            this.pnlDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDataGridView.Name = "pnlDataGridView";
            this.pnlDataGridView.Size = new System.Drawing.Size(10, 239);
            this.pnlDataGridView.TabIndex = 39;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(716, 10);
            this.panel2.TabIndex = 40;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            this.panel3.Controls.Add(this.lblColecciones);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(-12, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(722, 47);
            this.panel3.TabIndex = 41;
            // 
            // cmbIDgenero
            // 
            this.cmbIDgenero.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            this.cmbIDgenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIDgenero.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbIDgenero.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cmbIDgenero.ForeColor = System.Drawing.Color.White;
            this.cmbIDgenero.FormattingEnabled = true;
            this.cmbIDgenero.Location = new System.Drawing.Point(479, 181);
            this.cmbIDgenero.Name = "cmbIDgenero";
            this.cmbIDgenero.Size = new System.Drawing.Size(199, 25);
            this.cmbIDgenero.TabIndex = 42;
            // 
            // cmbIDtipo
            // 
            this.cmbIDtipo.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            this.cmbIDtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIDtipo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbIDtipo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cmbIDtipo.ForeColor = System.Drawing.Color.White;
            this.cmbIDtipo.FormattingEnabled = true;
            this.cmbIDtipo.Location = new System.Drawing.Point(479, 243);
            this.cmbIDtipo.Name = "cmbIDtipo";
            this.cmbIDtipo.Size = new System.Drawing.Size(199, 25);
            this.cmbIDtipo.TabIndex = 43;
            // 
            // cmbPiso
            // 
            this.cmbPiso.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (4)))), ((int) (((byte) (41)))), ((int) (((byte) (68)))));
            this.cmbPiso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPiso.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbPiso.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cmbPiso.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmbPiso.FormattingEnabled = true;
            this.cmbPiso.Items.AddRange(new object[] {"1", "2", "3", "4"});
            this.cmbPiso.Location = new System.Drawing.Point(479, 307);
            this.cmbPiso.Name = "cmbPiso";
            this.cmbPiso.Size = new System.Drawing.Size(199, 25);
            this.cmbPiso.TabIndex = 44;
            // 
            // pnlNombre
            // 
            this.pnlNombre.BackColor = System.Drawing.Color.DarkTurquoise;
            this.pnlNombre.Location = new System.Drawing.Point(479, 100);
            this.pnlNombre.Margin = new System.Windows.Forms.Padding(2);
            this.pnlNombre.Name = "pnlNombre";
            this.pnlNombre.Size = new System.Drawing.Size(10, 18);
            this.pnlNombre.TabIndex = 38;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Location = new System.Drawing.Point(479, 160);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 18);
            this.panel1.TabIndex = 39;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel4.Location = new System.Drawing.Point(479, 222);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 18);
            this.panel4.TabIndex = 45;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel5.Location = new System.Drawing.Point(479, 284);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 18);
            this.panel5.TabIndex = 46;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel6.Location = new System.Drawing.Point(479, 357);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 35);
            this.panel6.TabIndex = 47;
            // 
            // Colecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 474);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlNombre);
            this.Controls.Add(this.cmbPiso);
            this.Controls.Add(this.cmbIDtipo);
            this.Controls.Add(this.cmbIDgenero);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlDataGridView);
            this.Controls.Add(this.pnlAgregar);
            this.Controls.Add(this.pnlActualizar);
            this.Controls.Add(this.pnlMostrar);
            this.Controls.Add(this.pnlEliminar);
            this.Controls.Add(this.btnActualizar2);
            this.Controls.Add(this.lblIDcoleccion);
            this.Controls.Add(this.txtIDcoleccion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dgvColeccion);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblPiso);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Colecciones";
            this.Text = "Colecciones";
            this.Load += new System.EventHandler(this.Colecciones_Load);
            ((System.ComponentModel.ISupportInitialize) (this.dgvColeccion)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel panel6;

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Panel pnlNombre;

        private System.Windows.Forms.ComboBox cmbPiso;

        private System.Windows.Forms.ComboBox cmbIDtipo;

        private System.Windows.Forms.ComboBox cmbIDgenero;

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;

        private System.Windows.Forms.Panel pnlEliminar;
        private System.Windows.Forms.Panel pnlMostrar;
        private System.Windows.Forms.Panel pnlActualizar;
        private System.Windows.Forms.Panel pnlAgregar;
        private System.Windows.Forms.Panel pnlDataGridView;

        private System.Windows.Forms.Button btnActualizar2;
        private System.Windows.Forms.Label lblIDcoleccion;
        private System.Windows.Forms.TextBox txtIDcoleccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView dgvColeccion;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNombe;

        private System.Windows.Forms.Label lblColecciones;

        #endregion
    }
}