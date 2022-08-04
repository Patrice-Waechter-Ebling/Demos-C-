using System;

namespace Demo_Param2_ref
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            double b = 2;
            decimal c = 2;
            string d="Patate";

            Console.WriteLine("---> Avant :");
            Console.WriteLine($"a : {a}");
            Console.WriteLine($"b : {b}");
            Console.WriteLine($"c : {c}");
            Console.WriteLine($"d : {d}");
            MethodeParamDemo(a,ref b,c,ref d);
            Console.WriteLine("---> Après :");
            Console.WriteLine($"a : {a}");
            Console.WriteLine($"b : {b}");
            Console.WriteLine($"c : {c}");
            Console.WriteLine($"d : {d}");
        }
        static void MethodeParamDemo(int a, ref double b, decimal c, ref string d)
        {
            a *= 2;
            b *= 2;
            c *= 2;
            d = d + d;
            Console.WriteLine("---> Dans la méthode (à la fin):");
            Console.WriteLine($"a : {a}");
            Console.WriteLine($"b : {b}");
            Console.WriteLine($"c : {c}");
            Console.WriteLine($"d : {d}");
        }
    }
}
