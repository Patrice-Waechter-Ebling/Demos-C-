using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
        string fichier = null,config=null;
        Utilitaires ut=new Utilitaires();
        internal Utilitaires GetUt() { return this.ut; }

        public MainWindow()
        {
            InitializeComponent();
            InitialiseMenu();
            this.InitialiseGrille();
            config = GetUt().IniFile(Environment.CurrentDirectory);
        }
        private void InitialiseMenu()
        {
            this.Menu = new MenuItems();
            this.CreerMenuParDefaut();
            int[] ints = new int[Menu.GetNombreItem()];
            this.elements = ints;
        }
        public void ChargerMenuDepuisConfigurationExterne()
        {
            for (int a = 0; a < Menu.GetNombreItem(); a++)
            {
                try
                {
                    string nom = this.GetUt().LireINI("titre", a.ToString());//recupere le nom
                    double prix = double.Parse(this.GetUt().LireINI("Prix", a.ToString()));//recupere le prix et converti en double
                    string image = this.GetUt().LireINI("Image", a.ToString());
                    int id = int.Parse(this.GetUt().LireINI("ID", a.ToString()));
                }
                catch (ArgumentNullException e) { this.GetUt().MessageErreur(e.Message, "Argument null"); }
                catch (FormatException e) { this.GetUt().MessageErreur(e.Message, "Formatage invalide"); }
                catch (OverflowException e) { this.GetUt().MessageErreur(e.Message, "Dépassement de capacitée"); }
            }

        }
        public void SauvegarderMenuVersConfigurationExterne()
        {
            for(int a=0; a < Menu.GetNombreItem(); a++)
            {
                this.GetUt().EcrireINI("titre", this.Menu.GetNomItem(a), a.ToString());
                this.GetUt().EcrireINI("Prix", this.Menu.GetPrixItem(a).ToString(), a.ToString());
                this.GetUt().EcrireINI("Image", this.Menu.GetCheminImage(a), a.ToString());
                this.GetUt().EcrireINI("ID", a.ToString(), a.ToString());
            }
        }
        private void CreerMenuParDefaut()
        {
            this.Menu.AjouterItem(new Item(1, "Canne de sauce", 32.75,".\\images\\i1.png"));
            this.Menu.AjouterItem(new Item(2, "Soupe de tofu", 45.67,".\\images\\i2.png"));
            this.Menu.AjouterItem(new Item(3, "Poulet", 1.54,".\\images\\i3.png"));
            this.Menu.AjouterItem(new Item(4, "Patates", 17.632,".\\images\\i4.png"));
            this.Menu.AjouterItem(new Item(5, "Spaghetti", 23.23,".\\images\\i5.png"));
            this.Menu.AjouterItem(new Item(6, "Borgor", 7.632,".\\images\\i6.png"));
            this.Menu.AjouterItem(new Item(7, "Pogo", 1.61,".\\images\\i7.png"));
            this.Menu.AjouterItem(new Item(8, "Hot-Dog du Costco", 5.322,".\\images\\i8.png"));
            this.Menu.AjouterItem(new Item(9, "Fish n' chips", 9.278,".\\images\\i9.png"));
            this.Menu.AjouterItem(new Item(10, "Beans", 2.909,".\\images\\i10.png"));
            this.Menu.AjouterItem(new Item(11, "Sirop d'érâble", 4.675,".\\images\\i11.png"));
            this.Menu.AjouterItem(new Item(12, "Coquille St-Jacques", 18.462,".\\images\\i12.png"));
        }
        private void InitialiseGrille()
        {
            int position = 0;
            for (int ligne = 0; ligne < GrilleMenu.RowDefinitions.Count; ligne++)
            {
                for (int colonne = 0; colonne < GrilleMenu.ColumnDefinitions.Count; colonne++)
                {
                    Button b = new Button();
                    PositionnerBouton(b,ligne,colonne,position);
                    position++;
                }
            }

        }
        private void PositionnerBouton(Button b, int Ligne, int colonne,int index)
        {
            Grid.SetRow(b, Ligne);
            Grid.SetColumn(b, colonne);
            GrilleMenu.Children.Add(b);
            b.Name = $"b{index}";
            b.Click+= (RoutedEventHandler)this.BouttonB_Click;
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
                //affiche le copyright que si la liste est vide
            {
     //           MessageBox.Show("Codé par Patrice Waechter-Ebling 2022",this.Title,MessageBoxButton.OK,MessageBoxImage.Information); 
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
            listbox1.Items.Add($"֍ Total ");
            listbox1.Items.Add($"   {Math.Round(soustotal*1.15, 2)}$");//on echape pas aux taxes
            string tmpfact = null;
            fichier = Environment.CurrentDirectory +"\\"+ GetUt().ExtraireDateHeure()  + ".txt";
            MessageBox.Show(fichier, "Sauvegarde");
            StreamWriter sw = new StreamWriter(fichier);
            //disposition pour la presentation du MessageBox
            for(int a=0; a<listbox1.Items.Count; a++)
            {
                sw.WriteLine(listbox1.Items[a].ToString());
                if (a % 2 == 0)
                {
                    tmpfact += listbox1.Items[a].ToString() +"\t";
                }
                else 
                {
                    tmpfact += listbox1.Items[a].ToString() + "\n";
                }
            }
            sw.Close();
            MessageBoxResult res= MessageBox.Show(tmpfact, "Confirmation de commande",MessageBoxButton.YesNo,MessageBoxImage.Question);
            if (res == MessageBoxResult.Yes) {
                Process processus = new Process();
                processus.StartInfo.FileName = "notepad.exe";
                processus.StartInfo.WorkingDirectory = Environment.CurrentDirectory;
                processus.StartInfo.Arguments =  fichier;
                processus.Start();
            }
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            AjouterAuMenu ajouterAuMenu = new AjouterAuMenu();
            /*
             * ajouter 1 au nombres d' items deja presents sinon on ecrase le dernier de la liste existante
             */
            try
            {
                if (Menu.GetNombreItem() + 1 > 12)
                {
                    ajouterAuMenu.Title = "Modifier un item du menu";
                    throw new ArithmeticException("Dépassement des parametres fixés dans le cahier des charges");
                }
                ajouterAuMenu.addID.Text = $"{Menu.GetNombreItem()+1}";
            }
            catch (ArithmeticException ex)
            {
                MessageBox.Show(ex.Message, App.ResourceAssembly.FullName.ToString(), MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
            ajouterAuMenu.ShowDialog();
        }
    }
}
