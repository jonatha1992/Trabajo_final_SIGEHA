using Abstraccion;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace DAL
{
    public class Conexion
    {

        static string ConexionsString { get; set; }
        static string XmlFilePath { get; set; }

        public bool TestConection()
        {
            using (StreamReader archivo = new StreamReader(@"ConexionString.txt"))
            {
                ConexionsString = archivo.ReadLine();
            }

            bool fileExist = File.Exists(ConexionsString);

            if (fileExist)
            {
                XmlFilePath = ConexionsString;
            }
            else
            {
                XmlFilePath = "Base de datos.xml";
            }

            return File.Exists(XmlFilePath);
        }

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
        public XElement LeerObjeto(string NodoContenedor, string idElemento)
        {
            try
            {
                XDocument xdoc = XDocument.Load(XmlFilePath);

                XElement ElementoGenerico = xdoc.Descendants(NodoContenedor)
                                                 .FirstOrDefault(e => e.Element("Id")?.Value == idElemento);

                return ElementoGenerico;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Agregar(string NodoPadre, XElement elemento)
        {
            try
            {
                XDocument xmlDoc = XDocument.Load(XmlFilePath);
                XElement elementoPadre = xmlDoc.Descendants(NodoPadre).First();

                if (elementoPadre == null)
                {
                    elementoPadre = new XElement(NodoPadre);
                    xmlDoc.Root.Add(elementoPadre);
                }


                elementoPadre.Add(elemento);

                xmlDoc.Save(XmlFilePath);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
        }

        public bool Actualizar(string NodoPadre, string idElemento, XElement nuevoElemento)
        {
            try
            {
                XDocument xmlDoc = XDocument.Load(XmlFilePath);
                XElement elementoPadre = xmlDoc.Descendants(NodoPadre).FirstOrDefault();

                if (elementoPadre == null)
                {
                    throw new Exception($"No se encontró el nodo: {NodoPadre}");
                }

                XElement elementoAActualizar = elementoPadre.Elements()
                                                            .FirstOrDefault(e => e.Element("Id")?.Value == idElemento);

                if (elementoAActualizar == null)
                {
                    throw new Exception($"No se encontró el elemento con el Id: {idElemento} en el nodo: {NodoPadre}");
                }

                // Para cada elemento en el nuevoElemento
                foreach (XElement element in nuevoElemento.Elements())
                {
                    // Comprueba si el elemento ya existe en elementoAActualizar
                    XElement existingElement = elementoAActualizar.Element(element.Name);
                    if (existingElement != null)
                    {
                        // Si existe, actualiza su valor
                        existingElement.Value = element.Value;
                    }
                    else
                    {
                        // Si no existe, añádelo
                        elementoAActualizar.Add(new XElement(element.Name, element.Value));
                    }
                }

                xmlDoc.Save(XmlFilePath);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
        }

        public int ObtenerUltimoID(string elementoPadre)
        {
            try
            {
                XDocument xmlDoc = XDocument.Load(XmlFilePath);
                IEnumerable<XElement> elementos = xmlDoc.Descendants(elementoPadre).Elements();

                if (elementos.Any())
                {
                    int ultimoId = elementos.Max(x => (int)x.Element("Id"));
                    return ultimoId + 1;
                }

                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
        }

        public bool EliminarConCriterio(string NodoPadre, Func<XElement, bool> criterioEliminacion)
        {
            try
            {
                XDocument xmlDoc = XDocument.Load(XmlFilePath);
                XElement elementoPadre = xmlDoc.Descendants(NodoPadre).FirstOrDefault();

                if (elementoPadre == null)
                {
                    throw new Exception($"No se encontró el nodo: {NodoPadre}");
                }

                XElement elementoAEliminar = elementoPadre.Elements().FirstOrDefault(criterioEliminacion);

                if (elementoAEliminar == null)
                {
                    throw new Exception($"No se encontró el elemento con el criterio especificado en el nodo: {NodoPadre}");
                }

                elementoAEliminar.Remove();
                xmlDoc.Save(XmlFilePath);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
        }

        public bool Eliminar(string NodoPadre, string idElemento, string elementocontenedor = "", bool eliminarTodos = false)
        {
            try
            {
                XDocument xmlDoc = XDocument.Load(XmlFilePath);
                XElement elementoPadre = xmlDoc.Descendants(NodoPadre).FirstOrDefault();

                if (elementoPadre == null)
                {
                    throw new Exception($"No se encontró el nodo: {NodoPadre}");
                }

                IEnumerable<XElement> elementosAEliminar;

                if (elementocontenedor == "") // si es una tabla normal
                {
                    elementosAEliminar = elementoPadre.Elements().Where(e => e.Element("Id")?.Value == idElemento);
                }
                else //si es una tabla de muchos a muchos
                {
                    elementosAEliminar = elementoPadre.Elements().Where(e => e.Element(elementocontenedor)?.Value == idElemento);
                }

                if (!elementosAEliminar.Any())
                {
                    throw new Exception($"No se encontró el elemento con el Id: {idElemento} en el nodo: {NodoPadre}");
                }

                // Elimina el elemento o los elementos
                if (eliminarTodos)
                {
                    foreach (var elemento in elementosAEliminar.ToList())
                    {
                        elemento.Remove();
                    }
                }
                else
                {
                    elementosAEliminar.First().Remove();
                }

                xmlDoc.Save(XmlFilePath);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
        }


    }
}
