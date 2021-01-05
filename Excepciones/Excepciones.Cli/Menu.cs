using System;
using Excepciones.Negocio;
namespace Excepciones.Cli
{
    class Menu
    {
        static void Main(string[] args)
        {
            var calculadora = new ExepcionesEjemplo();
            var contador = 0;
            do
            {
                Console.WriteLine("Ingrese el divisor");
                var divisor = Console.ReadLine();
                var resultado = calculadora.DividirParaCero(22, int.Parse(divisor));
                Console.WriteLine("La division es:" + resultado);
                contador++;
            } while (contador<3);

        }

    }
}
