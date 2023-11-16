using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dzfiguri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point("Красный", true, 5, 7);
            point.Display();

            Circle circle = new Circle("Голубой", true, 10, 15, 8);
            circle.Display();

            Rectangle rectangle = new Rectangle("Зеленый", true, 20, 25, 10, 5);
            rectangle.Display();
            Console.WriteLine("Задание 2");

            ICipher acipher = new ACipher();
            ICipher bcipher = new BCipher();

            Console.WriteLine("Введите текст для шифрования:");
            string text = Console.ReadLine();

            string encodedTextA = acipher.Encode(text);
            string decodedTextA = acipher.Decode(encodedTextA);

            string encodedTextB = bcipher.Encode(text);
            string decodedTextB = bcipher.Decode(encodedTextB);

            Console.WriteLine("ACipher:");
            Console.WriteLine("Зашифровано: " + encodedTextA);
            Console.WriteLine("Расшифровано: " + decodedTextA);

            Console.WriteLine("BCipher:");
            Console.WriteLine("Зашифровано: " + encodedTextB);
            Console.WriteLine("Расшифровано: " + decodedTextB);
            Console.ReadKey();
        }
    }

}
    

