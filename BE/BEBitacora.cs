using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BE
{


    public class Bitacora
    {
        private readonly string rutaArchivoBitacora;


        public Bitacora(string rutaArchivoBitacora)
        {
            this.rutaArchivoBitacora = rutaArchivoBitacora;
        }

        public void RegistrarEvento(BEUsuario usuario, string mensaje)
        {
            BEEvento evento = new BEEvento()
            {
                Fecha = DateTime.Now,
                Usuario = usuario,
                Mensaje = mensaje
            };

            List<BEEvento> eventos = CargarEventosDesdeBitacora();
            eventos.Add(evento);
            GuardarEventosEnBitacora(eventos);
        }

        private List<BEEvento> CargarEventosDesdeBitacora()
        {
            return new List<BEEvento>();
        }

        private void GuardarEventosEnBitacora(List<BEEvento> eventos)
        {
        
        }
    }
}
