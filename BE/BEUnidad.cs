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

        public override object Clone()
        {
            return new BEUnidad
            {
                Id = this.Id,
                Nombre = this.Nombre,
                Cod = this.Cod, 
                Ursa = this.Ursa
           };
        }
    }
}
