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
        Commande commande = new Commande();
        int[] elements;
        int IDBouton;
       public MainWindow()
        {
            InitializeComponent();
            InitialiseMenu();
            InitialiseGrille();
        }
        private void InitialiseMenu()
        {
            this.Menu = new MenuItems();
            this.Menu.AjouterItem(new Item(1, "Canne de sauce",1.54, ".\\images\\i1.png"));
            this.Menu.AjouterItem(new Item(2, "Soupe de tofu", 25.67, ".\\images\\i2.png"));
            this.Menu.AjouterItem(new Item(3, "Poulet", 32.75 , ".\\images\\i3.png"));
            this.Menu.AjouterItem(new Item(4, "Patates", 17.632, ".\\images\\i4.png"));
            this.Menu.AjouterItem(new Item(5, "Spaghetti", 23.23, ".\\images\\i5.png"));
            this.Menu.AjouterItem(new Item(6, "Borgor", 7.632, ".\\images\\i6.png"));
            int[] ints = new int[Menu.GetNombreItem()];
            this.elements = ints;
        }
        private void InitialiseGrille()
        {
            PositionnerBouton(new Button(),0,0,0);
            PositionnerBouton(new Button(), 0,1,1);
            PositionnerBouton(new Button(), 0,2,2);
            PositionnerBouton(new Button(), 0,3,3);
            PositionnerBouton(new Button(), 1,0,4);
            PositionnerBouton(new Button(), 1,1,5);
        }
        private void PositionnerBouton(Button b, int Ligne, int colonne)
        {
            Grid.SetRow(b, Ligne);
            Grid.SetColumn(b, colonne);
            GrilleMenu.Children.Add(b);
        }
        private void PositionnerBouton(Button b, int Ligne, int colonne,int index)
        {
            Grid.SetRow(b, Ligne);
            Grid.SetColumn(b, colonne);
            GrilleMenu.Children.Add(b);
            b.Name = $"b{index}";
            b.Click+= (RoutedEventHandler)this.BouttonB_Click;
            UpdateBoutton(b, index);
        }
        private void UpdateBoutton(Button b,int index)
        {
            Image im = new Image();
            var convert = new BrushConverter();
            var fond = (Brush)convert.ConvertFromString("#83D799");
            im.Source = new BitmapImage(new Uri(this.Menu.GetCheminImage(index), UriKind.Absolute));
            b.Background = new SolidColorBrush(Color.FromRgb(0xCC, 0xCC, 0xFF));
            b.BorderThickness=new Thickness(2);
            b.Margin = new Thickness(3);
            b.BorderBrush = fond;
            b.Content = im;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Statut.Content = "Panier";
            for (int a = 0; a < elements.Length; a++) //reset matrice
            {
                elements[a] = 0;
            }
            listbox1.Items.Clear();
        }
        protected void BouttonB_Click(object sender, EventArgs e)
        {
            Button boutton = sender as Button;
            IDBouton = int.Parse(boutton.Name.Substring(1, boutton.Name.Length - 1));//converti le nom dynamique en entier
            elements[IDBouton]++;
            Item i = new Item(Menu.GetNomItem(IDBouton), Menu.GetPrixItem(IDBouton));
            commande.AjouterItem(i);
            boutton.ToolTip =$"Il y a présentement {elements[IDBouton]} entrées pour {Menu.GetNomItem(IDBouton)} \n {elements[IDBouton]}x{Menu.GetNomItem(IDBouton)}={Math.Round( elements[IDBouton] * Menu.GetPrixItem(IDBouton),2)}$";
            listbox1.Items.Add($"{Menu.GetNomItem(IDBouton)}  {Menu.GetPrixItem(IDBouton)}$");
        }

        private void DockPanel_GotFocus(object sender, RoutedEventArgs e)
        {
            if (listbox1.Items.Count < 1)
            {
                MessageBox.Show("Codé par Patrice Waechter-Ebling 2022",this.Title,MessageBoxButton.OK,MessageBoxImage.Information);           
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Statut.Content = "Facturation";
            listbox1.Items.Clear();
            double soustotal = 0;
            for (int a = 0; a < elements.Length ; a++) {
                if (elements[a] > 0)
                {
                    soustotal += Math.Round(elements[a] * Menu.GetPrixItem(a), 2);
                    listbox1.Items.Add($"֍ {Menu.GetNomItem(a)}");
                    listbox1.Items.Add($"  ◊ {elements[a]}x{Menu.GetPrixItem(a)}={Math.Round(elements[a] * Menu.GetPrixItem(a), 2)}$");
                }
            }
            listbox1.Items.Add($"-------------- ");
            listbox1.Items.Add($"֍ Total ");
            listbox1.Items.Add($"   {Math.Round(soustotal*1.15, 2)}$");//on echape pas aux taxes
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            AjouterAuMenu ajouterAuMenu = new AjouterAuMenu();
            ajouterAuMenu.ShowDialog();
        }
    }
}
