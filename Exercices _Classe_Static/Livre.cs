using System;
using System.Collections.Generic;
using System.Text;

namespace Exercices__Static
{
    class Livre
    {
        string ISBN;
        string Titres;
        int nbPages;
        static string Auteur = "Bernard";
     
        public static string GetAuteur() { return Livre.Auteur; }

        public String GetISBN() { return this.ISBN; }
        public void SetISBN(String value) { this.ISBN = value; }
        public String GetTitre() { return this.Titres; }
        public void SetTitre(String value) { this.Titres = value; }
        public int GetnbPages() { return this.nbPages; }
        public void SetnbPages(int value) { this.nbPages = value; }

        public Livre()
        {
        }

        public Livre(string iSBN, string titres, int nbPages)
        {
            this.ISBN = iSBN;
            this.Titres = titres;
            this.nbPages = nbPages;
        }

    }
}
