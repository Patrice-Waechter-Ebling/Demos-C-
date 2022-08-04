using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControlTestVS.NET5 //.NET 3.52
{
    class Program
    {
        static void Main()
        {
            string ChaineCaracteres = "je prefere programmer en cpp";
            int NombreCaracteres_1 = 15;
            int NombreCaracteres_2 = 55;
            Console.WriteLine("Méthode AnalyserSommairementChaineCaracteres()");
            Console.WriteLine("-----------------------------------------------");
            AnalyserSommairementChaineCaracteres(ChaineCaracteres);
            AnalyserSommairementChaineCaracteres("Programmation");
            Console.WriteLine("\n\n_.~\"(_.~\"(_.~\"(_.~\"(_.~\"(_.~\"(_.~\"(_.~\"(_.~\"(_.~\"(_.~\"(_.~\"(\n\n");
            Console.WriteLine("Méthode TronquerChaineDeCaracteres()");
            Console.WriteLine("-------------------------------------");
            TronquerChaineDeCaracteres(ChaineCaracteres, NombreCaracteres_1);
            TronquerChaineDeCaracteres(ChaineCaracteres, NombreCaracteres_2);
            Console.WriteLine("\n\n_.~\"(_.~\"(_.~\"(_.~\"(_.~\"(_.~\"(_.~\"(_.~\"(_.~\"(_.~\"(_.~\"(_.~\"(\n\n");
            Console.WriteLine("Méthode StructurerEnPhraseExclamative()");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(StructurerEnPhraseExclamative(ChaineCaracteres));
            Console.WriteLine("\n\n_.~\"(_.~\"(_.~\"(_.~\"(_.~\"(_.~\"(_.~\"(_.~\"(_.~\"(_.~\"(_.~\"(_.~\"(\n\n");
            Console.WriteLine("Méthode AnalyserContenuAlphabetique()");
            Console.WriteLine("--------------------------------------");
            AnalyserContenuAlphabetique(ChaineCaracteres);
            Console.WriteLine("\n----------------- FIN DU PROGRAMME ----------------------\n");
            Console.ReadKey();


        }
        static void AnalyserSommairementChaineCaracteres(string ChaineCaracteres)        {
            if (ChaineCaracteres.Contains(" ") == true)
            {
                Console.WriteLine("\"" + ChaineCaracteres.ToString() + "\" est une phrase contenant " +ChaineCaracteres.Length.ToString() +" caracteres");
            }else{
                Console.WriteLine("\"" + ChaineCaracteres.ToString()+"\" est un mot contenant "+ChaineCaracteres.Length.ToString()+ "caracteres");
            }
        }

        static void TronquerChaineDeCaracteres(string ChaineCaracteres, int NombreCaracteres_1){
            if (NombreCaracteres_1 < ChaineCaracteres.Length)
            {
                Console.WriteLine("[PARTIELLE] "+ChaineCaracteres.Substring(0, NombreCaracteres_1));
            }else{
                Console.WriteLine("[COMPLÈTE] "+ChaineCaracteres.ToString());
            }
        }

        static string StructurerEnPhraseExclamative(string ChaineCaracteres)
        {
            return  ChaineCaracteres.Substring(0, 1).ToUpper() + ChaineCaracteres.Substring(1, ChaineCaracteres.Length - 1).ToLower() + "!";
        }
        static string LaLettreEstInclue(string ChaineCaracteres, string lettre, ref int nb){
            if (ChaineCaracteres.ToLower().Contains(lettre) == true)
            {
                nb++;
                return "OUI*";
            }else{
                return "non";
            }
        }
        static void AnalyserContenuAlphabetique(string ChaineCaracteres)
        {
            int nombre = 0;
            Console.WriteLine("a:"+LaLettreEstInclue(ChaineCaracteres, "a", ref nombre));
            Console.WriteLine("b:"+ LaLettreEstInclue(ChaineCaracteres, "b", ref nombre));
            Console.WriteLine("c:"+ LaLettreEstInclue(ChaineCaracteres, "c", ref nombre));
            Console.WriteLine("d:"+ LaLettreEstInclue(ChaineCaracteres, "d", ref nombre));
            Console.WriteLine("e:"+ LaLettreEstInclue(ChaineCaracteres, "e", ref nombre));
            Console.WriteLine("f:"+ LaLettreEstInclue(ChaineCaracteres, "f", ref nombre));
            Console.WriteLine("g:"+ LaLettreEstInclue(ChaineCaracteres, "g", ref nombre));
            Console.WriteLine("h:"+ LaLettreEstInclue(ChaineCaracteres, "h", ref nombre));
            Console.WriteLine("i:"+ LaLettreEstInclue(ChaineCaracteres, "i", ref nombre));
            Console.WriteLine("j:"+ LaLettreEstInclue(ChaineCaracteres, "j", ref nombre));
            Console.WriteLine("k:"+ LaLettreEstInclue(ChaineCaracteres, "k", ref nombre));
            Console.WriteLine("l:"+ LaLettreEstInclue(ChaineCaracteres, "l", ref nombre));
            Console.WriteLine("m:"+ LaLettreEstInclue(ChaineCaracteres, "m", ref nombre));
            Console.WriteLine("n:"+ LaLettreEstInclue(ChaineCaracteres, "n", ref nombre));
            Console.WriteLine("o:"+ LaLettreEstInclue(ChaineCaracteres, "o", ref nombre));
            Console.WriteLine("p:"+ LaLettreEstInclue(ChaineCaracteres, "p", ref nombre));
            Console.WriteLine("q:"+ LaLettreEstInclue(ChaineCaracteres, "q", ref nombre));
            Console.WriteLine("r:"+ LaLettreEstInclue(ChaineCaracteres, "r", ref nombre));
            Console.WriteLine("s:"+ LaLettreEstInclue(ChaineCaracteres, "s", ref nombre));
            Console.WriteLine("t:"+ LaLettreEstInclue(ChaineCaracteres, "t", ref nombre));
            Console.WriteLine("u:"+ LaLettreEstInclue(ChaineCaracteres, "u", ref nombre));
            Console.WriteLine("v:"+ LaLettreEstInclue(ChaineCaracteres, "v", ref nombre));
            Console.WriteLine("w:"+ LaLettreEstInclue(ChaineCaracteres, "w", ref nombre));
            Console.WriteLine("x:"+ LaLettreEstInclue(ChaineCaracteres, "x", ref nombre));
            Console.WriteLine("y:"+ LaLettreEstInclue(ChaineCaracteres, "y", ref nombre));
            Console.WriteLine("z:"+ LaLettreEstInclue(ChaineCaracteres, "z", ref nombre));
            Console.WriteLine("-->Bilan:"+ nombre.ToString()+ " lettres de l'alphabet en minuscules");
        }
    }
}
