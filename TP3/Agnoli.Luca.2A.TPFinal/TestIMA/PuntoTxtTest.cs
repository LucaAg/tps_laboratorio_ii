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
    public class PuntoTxtTest
    {
        [TestMethod]
        public void PuntoTxt_DeberiaRetornarTrue_SiLaExtensionEsTipoTxt()
        {
            //Arrange
            string ruta = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\MiArchivo.txt";
            PuntoTxt<string> txt = new PuntoTxt<string>();
            bool rutaValidacion = txt.ValidarExtension(ruta);
            // string 
            Assert.IsTrue(rutaValidacion);
        }

        [TestMethod]
        [ExpectedException(typeof(MiExcepcionArchivoInvalido))]
        public void PuntoTxt_DeberiaLanzarMiExcepcionArchivoInvalido_SiElArchivoNoEsExiste()
        {
            //Arrange
            string ruta = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\ArchivoArchivo.txt";
            PuntoTxt<string> txt = new PuntoTxt<string>();
            if (!txt.ValidarSiExisteElArchivo(ruta))
            {
                throw new MiExcepcionArchivoInvalido("Archivo invalido", "Error", "Test puntoJson");
            }
        }
    }
}
