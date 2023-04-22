using Abstraccion;

namespace BE
{
    public class BEPersona : IEntidad
    {
        public BEPersona() { }
        public BEPersona(int id)
        {
            Id = id;
        }
        public BEPersona(int id, string nombre, string dNI = "")
        {
            Id = id;
            NombreCompleto = nombre;
            DNI = dNI;
        }

        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public string DNI { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Ocupacion { get; set; }
        public BEEstado_Persona EstadoPersona { get; set; }


    }
}
