using Abstraccion;
using BE;
using MPP;
using System.Collections.Generic;

namespace Negocio
{
    public class BLLEstado_Persona : IGestor<BEEstado_Persona>
    {
        MPPEstado_Persona mpEstado_persona;

        public BLLEstado_Persona()
        {
            mpEstado_persona = new MPPEstado_Persona();
        }

        public bool Actualizar(BEEstado_Persona Object)
        {
            throw new System.NotImplementedException();
        }

        public BEEstado_Persona Agregar(BEEstado_Persona Object)
        {
            throw new System.NotImplementedException();
        }

        public bool Eliminar(BEEstado_Persona Object)
        {
            throw new System.NotImplementedException();
        }

        public BEEstado_Persona ListarObjeto(BEEstado_Persona Estdo_persona)
        {
            return mpEstado_persona.ListarObjeto(Estdo_persona);
        }

        public List<BEEstado_Persona> ListarTodo()
        {
            return mpEstado_persona.ListarTodo();
        }
    }
}
