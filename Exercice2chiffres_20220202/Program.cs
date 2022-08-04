using System;

namespace Exercice2chiffres
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            Console.Title="Comparateur de deux chiffres";
            do
            {
                Console.WriteLine("Entrez la premiere valeur à comparer");
                double val1 =Convert.ToDouble(Console.ReadLine().Replace(".", ","));
                Console.WriteLine("Entrez la deuxieme valeur à comparer");
                double val2 = Convert.ToDouble(Console.ReadLine().Replace(".", ","));
                if (val1 <= val2)
                {
                    if (val1 != val2)
                    {
                        Console.WriteLine($"{val1} est inférieur à {val2}");
                    }
                    else
                    {
                        Console.WriteLine($"{val1} égale {val2}");
                    }
                }
                else
                {
                    Console.WriteLine($"{val1} est supérieur à {val2}");
                }
                Console.WriteLine("Entrez une valeur pair pour faire un autre tour");
                x = Convert.ToInt32(Console.ReadLine());
            } while (x % 2 == 0);
     
         }
    }
}
