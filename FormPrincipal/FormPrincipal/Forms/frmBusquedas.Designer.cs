using System.ComponentModel;

namespace FormPrincipal
{
    partial class frmBusquedas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBusquedas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblColecciones = new System.Windows.Forms.Label();
            this.tbBusquedas = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbBusquedas = new System.Windows.Forms.ComboBox();
            this.picBusquedasBtn = new System.Windows.Forms.PictureBox();
            this.pnlEjemplaresDGV = new System.Windows.Forms.Panel();
            this.dgvBusquedasEjemplares = new System.Windows.Forms.DataGridView();
            this.txtBusquedas = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel27 = new System.Windows.Forms.Panel();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lblAutorTexto = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAutorTitulo = new System.Windows.Forms.Label();
            this.lblGeneroTexto = new System.Windows.Forms.Label();
            this.panel41 = new System.Windows.Forms.Panel();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblColeccionTexto = new System.Windows.Forms.Label();
            this.lblTituloTexto = new System.Windows.Forms.Label();
            this.panel40 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel39 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.picPortada = new System.Windows.Forms.PictureBox();
            this.ttpBusquedas = new System.Windows.Forms.ToolTip(this.components);
            this.panel3.SuspendLayout();
            this.tbBusquedas.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBusquedasBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusquedasEjemplares)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPortada)).BeginInit();
            this.SuspendLayout();
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
            this.panel3.Location = new System.Drawing.Point(-6, -2);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(716, 43);
            this.panel3.TabIndex = 92;
            // 
            // lblColecciones
            // 
            this.lblColecciones.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColecciones.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblColecciones.Location = new System.Drawing.Point(278, 5);
            this.lblColecciones.Margin = new System.Windows.Forms.Padding(0);
            this.lblColecciones.Name = "lblColecciones";
            this.lblColecciones.Size = new System.Drawing.Size(154, 28);
            this.lblColecciones.TabIndex = 1;
            this.lblColecciones.Text = "BÚSQUEDAS";
            // 
            // tbBusquedas
            // 
            this.tbBusquedas.Controls.Add(this.tabPage1);
            this.tbBusquedas.Controls.Add(this.tabPage2);
            this.tbBusquedas.Location = new System.Drawing.Point(-3, 39);
            this.tbBusquedas.Name = "tbBusquedas";
            this.tbBusquedas.SelectedIndex = 0;
            this.tbBusquedas.Size = new System.Drawing.Size(710, 437);
            this.tbBusquedas.TabIndex = 99;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.cmbBusquedas);
            this.tabPage1.Controls.Add(this.picBusquedasBtn);
            this.tabPage1.Controls.Add(this.pnlEjemplaresDGV);
            this.tabPage1.Controls.Add(this.dgvBusquedasEjemplares);
            this.tabPage1.Controls.Add(this.txtBusquedas);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(702, 411);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // cmbBusquedas
            // 
            this.cmbBusquedas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.cmbBusquedas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBusquedas.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbBusquedas.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBusquedas.ForeColor = System.Drawing.Color.White;
            this.cmbBusquedas.FormattingEnabled = true;
            this.cmbBusquedas.Items.AddRange(new object[] {
            "Título completo",
            "Título parcial ",
            "Palabras clave",
            "Autor",
            "Formato"});
            this.cmbBusquedas.Location = new System.Drawing.Point(65, 24);
            this.cmbBusquedas.Name = "cmbBusquedas";
            this.cmbBusquedas.Size = new System.Drawing.Size(127, 25);
            this.cmbBusquedas.TabIndex = 103;
            // 
            // picBusquedasBtn
            // 
            this.picBusquedasBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBusquedasBtn.BackgroundImage")));
            this.picBusquedasBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBusquedasBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBusquedasBtn.Location = new System.Drawing.Point(596, 25);
            this.picBusquedasBtn.Name = "picBusquedasBtn";
            this.picBusquedasBtn.Size = new System.Drawing.Size(31, 21);
            this.picBusquedasBtn.TabIndex = 102;
            this.picBusquedasBtn.TabStop = false;
            this.picBusquedasBtn.Click += new System.EventHandler(this.picBusquedasBtn_Click);
            // 
            // pnlEjemplaresDGV
            // 
            this.pnlEjemplaresDGV.BackColor = System.Drawing.Color.DarkTurquoise;
            this.pnlEjemplaresDGV.Location = new System.Drawing.Point(65, 64);
            this.pnlEjemplaresDGV.Margin = new System.Windows.Forms.Padding(2);
            this.pnlEjemplaresDGV.Name = "pnlEjemplaresDGV";
            this.pnlEjemplaresDGV.Size = new System.Drawing.Size(10, 323);
            this.pnlEjemplaresDGV.TabIndex = 101;
            // 
            // dgvBusquedasEjemplares
            // 
            this.dgvBusquedasEjemplares.AllowUserToAddRows = false;
            this.dgvBusquedasEjemplares.AllowUserToDeleteRows = false;
            this.dgvBusquedasEjemplares.AllowUserToResizeColumns = false;
            this.dgvBusquedasEjemplares.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            this.dgvBusquedasEjemplares.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBusquedasEjemplares.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.dgvBusquedasEjemplares.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBusquedasEjemplares.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBusquedasEjemplares.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvBusquedasEjemplares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBusquedasEjemplares.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvBusquedasEjemplares.EnableHeadersVisualStyles = false;
            this.dgvBusquedasEjemplares.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.dgvBusquedasEjemplares.Location = new System.Drawing.Point(77, 64);
            this.dgvBusquedasEjemplares.Margin = new System.Windows.Forms.Padding(0);
            this.dgvBusquedasEjemplares.Name = "dgvBusquedasEjemplares";
            this.dgvBusquedasEjemplares.ReadOnly = true;
            this.dgvBusquedasEjemplares.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBusquedasEjemplares.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvBusquedasEjemplares.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.dgvBusquedasEjemplares.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvBusquedasEjemplares.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.dgvBusquedasEjemplares.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBusquedasEjemplares.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.dgvBusquedasEjemplares.RowTemplate.ReadOnly = true;
            this.dgvBusquedasEjemplares.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBusquedasEjemplares.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBusquedasEjemplares.Size = new System.Drawing.Size(560, 323);
            this.dgvBusquedasEjemplares.TabIndex = 100;
            this.dgvBusquedasEjemplares.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBusquedasEjemplares_CellContentDoubleClick);
            // 
            // txtBusquedas
            // 
            this.txtBusquedas.BackColor = System.Drawing.SystemColors.Control;
            this.txtBusquedas.Location = new System.Drawing.Point(198, 26);
            this.txtBusquedas.Name = "txtBusquedas";
            this.txtBusquedas.Size = new System.Drawing.Size(392, 20);
            this.txtBusquedas.TabIndex = 99;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.panel27);
            this.tabPage2.Controls.Add(this.btnRegresar);
            this.tabPage2.Controls.Add(this.lblAutorTexto);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.lblAutorTitulo);
            this.tabPage2.Controls.Add(this.lblGeneroTexto);
            this.tabPage2.Controls.Add(this.panel41);
            this.tabPage2.Controls.Add(this.lblGenero);
            this.tabPage2.Controls.Add(this.lblColeccionTexto);
            this.tabPage2.Controls.Add(this.lblTituloTexto);
            this.tabPage2.Controls.Add(this.panel40);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.panel39);
            this.tabPage2.Controls.Add(this.lblTitulo);
            this.tabPage2.Controls.Add(this.picPortada);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(702, 411);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // panel27
            // 
            this.panel27.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel27.Location = new System.Drawing.Point(290, 353);
            this.panel27.Margin = new System.Windows.Forms.Padding(2);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(7, 35);
            this.panel27.TabIndex = 207;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegresar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(290, 353);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(135, 35);
            this.btnRegresar.TabIndex = 206;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // lblAutorTexto
            // 
            this.lblAutorTexto.BackColor = System.Drawing.Color.Transparent;
            this.lblAutorTexto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAutorTexto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutorTexto.ForeColor = System.Drawing.Color.Black;
            this.lblAutorTexto.Location = new System.Drawing.Point(378, 274);
            this.lblAutorTexto.Name = "lblAutorTexto";
            this.lblAutorTexto.Size = new System.Drawing.Size(199, 18);
            this.lblAutorTexto.TabIndex = 205;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Location = new System.Drawing.Point(381, 242);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 18);
            this.panel1.TabIndex = 204;
            // 
            // lblAutorTitulo
            // 
            this.lblAutorTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.lblAutorTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAutorTitulo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutorTitulo.ForeColor = System.Drawing.Color.White;
            this.lblAutorTitulo.Location = new System.Drawing.Point(381, 242);
            this.lblAutorTitulo.Name = "lblAutorTitulo";
            this.lblAutorTitulo.Size = new System.Drawing.Size(199, 18);
            this.lblAutorTitulo.TabIndex = 203;
            this.lblAutorTitulo.Text = "   Autor";
            this.lblAutorTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGeneroTexto
            // 
            this.lblGeneroTexto.BackColor = System.Drawing.Color.Transparent;
            this.lblGeneroTexto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGeneroTexto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneroTexto.ForeColor = System.Drawing.Color.Black;
            this.lblGeneroTexto.Location = new System.Drawing.Point(378, 212);
            this.lblGeneroTexto.Name = "lblGeneroTexto";
            this.lblGeneroTexto.Size = new System.Drawing.Size(199, 18);
            this.lblGeneroTexto.TabIndex = 202;
            // 
            // panel41
            // 
            this.panel41.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel41.Location = new System.Drawing.Point(378, 180);
            this.panel41.Margin = new System.Windows.Forms.Padding(2);
            this.panel41.Name = "panel41";
            this.panel41.Size = new System.Drawing.Size(10, 18);
            this.panel41.TabIndex = 201;
            // 
            // lblGenero
            // 
            this.lblGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.lblGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGenero.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.ForeColor = System.Drawing.Color.White;
            this.lblGenero.Location = new System.Drawing.Point(378, 180);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(199, 18);
            this.lblGenero.TabIndex = 200;
            this.lblGenero.Text = "   Formato";
            this.lblGenero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblColeccionTexto
            // 
            this.lblColeccionTexto.BackColor = System.Drawing.Color.Transparent;
            this.lblColeccionTexto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblColeccionTexto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColeccionTexto.ForeColor = System.Drawing.Color.Black;
            this.lblColeccionTexto.Location = new System.Drawing.Point(381, 142);
            this.lblColeccionTexto.Name = "lblColeccionTexto";
            this.lblColeccionTexto.Size = new System.Drawing.Size(199, 18);
            this.lblColeccionTexto.TabIndex = 199;
            // 
            // lblTituloTexto
            // 
            this.lblTituloTexto.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloTexto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTituloTexto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloTexto.ForeColor = System.Drawing.Color.Black;
            this.lblTituloTexto.Location = new System.Drawing.Point(378, 81);
            this.lblTituloTexto.Name = "lblTituloTexto";
            this.lblTituloTexto.Size = new System.Drawing.Size(199, 18);
            this.lblTituloTexto.TabIndex = 198;
            // 
            // panel40
            // 
            this.panel40.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel40.Location = new System.Drawing.Point(378, 110);
            this.panel40.Margin = new System.Windows.Forms.Padding(2);
            this.panel40.Name = "panel40";
            this.panel40.Size = new System.Drawing.Size(10, 18);
            this.panel40.TabIndex = 197;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(378, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 18);
            this.label2.TabIndex = 196;
            this.label2.Text = "   Colección";
            // 
            // panel39
            // 
            this.panel39.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel39.Location = new System.Drawing.Point(378, 48);
            this.panel39.Margin = new System.Windows.Forms.Padding(2);
            this.panel39.Name = "panel39";
            this.panel39.Size = new System.Drawing.Size(10, 18);
            this.panel39.TabIndex = 195;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(378, 48);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(199, 18);
            this.lblTitulo.TabIndex = 194;
            this.lblTitulo.Text = "   Título";
            // 
            // picPortada
            // 
            this.picPortada.Cursor = System.Windows.Forms.Cursors.Default;
            this.picPortada.Location = new System.Drawing.Point(116, 48);
            this.picPortada.Name = "picPortada";
            this.picPortada.Size = new System.Drawing.Size(190, 255);
            this.picPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPortada.TabIndex = 193;
            this.picPortada.TabStop = false;
            // 
            // ttpBusquedas
            // 
            this.ttpBusquedas.ShowAlways = true;
            this.ttpBusquedas.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttpBusquedas.ToolTipTitle = "Consejo";
            // 
            // frmBusquedas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 474);
            this.Controls.Add(this.tbBusquedas);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBusquedas";
            this.Text = "frmBusquedas";
            this.Load += new System.EventHandler(this.frmBusquedas_Load);
            this.panel3.ResumeLayout(false);
            this.tbBusquedas.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBusquedasBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusquedasEjemplares)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPortada)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblColecciones;
        private System.Windows.Forms.TabControl tbBusquedas;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cmbBusquedas;
        private System.Windows.Forms.PictureBox picBusquedasBtn;
        private System.Windows.Forms.Panel pnlEjemplaresDGV;
        private System.Windows.Forms.DataGridView dgvBusquedasEjemplares;
        private System.Windows.Forms.TextBox txtBusquedas;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblAutorTexto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAutorTitulo;
        private System.Windows.Forms.Label lblGeneroTexto;
        private System.Windows.Forms.Panel panel41;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblColeccionTexto;
        private System.Windows.Forms.Label lblTituloTexto;
        private System.Windows.Forms.Panel panel40;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel39;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox picPortada;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.ToolTip ttpBusquedas;
    }
}