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
        }

        public Evento(int idevent, string title, string obj, string ini, string fin, int asis, string area, int idarea, string image)
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
        }
    }
}