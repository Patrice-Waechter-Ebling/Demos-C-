using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_OO_v1
{
    class Automobile
    {
        public int NbrPlaces { set; get; }
        public int NbrPassagerPresents { private set; get; }
        public int NbrRangees { private set; get; }
        public int NbrColonnes { private set; get; }
        private bool[][] Organisation { get; set; }
        public Automobile()
        {
            NbrRangees = 2;
            NbrColonnes = 2;
            NbrPlaces = NbrColonnes * NbrRangees;
            NbrPassagerPresents = 0;
            Organisation = new bool[NbrRangees][];
            for (int i = 0; i < NbrRangees; i++)
            {
                Organisation[i] = new bool[NbrColonnes];
            }
        }
        public Automobile(int Radis,int carotte)
        {
            NbrRangees = Radis;
            NbrColonnes = carotte;
            NbrPlaces = NbrColonnes * NbrRangees;
            NbrPassagerPresents = 0;
            Organisation = new bool[NbrRangees][];
            for (int i = 0; i < NbrRangees; i++)
            {
                Organisation[i] = new bool[NbrColonnes];
            }
        }
        public Automobile(int[] config)
        {
            NbrRangees = config[0];
            NbrColonnes = config[1];
            NbrPlaces = NbrColonnes * NbrRangees;
            NbrPassagerPresents = 0;
            Organisation = new bool[NbrRangees][];
            for (int i = 0; i < NbrRangees; i++)
            {
                Organisation[i] = new bool[NbrColonnes];
            }
        }
        public bool AjouterPassager()
        {
            if (NbrPassagerPresents < NbrPlaces)
            {
                NbrPassagerPresents++;
                return true;
            }
            else
            {
            return false;
            }
        }

    }
}
