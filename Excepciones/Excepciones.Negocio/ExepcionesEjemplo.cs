using System;
using System.Collections;
using System.IO;

namespace Excepciones.Negocio
{
    public class ExepcionesEjemplo
    {
        public ExepcionesEjemplo()
        {

        }
        public double DividirParaCero(double dividendo, double divisor)
        {
            
            if(divisor==0)
            {
                throw new DivideByZeroException("La divisor es 0 el resultado sera infinito");
            }
            else
            {
                double resultado = dividendo / divisor;
                return resultado;
            }
        }
        public string probarMensaje(string mensaje)
        {
            if (mensaje == null)
            {
                throw new ArgumentNullException("La cadena no puede o no debe ser null");
            }
            else
            {
                return "El mensaje fue: " + mensaje;
            }
        }
        public int probarRangoMaximo(int maximo)
        {
            if (maximo > 20)
            {
                throw new ArgumentOutOfRangeException("El numero debe ser menos 20");
            }
            else
            {
                return maximo;
            }
        }
        public bool probarRangoArreglo(int maximo, int [] arreglo)
        {
            if (maximo > arreglo.Length)
            {
                throw new IndexOutOfRangeException("El rango es mayor a la loguitud del arreglo ");
            }
            else
            {
                return true;
            }
        }
        public void probarArchivo(StreamWriter sw)
        {
            sw.WriteLine("Hola");
            sw.WriteLine("Mundo");
            sw.Close();
            try
            {
                sw.WriteLine("VAAAMOS");
            }
            catch
            {
                throw new InvalidOperationException("El archivo ya fue cerrado");
            }
        }
        public void probarArrayNull(ArrayList prueba)
        {

            try
            {
                prueba.Add(1);
            }
            catch
            {
                throw new NullReferenceException("El ArrayList fue inicializado con null");
            }
        }
        public bool  probarException(string nombreRango)
        {
            if (nombreRango.Length > 5)
            {
                throw new OwnExceptionRange("La longuitud sobrepasa el ejemplo");

            }
            else
            {
                return true;
            }
        }


    }
}
