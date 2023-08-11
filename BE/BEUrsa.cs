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

        public override object Clone()
        {
            return new BEUrsa
            {
                Id = this.Id,
                Nombre = this.Nombre,
                Unidades = this.Unidades != null ? new List<BEUnidad>(this.Unidades) : null

            };
        }

    }
}
