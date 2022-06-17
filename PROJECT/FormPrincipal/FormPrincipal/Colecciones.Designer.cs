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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombe = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtPiso = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblPiso = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.dgvColeccion = new System.Windows.Forms.DataGridView();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblIDcoleccion = new System.Windows.Forms.Label();
            this.txtIDcoleccion = new System.Windows.Forms.TextBox();
            this.plColor = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnActualizar2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.dgvColeccion)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(431, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "COLECCIONES";
            // 
            // txtNombe
            // 
            this.txtNombe.Location = new System.Drawing.Point(779, 122);
            this.txtNombe.Name = "txtNombe";
            this.txtNombe.Size = new System.Drawing.Size(247, 20);
            this.txtNombe.TabIndex = 3;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(779, 186);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(247, 20);
            this.txtGenero.TabIndex = 4;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(779, 246);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(247, 20);
            this.txtTipo.TabIndex = 5;
            // 
            // txtPiso
            // 
            this.txtPiso.Location = new System.Drawing.Point(779, 308);
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(247, 20);
            this.txtPiso.TabIndex = 6;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (19)))), ((int) (((byte) (15)))), ((int) (((byte) (64)))));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregar.Location = new System.Drawing.Point(23, 407);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(148, 30);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (19)))), ((int) (((byte) (15)))), ((int) (((byte) (64)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(218, 407);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(148, 30);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (19)))), ((int) (((byte) (15)))), ((int) (((byte) (64)))));
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(399, 407);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(148, 30);
            this.btnActualizar.TabIndex = 9;
            this.btnActualizar.Text = "Mostrar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblPiso
            // 
            this.lblPiso.Location = new System.Drawing.Point(779, 287);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(256, 18);
            this.lblPiso.TabIndex = 10;
            this.lblPiso.Text = "Numero de piso";
            // 
            // lblTipo
            // 
            this.lblTipo.Location = new System.Drawing.Point(779, 225);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(256, 18);
            this.lblTipo.TabIndex = 11;
            this.lblTipo.Text = "ID Tipo";
            // 
            // lblGenero
            // 
            this.lblGenero.Location = new System.Drawing.Point(779, 165);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(256, 18);
            this.lblGenero.TabIndex = 12;
            this.lblGenero.Text = "ID Genero";
            // 
            // dgvColeccion
            // 
            this.dgvColeccion.AllowUserToAddRows = false;
            this.dgvColeccion.AllowUserToDeleteRows = false;
            this.dgvColeccion.BackgroundColor = System.Drawing.Color.FromArgb(((int) (((byte) (19)))), ((int) (((byte) (15)))), ((int) (((byte) (64)))));
            this.dgvColeccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColeccion.Location = new System.Drawing.Point(105, 81);
            this.dgvColeccion.Name = "dgvColeccion";
            this.dgvColeccion.ReadOnly = true;
            this.dgvColeccion.Size = new System.Drawing.Size(547, 299);
            this.dgvColeccion.TabIndex = 13;
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(779, 101);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(256, 18);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "Nombre";
            // 
            // lblIDcoleccion
            // 
            this.lblIDcoleccion.Location = new System.Drawing.Point(779, 372);
            this.lblIDcoleccion.Name = "lblIDcoleccion";
            this.lblIDcoleccion.Size = new System.Drawing.Size(256, 18);
            this.lblIDcoleccion.TabIndex = 16;
            this.lblIDcoleccion.Text = "ID coleccion (eliminar o editar)";
            // 
            // txtIDcoleccion
            // 
            this.txtIDcoleccion.Location = new System.Drawing.Point(779, 393);
            this.txtIDcoleccion.Name = "txtIDcoleccion";
            this.txtIDcoleccion.Size = new System.Drawing.Size(247, 20);
            this.txtIDcoleccion.TabIndex = 15;
            // 
            // plColor
            // 
            this.plColor.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (19)))), ((int) (((byte) (15)))), ((int) (((byte) (64)))));
            this.plColor.Location = new System.Drawing.Point(-6, 459);
            this.plColor.Name = "plColor";
            this.plColor.Size = new System.Drawing.Size(1132, 24);
            this.plColor.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (19)))), ((int) (((byte) (15)))), ((int) (((byte) (64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-6, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1132, 49);
            this.panel1.TabIndex = 18;
            // 
            // btnActualizar2
            // 
            this.btnActualizar2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (19)))), ((int) (((byte) (15)))), ((int) (((byte) (64)))));
            this.btnActualizar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizar2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnActualizar2.ForeColor = System.Drawing.Color.White;
            this.btnActualizar2.Location = new System.Drawing.Point(584, 407);
            this.btnActualizar2.Name = "btnActualizar2";
            this.btnActualizar2.Size = new System.Drawing.Size(148, 30);
            this.btnActualizar2.TabIndex = 19;
            this.btnActualizar2.Text = "Actualizar";
            this.btnActualizar2.UseVisualStyleBackColor = false;
            this.btnActualizar2.Click += new System.EventHandler(this.btnActualizar2_Click);
            // 
            // Colecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 482);
            this.Controls.Add(this.btnActualizar2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.plColor);
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
            this.Controls.Add(this.txtPiso);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtNombe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Colecciones";
            this.Text = "Colecciones";
            ((System.ComponentModel.ISupportInitialize) (this.dgvColeccion)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnActualizar2;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Panel plColor;

        private System.Windows.Forms.Label lblIDcoleccion;
        private System.Windows.Forms.TextBox txtIDcoleccion;

        private System.Windows.Forms.Label lblNombre;

        private System.Windows.Forms.DataGridView dgvColeccion;

        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblGenero;

        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtPiso;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblPiso;

        private System.Windows.Forms.TextBox txtNombe;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}