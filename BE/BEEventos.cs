using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEEvento
    {
        public DateTime Fecha { get; set; }
        public BEUsuario Usuario { get; set; }
        public string Mensaje { get; set; }



    }
}
