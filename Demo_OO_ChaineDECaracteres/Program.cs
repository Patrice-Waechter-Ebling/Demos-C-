using System;

namespace Demo_OO_ChaineDECaracteres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo_OO_ChaineDECaracteres");
            ChaineDeCaracteres uneChaine = new ChaineDeCaracteres();
            ChaineDeCaracteres uneAutreChaine = new ChaineDeCaracteres("Patate");
            if (uneAutreChaine.AjouterCarateres(" 52Tomates"))
                AfficherChaineDeCaractere(uneAutreChaine);
            else
                Console.WriteLine("L'ajout n'a pas fonctionne");
            AfficherChaineDeCaractere(uneChaine);
            AfficherChaineDeCaractere(uneAutreChaine);
            uneAutreChaine.MettreEnMajustcules();
            AfficherChaineDeCaractere(uneAutreChaine);
            if (uneAutreChaine.AjouterCarateres(" 2Tomates"))
                AfficherChaineDeCaractere(uneAutreChaine);
            else
                Console.WriteLine("L'ajout n'a pas fonctionne");


        }
        static void AfficherChaineDeCaractere(ChaineDeCaracteres ChaineRecue)
        {
   /*         for (int i = 0; i < ChaineRecue.Longueur; i++)
            {
                Console.Write(ChaineRecue.Contenu[i]);
            }*/
            if(ChaineRecue.Longueur > 0)
            {
                foreach (char unChar in ChaineRecue.Contenu) 
                {
                        Console.Write(unChar);
                }
            }
      /* */
            Console.WriteLine();
        }
    }
}
