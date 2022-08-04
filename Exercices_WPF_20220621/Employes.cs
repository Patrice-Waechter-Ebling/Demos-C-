using System;
using System.Collections.Generic;
using System.Text;

namespace Exercices_20220621
{
    class Employes:List<Employes>
    {
        string nom;
        string prenom;
        int numEmploye;
        string[] poste = { "Prof", "Balayeur", "Cuisinier", "Gardien", "Gros Pourri", "Directeur", };

        public Employes(string nom, string prenom, int numEmploye)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.numEmploye = numEmploye;
        }
        public string GetNom() { return this.nom; }
        public string GetPrenom() { return this.prenom; }
        public int GetNumEmploye() { return this.numEmploye; }
        public string GetPoste(int index){return this.poste[index];}
        public void SetPoste(string poste,int index){this.poste[index]=poste;}
        public int GetNombrePoste(){return this.poste.Length;}
    }
}
