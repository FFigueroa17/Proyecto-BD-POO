namespace FormPrincipal
{
    public class Objetivo
    {
        public string objetivo { get; set; }
        public int idevento { get; set; }

        public Objetivo()
        {
            this.objetivo = "";
            this.idevento = 0;
        }

        public Objetivo(string obj, int even)
        {
            this.objetivo = obj;
            this.idevento = even;
        }
    }
}