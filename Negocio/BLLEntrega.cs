using Abstraccion;
using BE;
using MPP;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Negocio
{
    public class BLLEntrega : BLLPadreHallazgo, IGestor<BEEntrega>
    {

        MPPEntrega mmPEntrega;
        MPPElemento mPPElemento;

        public BLLEntrega()
        {
            mmPEntrega = new MPPEntrega();
            mPPElemento = new MPPElemento();
        }

        //public override string ObtenerNroActa(BEUnidad unidad, int anio)
        //{
        //    var entregas = ListarTodo();

        //    string nroEntrega = entregas
        //        .Where(h => h.Unidad.Id == unidad.Id && h.Anio == anio)
        //        .OrderByDescending(h => h.NroActa)
        //        .FirstOrDefault()?.NroActa;

        //    int numeroSecuencial = 0;

        //    if (nroEntrega == "" || nroEntrega == null)
        //    {
        //        numeroSecuencial = 1;
        //    }
        //    else
        //    {
        //        // Extraer solo el número secuencial sin incluir el código de unidad y el año
        //        string numeroSecuencialStr = nroEntrega.Substring(0, nroEntrega.IndexOf(unidad.Cod));

        //        if (int.TryParse(numeroSecuencialStr, out int numeroParseado))
        //        {
        //            numeroSecuencial = numeroParseado + 1;
        //        }
        //    }

        //    // Crear el nuevo número de Acta con el formato "XXXXCCC/YYYY"
        //    nroEntrega= $"{numeroSecuencial:D4}{unidad.Cod}/{anio}";

        //    return nroEntrega;
        //}

        public BEEntrega Agregar(BEEntrega entrega)
        {
            var verificarExisteNroActa = ListarTodo().Exists(x => x.NroActa == entrega.NroActa);
            if (!verificarExisteNroActa) // SI NO EXISTE QUE LO AGREGUE
            {
                return mmPEntrega.Agregar(entrega);
            }
            else return entrega;

        }
        public BEEntrega ListarObjeto(BEEntrega entrega)
        {
            entrega = ListarEntregaElementos(entrega);
            entrega = ListarEntregaPersonas(entrega);
            return entrega;

        }

        public BEEntrega ListarEntregaPersonas(BEEntrega entrega)
        {
            return mmPEntrega.ListarEntregaPersonas(entrega);
        }
        public BEEntrega ListarEntregaElementos(BEEntrega entrega)
        {
            return mmPEntrega.ListarEntregaElementos(entrega);
        }
        public bool Actualizar(BEEntrega entrega)
        {
            return mmPEntrega.Actualizar(entrega);
        }

        public bool Eliminar(BEEntrega pEntrega)
        {
            BLLElemento bLLElemento = new BLLElemento();
           
            if (pEntrega.listaElementos != null)
            {
                foreach (var item in pEntrega.listaElementos)
                {
                    bLLElemento.EliminarElementoEntrega(pEntrega, item);
                }
            }

            return mmPEntrega.Eliminar(pEntrega);
        }

        public List<BEEntrega> ListarTodo()
        {
            return mmPEntrega.ListarTodo(); 
        }


        public List<BEEntrega> ListarTodo(BEUnidad bEUnidad, DateTime Fecha)
        {
            int Anio = Fecha.Year;
            int Mes = Fecha.Month;
            var Lista = mmPEntrega.ListarTodo().Where(x => x.Unidad.Id == bEUnidad.Id && x.Anio == Anio && x.Fecha_entrega.Month == Mes)
                                     .OrderByDescending(x => x.Fecha_entrega).ToList();

            foreach (var entrega in Lista)
            {
                entrega.Unidad = bEUnidad;
            }
            return Lista;
        }

        public override int ObtenerNroActa(BEUnidad unidad, int anio)
        {
            var Entregas = ListarTodo();

            string nroEntrega = Entregas
                .Where(h => h.Unidad.Id == unidad.Id && h.Anio == anio)
                .OrderByDescending(h => h.NroActa)
                .FirstOrDefault()?.NroActa;

            int numeroSecuencial = 1;

            if (!string.IsNullOrEmpty(nroEntrega) && nroEntrega.Contains(unidad.Cod))
            {
                string numeroSecuencialStr = nroEntrega.Substring(0, nroEntrega.IndexOf(unidad.Cod));

                if (int.TryParse(numeroSecuencialStr, out int numeroParseado))
                {
                    numeroSecuencial = numeroParseado + 1;
                }
            }

            return numeroSecuencial;
        }

        public override int ExtraerNro(string NroActa, BEUnidad unidad)
        {

            int numeroSecuencial = 0;

            string numeroSecuencialStr = NroActa.Substring(0, NroActa.IndexOf(unidad.Cod));

            if (int.TryParse(numeroSecuencialStr, out int numeroParseado))
            {
                numeroSecuencial = numeroParseado ;
            }
            return numeroSecuencial;
        }
    }
}
