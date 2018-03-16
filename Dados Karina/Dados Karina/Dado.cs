using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados_Karina
{
    class Dado
    {
        Random rnd = new Random();

        private int lado;
        private int lado2;

        public int Lado { get => lado; }


        public int lanzar()
        {
            lado = rnd.Next(1, 7);
            return lado;
        }

     
        
    }
}
