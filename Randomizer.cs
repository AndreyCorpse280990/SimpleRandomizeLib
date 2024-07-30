using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRandomizeLib
{
    public class Randomizer
    {
        // Объект для генерации объектов
        private static readonly Random random = new Random();

        // функции рандомной генерации
        public int Int()
        {
            return random.Next();
        }

        public int IntN(int n) 
        {
            return random.Next(n);
        }

        public int IntRange(int min, int max)
        {
            return random.Next(min, max);
        }

        public bool Bool()
        {
            return random.Next(2) == 0;
        }
    }
}
