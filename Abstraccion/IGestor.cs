using System.Collections.Generic;

namespace Abstraccion
{
    public interface IGestor<T> where T : IEntidad
    {
        T Agregar(T Object);
        bool Actualizar(T Object);
        bool Eliminar(T Object);
        List<T> ListarTodo();
        T ListarObjeto(T Object);
    }
}
