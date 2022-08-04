using System;

namespace Laboratoire4
{
    class Program
    {
        static void Main(string[] args)
        {
            Exception ex=new Exception("Choix invalide");          
            Console.WriteLine("Regroupement des Restaurants de Granby!\nBienvenue\nFaites votre choix de restauration");
            Console.WriteLine("1: Livraison\n2: Sur place\nVotre selection: ");
            int choix=0;
            Plats p1=new Plats("pizza 3 fromages", 1);
            Plats p2=new Plats("sandwish a la viande", 2);
            Plats p3=new Plats("souvelaki", 3);
            Plats p4=new Plats("choucroute", 4);
            Commande cmd = new Commande(24);
            Menu menu = new Menu();
            menu.AfficherMenu();            
            cmd.AjouterItem(1);
            cmd.AjouterItem(3);
            try
            {
                choix = (int)Console.ReadLine()[1];
            }
            catch
            {
                Console.WriteLine(ex.Message);
            }
            if (choix != 1) {
                Console.WriteLine("Indiquez votre adresse svp: ");
                ConsommateurMaison cm = new ConsommateurMaison(Console.ReadLine());
                Livreur livreur = new Livreur(cm.GetAdrresse(), cmd);
            }
            else if (choix == 2) { }
            else
            {
                Console.WriteLine(ex.Message); 
            }
        }
    }
}
