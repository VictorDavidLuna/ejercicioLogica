using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Números Pares e Impares:

            //Escribe un programa que solicite al usuario un número entero y determine si es par o impar
            //
            //Extras: Agrega una opción para continuar verificando números hasta que el usuario decida detenerse
            //
            //  COMO HACER? Crear variable "n" despues preguntar con un if si es divisible por 2 si lo es el numero es par
            //  EXTRA 1 : despues hacer un while que corta si el número es cero
            //  ESTRA 2 : hacer manejo de exepciones con un bloque trycatch
            int n = 1;

            Console.WriteLine("Ingrese un numero, para saber si es par:");
            Console.WriteLine("El programa cierra cuando ingresa un cero");

            while (n > 0)
            {

                try
                {
                    n = int.Parse(Console.ReadLine());

                    if (n == 0)
                    {
                        Console.WriteLine("Programa finalizado");
                        break;
                    }


                    if (n % 2 == 0)
                    {
                        Console.WriteLine("El número : " + n + " es par");                     
                    }
                    else
                    {
                        Console.WriteLine("el numero : " + n + " es impar");                        
                    }                                                                                        
                   
                }

                catch (FormatException)
                {
                    Console.WriteLine("El programa solo admite números");

                    // throw;
                }
            }
           r
            Console.ReadKey();
        }
    }
}