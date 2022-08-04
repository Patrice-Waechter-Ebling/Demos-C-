using System;

namespace ChiffrePaire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnneeBiextile();
            MotDepasse();
            ChiffrePair();
        }
        static void ChiffrePair() {   
            Console.WriteLine("==> Chiffre paire");
            Console.WriteLine("Entrez 1 nombres entier au clavier en tapant entrée");
            int nbrA = Convert.ToInt32(Math.Truncate(Convert.ToDouble(Console.ReadLine().Replace(".",","))));
            if (nbrA % 2 == 0)            {
            Console.WriteLine($"{nbrA} est un chiffre pair");
            }else {
            Console.WriteLine($"{nbrA} est un chiffre impair");
            } 
        }
        static void AnneeBiextile(){
            Console.WriteLine("Entrez 1 annee au clavier en tapant entrée");
            int nbrA = Convert.ToInt32(Math.Truncate(Convert.ToDouble(Console.ReadLine().Replace(".", ","))));
            if ( (nbrA % 400 == 0)||(nbrA % 4 == 0)&&(nbrA % 100 != 0))
                {
                    Console.WriteLine($"{nbrA} est une année bisextille");
                }
                else
                {
                    Console.WriteLine($"{nbrA} n'est pas une année bisextille");
                }
            if (DateTime.IsLeapYear(nbrA) == true) {
                Console.WriteLine($"{nbrA} est une année bisextille datetime");
            }        else
            {
                Console.WriteLine($"{nbrA} n'est pas une année bisextille datetime");
            }
        }
        static void MotDepasse()
        {
            Console.WriteLine("Entrez votre mot de passe au clavier en tapant entrée");
            string mdp ="Patate$79";
            string ps = Console.ReadLine();
            if (ps != mdp)
            {
                Console.WriteLine("Ramasse ta pelle et vas pelter de la neige en Alaska");
            }
            else { Console.WriteLine("bingo");
            }
        }
    }
}

