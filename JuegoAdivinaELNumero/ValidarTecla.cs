using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoAdivinaELNumero
{
    internal class ValidarTecla
    {
        private bool teclaValidada;

        public bool ValidaTecla()
        {
            ConsoleKeyInfo inputchar;
            teclaValidada = false;
            int corteWhile = 0;

            Console.WriteLine("Presione la tecla 'Enter' para empezar a jugar o 'Escape' para salir.");
            while (corteWhile == 0)
            {

                try
                {
                    inputchar = Console.ReadKey();

                    if (inputchar.Key == ConsoleKey.Enter)
                    {
                        teclaValidada = true;
                        corteWhile++;
                    }
                    else if(inputchar.Key == ConsoleKey.Escape)
                    {
                        teclaValidada = false;
                        Console.WriteLine("HHas precionado 'Escape',saliendo...");
                        corteWhile++;
                        break;
                    }
                    else 
                        Console.WriteLine("\nTecla incorrecta solo 'Enter' o 'Escape' son validas");
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine("\nLa operacion no se a podido realizar, intente nuevamente");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nSe produjo un error");
                }
               
            }

            return teclaValidada;
        }

        public bool ReJugar()
        {
            ConsoleKeyInfo inputchar;
            teclaValidada = false;
            int corteWhile = 0;


            while (corteWhile == 0)
            {
                Console.WriteLine("Desea volver a jugar?('Enter',si/'Escape',no)");

                try
                {
                    inputchar = Console.ReadKey();
                    if (inputchar.Key == ConsoleKey.Enter)
                    {
                        teclaValidada = true;
                        corteWhile++;
                    }
                    else if (inputchar.Key == ConsoleKey.Escape)
                    {
                        teclaValidada = false;
                        Console.WriteLine("HHas precionado 'Escape',saliendo...");
                        corteWhile++;
                        break;
                    }
                    else
                        Console.WriteLine("\nTecla incorrecta solo 'Enter' es valido");
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine("\nLa operacion no se a podido realizar, intente nuevamente");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nSe produjo un error");
                }
            }
            return teclaValidada;
        }
    }
}

