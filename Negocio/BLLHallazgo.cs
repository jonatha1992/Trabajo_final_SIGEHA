using Abstraccion;
using BE;
using MPP;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Negocio
{
    public class BLLHallazgo : BLLPadreHallazgo, IGestor<BEHallazgo>
    {

        MPPHallazgo mPPHallazgo;

        public BLLHallazgo()
        {
            mPPHallazgo = new MPPHallazgo();
        }
        public BEHallazgo Agregar(BEHallazgo pHallazgo)
        {
            var verificarExisteNroActa = ListarTodo().Exists(x => x.NroActa == pHallazgo.NroActa);
            if (!verificarExisteNroActa) // SI NO EXISTE QUE LO AGREGUE
            {
                return null;
            }
                return mPPHallazgo.Agregar(pHallazgo);
        }
        public bool Actualizar(BEHallazgo Phallazgo)
        {

            return mPPHallazgo.Actualizar(Phallazgo);
        }

        public List<BEHallazgo> ListarTodo()
        {

            return mPPHallazgo.ListarTodo();
        }
        public BEHallazgo ListarObjeto(BEHallazgo Phallazgo)
        {
            return mPPHallazgo.ListarObjeto(Phallazgo);
        }

        public BEHallazgo ListarObjetoPersonas(BEHallazgo Phallazgo)
        {
            return mPPHallazgo.ListarObjetoPersonas(Phallazgo);
        }

        public BEHallazgo ListarObjetoElementos(BEHallazgo Phallazgo)
        {
            return mPPHallazgo.ListarObjetoElementos(Phallazgo);
        }
        public bool Eliminar(BEHallazgo pHallazgo)
        {
            return mPPHallazgo.Eliminar(pHallazgo);
        }

        public override string ObtenerNroActa(BEUnidad unidad, int anio)
        {
            string nroHallazgo = "";
            var hallazgos = ListarTodo();

             nroHallazgo = hallazgos.Where(h => h.Unidad.Id == unidad.Id && h.Anio == anio)
                            .OrderByDescending(h => h.NroActa)
                            .FirstOrDefault()?.NroActa;

            //nroHallazgo = mPPHallazgo.ObtenerNroHallazgo(unidad, anio);

            if (nroHallazgo == "")
            {
                nroHallazgo = $"0001{unidad.Cod}/{anio}";
            }
            else
            {
                string aux = (int.Parse(nroHallazgo.Substring(0, 4)) + 1).ToString();

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
                nroHallazgo = $"{(aux)}{unidad.Cod}/{anio}";
            }

            return nroHallazgo;
        }


   

        public List<BEHallazgo> ListarTodo(BEUnidad bEUnidad, DateTime fecha)
        {
            int Anio = fecha.Year;
            int Mes = fecha.Month;

            List<BEHallazgo> lista = ListarTodo().Where(x => x.Unidad.Id == bEUnidad.Id && x.Anio == Anio && x.FechaHallazgo.Month == Mes)
                                     .OrderByDescending(x => x.FechaHallazgo).ToList();
            return lista;
        }


    }
}
