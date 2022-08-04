using System;

namespace Random2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Random rnd = new Random();
            Console.WriteLine(rnd.Next(0, 99));
        }
    }
}
