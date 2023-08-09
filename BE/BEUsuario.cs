using System;
using System.Collections.Generic;

namespace BE
{
    public class BEUsuario : BEPersona, ICloneable
    {
        public string Password { get; set; }
        public string NombreUsuario { get; set; }
        public BEDestino Destino { get; set; }
        public List<BEComponente> Permisos { get; set; }


        public BEUsuario()
        {
            Permisos = new List<BEComponente>();
        }

        public override string ToString()
        {
            return NombreUsuario;
        }


        public object Clone()
        {
            BEUsuario clone = new BEUsuario
            {
                Password = this.Password,
                NombreUsuario = this.NombreUsuario,
                Destino = this.Destino?.Clone() as BEDestino
            };

            // Clonar la lista de Permisos
            clone.Permisos = new List<BEComponente>();

            return clone;
        }
       
    }
}
