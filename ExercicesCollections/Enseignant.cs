using System;

namespace ExercicesCollections
{
    internal class Enseignant : IComparable
    {
        int ID;
        string Nom;

        public Enseignant(int iD, string nom)
        {
            this.ID = iD;
            this.Nom = nom;
        }

        public int GetID() { return this.ID;}
        public string GetNom() { return this.Nom; }

        public int CompareTo(object obj)
        {
            Enseignant et = (Enseignant)obj;
            return this.GetID().CompareTo(((Enseignant)obj).GetID());
        }
    }
}