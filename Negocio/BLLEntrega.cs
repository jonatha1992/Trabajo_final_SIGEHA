using Abstraccion;
using BE;
using MPP;
using System;
using System.Collections.Generic;

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


            string NroEntrega = mmPEntrega.ObtenerNroEntrega(unidad, anio);


            if (NroEntrega == "")
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
            if (!mmPEntrega.VerificarSiExisteNroEntrega(entrega.NroActa)) // SI NO EXISTE QUE LO AGREGUE
            {
                return mmPEntrega.Agregar(entrega);
            }
            else return entrega;

        }
        public BEEntrega ListarObjeto(BEEntrega entrega)
        {
            return mmPEntrega.ListarObjeto(entrega);
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

        public bool Eliminar(BEEntrega entrega)
        {
            return mmPEntrega.Eliminar(entrega);
        }

        public List<BEEntrega> ListarTodo()
        {
            return mmPEntrega.ListarTodo();
        }
        public List<BEEntrega> ListarTodo(BEUnidad bEUnidad, int Anio)
        {
            var Lista = mmPEntrega.ListarTodo(bEUnidad, Anio);
            return Lista;
        }

        public List<BEEntrega> ListarTodo(BEUnidad bEUnidad, DateTime Fecha)
        {
            var Lista = mmPEntrega.ListarTodo(bEUnidad, Fecha);
            return Lista;
        }

    }
}
