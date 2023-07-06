using Abstraccion;
using BE;
using MPP;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public class BLLPersona : IGestor<BEPersona>
    {
        MPPPersona mpPPersonas;

        public BLLPersona()
        {
            mpPPersonas = new MPPPersona();
        }

        public bool AgregarPersonaHallazgo(BEHallazgo hallazgo, BEPersona ePersona)
        {
            if (ePersona.Id == 0)
            {
                var personas = ListarTodo();
                if (personas != null)
                {
                    if (personas.Exists(x => x.DNI == ePersona.DNI))
                    {
                        ePersona.Id = ListarTodo().Find(x => x.DNI == ePersona.DNI).Id;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
            return mpPPersonas.AgregarPersonaHallazgo(hallazgo, ePersona);
        }

        public bool AgregarPersonaEntrega(BEEntrega entrega, BEPersona ePersona)
        {

            if (ePersona.Id == 0)
            {
                ePersona.Id = ListarTodo().Find(x => x.DNI == ePersona.DNI).Id;
            }
            return mpPPersonas.AgregarPersonaEntrega(entrega, ePersona);
        }

        public bool ElimnarPersonaHallazgo(BEHallazgo hallazgo, BEPersona persona)
        {
            return mpPPersonas.EliminarPersonaHallazgo(hallazgo, persona);
        }

        public bool EliminarPersonaEntrega(BEEntrega entrega, BEPersona persona)
        {
            return mpPPersonas.EliminarPersonaEntrega(entrega, persona);
        }

        public BEPersona Agregar(BEPersona persona)
        {

            //Verificar el legajo SI EXISTE EN LA BASE DE DATOS
            var Personabuscada = ListarTodo().Find((x => x.DNI == persona.DNI ));
        
            if (Personabuscada != null)
            {
                persona.Id = Personabuscada.Id;
                Actualizar(persona);
                return persona;

            }
            else
            {
                return mpPPersonas.Agregar(persona); //AGREGAR
            }
        }

        public bool Actualizar(BEPersona Object)
        {

            return mpPPersonas.Actualizar(Object);
        }

        public bool Eliminar(BEPersona Object)
        {
            return mpPPersonas.Eliminar(Object);
        }

        public List<BEPersona> ListarTodo()
        {
            return mpPPersonas.ListarTodo();
        }

        public BEPersona ListarObjeto(BEPersona Object)
        {
            return mpPPersonas.ListarObjeto(Object);
        }

        public BEPersona BuscarPorDNI(string dni)
        {
            return ListarTodo().Find(x => x.DNI == dni);
        }
        public BEInstructor ConvertirPersona_A_Instructor(BEPersona bEPersona, int legajo, BEJerarquia bEJerarquia)
        {
            BEInstructor bEInstructor = new BEInstructor();

            bEInstructor.Id = bEPersona.Id;
            bEInstructor.NombreCompleto = bEPersona.NombreCompleto;
            bEInstructor.DNI = bEPersona.DNI;
            bEInstructor.Ocupacion = bEPersona.Ocupacion;
            bEInstructor.Telefono = bEPersona.Telefono;
            bEInstructor.Domicilio = bEPersona.Domicilio;
            bEInstructor.Legajo = legajo;
            bEInstructor.Jerarquia = bEJerarquia;

            return bEInstructor;
        }
    }
}

