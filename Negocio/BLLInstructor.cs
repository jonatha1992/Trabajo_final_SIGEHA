using Abstraccion;
using BE;
using MPP;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public class BLLInstructor : IGestor<BEInstructor>
    {
        MPPInstructor mpPinstructor;
        MPPPersona mMMpersona;

        public BLLInstructor()
        {
            mpPinstructor = new MPPInstructor();
            mMMpersona = new MPPPersona();
        }

        public List<BEInstructor> ListarTodo()
        {
            return mpPinstructor.ListarTodo();
        }


        public BEInstructor Agregar(BEInstructor pinstructor)
        {
            //Verificar el legajo SI EXISTE EN LA BASE DE DATOS
            var instructor = ListarTodo().Find((x => x.DNI == pinstructor.DNI || x.Legajo == pinstructor.Legajo));
            if (instructor != null)
            {
                pinstructor.Id = instructor.Id;
                Actualizar(pinstructor);
                return pinstructor;
            }
            else
            {
                return mpPinstructor.Agregar(pinstructor);
            }
        }

        public bool Actualizar(BEInstructor instructor)
        {
            return mpPinstructor.Actualizar(instructor);
        }
     

        public BEInstructor BuscarPorDNI_legajo(string legajo)
        {
            var instructor =  ListarTodo().Find(x => x.Legajo == Convert.ToInt32(legajo));
            if (instructor != null)
            {
                instructor = ListarObjeto(instructor);
            }
            return instructor;

        }


        public bool Eliminar(BEInstructor instructor)
        {
            return mpPinstructor.Eliminar(instructor);
        }
        public BEInstructor ListarObjeto(BEInstructor instructor)
        {
            return mpPinstructor.ListarObjeto(instructor);
        }



    }
}

