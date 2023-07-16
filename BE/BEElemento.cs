using Abstraccion;

namespace BE
{
    public class BEElemento : IEntidad
    {
        public BEElemento() { }
        public BEElemento(int id) { Id = id; }

        public BEHallazgo Hallazgo;
        public BEEntrega Entrega;

        public int Id { get; set; }

        public BEArticulo Articulo { get; set; }

        public string Descripcion { get; set; }
        public double Cantidad { get; set; }
        public BEEstado_Elemento Estado { get; set; }

    }
}
