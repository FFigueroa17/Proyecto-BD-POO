using System;

namespace FormPrincipal
{
    public class Usuario
    {
        public int id_user { get; set; }
        public string nombreUser { get; set; }
        public string ocupacionuser { get; set; }
        public string direccionuser { get; set; }
        public string correouser { get; set; }
        public string institucionuser { get; set; }
        public string fotografiauser { get; set; }
        public string telefonouser { get; set; }
        public int id_area_ingreso { get; set; }
        public DateTime fecha_hora_entrada { get; set; }
        public DateTime fecha_hora_salida { get; set; }

        public Usuario()
        {
            this.id_user = 0;
            this.nombreUser = "";
            this.direccionuser = "";
            this.ocupacionuser = "";
            this.correouser = "";
            this.institucionuser = "";
            this.fotografiauser = "";
            this.telefonouser = "";
            this.id_area_ingreso = 0;
            this.fecha_hora_entrada = new DateTime(2000, 1, 1, 1, 0, 0, 0);
            this.fecha_hora_salida = new DateTime(2000, 1, 1, 1, 0, 0, 0);
        }

        public Usuario(int id, string name, string dire, string ocu, string corr, string insti, string foto, string tel,
            int areaingre, DateTime entry, DateTime exit)
        {
            this.id_user = id;
            this.nombreUser = name;
            this.direccionuser = dire;
            this.ocupacionuser = ocu;
            this.correouser = corr;
            this.institucionuser = insti;
            this.fotografiauser = foto;
            this.telefonouser = tel;
            this.id_area_ingreso = areaingre;
            this.fecha_hora_entrada = entry;
            this.fecha_hora_salida = exit;
        }
    }
}