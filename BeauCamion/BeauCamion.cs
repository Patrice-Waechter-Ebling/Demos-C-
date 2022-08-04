using System;
using System.Collections.Generic;
using System.Text;

namespace BeauCamion
{

    class BeauCamion
    {
        string Nom = "Mon BeauCamion";
        string couleur="vert";
        int compteur=0;

        public BeauCamion(String nom , String couleur)
        {
            this.Nom = nom;
            this.couleur = couleur;
            this.compteur++;
        }


        public BeauCamion()
        {
            this.compteur++;
        }


        public Int32 GetCompteur() {return this.compteur;}

        public String GetCouleur() {return this.couleur; }

        public string GetNom() {return  this.Nom;}
    }
}
