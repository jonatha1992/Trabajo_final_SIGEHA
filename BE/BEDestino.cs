﻿using Abstraccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public abstract class BEDestino: IEntidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }




        public override string ToString()
        {
            return  Nombre;
        }
    }



}
