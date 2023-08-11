using BE;
using MPP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Negocio
{
    public class BLLBitacora
    {
        MPPBitacora mpPBitacora;

        public BLLBitacora()
        {
            mpPBitacora = new MPPBitacora();
        }

        public List<BEEvento> ListarTodo()
        {
            var lista = mpPBitacora.ListarTodo();
            lista = lista.OrderByDescending(e => e.Fecha).ToList();
            return lista;
        }

        public void RegistrarEvento(BEUsuario usuario, string mensaje)
        {
            BEEvento evento = new BEEvento()
            {
                Fecha = DateTime.Now,
                Usuario = usuario.NombreUsuario,
                Mensaje = mensaje
            };

            mpPBitacora.RegistrarEvento(evento);
        }

    }
}

