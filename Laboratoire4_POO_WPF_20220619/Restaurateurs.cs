using System;
using System.Collections.Generic;
using System.Windows;

namespace Laboratoire4_POO_WPF_20220619
{
    internal class Restaurateurs : List<Restaurateurs>
    {
        string NomRestaurant;
        bool Livraison = false;
        bool EnSalle = false;
        bool LesDeux = false;
        int compteurResto;

        public int GetCompteurResto() { return this.compteurResto; }
        public string GetNomRestaurant() { return this.NomRestaurant; }
        public bool GetLivraison() { return this.Livraison; }
        public bool GetEnSalle() { return this.EnSalle; }
        public bool GetLesDeux() { return this.LesDeux; }
        public Restaurateurs(string nomRestaurant, bool livraison, bool enSalle, bool lesDeux) : base()
        {
            this.NomRestaurant = nomRestaurant;
            this.Livraison = livraison;
            this.EnSalle = enSalle;
            this.LesDeux = lesDeux;
        }
        public Restaurateurs(string nomRestaurant, bool lesDeux = true) : base()
        {
            this.NomRestaurant = nomRestaurant;
            try
            {
                if (!lesDeux == true)
                {
                    this.Livraison = false;
                    this.EnSalle = true;
                    throw new Exception(nomRestaurant);
                }
                else
                {
                    this.Livraison = true;
                    this.EnSalle = true;
                }
                this.LesDeux = lesDeux;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, App.Current.MainWindow.Content.ToString(), MessageBoxButton.OK);
            }
        }
        public Restaurateurs()
        {
            this.compteurResto = 0;
        }

        public Restaurateurs CreerRestaurateurs(string nomRestaurant, bool livraison, bool enSalle, bool lesDeux)
        {
            Restaurateurs resto = new Restaurateurs(nomRestaurant, livraison, enSalle, lesDeux);
            this.compteurResto = this.Count;
            return resto;
        }
        public void AjouterRestaurateurs(Restaurateurs restaurateurs)
        {
            this.Add(restaurateurs);
        }
        public void AjouterRestaurateurs(string nomRestaurant, bool livraison, bool enSalle)
        {
            if ((livraison == true) && enSalle == true) { this.LesDeux = true; }
            this.Add(new Restaurateurs(nomRestaurant, livraison, enSalle, this.LesDeux));
        }
    }
}