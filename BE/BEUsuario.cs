using System.Collections.Generic;

namespace BE
{
    public class BEUsuario: BEPersona
    {
        public string Password { get; set; }
        public string NombreUsuario { get; set; }
        public BEUnidad Unidad { get; set; }
        public BEUrsa Ursa{ get; set; }
        public IList<BEComponente> Permisos { get; set; }
    }
}
