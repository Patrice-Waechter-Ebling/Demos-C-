using System;

namespace Program_Commutation_O_N
{
    class Program
    {
        static void Main(string[] args)
        {
            int Clef;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\n     ╔═══════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("     ║                                                                               ║");
            Console.WriteLine("     ║                             Hello World!                                      ║");
            Console.WriteLine("     ║                                                                               ║");
            Console.WriteLine("     ╚═══════════════════════════════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" \n choissiez O/N");
            Clef = Convert.ToInt32( Console.Read().ToString().ToLower());
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write( "Vous avez choisi ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(Clef);
            if (Clef == 79)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n\tvous avez choisi OUI");
            }
            if (Clef == 78)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\n\n\tvous avez choisi Non");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
