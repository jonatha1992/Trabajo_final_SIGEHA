using Abstraccion;
using System.Collections.Generic;

namespace BE
{
    public class BEUrsa : BEDestino
    {
        public BEUrsa() { }
        public BEUrsa(int id)
        {
            Id = id;
        }
        //public int Id { get; set; }
        //public string Nombre { get; set; }

        public List<BEUnidad> Unidades { get; set; }
        
        //ahora ver si modifico algo 
        public override string ToString()
        {
            return Nombre;
        }
    }
}
