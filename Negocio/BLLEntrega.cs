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
        public override string ObtenerNroActa(BEUnidad unidad, int anio)
        {


            var Entregas = ListarTodo();

            string NroEntrega = Entregas.Where(h => h.Unidad.Id == unidad.Id && h.Anio == anio)
                           .OrderByDescending(h => h.NroActa)
                           .FirstOrDefault()?.NroActa;


            if (NroEntrega == "" || NroEntrega == null)
            {

                NroEntrega = $"0001{unidad.Cod}/{anio}";
            }
            else
            {

                string aux = (int.Parse(NroEntrega.Substring(0, 4)) + 1).ToString();

                if (aux.Length == 1)
                {
                    aux = "000" + aux;
                }
                if (aux.Length == 2)
                {
                    aux = "00" + aux;
                }
                if (aux.Length == 3)
                {
                    aux = "0" + aux;
                }
                NroEntrega = $"{(aux)}{unidad.Cod}/{anio}";
            }

            return NroEntrega;
        }

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
            entrega = ListarObjetoElementos(entrega);
            entrega = ListarObjetoPersonas(entrega);
            return entrega;

        }

        public BEEntrega ListarObjetoPersonas(BEEntrega entrega)
        {
            return mmPEntrega.ListarObjetoPersonas(entrega);
        }
        public BEEntrega ListarObjetoElementos(BEEntrega entrega)
        {
            return mmPEntrega.ListarObjetoElementos(entrega);
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

    }
}
