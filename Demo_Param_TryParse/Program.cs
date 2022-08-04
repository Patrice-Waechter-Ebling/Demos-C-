using System;

namespace Demo_Param_TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            string EntreeDelUtilisateur;

            EntreeDelUtilisateur = Console.ReadLine();

            int ValeurConvertie;

            if (Int32.TryParse(EntreeDelUtilisateur, out ValeurConvertie))
                Console.WriteLine($"Conversion réussie ! Valeur convertie : {ValeurConvertie}");
            else
                Console.WriteLine("Échec de la conversion.");
        }
    }
}
