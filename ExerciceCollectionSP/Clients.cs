using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ExerciceCollectionSP
{
    class Clients:Queue
    {
        int OrdreArrivee;

        public int GetOrdreArrivee() { return this.OrdreArrivee;}
        public Clients(int ordreArrivee)
        {
            this.OrdreArrivee = ordreArrivee;
        }

    }
}
