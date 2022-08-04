using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Laboratoire5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MenuItems Menu;
        Commande Commande;
        public MainWindow()
        {
            InitializeComponent();
            // Crée tous les items et les ajoute au menu
            InitialiseMenu();
            this.Commande = new Commande();
            // Prend le menu et ajoute les images aux boutons de la grille
            InitialiseGrille();
            CommandeItems.ItemsSource = this.Commande.GetLignes();
        }

        /**
         * Crée nos objets « Item » et ajoute au menu (liste d'items)
         */ 
        private void InitialiseMenu()
        {
            this.Menu = new MenuItems();

            string chemin = Environment.CurrentDirectory;

            Item i1 = new Item(1, "Canne de sauce", 32.75, chemin + "\\images\\i1.jpg");
            Item i2 = new Item(2, "Soupe de tofu", 45.67, chemin + "\\images\\i2.jpg");
            Item i3 = new Item(3, "Poulet", 1.54, chemin + "\\images\\i3.jpg");
            Item i4 = new Item(4, "Patates", 176.32, chemin + "\\images\\i4.jpg");
            Item i5 = new Item(5, "Spaghetti", 23.23, chemin + "\\images\\i5.jpg");
            Item i6 = new Item(6, "Borgor", 76.32, chemin + "\\images\\i6.jpeg");
            Item i7 = new Item(7, "Pogo", 1.61, chemin + "\\images\\i7.jpg");
            Item i8 = new Item(8, "Hot-Dog du Costco", 53.22, chemin + "\\images\\i8.png");
            Item i9 = new Item(9, "Fish n' chips", 92.78, chemin + "\\images\\i9.jpg");
            Item i10 = new Item(10, "Beans", 29.09, chemin + "\\images\\i10.jpg");
            Item i11 = new Item(11, "Sirop d'érâble", 46.75, chemin + "\\images\\i11.jpg");
            Item i12 = new Item(12, "Coquille St-Jacques", 84.62, chemin + "\\images\\i12.jpg");

            this.Menu.AjouterItem(i1);
            this.Menu.AjouterItem(i2);
            this.Menu.AjouterItem(i3);
            this.Menu.AjouterItem(i4);
            this.Menu.AjouterItem(i5);
            this.Menu.AjouterItem(i6);
            this.Menu.AjouterItem(i7);
            this.Menu.AjouterItem(i8);
            this.Menu.AjouterItem(i9);
            this.Menu.AjouterItem(i10);
            this.Menu.AjouterItem(i11);
            this.Menu.AjouterItem(i12);
        }

        /**
         * Créer les objets « Button » et les ajoute à notre grille (à ses enfants)
         */ 
        private void InitialiseGrille()
        {
            //Button b1 = new Button();
            //Image i1 = new Image();

            //i1.Source = new BitmapImage(new Uri("C:\\Users\\pdess\\source\\repos\\Laboratoire5\\images\\i6.jpeg", UriKind.Absolute));

            //b1.Content = i1;

            //Grid.SetColumn(b1, 0);
            //Grid.SetRow(b1, 0);

            //GrilleMenu.Children.Add(b1);

            // Compteur de position
            int position = 0;

            // Boucle Lignes
            for(int ligne = 0; ligne < GrilleMenu.RowDefinitions.Count; ligne ++)
            {
                // Boucle TOUTES les colonnes
                for(int colonne = 0; colonne < GrilleMenu.ColumnDefinitions.Count; colonne ++)
                {
                    Button b = new Button();
                    Image i = new Image();

                    i.Source = new BitmapImage(new Uri(Menu.GetItems()[position].GetImage(), UriKind.Absolute));

                    b.Content = i;
                    // L'id de notre item, on l'attribut au tag de bouton (qui sert à mettre des metadonnées).
                    b.Tag = Menu.GetItems()[position].GetId();

                    Grid.SetColumn(b, colonne);
                    Grid.SetRow(b, ligne);

                    b.Click += Button_Click;

                    GrilleMenu.Children.Add(b);
                    position++;
                }
            }
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            // Le sender c'est un bouton (je sais car je vais associer l'événement à un bouton ...)
            Button button = (Button)sender;

            // Chercher l'item qui correspondont à notre tag (GetId() de l'item).
            Item item = Menu.Trouver(Convert.ToInt32(button.Tag));

            // Ajouter notre item à la commande
            // via une ligne de commande
            this.Commande.AjouterItem(item);
            CommandeItems.Items.Refresh();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window facture = new Window();
            Grid layout = new Grid();

            // Afficher toutes les lignes
            ListBox commande = new ListBox();
            commande.ItemsSource = this.Commande.GetLignes();
            
            layout.Children.Add(commande);

            // Afficher le total
            double total = 0.00;

            foreach(LigneCommande ligne in this.Commande.GetLignes())
            {
                total += ligne.GetTotal();
            }

            TextBlock titreTotal = new TextBlock();
            titreTotal.FontSize = 54;
            titreTotal.FontWeight = FontWeight.FromOpenTypeWeight(12);
            titreTotal.Text = "Total : " + total + "$";

            layout.Children.Add(titreTotal);

            facture.Content = layout;
            facture.Show();
        }
    }
}
