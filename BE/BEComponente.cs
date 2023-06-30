using Abstraccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public abstract class BEComponente: IEntidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public abstract List<BEComponente> Hijos { get; }
        public abstract void AgregarHijo(BEComponente c);
        public abstract void VaciarHijos();
        public abstract void EliminarHijo(BEComponente c);


        public override string ToString()
        {
            return Nombre.ToString();
        }
    }



   

}
