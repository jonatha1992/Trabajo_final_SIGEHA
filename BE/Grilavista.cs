using System.Collections.Generic;

namespace BE
{

    public class ElementoBusqueda
    {
        public int Id { get; set; }
        public string Fecha_hallazgo { get; set; }
        public string Hallazgo { get; set; }
        public string Lugar { get; set; }
        public string Articulo { get; set; }
        public string Cantidad { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public string Entrega { get; set; }
    }

    public class ElementoActa
    {

        public ElementoActa() { }

        public int Id { get; set; }
        public string Articulo { get; set; }
        public string Descripcion { get; set; }
        public double Cantidad { get; set; }
        public string Estado { get; set; }



       


    }
}