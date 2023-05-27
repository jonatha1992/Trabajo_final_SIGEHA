using Abstraccion;

namespace BE
{
    public class BEEstado_Elemento : IEntidad
    {
        public BEEstado_Elemento() { }
        public BEEstado_Elemento(int id)
        {
            Id = id;
        }
        public BEEstado_Elemento(int id, string estado)
        {
            Id = id;
            Nombre = estado;
        }
        public int Id { get; set; }
        public string Nombre { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
