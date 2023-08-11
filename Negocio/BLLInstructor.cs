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

            return mpPinstructor.Agregar(pinstructor);
        }

        public bool Actualizar(BEInstructor instructor)
        {
            return mpPinstructor.Actualizar(instructor);
        }


        public BEInstructor BuscarPor_legajo_dni(string legajo, string dni = "")
        {
            int legajoInt;
            if (int.TryParse(legajo, out legajoInt))
            {
                var instructores = ListarTodo();
                if (instructores != null)
                {
                    var instructor = instructores.Find(x => x.Legajo == legajoInt);
                    if (instructor != null)
                    {
                        return ListarObjeto(instructor);
                    }
                }
            }

            if (!string.IsNullOrEmpty(dni))
            {
                var instructores = ListarTodo();
                if (instructores != null)
                {
                    var instructor = instructores.Find(x => x.DNI == dni);
                    if (instructor != null)
                    {
                        return ListarObjeto(instructor);
                    }
                }
            }

            return null;

        }
        public bool VerficarExiste_DNI_Legajo(int legajo, string dni)
        {
            var instructores = ListarTodo();
            if (instructores != null)
            {
                return instructores.Exists(x => x.Legajo == legajo || x.DNI == dni);
            }
            return false;
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

