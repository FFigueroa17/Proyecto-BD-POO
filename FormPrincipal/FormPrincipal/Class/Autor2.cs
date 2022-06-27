namespace FormPrincipal
{
    public class Autor2
    {
        public int idAutor { get; set; }
        public int idEjemplar { get; set; }

        public Autor2()
        {
            idAutor = 0;
            idEjemplar = 0;
        }
        
        public Autor2(int idAut, int idEjem)
        {
            idAutor = idAut;
            idEjemplar = idEjem;
        }
    }
}