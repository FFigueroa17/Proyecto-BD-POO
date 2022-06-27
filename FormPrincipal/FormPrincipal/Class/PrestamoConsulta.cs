using System;
using System.Drawing;

namespace FormPrincipal
{
    public class PrestamoConsulta
    {
        public int id_prestamo { get; set; }
        public string Usuario { get; set; }
        public string Ejemplar { get; set; }
        public string fotografia { get; set; }
        public Bitmap Portada { get; set; }
        public DateTime Prestamo { get; set; }
        public DateTime Devolución { get; set; }
        public int id_usuario { get; set; }
        public int id_ejemplar { get; set; }

        public PrestamoConsulta()
        {
            this.id_prestamo = 0;
            this.id_usuario = 0;
            this.id_ejemplar = 0;
            this.Usuario = "";
            this.Ejemplar = "";
            this.fotografia = "";
            this.Portada = null;
        }

        public PrestamoConsulta(int id_reserva, DateTime fecha_hora_prestamo, DateTime fecha_hora_devolucion, int id_usuario, int id_ejemplar, string usuario, string ejemplar, string fotografia, Bitmap fotografiaAUX)
        {
            this.id_prestamo = id_reserva;
            this.Prestamo = fecha_hora_prestamo;
            this.Devolución = fecha_hora_devolucion;
            this.id_usuario = id_usuario;
            this.id_ejemplar = id_ejemplar;
            this.Usuario = usuario;
            this.Ejemplar = ejemplar;
            this.fotografia = fotografia;
            Portada = fotografiaAUX;
        }
    }
}