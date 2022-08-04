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

        public Item(int id, string nom, double prix, string image)
        {
            this.Id = id;
            this.Nom = nom;
            this.Prix = prix;
            this.Image = image;
        }

        public int GetId()
        {
            return this.Id;
        }

        public string GetImage()
        {
            return this.Image;
        }

        public double GetPrix()
        {
            return this.Prix;
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

        public override string ToString()
        {
            return this.Nom + " " + this.Prix + "$";
        }
    }
}
