using System;
using System.Collections.Generic;

namespace Laboratoire4_POO_WPF_20220619
{
    internal class Commande : List<Commande>
    {
        string Plat;
        int Quantite;
        double PrixUnitaire;
        double PrixTotal;


        public Commande() : base()
        {
            this.Quantite = 1;
        }

        public Commande(string plat, int quantite, double prixUnitaire) : base()
        {
            if (plat == null) { throw new ArgumentNullException("Ce paramètre ne peut pas etre null"); }
            this.Plat = plat;
            if (quantite > 0)
            {
                this.Quantite = quantite;
            }
            else
            {
                throw new ArgumentException("Erreur:La quantité doit etre au minimum de 1 article");
            }
            this.PrixUnitaire = prixUnitaire;
            if ((this.PrixUnitaire > 0) && (this.Quantite > 0))
            {
                this.PrixTotal = prixUnitaire * quantite;
            }
            else
            {
                throw new Exception("Il n'y a pas d'article gratuit prévu dans cette commande");
            }
        }
        public string GetPlat() { return this.Plat; }

        public double GetPrixTotal() { return this.PrixTotal; }
        public int GetQuantite() { return this.Quantite; }
        public double GetPrixUnitaire() { return this.PrixUnitaire; }
        public void AjouterItem(Menu menu) { this.Add(new Commande(menu.GetTitre(), 1, menu.GetPrix())); }
        public void AjouterItem(string plat, int quantite, double prixUnitaire)
        {
            if (plat == null) { throw new ArgumentNullException("Líntitulé ne doit pas etre vide"); }
            if (quantite < 1) { throw new ArithmeticException("La quantité minimale est de 1"); }
            if (prixUnitaire <= 0) { throw new ArithmeticException($"{prixUnitaire} est incorect comme valeur"); }
            this.Add(new Commande(plat, quantite, prixUnitaire));
        }
        public double CalculerFraisLivraison()
        {
            if (this.GetPrixTotal() < 20) { return GetPrixTotal() * 1.15; }
            if (this.GetPrixTotal() < 30) { return GetPrixTotal() * 1.1; }
            if (this.GetPrixTotal() < 40) { return GetPrixTotal() * 1.05; }
            return GetPrixTotal();
        }
    }
}