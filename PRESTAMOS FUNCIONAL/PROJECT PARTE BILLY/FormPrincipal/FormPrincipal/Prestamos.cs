﻿using System;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormPrincipal.Properties;

namespace FormPrincipal
{
    public partial class Prestamos : Form
    {
        public Prestamos()
        {
            InitializeComponent();
        }
        
        public void Limpiar()
        {
            txtIDUsuario.Clear();
            txtIDEjemplar.Clear();
        }

        public string Flag(DateTime prueba1, DateTime prueba2, string id)
        {
            bool exito = true;
            string cadena = Resources.cadena_conexion;
            string count = "";

            using (SqlConnection connection = new SqlConnection(cadena)){
                string query = "select count(*) 'Conteo' from PRESTAMO WHERE id_ejemplar = '" +id + "' AND CONVERT(datetime,'" +prueba1+ "',103) >= fecha_hora_prestamo AND CONVERT(datetime,'" +prueba1+ "',103) <= fecha_hora_devolucion";
               
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader()){
                    while (reader.Read())
                    {
                        count = reader["Conteo"].ToString();
                    }   
                }
                connection.Close();
            }
            return count;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvPrestamos.DataSource = null;
            dgvPrestamos.DataSource = PrestamosDAO.ObtenerTodos();
        }
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DateTime prueba1 =  Convert.ToDateTime(dtpPrestamo.Value.Date + dtpPrestamoH.Value.TimeOfDay);
            DateTime prueba2 =  Convert.ToDateTime(dtpDevolucion.Value.Date + dtpDevolucionH.Value.TimeOfDay);
            string id = txtIDEjemplar.Text;
            lblPrueba1.Text = Convert.ToString(prueba1);
            lblPrueba2.Text = Convert.ToString(prueba2);
            string verify = Flag(prueba1,prueba2, id);

            if (dtpPrestamo.Value != null && dtpDevolucion.Value != null && txtIDUsuario.Text.Length >0 && 
                txtIDEjemplar.Text.Length > 0)
            {
                if (verify == "0")
                {
                    Prestamo col = new Prestamo();
                    col.fecha_hora_prestamo = dtpPrestamo.Value.Date + dtpPrestamoH.Value.TimeOfDay;
                    col.fecha_hora_devolucion = dtpDevolucion.Value.Date + dtpDevolucionH.Value.TimeOfDay;
                    col.id_usuario = Convert.ToInt32(txtIDUsuario.Text);
                    col.id_ejemplar = Convert.ToInt32(txtIDEjemplar.Text);

                    PrestamosDAO.CrearNuevo(col);
                    MessageBox.Show("Nuevo prestamo agregado correctamente", "BINAES", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Este ejemplar se encuentra en prestamo.", "BINAES", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }

            else
            {
                MessageBox.Show("Debe llenar todos los campos", "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
            
            Limpiar();
            dgvPrestamos.DataSource = null;
            dgvPrestamos.DataSource = PrestamosDAO.ObtenerTodos();
        }

        private void btnActualizar2_Click(object sender, EventArgs e)
        {
            if (dtpPrestamo.Value != null  && dtpDevolucion.Value != null && txtIDUsuario.Text.Length >0 && 
                txtIDEjemplar.Text.Length > 0)
            {
                Prestamo col = new Prestamo();
                col.id_prestamo = Convert.ToInt32(txtPrestamoMod.Text);
                col.fecha_hora_prestamo = dtpPrestamo.Value.Date + dtpPrestamoH.Value.TimeOfDay;
                col.fecha_hora_devolucion = dtpDevolucion.Value.Date + dtpDevolucionH.Value.TimeOfDay;
                col.id_usuario = Convert.ToInt32(txtIDUsuario.Text);
                col.id_ejemplar = Convert.ToInt32(txtIDEjemplar.Text);

                PrestamosDAO.ActualizarPorID(col);
                MessageBox.Show("Prestamo actualizado correctamente", "BINAES", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos", "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
           
            dgvPrestamos.DataSource = null;
            dgvPrestamos.DataSource = PrestamosDAO.ObtenerTodos();
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtPrestamoMod.Text.Length > 0)
            {
                int ID_a_borrar = Convert.ToInt32(txtPrestamoMod.Text);

                if (PrestamosDAO.EliminarPorID(ID_a_borrar))
                    MessageBox.Show("Prestamo eliminado correctamente", "BINAES", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                else
                    MessageBox.Show("Ha ocurrido un error");
            }
            else
            {
                MessageBox.Show("Ingrese un ID de prestamo correcto", "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
            
            dgvPrestamos.DataSource = null;
            dgvPrestamos.DataSource = PrestamosDAO.ObtenerTodos();
            
            Limpiar();
        }

        
    }
}