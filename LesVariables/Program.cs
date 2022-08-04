using System;

namespace LesVariables
{
    internal class Program
    {
        static void Entiers()   {
            int myNum = 100000;
            Console.WriteLine("Entier: " + myNum);
        }
        static void Booleens()
        {
            bool isFishTasty = true;
            bool isCSharpFun = false;
            Console.WriteLine("Booleen: " + isCSharpFun);   // Outputs True
            Console.WriteLine("Booleen: " + isFishTasty);   // Outputs False
        }
        static void Longs()
        {
            long myNum = 15000000000L;
            Console.WriteLine("Long: " + myNum);
        }
        static void Doubles()
        {
            double myNum = 19.99D;
            Console.WriteLine("Double: " + myNum);
        }
        static void Floats()
        {
            float myNum = 5.75F;
            float f1 = 35e3F;
            double d1 = 12E4D;
            Console.WriteLine("floats");
            Console.WriteLine(f1);
            Console.WriteLine(d1);
            Console.WriteLine(myNum);
        }
        static void Caractere()
        {
            char myGrade = 'B';
            Console.WriteLine("char: " + myGrade);
        }
        static void Textes()
        {
            string str = "Le string est utilisé pour stocker une séquence de caractères (texte). ";
            Console.WriteLine("string: " + str);
        }
        static void Main(string[] args)
        {
            Console.Title = "Sources basees sur les exemples du tutoriel";
            Console.WriteLine("Developpé dans le cadre de l'AEC\tLicence: Educative\tCodé par Patrice Andre Waechter-Ebling\n");
            Entiers();
            Booleens();
            Longs();
            Doubles();
            Floats();
            Caractere();
            Textes();
        }
    }
}
