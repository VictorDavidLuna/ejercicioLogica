using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoAdivinaELNumero
{
    internal class NumeroAlatorio
    {
        private int n;
      
        
       

        public int GenerarNumeroAleatorio()
        {
            Random random = new Random();
            n = random.Next(1, 101);

            return n;
        }
    }
}
