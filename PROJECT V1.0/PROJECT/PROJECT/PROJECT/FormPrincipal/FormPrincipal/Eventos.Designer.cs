using System.ComponentModel;

namespace FormPrincipal
{
    partial class Eventos
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
            this.dgvEventos = new System.Windows.Forms.DataGridView();
            this.lblTituloEvento = new System.Windows.Forms.Label();
            this.txtTituloEvento = new System.Windows.Forms.TextBox();
            this.txtFechHorIniEvento = new System.Windows.Forms.TextBox();
            this.txtFechHorFinEvento = new System.Windows.Forms.TextBox();
            this.txtAsistenciasEvento = new System.Windows.Forms.TextBox();
            this.lblFechHorInicioEven = new System.Windows.Forms.Label();
            this.lblasistenciasEvento = new System.Windows.Forms.Label();
            this.lblFechHorFin = new System.Windows.Forms.Label();
            this.btnAgregarEvento = new System.Windows.Forms.Button();
            this.btnActualizarEvento = new System.Windows.Forms.Button();
            this.btnEliminarEvento = new System.Windows.Forms.Button();
            this.btnMostrarEvento = new System.Windows.Forms.Button();
            this.lblAreaEvento = new System.Windows.Forms.Label();
            this.lblImagenEvento = new System.Windows.Forms.Label();
            this.cmbAreaEvento = new System.Windows.Forms.ComboBox();
            this.lblIDElimiEditEvento = new System.Windows.Forms.Label();
            this.txtIDElimEditEvento = new System.Windows.Forms.TextBox();
            this.txtImagenEvento = new System.Windows.Forms.TextBox();
            this.txtObjetivo = new System.Windows.Forms.TextBox();
            this.lblObjetivo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.dgvEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(330, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 66);
            this.label1.TabIndex = 1;
            this.label1.Text = "EVENTOS";
            // 
            // dgvEventos
            // 
            this.dgvEventos.BackgroundColor = System.Drawing.Color.FromArgb(((int) (((byte) (19)))), ((int) (((byte) (15)))), ((int) (((byte) (64)))));
            this.dgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventos.Location = new System.Drawing.Point(39, 98);
            this.dgvEventos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEventos.Name = "dgvEventos";
            this.dgvEventos.RowTemplate.Height = 24;
            this.dgvEventos.Size = new System.Drawing.Size(443, 288);
            this.dgvEventos.TabIndex = 30;
            // 
            // lblTituloEvento
            // 
            this.lblTituloEvento.Location = new System.Drawing.Point(552, 98);
            this.lblTituloEvento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloEvento.Name = "lblTituloEvento";
            this.lblTituloEvento.Size = new System.Drawing.Size(324, 22);
            this.lblTituloEvento.TabIndex = 32;
            this.lblTituloEvento.Text = "Título";
            // 
            // txtTituloEvento
            // 
            this.txtTituloEvento.Location = new System.Drawing.Point(552, 124);
            this.txtTituloEvento.Margin = new System.Windows.Forms.Padding(4);
            this.txtTituloEvento.Name = "txtTituloEvento";
            this.txtTituloEvento.Size = new System.Drawing.Size(311, 22);
            this.txtTituloEvento.TabIndex = 33;
            // 
            // txtFechHorIniEvento
            // 
            this.txtFechHorIniEvento.Location = new System.Drawing.Point(552, 188);
            this.txtFechHorIniEvento.Margin = new System.Windows.Forms.Padding(4);
            this.txtFechHorIniEvento.Name = "txtFechHorIniEvento";
            this.txtFechHorIniEvento.Size = new System.Drawing.Size(311, 22);
            this.txtFechHorIniEvento.TabIndex = 34;
            // 
            // txtFechHorFinEvento
            // 
            this.txtFechHorFinEvento.Location = new System.Drawing.Point(552, 251);
            this.txtFechHorFinEvento.Margin = new System.Windows.Forms.Padding(4);
            this.txtFechHorFinEvento.Name = "txtFechHorFinEvento";
            this.txtFechHorFinEvento.Size = new System.Drawing.Size(311, 22);
            this.txtFechHorFinEvento.TabIndex = 35;
            // 
            // txtAsistenciasEvento
            // 
            this.txtAsistenciasEvento.Location = new System.Drawing.Point(552, 317);
            this.txtAsistenciasEvento.Margin = new System.Windows.Forms.Padding(4);
            this.txtAsistenciasEvento.Name = "txtAsistenciasEvento";
            this.txtAsistenciasEvento.Size = new System.Drawing.Size(311, 22);
            this.txtAsistenciasEvento.TabIndex = 36;
            // 
            // lblFechHorInicioEven
            // 
            this.lblFechHorInicioEven.Location = new System.Drawing.Point(552, 162);
            this.lblFechHorInicioEven.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechHorInicioEven.Name = "lblFechHorInicioEven";
            this.lblFechHorInicioEven.Size = new System.Drawing.Size(324, 22);
            this.lblFechHorInicioEven.TabIndex = 37;
            this.lblFechHorInicioEven.Text = "Fecha y hora de inicio YYYY-MM-DD";
            // 
            // lblasistenciasEvento
            // 
            this.lblasistenciasEvento.Location = new System.Drawing.Point(552, 291);
            this.lblasistenciasEvento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblasistenciasEvento.Name = "lblasistenciasEvento";
            this.lblasistenciasEvento.Size = new System.Drawing.Size(324, 22);
            this.lblasistenciasEvento.TabIndex = 38;
            this.lblasistenciasEvento.Text = "Cantidad de asistencias";
            // 
            // lblFechHorFin
            // 
            this.lblFechHorFin.Location = new System.Drawing.Point(552, 225);
            this.lblFechHorFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechHorFin.Name = "lblFechHorFin";
            this.lblFechHorFin.Size = new System.Drawing.Size(324, 22);
            this.lblFechHorFin.TabIndex = 39;
            this.lblFechHorFin.Text = "Fecha y hora de fin YYYY-MM-DD";
            // 
            // btnAgregarEvento
            // 
            this.btnAgregarEvento.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (19)))), ((int) (((byte) (15)))), ((int) (((byte) (64)))));
            this.btnAgregarEvento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarEvento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarEvento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAgregarEvento.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregarEvento.Location = new System.Drawing.Point(39, 456);
            this.btnAgregarEvento.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarEvento.Name = "btnAgregarEvento";
            this.btnAgregarEvento.Size = new System.Drawing.Size(180, 37);
            this.btnAgregarEvento.TabIndex = 40;
            this.btnAgregarEvento.Text = "Agregar";
            this.btnAgregarEvento.UseVisualStyleBackColor = false;
            this.btnAgregarEvento.Click += new System.EventHandler(this.btnAgregarEvento_Click);
            // 
            // btnActualizarEvento
            // 
            this.btnActualizarEvento.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (19)))), ((int) (((byte) (15)))), ((int) (((byte) (64)))));
            this.btnActualizarEvento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarEvento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizarEvento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnActualizarEvento.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnActualizarEvento.Location = new System.Drawing.Point(302, 456);
            this.btnActualizarEvento.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizarEvento.Name = "btnActualizarEvento";
            this.btnActualizarEvento.Size = new System.Drawing.Size(180, 37);
            this.btnActualizarEvento.TabIndex = 41;
            this.btnActualizarEvento.Text = "Actualizar";
            this.btnActualizarEvento.UseVisualStyleBackColor = false;
            this.btnActualizarEvento.Click += new System.EventHandler(this.btnActualizarEvento_Click);
            // 
            // btnEliminarEvento
            // 
            this.btnEliminarEvento.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (19)))), ((int) (((byte) (15)))), ((int) (((byte) (64)))));
            this.btnEliminarEvento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarEvento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarEvento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnEliminarEvento.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEliminarEvento.Location = new System.Drawing.Point(39, 511);
            this.btnEliminarEvento.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarEvento.Name = "btnEliminarEvento";
            this.btnEliminarEvento.Size = new System.Drawing.Size(180, 37);
            this.btnEliminarEvento.TabIndex = 42;
            this.btnEliminarEvento.Text = "Eliminar";
            this.btnEliminarEvento.UseVisualStyleBackColor = false;
            // 
            // btnMostrarEvento
            // 
            this.btnMostrarEvento.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (19)))), ((int) (((byte) (15)))), ((int) (((byte) (64)))));
            this.btnMostrarEvento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarEvento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMostrarEvento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnMostrarEvento.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMostrarEvento.Location = new System.Drawing.Point(302, 511);
            this.btnMostrarEvento.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrarEvento.Name = "btnMostrarEvento";
            this.btnMostrarEvento.Size = new System.Drawing.Size(180, 37);
            this.btnMostrarEvento.TabIndex = 43;
            this.btnMostrarEvento.Text = "Mostrar";
            this.btnMostrarEvento.UseVisualStyleBackColor = false;
            this.btnMostrarEvento.Click += new System.EventHandler(this.btnMostrarEvento_Click);
            // 
            // lblAreaEvento
            // 
            this.lblAreaEvento.Location = new System.Drawing.Point(552, 353);
            this.lblAreaEvento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAreaEvento.Name = "lblAreaEvento";
            this.lblAreaEvento.Size = new System.Drawing.Size(324, 22);
            this.lblAreaEvento.TabIndex = 45;
            this.lblAreaEvento.Text = "Área del evento";
            // 
            // lblImagenEvento
            // 
            this.lblImagenEvento.Location = new System.Drawing.Point(552, 414);
            this.lblImagenEvento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImagenEvento.Name = "lblImagenEvento";
            this.lblImagenEvento.Size = new System.Drawing.Size(324, 22);
            this.lblImagenEvento.TabIndex = 46;
            this.lblImagenEvento.Text = "Imagen de evento";
            // 
            // cmbAreaEvento
            // 
            this.cmbAreaEvento.FormattingEnabled = true;
            this.cmbAreaEvento.Location = new System.Drawing.Point(552, 379);
            this.cmbAreaEvento.Name = "cmbAreaEvento";
            this.cmbAreaEvento.Size = new System.Drawing.Size(310, 24);
            this.cmbAreaEvento.TabIndex = 47;
            // 
            // lblIDElimiEditEvento
            // 
            this.lblIDElimiEditEvento.Location = new System.Drawing.Point(69, 397);
            this.lblIDElimiEditEvento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDElimiEditEvento.Name = "lblIDElimiEditEvento";
            this.lblIDElimiEditEvento.Size = new System.Drawing.Size(196, 22);
            this.lblIDElimiEditEvento.TabIndex = 48;
            this.lblIDElimiEditEvento.Text = "ID evento (Eliminar o editar)";
            // 
            // txtIDElimEditEvento
            // 
            this.txtIDElimEditEvento.Location = new System.Drawing.Point(255, 397);
            this.txtIDElimEditEvento.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDElimEditEvento.Name = "txtIDElimEditEvento";
            this.txtIDElimEditEvento.Size = new System.Drawing.Size(195, 22);
            this.txtIDElimEditEvento.TabIndex = 49;
            // 
            // txtImagenEvento
            // 
            this.txtImagenEvento.Location = new System.Drawing.Point(551, 440);
            this.txtImagenEvento.Margin = new System.Windows.Forms.Padding(4);
            this.txtImagenEvento.Name = "txtImagenEvento";
            this.txtImagenEvento.Size = new System.Drawing.Size(311, 22);
            this.txtImagenEvento.TabIndex = 50;
            // 
            // txtObjetivo
            // 
            this.txtObjetivo.Location = new System.Drawing.Point(551, 494);
            this.txtObjetivo.Margin = new System.Windows.Forms.Padding(4);
            this.txtObjetivo.Multiline = true;
            this.txtObjetivo.Name = "txtObjetivo";
            this.txtObjetivo.Size = new System.Drawing.Size(311, 54);
            this.txtObjetivo.TabIndex = 51;
            // 
            // lblObjetivo
            // 
            this.lblObjetivo.Location = new System.Drawing.Point(551, 471);
            this.lblObjetivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObjetivo.Name = "lblObjetivo";
            this.lblObjetivo.Size = new System.Drawing.Size(324, 22);
            this.lblObjetivo.TabIndex = 52;
            this.lblObjetivo.Text = "Objetivo";
            // 
            // Eventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(939, 583);
            this.Controls.Add(this.lblObjetivo);
            this.Controls.Add(this.txtObjetivo);
            this.Controls.Add(this.txtImagenEvento);
            this.Controls.Add(this.txtIDElimEditEvento);
            this.Controls.Add(this.lblIDElimiEditEvento);
            this.Controls.Add(this.cmbAreaEvento);
            this.Controls.Add(this.lblImagenEvento);
            this.Controls.Add(this.lblAreaEvento);
            this.Controls.Add(this.btnMostrarEvento);
            this.Controls.Add(this.btnEliminarEvento);
            this.Controls.Add(this.btnActualizarEvento);
            this.Controls.Add(this.btnAgregarEvento);
            this.Controls.Add(this.lblFechHorFin);
            this.Controls.Add(this.lblasistenciasEvento);
            this.Controls.Add(this.lblFechHorInicioEven);
            this.Controls.Add(this.txtAsistenciasEvento);
            this.Controls.Add(this.txtFechHorFinEvento);
            this.Controls.Add(this.txtFechHorIniEvento);
            this.Controls.Add(this.txtTituloEvento);
            this.Controls.Add(this.lblTituloEvento);
            this.Controls.Add(this.dgvEventos);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Eventos";
            this.Text = "Eventos";
            this.Load += new System.EventHandler(this.Eventos_Load);
            ((System.ComponentModel.ISupportInitialize) (this.dgvEventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtObjetivo;
        private System.Windows.Forms.Label lblObjetivo;

        private System.Windows.Forms.TextBox txtImagenEvento;

        private System.Windows.Forms.TextBox txtIDElimEditEvento;

        private System.Windows.Forms.ComboBox cmbAreaEvento;
        private System.Windows.Forms.Label lblIDElimiEditEvento;

        private System.Windows.Forms.Label lblFechHorInicioEven;
        private System.Windows.Forms.Label lblImagenEvento;
        private System.Windows.Forms.Label lblTituloEvento;

        private System.Windows.Forms.Label lblAreaEvento;

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblNombreEvento;
        private System.Windows.Forms.TextBox txtTituloEvento;
        private System.Windows.Forms.TextBox txtFechHorIniEvento;
        private System.Windows.Forms.TextBox txtFechHorFinEvento;
        private System.Windows.Forms.TextBox txtAsistenciasEvento;
        private System.Windows.Forms.Label lblasistenciasEvento;
        private System.Windows.Forms.Label lblFechHorFin;
        private System.Windows.Forms.Button btnAgregarEvento;
        private System.Windows.Forms.Button btnActualizarEvento;
        private System.Windows.Forms.Button btnEliminarEvento;
        private System.Windows.Forms.Button btnMostrarEvento;

        private System.Windows.Forms.DataGridView dgvEventos;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}