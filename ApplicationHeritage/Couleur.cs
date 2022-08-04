using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationHeritage
{
    class Couleur:Homme
    {
        int cheveux;
        int peau;
        int yeux;
        // Homme()
        public Couleur(double couleur, int age, string prenom, string nom , int taille ,int yeux,int peau,int cheveux):base( couleur,  age,  prenom  , nom ,  taille)
        {
            this.yeux = yeux;
            this.peau = peau;
            this.cheveux = cheveux;
        }
    }
}
