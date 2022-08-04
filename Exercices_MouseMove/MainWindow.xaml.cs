using System.Windows;
using System.Windows.Input;

namespace Exercices_20220621_E2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            System.Windows.Point position = e.GetPosition(this);
            double pX = position.X;
            double pY = position.Y;
            Title = $"{e.MouseDevice.ToString()}, Position X: {pX}\nPosition Y: {pY}";
            if ((this.Width - pX) > 0) { curseur2.Width = (this.Width - pX); }
            if ((this.Height - pY) > 0) { curseur2.Height = (this.Height - pY); }
        }
    }
}
