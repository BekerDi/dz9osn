using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz9osn
{
    internal class Mouse
    {
        Random rnd = new Random();
        public int position;
        public bool flag1 = false;
        public bool flag2 = false;
        public bool flag3 = false;
        public bool flag4 = false;


        public int x = 0;

        public void Champion()
        {
            while (x != 4)
            {
                int value = rnd.Next(0, 60);

                if (-1 < value && value < 15 && flag1 == false) { x++; position = x; Console.WriteLine($"Место России: {position} "); flag1 = true; }

                if (14 < value && value < 30 && flag2 == false) { x++; position = x; Console.WriteLine($"Место Казахстана: {position} "); flag2 = true; }

                if (29 < value && value < 45 && flag3 == false) { x++; position = x; Console.WriteLine($"Место Китая: {position} "); flag3 = true; }

                if (44 < value && value < 60 && flag4 == false) { x++; position = x; Console.WriteLine($"Место Англии: {position} "); flag4 = true; }
            }
        }
    }
}

