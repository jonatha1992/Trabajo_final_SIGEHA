﻿using Abstraccion;
using System;

namespace BE
{
    public abstract class BEDestino : IEntidad, ICloneable
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public abstract object Clone();
        public override string ToString()
        {
            return Nombre;
        }
    }



}
