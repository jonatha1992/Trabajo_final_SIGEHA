using Abstraccion;
using System;

namespace BE
{
    public class BEHallazgo : BEPAdreHallazgo, IEntidad, IComparable<BEHallazgo>
    {
        public BEHallazgo() { }
        public BEHallazgo(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
        public DateTime FechaHallazgo { get; set; }

        public string LugarHallazgo { get; set; }

        public int CompareTo(BEHallazgo other)
        {
            if (this.FechaHallazgo > other.FechaHallazgo) return 1;
            else if (this.FechaHallazgo < other.FechaHallazgo) return -1;
            else return 0;


        }

        public override string ToString()
        {
            return NroActa.ToString();
        }
    }
}
