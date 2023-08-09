using Abstraccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public abstract class BEDestino: IEntidad, ICloneable
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public abstract object Clone();
        public override string ToString()
        {
            return  Nombre;
        }
    }



}
