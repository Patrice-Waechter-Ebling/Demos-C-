using System;

namespace BeSureItsValidNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\nEntres un nombre");
            string tmp = BeSureItsValidNumber(Console.ReadLine());
            int a=Convert.ToInt32( Math.Truncate(Convert.ToDouble(tmp)));
            Console.Write($"Texte saisi {tmp} entier obtenu {a}");
        }
        static string BeSureItsValidNumber(string saisie) {return  saisie.Replace(".", ",");     }
    }
}
