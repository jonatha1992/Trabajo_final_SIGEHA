using System.Collections.Generic;

namespace BE
{
    public class BEInstructor : BEPersona
    {
        public BEInstructor() { }
        public BEInstructor(int id)
        {
            Id = id;
        }
        public BEInstructor(int id, string Nombre, string dni, int legajo, BEJerarquia bEJerarquia) : base(id, Nombre, dni)
        {
            Legajo = legajo;
            Jerarquia = bEJerarquia;
        }
        public int Legajo { get; set; }
        public BEJerarquia Jerarquia { get; set; }
        public BEUnidad Unidad{ get; set; }
        public BEUrsa Ursa { get; set; }

        public string Password{ get; set; }
        public string Mail { get; set; }


    }
}
