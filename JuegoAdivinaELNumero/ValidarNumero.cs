using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoAdivinaELNumero
{
    internal class ValidarNumero
    {
        private string validacion;


        public string NumeroValidado(int numero)
        {
            string input;
            int inputNumero;
            int contador = 0;
            int corte  = 0;
            while (corte == 0)
            {
                Console.WriteLine("Ingresa un número:");
                try
                {
                    input = Console.ReadLine();
                    inputNumero = int.Parse(input);

                    if (inputNumero == numero)
                    {
                        contador++;
                        validacion = "Has ganado en : " + contador + " intentos";
                        corte = 1;
                    }

                    else if (inputNumero < numero)
                    {
                        Console.WriteLine("te falta");
                        contador++;
                    }
                    else if (inputNumero > numero)
                    {
                        Console.WriteLine("te pasaste");
                        contador++;
                    }

                }
                catch (FormatException ex)
                {
                    Console.WriteLine("El programa solo admite números.");                    
                }
            }
            return validacion;
        }
    }
}
