namespace ExercicesCollections
{
    internal class LocalDeClasse
    {
        int ID;
        string Nom;

        public LocalDeClasse(int iD, string nom)
        {
            this.ID = iD;
            this.Nom = nom;
        }

        public int GetID() { return this.ID; }
        public string GetNom() { return this.Nom; }

        public int CompareTo(object obj)
        {
            LocalDeClasse classe = (LocalDeClasse)obj;
            return this.GetID().CompareTo(((Enseignant)obj).GetID());
        }
    }
}