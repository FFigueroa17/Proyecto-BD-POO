using System;

namespace FormPrincipal
{
    public class Evento
    {
        public int IDEvento { get; set; }
        public string titulo { get; set; }
        public string objetivo { get; set; }
        public string fechaIni { get; set; }
        public string fechaFin { get; set; }
        public int asistencias { get; set; }
        public string areaevento { get; set; }
        public int idareaeve { get; set; }
        public string imagen { get; set; }
        public DateTime fechInicio { get; set; }
        public DateTime fechFin { get; set; }

        public Evento()
        {
            this.IDEvento = 0;
            this.titulo = "";
            this.objetivo = "";
            this.fechaIni = "";
            this.fechaFin = "";
            this.asistencias = 0;
            this.areaevento = "";
            this.idareaeve = 0;
            this.imagen = "";
            this.fechInicio = new DateTime(2000, 1, 1, 1, 0, 0, 0);
            this.fechFin = new DateTime(2000, 1, 1, 1, 0, 0, 0);
        }

        public Evento(int idevent, string title, string obj, string ini, string fin, int asis, string area,
            int idarea, string image, DateTime fini, DateTime ffin)
        {
            this.IDEvento = idevent;
            this.titulo = title;
            this.objetivo = obj;
            this.fechaIni = ini;
            this.fechaFin = fin;
            this.asistencias = asis;
            this.areaevento = area;
            this.idareaeve = idarea;
            this.imagen = image;
            this.fechInicio = fini;
            this.fechFin = ffin;
        }

        public Evento(int ideve, string title, string obje, string feini, string fefin, int asist, string area, string image)
        {
            this.IDEvento = ideve;
            this.titulo = title;
            this.objetivo = obje;
            this.fechaIni = feini;
            this.fechaFin = fefin;
            this.asistencias = asist;
            this.areaevento = area;
            this.imagen = image;
        }
    }
}