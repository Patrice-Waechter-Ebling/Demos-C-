using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationHeritage
{
    class Femme:Homme
    {
        int grandeur;
        bool coquette;

        public Femme(double couleur, int age, string prenom, string nom, int taille,bool coquette, int grandeur = 0):base(couleur, age, prenom, nom, taille)
        {
            this.coquette = coquette;
            this.grandeur = grandeur;
        }
    }
}
