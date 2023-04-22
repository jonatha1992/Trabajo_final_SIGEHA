using Abstraccion;
using System;

namespace BE
{
    public class BEEntrega : BEPAdreHallazgo, IEntidad, IComparable<BEEntrega>
    {
        public BEEntrega() { }
        public BEEntrega(int id)
        {
            Id = id;
        }

        public int Id { get; set; }

        public DateTime Fecha_entrega { get; set; }

        public int CompareTo(BEEntrega other)
        {
            if (this.Fecha_entrega > other.Fecha_entrega) return 1;
            else if (this.Fecha_entrega < other.Fecha_entrega) return -1;
            else return 0;
        }

        public override string ToString()
        {
            return NroActa.ToString();
        }
    }
}
