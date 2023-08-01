using BE;
using MPP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Negocio
{
    public class BLLBackUp
    {
        MPPBackUp mppBackup;

        public BLLBackUp()
        {
            mppBackup = new MPPBackUp();
        }

        public List<BEBackUp> ListarTodo()
        {
            var lista = mppBackup.ListarTodo();
            lista = lista.OrderByDescending(e => e.Fecha).ToList();
            return lista;
        }

        public string GenerarBackup()
        {
            BEBackUp bEBackUp = new BEBackUp();
            bEBackUp.Fecha = DateTime.Now;
            bEBackUp.Nombre = $"BackUp_{bEBackUp.Fecha.ToString("dd-MM-yyyy HH-mm-ss")}.xml";
            mppBackup.GenerarBackUp(bEBackUp);
            return bEBackUp.Nombre;
        }

        public bool RestaurarBackup(BEBackUp bEBackUp)
        {
            return mppBackup.RestaurarBackUp(bEBackUp);
        }

    }
}

