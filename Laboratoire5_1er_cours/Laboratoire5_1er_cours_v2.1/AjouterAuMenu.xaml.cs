using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Laboratoire5
{
    /// <summary>
    /// Logique d'interaction pour AjouterAuMenu.xaml
    /// </summary>
    public partial class AjouterAuMenu : Window
    {
        Utilitaires ut=new Utilitaires();
        public AjouterAuMenu()
        {
            InitializeComponent();
            logo.Source= new BitmapImage(new Uri(Environment.CurrentDirectory+"/patice.bin", UriKind.Relative));
        }

        private void Window_Activated(object sender, EventArgs e)
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Image im = new Image();
            im.Source= new BitmapImage(new Uri(ut.ChargerCheminImage(), UriKind.Absolute));
            logo.Source = im.Source;
        }
    }
}
