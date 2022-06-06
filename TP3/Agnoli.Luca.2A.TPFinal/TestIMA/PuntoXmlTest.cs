using BibliotecaIMA;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIMA
{
    [TestClass]
    public class PuntoXmlTest
    {
        [TestMethod]
        public void PuntoXml_DeberiaRetornarTrue_SiLaExtensionEsTipoXml()
        {
            //Arrange
            string ruta = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\MiArchivo.xml";
            PuntoXml<string> xml = new PuntoXml<string>();
            bool rutaValidacion = xml.ValidarExtension(ruta);
            // string 
            Assert.IsTrue(rutaValidacion);
        }

        [TestMethod]
        [ExpectedException(typeof(MiExcepcionArchivoInvalido))]
        public void PuntoXml_DeberiaLanzarMiExcepcionArchivoInvalido_SiElArchivoNoEsExiste()
        {
            //Arrange
            string ruta = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\ArchivoArchivo.xml";
            PuntoTxt<string> xml = new PuntoTxt<string>();
            if (!xml.ValidarSiExisteElArchivo(ruta))
            {
                throw new MiExcepcionArchivoInvalido("Archivo invalido", "Error", "Test puntoJson");
            }
        }
    }
}
