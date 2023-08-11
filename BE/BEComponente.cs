using Abstraccion;
using System.Collections.Generic;

namespace BE
{
    public abstract class BEComponente : IEntidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public abstract List<BEComponente> Hijos { get; }
        public abstract void AgregarHijo(BEComponente c);
        public abstract void VaciarHijos();
        public abstract void EliminarHijo(BEComponente c);

    }

}
