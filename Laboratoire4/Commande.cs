using System.Collections;
using System.Collections.Generic;

namespace Laboratoire4
{
    internal class Commande:Plats
    {
        
        int v;
        Menu mnu = new Menu();
        Stack nCommande = new Stack();
        public Commande(int v)
        {
            this.v = v;
        }

        public int GetNumeroCommande() { return v; }
        public void AjouterItem(int choix)
        {
            nCommande.Push(GetPlat(choix));
        }
    }
}