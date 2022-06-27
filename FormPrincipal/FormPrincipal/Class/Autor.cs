namespace FormPrincipal
{
    public class Autor
    {
        public string Nombre {get; set;}
        public int idEjemplar {get; set;}

        public Autor()
        {
            Nombre = "";
            idEjemplar = 0;
        }

        public Autor(string nombre, int idEjem)
        {
            Nombre = nombre;
            idEjemplar = idEjem;
        }
    }
}