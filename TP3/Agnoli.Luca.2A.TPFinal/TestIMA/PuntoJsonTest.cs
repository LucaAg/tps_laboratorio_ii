using BibliotecaIMA;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestIMA
{
    [TestClass]
    public class PuntoJsonTest
    {
        [TestMethod]
        public void PuntoJson_DeberiaRetornarTrue_SiLaExtensionEsTipoJson()
        {
            //Arrange
            string ruta = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\MiArchivo.json";
            PuntoJson<string> json = new PuntoJson<string>();
            bool rutaValidacion = json.ValidarExtension(ruta);
            // string 
            Assert.IsTrue(rutaValidacion);
        }

        [TestMethod]
        [ExpectedException(typeof(MiExcepcionArchivoInvalido))]
        public void PuntoJson_DeberiaLanzarMiExcepcionArchivoInvalido_SiElArchivoNoEsExiste()
        {
            //Arrange
            string ruta = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\ArchivoArchivo.json";
            PuntoJson<string> json = new PuntoJson<string>();
            if(!json.ValidarSiExisteElArchivo(ruta))
            {
                throw new MiExcepcionArchivoInvalido("Archivo invalido", "Error", "Test puntoJson");
            }
        }
    }
}
