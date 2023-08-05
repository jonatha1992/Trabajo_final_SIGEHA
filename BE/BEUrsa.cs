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

        public List<BEUnidad> Unidades { get; set; }
        
   
 
    }
}
