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

namespace Exercices_20220621
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Employes ep = new Employes(null, null, 0);
        public MainWindow()
        {
            InitializeComponent();
            int i = ep.GetNombrePoste();
            for (int a = 0; a < i; a++) {
                poste.Items.Add(ep.GetPoste(a));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ep.Add(new Employes(nom.Text.ToString()
                , prenom.Text.ToString(), Convert.ToInt32(numEmploye.Text.ToString())));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (ep.Count < 1) {
                Exception ex = new Exception("Impossible dáfficher le néant");
                MessageBox.Show(ex.Message, ex.GetType().FullName,MessageBoxButton.OK);
            }
            else
            {
                Resultat resultat = new Resultat();
                resultat.ShowDialog();
            }
        }
    }
}
