using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_OO_ChaineDECaracteres
{
    class ChaineDeCaracteres
    {
        //Proprietes
        public char[] Contenu { get; private set; }
        public int Longueur { get; private set; }
        public bool ChiffreAutorise { get; set; }
        public bool CaracteresSpeciauxAutorises { get; set; }
        public int MaxSommeChiffre { get; private set; }

        //Methodes
        public ChaineDeCaracteres()
        {
            Longueur = 0;
            ChiffreAutorise = true;
            CaracteresSpeciauxAutorises = true;
            MaxSommeChiffre = 79;
        }
        public ChaineDeCaracteres(string ParametreRecu)
        {
            Longueur = ParametreRecu.Length;
            Contenu = new char[Longueur];
            ChiffreAutorise = false;
            CaracteresSpeciauxAutorises = false;
            for (int i = 0; i < Longueur; i++)
            {
                Contenu[i] = ParametreRecu[i];
                if (char.IsDigit(Contenu[i]))
                {
                    ChiffreAutorise = true; break;
                }
                if (!(Contenu[i] < 48 && Contenu[i] > 58 && Contenu[i] > 96 && Contenu[i] < 123 && Contenu[i] > 64 & Contenu[i] < 91)) 
                {
                    CaracteresSpeciauxAutorises = true; break;
                }
            }

            MaxSommeChiffre = CalculerSommeChiffreDansContenu();
        }
        public int CalculerSommeChiffreDansContenu()
        {
            int Accumulateur = 0;
            for (int i = 0; i < Longueur; i++)
            {
                if (char.IsDigit(Contenu[i]))
                {
                    Accumulateur += (int)(Contenu[i] - 48);
                    /* 
                     * attention convert.int32 ne traite pas les char comme des string
                     *             char unChar = '1';
                     *             Console.WriteLine(unChar); //affiche le caractere 1
                     *             Console.WriteLine(Convert.ToInt32(unChar)); //affiche 49 decimal du carac ASCII 1
                     *             Console.WriteLine(Convert.ToInt32(unChar.ToString())); // affiche 1
                    */
                }
            }
            return Accumulateur;
        }
        private int CalculerSommeChiffreDansAutreContenu(char[] AutreContenu)
        {
            int Accumulateur = 0;
            for (int i = 0; i < Longueur; i++)
            {
                if (char.IsDigit(AutreContenu[i]))
                {
                    Accumulateur += (int)(AutreContenu[i] - 48);
                }
            }
            return Accumulateur;
        }
        public void MettreEnMajustcules()
        {
            for (int i = 0; i < Longueur; i++)
            {
                if (char.IsLetter(Contenu[i]) && Contenu[i] >= 97 && Contenu[i] <= 122)
                {//char.IsLetter(Contenu[i])  est redondant
                    Contenu[i] = (char)(Contenu[i] - 32);

                }
            }
        }
        public bool AjouterCarateres(string CaractereAjouter)
        {
            int nouvelleLongeur = Contenu.Length + CaractereAjouter.Length;
            char[] nouveauContenu = new char[nouvelleLongeur];
            for (int i = 0; i < Longueur; i++)
            {
                nouveauContenu[i] = Contenu[i];
            }
            for (int i = 0; i < CaractereAjouter.Length; i++)
            {
                nouveauContenu[i + Longueur] = CaractereAjouter[i];
            }
            if (!ChiffreAutorise)
            { 
                for(int i=0; i<CaractereAjouter.Length; i++) 
                {
                    if (char.IsDigit(CaractereAjouter[i]))
                    { 
                        return false; 
                    }
                }
            }
            //somme chiffre est ok?
            if (CalculerSommeChiffreDansAutreContenu(nouveauContenu) > MaxSommeChiffre) return false;
            //---------
            Longueur = nouvelleLongeur;
            Contenu = nouveauContenu;
            return true;//parce que l'ajout a est ok
        }
    }
}
