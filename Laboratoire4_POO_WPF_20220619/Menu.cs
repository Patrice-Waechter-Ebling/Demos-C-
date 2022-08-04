using System.Collections.Generic;

namespace Laboratoire4_POO_WPF_20220619
{
    internal class Menu : List<Menu>
    {
        string Titre;
        double Prix;
        int Quantite;
        int conte;
        double PrixTotalItem;

        public Menu(string titre, double prix) : base()
        {
            this.conte++;
            this.Titre = titre;
            this.Prix = prix;
            this.Add(this);
        }

        public Menu(string titre, double prix, int quantite) : base()
        {
            this.Titre = titre;
            this.Prix = prix;
            this.Quantite = quantite;
        }

        public string GetTitre() { return this.Titre; }
        public double GetPrix() { return this.Prix; }
        public int GetConte() { return this.conte; }
        public double GetPrixTotalItem() { return this.PrixTotalItem; }
        public int GetQuantite() { return this.Quantite; }
        public void SetQuantite(int value)
        {
            this.Quantite = value;
            this.PrixTotalItem = this.Quantite * this.Prix;
        }


    }
}