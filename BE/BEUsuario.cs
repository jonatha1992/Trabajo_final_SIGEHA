using System.Collections.Generic;

namespace BE
{
    public class BEUsuario: BEPersona
    {
        public string Password { get; set; }
        public string NombreUsuario { get; set; }
        public BEDestino Destino{ get; set; }
        public List<BEComponente> Permisos { get; set; }


        public BEUsuario()
        {
            Permisos = new List<BEComponente>();
        }

        public override string ToString()
        {
            return NombreUsuario;
        }
    }
}
