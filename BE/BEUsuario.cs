using System.Collections.Generic;

namespace BE
{
    public class BEUsuario
    {
        public string Id { get; set; }
        public string Password { get; set; }
        public string Usuario { get; set; }
        
        public BEUnidad Unidad { get; set; }
        public BEUrsa Ursa{ get; set; }
        public IList<BEComponente> Permisos { get; set; }
    }
}
