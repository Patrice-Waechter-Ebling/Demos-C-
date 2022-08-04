using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;

namespace ManipulationsStrings
{
    class Program
    {
        static void Main(string[] args)   {
            Console.WriteLine("Exécution: "+args);
            Console.WriteLine("Nom á modifier ");
            string tmp = Console.ReadLine();
            if (Directory.Exists(tmp)!=false){  Directory.CreateDirectory(tmp);   }
            string tmp2 = tmp;
            int lng = tmp.Length;
            int indexMax = lng - 1;
            Console.WriteLine("Nombre de caractères à retirer à gauche ");
            int stStart = Convert.ToInt32(Console.ReadLine());
            int index = indexMax - stStart;
            for (int a = 0; a <= stStart; a++) {
                tmp2 = tmp2 + tmp[a];
            }
            Console.WriteLine("Chaine retirée à gauche: " +tmp2.Substring(0,stStart));
            Console.WriteLine("Chaine restante à droite: " + tmp.Substring(stStart));
            string tmp1=tmp.Substring(stStart)+" ["+tmp2.Substring(0,stStart-1)+"]";
            Console.WriteLine("Resultat: " + tmp1);
            Directory.Move(tmp, tmp1); 
           
            Console.ReadLine();
            //201-016-RE Mise à niveau pour Mathématique, séquence Technico-sciences de la 4e secondaire          

        }
    }
}
