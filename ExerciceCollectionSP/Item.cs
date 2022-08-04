using System.Collections;
using System.Collections.Generic;

namespace ExerciceCollectionSP
{
    internal class Item:Stack
    {
        string v1;
        int v2;
        double v3;
        int conte;

        List<Item> ls = new List<Item>();

        public Item(string v1, int v2, double v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }
        public int GetConte() {return conte;}
        public string GetNom() { return this.v1;}
        public int GetQuantitee() { return this.v2;}
        public double GetPrix() { return this.v3;}

        public void AjouterItem(string v1, int v2, double v3)
        {
           
            ls.Add()
                this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.conte+=v2;
        }
    }
}