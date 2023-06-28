using Abstraccion;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BE
{
    public class BERol : BEComponente
    {
        private List<BEComponente> _hijos;
        public BERol()
        {
            _hijos = new List<BEComponente>();
        }



        public override List<BEComponente> Hijos
        {
            get
            {
                return _hijos.ToList();
            }

        }


        public override void AgregarHijo(BEComponente c)
        {
            _hijos.Add(c);
        }

        public override void VaciarHijos()
        {
            _hijos = new List<BEComponente>();
        }
    }
}