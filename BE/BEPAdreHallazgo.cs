using System;
using System.Collections.Generic;

namespace BE
{
    public class BEPadreHallazgo
    {

        public string NroActa { get; set; }
        public DateTime? FechaActa { get; set; }
        public BEUnidad Unidad { get; set; }
        public int Anio { get; set; }
        public List<BEPersona> listaPersonas { get; set; }
        public List<BEElemento> listaElementos { get; set; }
        public string  Observacion { get; set; }


    }
}
