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

namespace ex_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Vous devez faire en sorte que ...
        // 1. Lorsqu'on clique sur le bouton « Switch », 
        // nous interchangeons les couleurs des deux rectangles.
        // 2. Lorsque nous changeons le contenu du textbox « Titre », 
        // le titre en gras change dynamiquement pour représenter la 
        // valeur du textbox.
        public MainWindow()
        {
            InitializeComponent();
        }

  
        private void Switch_Click(object sender, RoutedEventArgs e)
        {
            Brush brushRouge = R1.Fill;
            Brush brushBleu = R2.Fill;
            if (R1.Fill == brushRouge)
            {
                R1.Fill = brushBleu;
                R2.Fill = brushRouge;
            }
            else
            {
                R1.Fill = brushRouge;
                R2.Fill = brushBleu;

            }
        }

        private void TitreInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tmp = TitreInput.Text;
            TextBlock Tite = new TextBlock
            {
                Text = tmp
            };
            Switch.Content = Tite.Text;

        }
    }
}
