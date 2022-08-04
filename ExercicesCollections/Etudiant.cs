using System;

namespace ExercicesCollections
{
    internal class Etudiant : IComparable
    {
        int ID;
        string Nom;

        public Etudiant(int iD, string nom)
        {
            this.ID = iD;
            this.Nom = nom;
        }

        public int GetID() { return this.ID; }
        public string GetNom() { return this.Nom; }

        public int CompareTo(object obj)
        {
            Etudiant et = (Etudiant)obj;
            return this.GetID().CompareTo(((Etudiant)obj).GetID());
        }
    }
}