using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriajeApp.DomainServices;
using TriajeApp.Models;

namespace UnitTestTriajeApp
{
    [TestClass]
    public class EncuestaUnitTest
    {
        [TestMethod]
        public void PruebaParaValidarSiEncuestaExiste()
        {
            var encuesta = new Encuesta();
            var id = new int();
            encuesta = null;

            var encuestaDomainService = new EncuestaDomainService();
            var resultado = encuestaDomainService.GetEncuestaDomainService(id, encuesta);

            Assert.AreEqual("Este registro no existe.", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarSiHayEncuestaTipo()
        {
            var encuesta = new Encuesta();
            encuesta.encuestaTipo = "";

            var encuestaDomainService = new EncuestaDomainService();
            var resultado = encuestaDomainService.PostEncuestaDomainService(encuesta);

            Assert.AreEqual("Especifique el tipo de visita.", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarSiHayEmpleadoBarCode()
        {
            var encuesta = new Encuesta();
            encuesta.empleadoBarcode = "";

            var encuestaDomainService = new EncuestaDomainService();
            var resultado = encuestaDomainService.PostEncuestaDomainService(encuesta);

            Assert.AreEqual("Se necesita el barcode del empleado.", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarSiHayEmpleadoDNI()
        {
            var encuesta = new Encuesta();
            encuesta.empleadoDNI = "";

            var encuestaDomainService = new EncuestaDomainService();
            var resultado = encuestaDomainService.PostEncuestaDomainService(encuesta);

            Assert.AreEqual("Se necesita la identificación del empleado.", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarSiHayEmpleadoNombre()
        {
            var encuesta = new Encuesta();
            encuesta.empleadoNombre = "";

            var encuestaDomainService = new EncuestaDomainService();
            var resultado = encuestaDomainService.PostEncuestaDomainService(encuesta);

            Assert.AreEqual("Se necesita el nombre del empleado.", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarSiHayEmpleadoTelefono()
        {
            var encuesta = new Encuesta();
            encuesta.empleadoTelefono = "";

            var encuestaDomainService = new EncuestaDomainService();
            var resultado = encuestaDomainService.PostEncuestaDomainService(encuesta);

            Assert.AreEqual("Se necesita el telefono del empleado.", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarSiHayEmpleadoSexo()
        {
            var encuesta = new Encuesta();
            encuesta.empleadoSexo = "";

            var encuestaDomainService = new EncuestaDomainService();
            var resultado = encuestaDomainService.PostEncuestaDomainService(encuesta);

            Assert.AreEqual("Se necesita el sexo del empleado.", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarSiHayEmpresaNombre()
        {
            var encuesta = new Encuesta();
            encuesta.empresaNombre = "";

            var encuestaDomainService = new EncuestaDomainService();
            var resultado = encuestaDomainService.PostEncuestaDomainService(encuesta);

            Assert.AreEqual("Se necesita el nombre de la empresa.", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarSiHayEmpresaEdificio()
        {
            var encuesta = new Encuesta();
            encuesta.empresaEdificio = "";

            var encuestaDomainService = new EncuestaDomainService();
            var resultado = encuestaDomainService.PostEncuestaDomainService(encuesta);

            Assert.AreEqual("Se necesita el edificio donde se encuentra la empresa.", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarSiHayEmpresaNivel()
        {
            var encuesta = new Encuesta();
            encuesta.empresaNivel = "";

            var encuestaDomainService = new EncuestaDomainService();
            var resultado = encuestaDomainService.PostEncuestaDomainService(encuesta);

            Assert.AreEqual("Se necesita el nivel en el que se encuentra la empresa.", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarSiHayKitBienvenida()
        {
            var encuesta = new Encuesta();
            encuesta.kitBienvenida = "";

            var encuestaDomainService = new EncuestaDomainService();
            var resultado = encuestaDomainService.PostEncuestaDomainService(encuesta);

            Assert.AreEqual("Se necesita una respuesta.", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarSiHayHaViajado()
        {
            var encuesta = new Encuesta();
            encuesta.haViajado = "";

            var encuestaDomainService = new EncuestaDomainService();
            var resultado = encuestaDomainService.PostEncuestaDomainService(encuesta);

            Assert.AreEqual("Se necesita una respuesta.", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarSiHayCercaniaCovid()
        {
            var encuesta = new Encuesta();
            encuesta.cercaniaCovid = "";

            var encuestaDomainService = new EncuestaDomainService();
            var resultado = encuestaDomainService.PostEncuestaDomainService(encuesta);

            Assert.AreEqual("Se necesita una respuesta.", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarSiHayEmpleadoSintomas()
        {
            var encuesta = new Encuesta();
            encuesta.empleadoSintomas = "";

            var encuestaDomainService = new EncuestaDomainService();
            var resultado = encuestaDomainService.PostEncuestaDomainService(encuesta);

            Assert.AreEqual("Se necesitan los síntomas del empleado.", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarSiHayAlertaIncapacidad()
        {
            var encuesta = new Encuesta();
            encuesta.alertaIncapacidad = "";

            var encuestaDomainService = new EncuestaDomainService();
            var resultado = encuestaDomainService.PostEncuestaDomainService(encuesta);

            Assert.AreEqual("Se necesita una respuesta.", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarSiHayReintegroIncapacidad()
        {
            var encuesta = new Encuesta();
            encuesta.reintegroIncapacidad = "";

            var encuestaDomainService = new EncuestaDomainService();
            var resultado = encuestaDomainService.PostEncuestaDomainService(encuesta);

            Assert.AreEqual("Se necesita una respuesta.", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarSiHayEmpleadoIncapacitado()
        {
            var encuesta = new Encuesta();
            encuesta.empleadoIncapacitado = "";

            var encuestaDomainService = new EncuestaDomainService();
            var resultado = encuestaDomainService.PostEncuestaDomainService(encuesta);

            Assert.AreEqual("Se necesita una respuesta.", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarSiHayEmpleadoVacunado()
        {
            var encuesta = new Encuesta();
            encuesta.empleadoVacunado = "";

            var encuestaDomainService = new EncuestaDomainService();
            var resultado = encuestaDomainService.PostEncuestaDomainService(encuesta);

            Assert.AreEqual("Se necesita una respuesta.", resultado);
        }
    }
}
