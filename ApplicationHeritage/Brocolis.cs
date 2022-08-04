using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationHeritage
{
    class Brocolis : Legumes
    {
        bool gouteux;
        int texture;
        int prix;

        public Brocolis(int duree2Vie, int couleur ,int prix, int texture, bool gouteux):base( duree2Vie,  couleur)
        {
            this.prix = prix;
            this.texture = texture;
            this.gouteux = gouteux;
        }
    }
}
