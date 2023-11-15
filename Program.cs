using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz9osn
{
    internal class Program
    {
        static void Main(string[] args)
        {
         Russian team1 = new Russian(0);
         Kazakhstan team2 = new Kazakhstan(1);
         France team3 = new France(2);
         China team4 = new China(3);

            team1.Print();
            team2.Print();
            team3.Print();
            team4.Print();

            Console.WriteLine("Результат гонок");
            Gonki gonki = new Gonki(); 
            gonki.Champion();
            Console.WriteLine("Результат мышеловки");
            Mouse mouse = new Mouse(); 
            mouse.Champion();
           

            Console.ReadKey();
        }
    }
}
