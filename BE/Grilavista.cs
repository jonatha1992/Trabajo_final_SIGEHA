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

    public class Elemento
    {

        public Elemento() { }

        public int Id { get; set; }
        public string Articulo { get; set; }
        public string Descripcion { get; set; }
        public double Cantidad { get; set; }
        public string Estado { get; set; }



        public List<Elemento> CrearListaElementos(List<BEElemento> bEElementos)
        {
            List<Elemento> lista = new List<Elemento>();
            
            foreach (BEElemento item in bEElementos)
            {
                Elemento elemento = new Elemento();
                elemento.Id = item.Id;
                elemento.Articulo = item.Articulo.Categoria.Nombre + "-" + item.Articulo.Nombre;
                elemento.Descripcion = item.Descripcion.ToLower();
                elemento.Cantidad = item.Cantidad;
                elemento.Estado = item.Estado.Nombre;
                lista.Add(elemento);

            }
            return lista;

        }


    }
}