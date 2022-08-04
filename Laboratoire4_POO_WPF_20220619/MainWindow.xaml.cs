using System;
using System.Windows;
using System.Windows.Controls;

namespace Laboratoire4_POO_WPF_20220619
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        int choix = 0;
        string nom = null;
        public MainWindow()
        {
            InitializeComponent();
            AjouterRestaurants();
            Menu mnu = CreerMenu();
            AfficherMenu(mnu);
        }
        private void AjouterRestaurants()
        {
            Restaurateurs restaurant = new Restaurateurs();
            restaurant.CreerRestaurateurs(null, false, false, false);
            restaurant.AjouterRestaurateurs(new Restaurateurs("Bistro Le Calumet", true));
            restaurant.AjouterRestaurateurs(new Restaurateurs("Les Rôtisseries Duhamel", true));
            restaurant.AjouterRestaurateurs(new Restaurateurs("Restaurant Granby Express", true));
            restaurant.AjouterRestaurateurs(new Restaurateurs("Cantine Chez Richard", true));
            restaurant.AjouterRestaurateurs(new Restaurateurs("Restaurant Lueur du Mékong", false, false, true));
            Restaurants.SelectedIndex = restaurant.GetCompteurResto() - 1;
            AfficherRestaurateurs(restaurant, choix);
        }
        private Menu CreerMenu()
        {
            Menu menu = new Menu("Pizza 3 fromages", 7.65);
            menu.Add(new Menu("Sandwish a la viande", 6.59));
            menu.Add(new Menu("Souvelaki", 4.99));
            menu.Add(new Menu("Choucroute", 13.25));
            menu.Add(new Menu("Carbonara", 25.32));
            menu.Add(new Menu("Pizza 18\"", 29.99));
            menu.Add(new Menu("Poutine 8\"", 8.75));
            return menu;
        }
        private void AfficherMenu(Menu menu)
        {
            int a = 1;
            foreach (Menu i in menu)
            {
                try
                {
                    ListePlats.Items.Add($"Choix #{a++} {i.GetTitre()} {i.GetPrix()}$");
                }
                catch (StackOverflowException e)
                {
                    choix = 1;
                    throw new ArgumentException(e.Message + "\nMode automatique activé");
                }
            }
            /*    Console.Write("\nFaites votre choix de restauration\n1: Livraison\n2: Sur place\n3: Ramassage\nVotre selection: ");
                try { choix = (int)Console.ReadLine()[0]; }
                catch (System.IndexOutOfRangeException e) { Console.WriteLine(e.Message); choix = 1; }
                catch (System.IO.IOException e) { throw new ArgumentException(e.Message); }
                switch (choix)
                {
                    case 1: { Console.Write("Livraison sélectionnée"); } break;
                    case 2: { Console.Write("Réservation sur place sélectionnée"); } break;
                    case 3: { Console.Write("Le ramassage n'a pas été implenté car il ne fait pas partie des paramètres désignés"); return; }
                    default: throw new AccessViolationException("Choix sélectionné invalide");
                }*/
        }

        private void Quitter_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Reinitialiser_Click(object sender, RoutedEventArgs e)
        {
            ListePlatsCommandes.Items.Clear();
        }

        private void Commander_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Livraison_Checked(object sender, RoutedEventArgs e)
        {
            choix = 1;
        }

        private void LesDeux_Checked(object sender, RoutedEventArgs e)
        {
            choix = 2;
        }

        private void Restaurants_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            nom = Restaurants.SelectedItem.ToString();
        }
        private void AfficherRestaurateurs(Restaurateurs restaurateurs, int choix)
        {
            int a = 0;
            foreach (Restaurateurs i in restaurateurs)
            {
                a++;
                try
                {
                    switch (choix)
                    {
                        case 1:
                            {
                                if (i.GetLivraison() != false)
                                {
                                    Restaurants.Items.Add(i.GetNomRestaurant());
                                }
                            }
                            break;
                        case 2:
                            {

                                if (i.GetLesDeux() != false)
                                {
                                    Restaurants.Items.Add(i.GetNomRestaurant());
                                }
                            }
                            break;
                        case 3:
                            {
                                NotImplementedException e = new NotImplementedException("Fonction TakeOff non implentée");
                                MessageBox.Show(e.Message.ToString(), e.GetType().ToString(), MessageBoxButton.OK, MessageBoxImage.Exclamation);
                            }
                            break;
                        default:
                            {
                                Restaurants.Items.Add(i.GetNomRestaurant());
                            }
                            break;
                    }
                }
                catch (InvalidOperationException e)
                {
                    MessageBox.Show(e.Message, e.GetType().ToString());
                }
                catch (StackOverflowException e)
                {
                    MessageBox.Show(e.Message, e.GetType().ToString(), MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    break;
                }
            }
            /*   Console.Write("Veuillez choisir un restaurant parmis la liste proposée: ");
               string tmp = null;
               try
               {
                   tmp = SelectionRestaurant(restautrants, Convert.ToInt32(Console.ReadLine()[0]) - 0x30);
               }
               catch (System.IO.IOException e)
               {
                   Console.WriteLine(e.Message);
               }
               return tmp;*/
        }

        private void ListePlats_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
