
using System;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine();
            string text = Console.ReadLine();
            int x = Convert.ToInt32(text);

            switch (x)
            {
                case 1:
                    Console.WriteLine("Число 1");
                    break;
                case 2:
                    Console.WriteLine("Число 2");
                    break;

            }

            Console.WriteLine("Все");
        }
    }
}