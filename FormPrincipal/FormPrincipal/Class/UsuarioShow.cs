using System;
using System.Drawing;

namespace FormPrincipal
{
    public class UsuarioShow
    {
        public int id_user { get; set; }
        public string nombreUser { get; set; }
        public string fotografiauser { get; set; }
        public Bitmap imagenuser { get; set; }
        public string area { get; set; }
        public DateTime Fecha_hora_entrada { get; set; }
        public DateTime Fecha_hora_salida { get; set; }
        public string qrruta { get; set; }
        public Bitmap qr { get; set; }

        public UsuarioShow()
        {
            this.id_user = 0;
            this.nombreUser = "";
            this.area = "";
            this.fotografiauser = "";
            this.Fecha_hora_entrada = new DateTime(2000, 1, 1, 1, 0, 0, 0);
            this.Fecha_hora_salida = new DateTime(2000, 1, 1, 1, 0, 0, 0);
            this.imagenuser = null;
            this.qrruta = "";
            this.qr = null;
        }

        public UsuarioShow(int id, string name, string are, string foto, DateTime entrada,
            DateTime salida, Bitmap imagen, string rutaqr, Bitmap qere)
        {
            this.id_user = id;
            this.nombreUser = name;
            this.area = are;
            this.fotografiauser = foto;
            this.Fecha_hora_entrada = entrada;
            this.Fecha_hora_salida = salida;
            this.imagenuser = imagen;
            this.qrruta = rutaqr;
            this.qr = qere;
        }
    }
}