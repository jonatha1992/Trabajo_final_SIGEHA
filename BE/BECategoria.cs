﻿using Abstraccion;
using System.Collections.Generic;

namespace BE
{
    public class BECategoria : IEntidad
    {
        public BECategoria() { }
        public BECategoria(int id)
        {
            Id = id;
        }
        public BECategoria(int id, string name)
        {
            Id = id;
            Nombre = name;
        }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<BEArticulo> Articulos { get; set; }

        public override string ToString()
        {
            return Nombre;
        }

    }
}

