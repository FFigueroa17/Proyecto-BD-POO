using System;
using System.Drawing;

namespace FormPrincipal
{
    public class EjemplarConsulta
    {
        public int ID_ejemplar { get; set; }
        public string Nombre_Ejemplar { get; set; }
        public string Portada_Ejemplar { get; set; }
        public Bitmap Portada { get; set; }
        public string Formato { get; set; }
        public DateTime Fecha_de_publicacion { get; set; }
        public string ISBN { get; set; }
        public string ISSN { get; set; }
        public string DOI { get; set; }
        public string Idioma { get; set; }
        public string Coleccion { get; set; }
        public string Editorial { get; set; }
        public string Autor { get; set; }
        public string Palabras_Clave { get; set; }

        public EjemplarConsulta()
        {
            this.ID_ejemplar = 0;
            this.Nombre_Ejemplar = "";
            this.Portada_Ejemplar = "";
            this.Portada = null;
            this.Formato = "";
            this.Fecha_de_publicacion = DateTime.Now;
            this.ISBN = "";
            this.ISSN = "";
            this.DOI = "";
            this.Idioma = "";
            this.Coleccion = "";
            this.Editorial = "";
            this.Autor = "";
            this.Palabras_Clave = "";
        }

        public EjemplarConsulta(int idEjemplar, string nombreEjemplar, string portada, Bitmap portada2,string formato, DateTime fechaDePublicacion,string isbn, string issn,string doi, string idioma, string coleccion, string editorial, string aut, string palB, string eti )
        {
            ID_ejemplar = idEjemplar;
            Nombre_Ejemplar = nombreEjemplar;
            Portada_Ejemplar = portada;
            Portada = portada2;
            Formato = formato;
            Fecha_de_publicacion = fechaDePublicacion;
            ISBN = isbn;
            ISSN = issn;
            DOI = doi;
            Idioma = idioma;
            Coleccion = coleccion;
            Editorial = editorial;
            Autor = aut;
            Palabras_Clave= palB;
        }
    }
}