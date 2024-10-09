using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoAdivinaELNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int contJuego = 0;            
            ValidarTecla validar = new ValidarTecla();
            NumeroAlatorio numjuego = new NumeroAlatorio();
            //string input;
            
            numero = numjuego.GenerarNumeroAleatorio();

            ValidarNumero valNumero = new ValidarNumero();

            Console.WriteLine("ADIVINA EL NÚMERO");
            Console.WriteLine("Intena adivinar un número del 1 al 100 en la menor cantidad de intentos posible");

            while (true)
            {
                if(contJuego == 0)
                {
                     if (validar.ValidaTecla())
                     {
                         Console.WriteLine("Comencemos a jugar");
                         Console.WriteLine(valNumero.NumeroValidado(numero));
                         contJuego = 1;
                    }
                     else
                     {
                         Console.WriteLine("Precione nuevamente 'Escape' para salir");
                         break;
                     }
                }
                else
                {
                    if(validar.ReJugar())
                    {
                        numero = numjuego.GenerarNumeroAleatorio();
                        Console.WriteLine(valNumero.NumeroValidado(numero));
                    }
                    else
                    {
                        Console.WriteLine("Precione nuevamente 'Escape' para salir");
                        break;
                    }
                }
                
                

            }
            Console.ReadKey();    

        }
    }
}
