using Abstraccion;

namespace BE
{
    public class BEUnidad : IEntidad
    {
        public BEUnidad() { }
        public BEUnidad(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
        public string Cod { get; set; }
        public string NombreUnidad { get; set; }
        public BEUrsa Ursa { get; set; }

        public override string ToString()
        {
            return NombreUnidad;
        }
    }
}
