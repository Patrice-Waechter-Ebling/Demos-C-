using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratoire4_POO
{
    interface TraitementCentral
    {
        public void CreerMenu();
        public void AfficherMenu(Menu menu);
        public void CreerRestautrants();
        public void AfficherRestautrants(Restautrants restautrants);
        public void CreerCommande(string article, int quantite, double prixunitaire);
    }
}
