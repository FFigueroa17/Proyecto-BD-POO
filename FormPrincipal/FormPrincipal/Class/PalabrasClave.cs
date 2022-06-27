namespace FormPrincipal
{
    public class PalabrasClave
    {
        public string palabraClave { get; set; }
        public int idEjemplar{ get; set; }

        public PalabrasClave()
        {
            palabraClave = "";
            idEjemplar = 0;
        }

        public PalabrasClave(string pClave, int idPClave)
        {
            palabraClave = pClave;
            idEjemplar = idPClave;
        }
    }
}