using Abstraccion;
using System;

namespace BE
{
    public class BEJerarquia : IEntidad, IComparable<BEJerarquia>
    {
        public BEJerarquia() { }
        public BEJerarquia(int id) => Id = id;

        public BEJerarquia(int id, string jerar, string Abre)
        {
            Id = id;
            Jerarquia = jerar;
            Abreviatura = Abre;
        }
        public int Id { get; set; }
        public string Jerarquia { get; set; }
        public string Abreviatura { get; set; }

        public int CompareTo(BEJerarquia other)
        {
            if (this.Id > other.Id) return 1;
            else if (this.Id < other.Id) return -1;
            else return 1;

        }

        public override string ToString()
        {
            return Jerarquia;
        }
    }
}
