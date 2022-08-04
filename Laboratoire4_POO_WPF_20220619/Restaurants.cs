using System.Collections;
using System.Collections.Generic;

namespace Laboratoire4_POO
{
    internal class Restautrants : List<Restautrants>
    {
        string Nom;
        bool livraison, lesDeux, Surplace;

        public string GetNom() {return this.Nom;}
        public bool GetLivraison() {return this.livraison;}
        public bool GetLesDeux() { return this.lesDeux;  }
        public bool GetSurPlace() { return this.Surplace; }

        public Restautrants(string nom, bool livraison, bool lesDeux, bool surplace) : base()
        {
            this.Nom = nom;
            this.livraison = livraison;
            this.lesDeux = lesDeux;
            this.Surplace = surplace;
            this.Sort();
        }
        public Restautrants(string nom, bool lesDeux=true) : base()
        {
            this.Nom = nom;
            if (lesDeux != true) { 
                throw new System.Exception("Take-Out non implenté");
            }
            else
            {
                this.livraison = lesDeux ;
                this.Surplace = lesDeux;
            }
            this.lesDeux = lesDeux;
            this.Sort();
        }

    }
}