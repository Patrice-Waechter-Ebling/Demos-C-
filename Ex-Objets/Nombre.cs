using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Objets
{
    class Nombre
    {
        public int ValeurInt;
        public int ValeurDouble;

        public Nombre(int valeurInt, int valeurDouble)
        {
            this.ValeurInt = valeurInt;
            this.ValeurDouble = valeurDouble;           
        }

        public int Fact()
        {
            for (int x = 1; x < this.ValeurInt + 1; x++)
            {
                int b = (this.ValeurInt - 1);
                int c = b + 1;
                this.ValeurDouble = c * b;
            }

            return this.ValeurDouble;
        }

        private int Fact(int nombre)
        {
            if(nombre > 1)
            {
                return nombre * Fact(nombre - 1);
            }

            return nombre;
        }
    }
}
