namespace FormPrincipal
{
    public class Coleccion
    {
        public int IDcoleccion { get; set; }
        public string Nombre { get; set; }
        public int IDgenero { get; set; }
        public string Genero { get; set; }
        public int IDtipo { get; set; }
        public string Tipo { get; set; }
        public int numeroPiso { get; set; }

        public Coleccion()
        {
            this.IDcoleccion = 0;
            this.Nombre = "";
            this.IDgenero = 0;
            this.Genero = "";
            this.IDtipo = 0;
            this.Tipo = "";
            this.numeroPiso = 0;
            
        }

        public Coleccion(int dcoleccion, string nombre, int dgenero, string genero, int dtipo, string tipo, int numeroP)
        {
            IDcoleccion = dcoleccion;
            Nombre = nombre;
            IDgenero = dgenero;
            Genero = genero;
            IDtipo = dtipo;
            Tipo = tipo;
            numeroPiso = numeroP;
        }
    }
}