using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz9osn
{
    public class France
    {
        public int count = 0;
        public static int[] nNum;
        public static int n = 15;
        public France (int count)
        {
            nNum = new int[n];
            for (int i = 0; i < n; i++)
                nNum[i] = i + count * 15;
        }
        public void Print()
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{nNum[i]}");
            }
            Console.WriteLine("\n");
        }






    }

}
