using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationHeritage
{
    class Legumes
    {
        int couleur;
        int duree2Vie;

        public Legumes(int duree2Vie, int couleur = 0)
        {
            this.duree2Vie = duree2Vie;
            this.couleur = couleur;
        }
    }
}
