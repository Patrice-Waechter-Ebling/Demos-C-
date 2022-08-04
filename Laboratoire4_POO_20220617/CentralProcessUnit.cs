using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Laboratoire4_POO
{
    internal class CentralProcessUnit
    {
        int choix;
        int nbrResto;

        public int GetNbrResto() {return this.nbrResto;}
        public int GetChoix(){return this.choix;}
        public Menu CreerMenu()
        {
            Menu menu = new Menu("pizza 3 fromages", 7.65);
            menu.Add(new Menu("sandwish a la viande", 6.59));
            menu.Add(new Menu("souvelaki", 4.99));
            menu.Add(new Menu("choucroute", 13.25));
            menu.Add(new Menu("Carbonara", 25.32));
            menu.Add(new Menu("Pizza 18\"",  29.99));
            menu.Add(new Menu("Poutine 8\"", 8.75));
            return menu;
        }
        public void AfficherMenu(Menu menu)
        {
            int a = 1;
            foreach (Menu i in menu)
            {
                try { Console.WriteLine("Choix #" + a++ + " " + i.GetTitre() + " " + i.GetPrix()); ; }
                catch (StackOverflowException e)
                {
                    choix = 1;   
                    throw new ArgumentException(e.Message + "\nMode automatique activé");
                }
            }
            Console.Write("\nFaites votre choix de restauration\n1: Livraison\n2: Sur place\n3: Ramassage\nVotre selection: ");
            try { choix = (int)Console.ReadLine()[0]; }
            catch (System.IndexOutOfRangeException e) { Console.WriteLine(e.Message); choix = 1; }
            catch (System.IO.IOException e) { throw new ArgumentException( e.Message); }
            switch (choix)
            {
                case 0x31: { Console.Write("Livraison sélectionnée"); } break;
                case 0x32: { Console.Write("Réservation sur place sélectionnée"); } break;
                case 0x33: { Console.Write("Le ramassage n'a pas été implenté car il ne fait pas partie des paramètres désignés");return; } 
                default: throw new AccessViolationException("Choix sélectionné invalide");
            }
       }
        public string CreerRestautrants(){
            Restautrants resto = new Restautrants(null, false, false, false);
            resto.Add(new Restautrants("Bistro Le Calumet", true));
            resto.Add(new Restautrants("Les Rôtisseries Duhamel", true));
            resto.Add(new Restautrants("Restaurant Granby Express", true));
            resto.Add(new Restautrants("Cantine Chez Richard", true, true, true));
            resto.Add(new Restautrants("Restaurant Lueur du Mékong", false, false, true));
            this.nbrResto=resto.Count;
            return AfficherRestaurants(resto);
        }
        public string AfficherRestaurants(Restautrants restautrants){
            int a = 0;
            foreach (Restautrants i in restautrants){
                a++;
                try{
                    switch (choix){
                        case 0x31:{
                                if (i.GetLivraison() != false){
                                    Console.WriteLine($"Choix {a}:Livraison:{i.GetLivraison()} \t Sur Place:{i.GetSurPlace()}\t{i.GetNom()} ");
                                }
                            }
                            break;
                        case 0x32:{
                                if (i.GetSurPlace() != false){
                                    Console.WriteLine($"Choix {a}:Sur Place:{i.GetSurPlace()}\t{i.GetNom()} ");
                                }
                            }
                            break;
                        default:
                            {
                                Console.WriteLine($"Choix {a}: Livraison:{i.GetLivraison()}\tSur place et livraison:{i.GetLesDeux()} \t Sur Place:{i.GetSurPlace()}\t{i.GetNom()} ");
                            }
                            break;
                    }
                }
                catch (StackOverflowException e) { Console.WriteLine(e.Message); break; }
            }
            Console.Write("Veuillez choisir un restaurant parmis la liste proposée: ");
            string tmp=null;
            try
            {
               tmp=SelectionRestaurant(restautrants, Convert.ToInt32( Console.ReadLine()[0])-0x30);
            }
            catch(System.IO.IOException e)
            {
                Console.WriteLine(e.Message);
            }
            return tmp;
        }
        public string SelectionRestaurant(Restautrants restautrants, int index){
            //index -1 a cause líndexation de la liste qui commence a 0 alors que láffichage du menu commence a 1
            Console.Write($"\nBienvenue chez {restautrants[index - 1].GetNom()}, voici les plats disponibles\n");
            return restautrants[index - 1].GetNom();
        }
        public string SelectionPlat(Menu menu, int index){
            //index -1 a cause líndexation de la liste qui commence a 0 alors que láffichage du menu commence a 1
            Console.Write($"\nPlat: {menu[index - 1].GetTitre()}");
            return menu[index - 1].GetTitre();
        }
        protected void OnErreur(string exception){throw new ArgumentException(exception);}
        public Commande CreerCommande(Client client){
            Commande ajoutCommande = new Commande();
            return ajoutCommande;
        }
    }
}
