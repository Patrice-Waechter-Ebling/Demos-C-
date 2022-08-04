using System;

namespace Laboratoire1
{
    class Produit
    {
        int Id;
        string Nom;
        double Prix;
        public int GetID() { return this.Id; }
        public string GetNom() { return this.Nom; }
        public double GetPrix() { return Math.Round(this.Prix, 2); }
        public void SetID(int valeur) { this.Id = valeur; }
        public void SetNom(string valeur) { this.Nom = valeur; }
        public void SetPrix(double valeur) { this.Prix = valeur; }
        public void SetPrix(int valeur) { this.Prix = valeur; }
        public Produit(int id, string nom, double prix)
        {
            this.Id = id;
            this.Nom = nom;
            this.Prix = prix;
        }
    }
}
