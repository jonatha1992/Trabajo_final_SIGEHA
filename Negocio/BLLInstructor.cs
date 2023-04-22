using Abstraccion;
using BE;
using MPP;
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
            //Verificar el DNI SI EXISTE EN LA BASE DE DATOS
            var instructores = ListarTodo();
            if (instructores.Exists(x => x.DNI == pinstructor.DNI || x.Legajo == pinstructor.Legajo))
            {
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
        public bool Conversion(BEInstructor instructor)
        {

            return mpPinstructor.Conversion(instructor);
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

