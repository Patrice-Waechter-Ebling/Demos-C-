using System;

namespace Ex_Objets
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 18;
            int y = 12;
            // #1 - Factoriel de x ?
            Nombre nbr = new Nombre(x,y);
            Console.WriteLine( nbr.Fact());
            // #2 - Boucler sur un tableau de produits pour afficher la liste
            TableauMateriel matos = new TableauMateriel();
            for(int a =0; a<matos.GetTableItemCount;a++)
            {
                Console.WriteLine($"Piece numero {a+1} retourne {matos.GetTableauItem(a)}");
            }
            //      des codes de produits.
            // #3 - Permettre à un local d'être vide.
            Local local= new Local();

            // #4 - Compte utilisateur
            Console.WriteLine("Quel est le nom d'utilisateur?");
            string nomUtilisateur = Console.ReadLine();

            // Le mot de passe doit être "encodé" de la façon à ce que 
            // chaque lettre est remplacée par la suivante dans l'alphabet.
            // ex. A->B, B->C, ..., Z->A
            // Pour les chiffres, on fait l'inverse
            // ex. 9->8, 8->7, ..., 0->9
            // Les symboles restent les mêmes
            // ex. ?->?, &->&, ...
            Console.WriteLine("Quel est le mot de passe?");
            string motDePasse = Console.ReadLine();

            // Si oui, on affiche le nom d'utilisateur et le mot de passe 
            // ENCODÉ. Si non, on ne fait rien.
            Console.WriteLine("Voulez-vous afficher vos informations? (O-o/N-n)");

            // #5 - Sondage
            while(true)
            {
                Console.WriteLine("Aimez-vous le café? (O-o/N-n)");
            }

            // À la fin du sondage, on détermine si le café
            // c'est bon, ou non. On en fait donc une CONCLUSION.

            // #6 (BONUS) - Permettez à un utilisateur de créer son 
            //              ordinateur personnel.
            //              Petit rappel : un ordinateur est composé de :
            //                              - Une carte mère
            //                              - Un processeur
            //                              - Au moins un disque dur
            //                              - Au moins une barrette de mémoire
            //                              - Un bloc d'alimentation
        }
    }
}
