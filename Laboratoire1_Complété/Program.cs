using System;

namespace Laboratoire1
{
    class Program
    {
        static string separateur = "";
        static void CreerSeparateur()
        {
            for (int i = 0; i < 20; i++)
            {
                separateur += "-";
            }
        }
        static void Main(string[] args)
        {
            CreerSeparateur();
            // Produits possibles
            Produit[] produitsPossibles =
             {
                new Produit(1, "Patate", 3.23),
                new Produit(2, "Steak", 6.42),
                new Produit(3, "Carotte", 1.98),
                new Produit(4, "Nain de jardin", 38.38),
                new Produit(5, "Jus de pomme", 83.35),
                new Produit(6, "Beau jeans bleus", 5.86),
                new Produit(7, "Roche multicolore", 132.65),
                new Produit(8, "Cactus pas trop piquant", 12.36),
                new Produit(9, "Peanuts", 7.57),
                new Produit(10, "Spaghetti", 52.33)
            };

            // Nos commandes
            Commande[] commandes = new Commande[100];

            // Créer les commandes
            Commande c1 = new Commande(1, 2);
            c1.SetNumero(1);
            c1.SetProduit(0, produitsPossibles[4]);
            c1.SetProduit(1, produitsPossibles[9]);
            commandes[0] = c1;
            Commande c2 = new Commande(2, 5);

            c2.SetProduit(0, produitsPossibles[1]);
            c2.SetProduit(1, produitsPossibles[2]);
            c2.SetProduit(2, produitsPossibles[7]);
            c2.SetProduit(3, produitsPossibles[8]);
            c2.SetProduit(4, produitsPossibles[3]);

            commandes[1] = c2;

            Commande c3 = new Commande(3, 3);
            c3.SetProduit(0, produitsPossibles[6]);
            c3.SetProduit(1, produitsPossibles[9]);
            c3.SetProduit(2, produitsPossibles[2]);
            commandes[2] = c3;

            // Afficher les détails de la première facture.
            Console.WriteLine("Première facture : ");
            Commande premiereCommande = commandes[0];
            Console.WriteLine("Facture " + premiereCommande.GetNumero());
            double totalC1 = 0.00;
            foreach (Produit p in premiereCommande.GetProduits())
            {
                // Même raisonnement que pour notre foreach actuel.
                if (p == null)
                    break;

                Console.WriteLine($"{p.GetID()} - {p.GetNom()} :{ p.GetPrix()}$");
                totalC1 += p.GetPrix();
            }
            Console.WriteLine("Total : " + Math.Round(totalC1, 2) + "$");
            Console.WriteLine(separateur);
            // Afficher les détails de la deuxième facture.
            Console.WriteLine(separateur);
            Console.WriteLine("Deuxième facture : ");
            Commande deuxiemeCommande = commandes[1];
            Console.WriteLine("Facture " + deuxiemeCommande.GetNumero());

            double totalC2 = 0.00;
            foreach (Produit p in deuxiemeCommande.GetProduits())
            {
                // Même raisonnement que pour notre foreach actuel.
                if (p == null)
                    break;

                Console.WriteLine($"{p.GetID()} - {p.GetNom()} :{ p.GetPrix()}$");
                totalC2 += p.GetPrix();
            }
            Console.WriteLine("Total : " + Math.Round(totalC2, 2) + "$");
            Console.WriteLine(separateur);
            foreach (Commande c in commandes)
            {
                // Puisque nous n'avons pas 100 commandes.
                if (c == null)
                    break;
                Console.WriteLine(separateur);
                Console.WriteLine("Facture " + c.GetNumero());
                double total = 0.00;
                foreach (Produit p in c.GetProduits())
                {
                    // Même raisonnement que pour notre foreach actuel.
                    if (p == null)
                        break;

                    Console.WriteLine($"{p.GetID()} - {p.GetNom()} :{ p.GetPrix()}$");
                    total += p.GetPrix();
                }
                Console.WriteLine("Total : " + Math.Round(total, 2) + "$");
                Console.WriteLine(separateur);
            }
        }
    }
}
