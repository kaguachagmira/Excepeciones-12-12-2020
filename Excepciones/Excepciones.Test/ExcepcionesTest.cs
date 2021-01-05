using Excepciones.Negocio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.IO;

namespace Excepciones.Test
{
    [TestClass]
    public class ExcepcionesTest
    {
        [TestMethod]
        [ExpectedException (typeof(DivideByZeroException))]
        public void DividirParaCero()
        {
            var dividendo = 5;
            var divisor = 0;

            var resultadoEsperado = new DivideByZeroException();


            var ejemplo = new ExepcionesEjemplo();

            _ = ejemplo.DividirParaCero(dividendo,divisor);

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void probarMensaje()
        {
            string mensaje = null;

            var ejemplo = new ExepcionesEjemplo();
            _ = ejemplo.probarMensaje(mensaje);
            
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void probarRangoMaximo()
        {
            int maximo = 30;
            var ejemplo = new ExepcionesEjemplo();
            _ = ejemplo.probarRangoMaximo(maximo);
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void probarRangoArreglo()
        {
            int rangoArreglo = 10;
            int[] arregloPrueba = new int[5];

            var ejemplo = new ExepcionesEjemplo();
            _ = ejemplo.probarRangoArreglo(rangoArreglo, arregloPrueba);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void probarArchivo()
        {
            string nombreArchivo = "archivo.txt";
            StreamWriter sw = new StreamWriter(nombreArchivo);

            var ejemplo = new ExepcionesEjemplo();
            ejemplo.probarArchivo(sw);
        }
        [TestMethod]
        [ExpectedException(typeof(OwnExceptionRange))]
        public void probarException()
        {
            string nombreRango = "holamundito";
            var ejemplo = new ExepcionesEjemplo();
            _=ejemplo.probarException(nombreRango);

        }
    }
}
