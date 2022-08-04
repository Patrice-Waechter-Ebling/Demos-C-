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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Image im = new Image();
            string fichierImage = ut.ChargerCheminImage();
            im.Source= new BitmapImage(new Uri(fichierImage, UriKind.Absolute));
            logo.Source = im.Source;
            this.addImage.Text = fichierImage;
            //extraction du titre depuis le nom de l'image
            //ne pas oublier de compter le \0 a la fin du nom de fichier d'ou 0x05 et non pas 0x04
            this.addNom.Text = fichierImage.Substring(fichierImage.LastIndexOf("\\")+1, fichierImage.Length - fichierImage.LastIndexOf("\\") - 0x05);
        }
    }
}
