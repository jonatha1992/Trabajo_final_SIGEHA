using Abstraccion;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using BE;
using System.Xml.Linq;

namespace DAL
{
    public class Conexion
    {

        string XmlFilePathBaseDatos = "BaseDatos/Base de datos.xml";
        string XmlFilePathBitacora = "BaseDatos/Bitacora.xml";
        string XmlFolderPathBackup = "BackUps";


        public bool GenerarBackUp(BEBackUp bEBackUp )
        {

            try
            {
                string rutaDestino = Path.Combine(XmlFolderPathBackup, bEBackUp.NombreArchivo);
                File.Copy(XmlFilePathBaseDatos, rutaDestino);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool RestaurarBackUp(BEBackUp bEBackUp)
        {
            try
            {
                string rutaBackup = Path.Combine(XmlFolderPathBackup, bEBackUp.NombreArchivo);

                // Restaurar el backup copiando el archivo al archivo de base de datos
               
                string rutaDestino = Path.Combine(Path.GetDirectoryName(XmlFilePathBaseDatos), "Base de datos.xml");
                File.Copy(rutaBackup, rutaDestino, true);

                return true;
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante la restauración del backup
                Console.WriteLine($"Error al restaurar el backup: {ex.Message}");
                return false;
            }
        }

        public string[] ListarBackups()
        {
            if (!Directory.Exists(XmlFolderPathBackup))
            {
                Directory.CreateDirectory(XmlFolderPathBackup);
            }
            
            string[] rutasArchivos = Directory.GetFiles(XmlFolderPathBackup);
            return rutasArchivos;
        }

        public IEnumerable<XElement> LeerTodosEventos(string Nodopadre)
        {
            try
            {
                XDocument xdoc = XDocument.Load(XmlFilePathBitacora);

                IEnumerable<XElement> ElementosGenericos = xdoc.Descendants(Nodopadre);

                return ElementosGenericos;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public bool AgregarEvento(string NodoPadre, XElement elemento)
        {
            try
            {
                XDocument xmlDoc = XDocument.Load(XmlFilePathBitacora);
                XElement elementoPadre = xmlDoc.Descendants(NodoPadre).First();

                if (elementoPadre == null)
                {
                    elementoPadre = new XElement(NodoPadre);
                    xmlDoc.Root.Add(elementoPadre);
                }


                elementoPadre.Add(elemento);

                xmlDoc.Save(XmlFilePathBitacora);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
        }

        public int ObtenerUltimoIDBitacora(string elementoPadre)
        {
            try
            {
                XDocument xmlDoc = XDocument.Load(XmlFilePathBitacora);
                IEnumerable<XElement> elementos = xmlDoc.Descendants(elementoPadre).Elements();

                if (elementos.Any())
                {
                    int ultimoId = elementos.Max(x => (int)x.Element("Id"));
                    return ultimoId + 1;
                }

                return 1;
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
        }

        public bool TestConection()
        {
            //using (StreamReader archivo = new StreamReader(@"ConexionString.txt"))
            //{
            //    ConexionsString = archivo.ReadLine();
            //}

            //bool fileExist = File.Exists(ConexionsString);

            //if (fileExist)
            //{
            //    XmlFilePathBaseDatos = ConexionsString;
            //}
            //else
            //{
            //    XmlFilePathBaseDatos = "BaseDatos/Base de datos.xml";
            //}

            return File.Exists(XmlFilePathBaseDatos);
        }

        public IEnumerable<XElement> LeerTodos(string Nodopadre)
        {
            try
            {
                XDocument xdoc = XDocument.Load(XmlFilePathBaseDatos);

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
                XDocument xdoc = XDocument.Load(XmlFilePathBaseDatos);

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
                XDocument xmlDoc = XDocument.Load(XmlFilePathBaseDatos);
                XElement elementoPadre = xmlDoc.Descendants(NodoPadre).First();

                if (elementoPadre == null)
                {
                    elementoPadre = new XElement(NodoPadre);
                    xmlDoc.Root.Add(elementoPadre);
                }


                elementoPadre.Add(elemento);

                xmlDoc.Save(XmlFilePathBaseDatos);

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
                XDocument xmlDoc = XDocument.Load(XmlFilePathBaseDatos);
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

                //// Elimina los elementos existentes que no se encuentren en el nuevoElemento
                //foreach (XElement existingElement in elementoAActualizar.Elements().ToList())
                //{
                //    if (!nuevoElemento.Elements().Any(e => e.Name == existingElement.Name))
                //    {
                //        existingElement.Remove();
                //    }
                //}

                xmlDoc.Save(XmlFilePathBaseDatos);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
        }

        public int ObtenerUltimoID(string NodoPadre)
        {
            try
            {
                XDocument xmlDoc = XDocument.Load(XmlFilePathBaseDatos);
                IEnumerable<XElement> elementos = xmlDoc.Descendants(NodoPadre).Elements();

                if (elementos.Any())
                {
                    int ultimoId = elementos.Max(x => (int)x.Element("Id"));
                    return ultimoId + 1;
                }

                return 1;
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
                XDocument xmlDoc = XDocument.Load(XmlFilePathBaseDatos);
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
                xmlDoc.Save(XmlFilePathBaseDatos);

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
                XDocument xmlDoc = XDocument.Load(XmlFilePathBaseDatos);
                XElement elementoPadre = xmlDoc.Descendants(NodoPadre).FirstOrDefault();

                if (elementoPadre == null)
                {
                    return false;
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
                    return false;
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

                xmlDoc.Save(XmlFilePathBaseDatos);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
        }


    }
}
