using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL
{
    public class DALBitacora
    {

        static string XmlFilePath = "Bitacora.xml";


        public IEnumerable<XElement> LeerTodos(string Nodopadre)
        {
            try
            {
                XDocument xdoc = XDocument.Load(XmlFilePath);

                IEnumerable<XElement> ElementosGenericos = xdoc.Descendants(Nodopadre);

                return ElementosGenericos;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }

}
