namespace FormPrincipal
{
    public class Evento2
    {
        //OBJETO EXCLUSIVO PARA MOSTRAR DATOS
        public int IdEvento { get; set; }
        public string titulo { get; set; }
        public string objetivo { get; set; }
        public string imagen { get; set; }
        public string fechaIni { get; set; }
        public string fechaFin { get; set; }
        public int asistencias { get; set; }
        public string areaEvento { get; set; }

        public Evento2()
        {
            this.IdEvento = 0;
            this.titulo = "";
            this.objetivo = "";
            this.imagen = "";
            this.fechaIni = "";
            this.fechaFin = "";
            this.asistencias = 0;
            this.areaEvento = "";
        }

        public Evento2(int id, string title, string obj, string image, string ini, string fin, int asis, string even)
        {
            this.IdEvento = id;
            this.titulo = title;
            this.objetivo = obj;
            this.imagen = image;
            this.fechaIni = ini;
            this.fechaFin = fin;
            this.asistencias = asis;
            this.areaEvento = even;
        }
    }
}