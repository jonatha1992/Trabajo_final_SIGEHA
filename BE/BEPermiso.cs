using Abstraccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEPermiso : BEComponente
    {
        public override List<BEComponente> Hijos
        {
            get
            {
                return new List<BEComponente>();
            }

        }

        public override void AgregarHijo(BEComponente c)
        {
            throw new NotImplementedException();
        }

        public override void VaciarHijos()
        {
            throw new NotImplementedException();
        }
    }
}
