using Abstraccion;
using System;

namespace BE
{
    public class BERol:IEntidad
    {
        public BERol(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}