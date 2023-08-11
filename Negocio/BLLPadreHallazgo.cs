using BE;

namespace Negocio
{
    public abstract class BLLPadreHallazgo
    {
        //public abstract string ObtenerNroActa(BEUnidad unidad, int anio);
        public abstract int ObtenerNroActa(BEUnidad unidad, int anio);
        public abstract int ExtraerNro(string nroActa, BEUnidad unidad);

    }
}
