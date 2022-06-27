using System;
using System.Drawing;

namespace FormPrincipal
{
    public class ReservaConsulta
    {
        public int id_reserva { get; set; }
        public string Usuario { get; set; }
        public string Ejemplar { get; set; }
        public string fotografia { get; set; }
        public Bitmap Portada { get; set; }
        public DateTime Reserva { get; set; }
        public DateTime Prestamo { get; set; }
        public DateTime Devolución { get; set; }
        public int id_usuario { get; set; }
        public int id_ejemplar { get; set; }

        public ReservaConsulta()
        {
            this.id_reserva = 0;
            this.id_usuario = 0;
            this.id_ejemplar = 0;
            this.Usuario = "";
            this.Ejemplar = "";
            this.fotografia = "";
            this.Portada = null;
        }

        public ReservaConsulta(int id_reserva, DateTime fecha_hora_reserva, DateTime fecha_hora_prestamo, DateTime fecha_hora_devolucion, int id_usuario, int id_ejemplar, string usuario, string ejemplar, string fotografia, Bitmap fotografiaAUX)
        {
            this.id_reserva = id_reserva;
            this.Reserva = fecha_hora_reserva;
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