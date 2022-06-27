using System;

namespace FormPrincipal
{
    public class Ejemplar
    {
        
        public int IDEjemplar { get; set; }
        public string NombreEjemplar { get; set; }
        public string Portada { get; set; }
        public string Formato { get; set; }
        public DateTime FechaDePublicacion { get; set; }
        public int IDidioma { get; set; }
        public string ISBN { get; set; }
        public string ISSN { get; set; }
        public string DOI { get; set; }
        public string Idioma { get; set; }
        public int IDcoleccion { get; set; }
        public string Coleccion { get; set; }
        public int IDeditorial { get; set; }
        public string Editorial { get; set; }
        public string Autor { get; set; }
        public int IDautor { get; set; }
        public string palabrasClave { get; set; }
        public string Etiqueta { get; set; }

        public Ejemplar()
        {
            this.IDEjemplar = 0;
            this.NombreEjemplar = "";
            this.Formato = "";
            this.Portada = "";
            this.FechaDePublicacion = DateTime.Now;
            this.ISBN = "";
            this.ISSN = "";
            this.DOI = "";
            this.IDidioma = 0;
            this.Idioma = "";
            this.IDcoleccion = 0;
            this.Coleccion = "";
            this.IDeditorial = 0;
            this.Editorial = "";
            this.Autor = "";
            this.IDautor = 0;
            this.palabrasClave = "";
            this.Etiqueta = "";
        }

        public Ejemplar(int idEjemplar, string nombreEjemplar, string portada, string formato, DateTime fechaDePublicacion, string isbn, string issn,string doi, int didioma, string idioma, int dcoleccion, string coleccion, int deditorial, string editorial, string autor, int dautor, string palabrasClave, string etiqueta)
        {
            IDEjemplar = idEjemplar;
            NombreEjemplar = nombreEjemplar;
            Portada = portada;
            Formato = formato;
            FechaDePublicacion = fechaDePublicacion;
            ISBN = isbn;
            ISSN = issn;
            DOI = doi;
            IDidioma = didioma;
            Idioma = idioma;
            IDcoleccion = dcoleccion;
            Coleccion = coleccion;
            IDeditorial = deditorial;
            Editorial = editorial;
            Autor = autor;
            IDautor = dautor;
            this.palabrasClave = palabrasClave;
            Etiqueta = etiqueta;
        }
    }
}