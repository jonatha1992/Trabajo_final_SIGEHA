using Abstraccion;
using System.Collections.Generic;

namespace BE
{
    public class BEUrsa : IEntidad
    {
        public BEUrsa() { }
        public BEUrsa(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
        public string NombreUrsa { get; set; }

        public List<BEUnidad> Unidades { get; set; }
        
        //ahora ver si modifico algo 
        public override string ToString()
        {
            return NombreUrsa;
        }
    }
}
