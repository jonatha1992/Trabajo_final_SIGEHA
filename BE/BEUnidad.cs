using Abstraccion;

namespace BE
{
    public class BEUnidad : BEDestino
    {
        public BEUnidad() { }
        public BEUnidad(int id)
        {
            Id = id;
        }
   
        public string Cod { get; set; }
        public BEUrsa Ursa { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
