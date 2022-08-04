using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratoire5
{
    class Commande
    {
        List<LigneCommande> Lignes;

        public Commande()
        {
            this.Lignes = new List<LigneCommande>();
        }

        // Si je n'ai pas déjà la ligne de commande, je la crée.
        // Si elle existe déjà, j'incrémente la ligne.
        public void AjouterItem(Item i)
        {
            foreach(LigneCommande ligne in this.Lignes)
            {
                if (ligne.GetItem().CompareTo(i) == 0)
                {
                    ligne.Incremente();
                    // Return je sors de la MÉTHODE
                    return;
                }
            }

            Lignes.Add(new LigneCommande(i));
        }

        // Vérifier si l'item existe.
        // Si item existe, quantité --.
        // Si existe pas, exception.
        // Si item quantité = 1, retirer ligne.
        public void RetirerItem(Item i)
        {
            foreach(LigneCommande ligne in this.Lignes)
            {
                if(ligne.GetItem().CompareTo(i) == 0)
                {
                    if (ligne.GetQuantite() == 1)
                    {
                        this.Lignes.Remove(ligne);
                    }
                    else
                        ligne.Decremente();
                }
            }
        }

        public List<LigneCommande> GetLignes()
        {
            return this.Lignes;
        }
    }
}
