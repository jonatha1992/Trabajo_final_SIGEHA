using Abstraccion;

namespace BE
{
    public class BEArticulo : IEntidad
    {
        public BEArticulo() { }
        public BEArticulo(int id)
        {
            Id = id;
        }
        public BEArticulo(int id, string nombre, BECategoria eCategoria)
        {
            Id = id;
            NombreArticulo = nombre;
            Categoria = eCategoria;
        }
        public int Id { get; set; }

        public string NombreArticulo { get; set; }

        public BECategoria Categoria { get; set; }

        public override string ToString()
        {
            return NombreArticulo;
        }

    }

}