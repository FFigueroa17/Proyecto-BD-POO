namespace FormPrincipal
{
    public class Area
    {
        public int IDarea { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Horario { get; set; }
        public int IDresponsable { get; set; }
        public string Responsable { get; set; }
        public int numeroPiso { get; set; }
        
        public Area()
        {
            this.IDarea = 0;
            this.Nombre = "";
            this.Descripcion = "";
            this.Horario = "";
            this.IDresponsable = 0;
            this.Responsable = "";
            this.numeroPiso = 0;
        }
        
        public Area(int darea, string nombre, string descripcion, string horario, int dresponsable, string responsable, int numeroP)
        {
            IDarea = darea;
            Nombre = nombre;
            Descripcion = descripcion;
            Horario = horario;
            IDresponsable = dresponsable;
            Responsable = responsable;
            numeroPiso = numeroP;
        }
    }
}