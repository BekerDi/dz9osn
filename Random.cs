using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz9osn
{
    internal class Gonki
    {
        Random rnd = new Random();
        public int position;
        public int flag1 = -1;
        public int flag2 = -1;
        public int flag3 = -1;
        public int flag4 = -1;


        public int x = 0;

        public void Champion()
        {
            while (x != 3)
            {
                int value = rnd.Next(0, 60);

                if (-1 < value && value < 15 && flag1 == -1) { x++; position = x; Console.WriteLine($"{x} Место: игрок {value} Россия"); flag1 = value; }

                if (14 < value && value < 30 && flag2 == -1) { x++; position = x; Console.WriteLine($"{x} Место:  игрок {value} Казахстана "); flag2 = value; }

                if (29 < value && value < 45 && flag3 == -1) { x++; position = x; Console.WriteLine($"{x} Место:игров {value}  Китая"); flag3 = value; }

                if (44 < value && value < 60 && flag4 == -1) { x++; position = x; Console.WriteLine($"{x}Место: игрок {value} Англии "); flag4 = value; }
            }
        }
    }
   
}
    
