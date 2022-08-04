using System;
using System.IO;

namespace TableASCII
{
    class Program
    {
        static string sDate = $"{DateTime.Now.Year}{DateTime.Now.Month}{ DateTime.Now.Day}";
        static void Main(string[] args)
        {
            Console.Title = "Extraction de la table ASCII pour la console en fonction de votre configuration installée";
            Console.WriteLine($"{Console.Title} \t Patrice Waechter-Ebling 2022");
            Menu();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Appuyez sur ESC pour quitter le programme ou toute autre pour recommencer");
            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                Console.ResetColor();
                return;
            }
            else {
                Main(args);
            }

        }
        static void Menu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t╔═══════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("\t║                                                                               ║");
            Console.WriteLine("\t║  Menu de sélection:                                                           ║");
            Console.WriteLine("\t║  ══════════════════                                                           ║");
            Console.WriteLine("\t║    1: Table ASCII Basique                                                     ║");
            Console.WriteLine("\t║    2: Table ASCII Étendue         Peut être long en fonction de la config     ║");
            Console.WriteLine("\t║                                                                               ║");
            Console.WriteLine("\t║                                                                               ║");
            Console.WriteLine("\t║ Developpe le 18/02/2022                        ©Patrice Waechter-Ebling 2022  ║");
            Console.WriteLine("\t╚═══════════════════════════════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Sélectionnnez 1 ou 2");
            
            int a = Int32.Parse(Console.ReadLine());
            switch (a)
            {
                case 1: TableASCII_Basique();break;
                case 2: TableASCII_Etendue();break;
                default: { Console.WriteLine("Saisie invalide");Console.Beep(4440, 250);  } return;
            }
        }
        static void TableASCII_Basique()
        {
            
            StreamWriter sw = new StreamWriter($"Table ASCII Basique[{sDate}].txt");
             sw.WriteLine(Console.Title);
            for (int x = 0; x < 0x25; x++)
            {
                string tmp=$"\t{x + 14}= {(char)(x + 14)} |{x + 14 + 44}= {(char)(x + 14 + 44)} |{x + 14 + 74}= {(char)(x + 14 + 74)} |{x + 14 + 104}= {(char)(x + 14 + 104)} | {x + 14 + 134}= {(char)(x + 14 + 134)} |{x + 14 + 164}= {(char)(x + 14 + 164)} |{x + 14 + 194}= {(char)(x + 14 + 194)} |{x + 14 + 204}= {(char)(x + 14 + 204)}  ";
                sw.WriteLine(tmp);
                Console.WriteLine(tmp);
            }
            sw.Close();
        }
        static void TableASCII_Etendue()
        {
            StreamWriter sw = new StreamWriter($"Table ASCII Étendue[{sDate}].txt");
            sw.WriteLine(Console.Title);
            for (int x = 0; x < 0xD03A; x++) //limite avant bug \\uD800 (Convertion Unicode index 226 page 1250)
            {
                string tmp = $"\t{x + 14}= {(char)(x + 14)} |{x + 14 + 44}= {(char)(x + 14 + 44)} |{x + 14 + 74}= {(char)(x + 14 + 74)} |{x + 14 + 104}= {(char)(x + 14 + 104)} | {x + 14 + 134}= {(char)(x + 14 + 134)} |{x + 14 + 164}= {(char)(x + 14 + 164)} |{x + 14 + 194}= {(char)(x + 14 + 194)} |{x + 14 + 204}= {(char)(x + 14 + 204)}  ";
                 Console.WriteLine(tmp);
               sw.WriteLine(tmp);
            }
            sw.Close();
        }
    }
}
