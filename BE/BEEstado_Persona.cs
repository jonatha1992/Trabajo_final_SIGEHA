﻿using Abstraccion;

namespace BE
{
    public class BEEstado_Persona : IEntidad
    {

        public BEEstado_Persona() { }
        public BEEstado_Persona(int id)
        {
            Id = id;
        }
        public BEEstado_Persona(int id, string estado)
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
