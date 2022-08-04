using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratoire5
{
    class Item : IComparable
    {
        int Id;
        string Nom;
        double Prix;
        string Image;

        public string GetNom() { return this.Nom;}
        public double GetPrix() { return this.Prix;}

        public Item(int id, string nom, double prix, string image)
        {
            this.Id = id;
            this.Nom = nom;
            this.Prix = prix;
            this.Image =Environment.CurrentDirectory + image;
        }

        public Item(string nom, double prix)
        {
            this.Nom = nom;
            this.Prix = prix;
        }

        public string GetCheminImage() {return this.Image;  }

        public int GetId()
        {
            return this.Id;
        }

        public int CompareTo(object obj)
        {
            Item item = (Item)obj;

            if (this.GetId() < item.GetId())
                return -1;
            else if (this.GetId() > item.GetId())
                return 1;
            else
                return 0;
        }
    }
}
