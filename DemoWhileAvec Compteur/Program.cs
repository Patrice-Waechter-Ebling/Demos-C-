using System;

namespace DemoWhileAvec_Compteur
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   MethodeBasic2();
               MethodePaire(20, true);
               MethodePaire(20, false);
               MethodeIncrementAvecSautDeTour();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" Démarrage de la fonction -->\tMenuSelection()");
            int val=MenuSelection();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"\tMenuSelection() ==>> {val}\t\tBonne journée");
            Console.ForegroundColor = ConsoleColor.White;*/
            //   MethodeIncrementAvecQuestion();
            Console.WriteLine("Méthode AnalyserContenuAlphabetique()");
            Console.WriteLine("--------------------------------------");
            string ChaineCaracteres = "je prefere programmer en cpp";
            AnalyserContenuAlphabetique(ChaineCaracteres);

        }
        static int MenuSelection()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Valeur d'incrementation? ");
            int val = (int)Math.Truncate(Convert.ToDecimal(Console.ReadLine().Replace(".", ",")));
            Console.Write($"{val} sera la valeur d'incrementation validée");

            Console.WriteLine("Sélectionner soit la methode \"A\" ou la methode \"B\"");
            string choix = Console.ReadLine().ToUpper();
            if (choix[0] != 'A')
            {
                if (choix[0] == 'B')
                {
                    MethodeIncrement_v2b(val); //idee de se servir la saisie pour genere la limite de boucle 
                    return 2;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"La valeur {choix[0]} n'est pas permise");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Sélectionner soit la methode \"A\" ou la methode \"B\"");
                    return -1;
                }
            }
            else
            {
                MethodeIncrement_v2a(val); //idee de se servir la saisie pour décaler la valeur de sortie 
                return 1;
            }
        }
        static void MainBoucle_FOR_basique(string[] args)
        {
            Console.WriteLine("Hello World!");

            for (int x = 0; x < 42; x++)
            {

                Console.WriteLine($"{x} = {x * 3 + 6}");



            }
        }

        static void MethodeBasic()
        {
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine("<--[DÉBUT] de la boucle -->");
                Console.WriteLine(i);
                i++;
                if (i == 5)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("<--[FIN] de la boucle -->");
            }
        }
        static void MethodeBasic2()
        {
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine($"<--[DÉBUT] de la boucle {i + 1} -->");
                Console.WriteLine(i);
                i++;
                if (i == 5)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine($"<--[FIN] de la boucle {i} -->");
            }
        }
        static void MethodePaire(int Valeur)
        {
            int i = 0;
            while (i < Valeur)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"<--[DÉBUT] de la boucle {i + 1} --> ");
                i++;
                if (i % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write($"{i} est paire");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{i} n'est pas un pair ");
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($" <--[FIN] de la boucle {i} -->");
            }
        }
        static void MethodeIncrement_v1_D()
        {
            int a = 10;
            Console.WriteLine("Valeur a au début: " + a);
            Console.WriteLine("//---");
            Console.WriteLine("Valeur a avant int c = ++a; : " + a);
            int c = ++a; //Augmente la valeur de a avant de la mettre dans c
            Console.WriteLine("Valeur c: " + c);
            Console.WriteLine("Valeur a après int c = ++a; : " + a);
            Console.WriteLine("//---");
            Console.WriteLine("Valeur a avant int d = a++; : " + a);
            int d = a++; //Augmente la valeur de a après de la mettre dans d
            Console.WriteLine("Valeur d: " + d);
            Console.WriteLine("Valeur a après int d = a++; : " + a);
            Console.WriteLine("//---");
            Console.WriteLine("Valeur a à la fin: " + a);
        }
        static void MethodeIncrement_v1a()
        {
            int i = 0, temp_i_pp, temp_pp_i;
            while (i < 5)
            {
                Console.Write("i : ");
                Console.Write(i); Console.Write("\t|\t"); temp_pp_i = i;
                Console.Write("Console.Write(++i) : ");
                Console.Write(++temp_pp_i); Console.Write("\t|\t");
                temp_i_pp = i;
                Console.Write("Console.Write(i++) : "); Console.Write(temp_i_pp++); Console.WriteLine(); i++;//i++ même chose que i=i+1
            }
        }
        static void MethodeIncrement_v1()
        {
            int i = 0;
            while (i < 5)
            {
                Console.Write("++i : ");
                Console.Write(++i + '\t');

                Console.Write("i++ : ");
                Console.Write(i++ + '\t');

                Console.Write("i   : ");
                Console.Write(i++ + '\t');
                Console.WriteLine();
            }
        }
        static void MethodeIncrement_v2a(int Decalage)
        { //basé sur la question de Jean
            int i = 0;
            int x = Decalage;
            while (i < Decalage)
            {
                x = Decalage + i;
                Console.WriteLine($"{i} -->{x++}");
                i++;
            }
        }
        static void MethodeIncrement_v2b(int Decalage)
        { //basé sur la question de Jean
            int i = 0;
            int x = Decalage;
            while (i < (Decalage * Decalage))
            {
                x = Decalage + i;
               Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"y=f(");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(i);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(") retoune comme valeur ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine((i * ++x));
                i++;
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void MethodeIncrementAvecSautDeTour(){
            int patate = 0;
            while (patate < 7) {
                patate++;
                if (patate != 3)
                {
                    Console.WriteLine(patate);
                }
            }
        }
        static void MethodeIncrementAvecQuestion()
        {
            int patate = 0;
            int limite = 7;
            while (patate < limite){
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"Cycle de patate=");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(patate);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" eme occurance");
                patate++;
                if (patate == limite) {  //ici patate vaut 7
                    Console.WriteLine($"Nombre de tours en plus?  Valeur de patate {patate}");
                    int plus =Convert.ToInt32(Console.ReadLine());
                    if (plus <=0){
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"limite de prolongation {plus} n'est pas permise");
                        Console.ForegroundColor = ConsoleColor.White;
                        return;
                    }
                    limite =limite + plus; // limite (nouvelle destination) 7+ valeur de [plus]
                }
            } 

        }

        static void MethodePaire(int Valeur,bool AffichePaire)
        {
            int i = 0;
            if (i > Valeur) { i = Valeur - 1; }// contre les valeurs inferieures a la valeur initiale de i
            if (AffichePaire)
            {
                Console.WriteLine("Le tri pair est selectionné");
            }
            else {
                Console.WriteLine("Le tri impair est selectionné");
            }
            while (i < Valeur)
            {
                i++;
                if (AffichePaire){
                   if (i % 2 == 0)
                    {
                        Console.WriteLine($"{i} est paire");
                    }
                }
                else {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine($"{i} est impair");
                    }
                }
            }
        }
         /*
         * tu sais que ca va prendre un return pour envoyer le texte de sortie
         * tu vas devoir traiter du texte 
         * tu vas devoir creer un variable de type string pour recevoir le traitement de ton operation sur le texte
         * dans ta variable cree quiest un string tu vas chercher une sous fonction qui te permet de produire le resultat demandé
         * il te faut utiliser ta variable cree tu vera une fonction qui corespond a rechercher un caractere 
         * fonction .contains() sugeree car elle retourne une valeur de type bool ideale pour un if
         * a partir de ca tu peux utiliser if/else pour selectionner ce qu'il doit executer dans chaque cas
         * arriver a la fin de la section de cas il doit renvoyer une reponse au format string comme defini dans la declaration de la fonction
         *  nb++ sert a increment le conteur dans un des 2 cas seulement 
         *  puis les retoune a la fonction qui l'a appelee via l'instruction ref
         */
        static string LaLettreEstInclue(string ChaineCaracteres, string lettre, ref int nb)
        {
            string cpp= ChaineCaracteres.ToLower();
            if (cpp.Contains(lettre) == true)
            {
                nb++;
                return "OUI*";
            }
            else
            {
                return "non";
            }
        }//fonction appelee

        // vaut une chaine de caracteres ( a cause du string dans la declaration de la fonction
  
        /*
         * tu sais que ca va rien returner comme sortie
         * tu sais que pour la combler les parametre de la fonction appelee il te faudra 
         * un string, un string et un int qui sera declare en ref du a la liaison pour recevoir
         * les info du compteur dans la fonction appelee
         * tu vas devoir afficher le result de chaque appel a la fonction appelee
         *  ex:Console.WriteLine($"z:{LaLettreEstInclue(ChaineCaracteres, "z", ref nombre)}");
         **/
        static void AnalyserContenuAlphabetique(string ChaineCaracteres)// fonction qui appelle
        {
            int nombre = 0;
            Console.WriteLine($"a:{LaLettreEstInclue(ChaineCaracteres, "a", ref nombre)}");
            Console.WriteLine($"b:{LaLettreEstInclue(ChaineCaracteres, "b", ref nombre)}");
            Console.WriteLine($"c:{LaLettreEstInclue(ChaineCaracteres, "c", ref nombre)}");
            Console.WriteLine($"d:{LaLettreEstInclue(ChaineCaracteres, "d", ref nombre)}");
            Console.WriteLine($"e:{LaLettreEstInclue(ChaineCaracteres, "e", ref nombre)}");
            Console.WriteLine($"f:{LaLettreEstInclue(ChaineCaracteres, "f", ref nombre)}");
            Console.WriteLine($"g:{LaLettreEstInclue(ChaineCaracteres, "g", ref nombre)}");
            Console.WriteLine($"h:{LaLettreEstInclue(ChaineCaracteres, "h", ref nombre)}");
            Console.WriteLine($"i:{LaLettreEstInclue(ChaineCaracteres, "i", ref nombre)}");
            Console.WriteLine($"j:{LaLettreEstInclue(ChaineCaracteres, "j", ref nombre)}");
            Console.WriteLine($"k:{LaLettreEstInclue(ChaineCaracteres, "k", ref nombre)}");
            Console.WriteLine($"l:{LaLettreEstInclue(ChaineCaracteres, "l", ref nombre)}");
            Console.WriteLine($"m:{LaLettreEstInclue(ChaineCaracteres, "m", ref nombre)}");
            Console.WriteLine($"n:{LaLettreEstInclue(ChaineCaracteres, "n", ref nombre)}");
            Console.WriteLine($"o:{LaLettreEstInclue(ChaineCaracteres, "o", ref nombre)}");
            Console.WriteLine($"p:{LaLettreEstInclue(ChaineCaracteres, "p", ref nombre)}");
            Console.WriteLine($"q:{LaLettreEstInclue(ChaineCaracteres, "q", ref nombre)}");
            Console.WriteLine($"r:{LaLettreEstInclue(ChaineCaracteres, "r", ref nombre)}");
            Console.WriteLine($"s:{LaLettreEstInclue(ChaineCaracteres, "s", ref nombre)}");
            Console.WriteLine($"t:{LaLettreEstInclue(ChaineCaracteres, "t", ref nombre)}");
            Console.WriteLine($"u:{LaLettreEstInclue(ChaineCaracteres, "u", ref nombre)}");
            Console.WriteLine($"v:{LaLettreEstInclue(ChaineCaracteres, "v", ref nombre)}");
            Console.WriteLine($"w:{LaLettreEstInclue(ChaineCaracteres, "w", ref nombre)}");
            Console.WriteLine($"x:{LaLettreEstInclue(ChaineCaracteres, "x", ref nombre)}");
            Console.WriteLine($"y:{LaLettreEstInclue(ChaineCaracteres, "y", ref nombre)}");
            Console.WriteLine($"z:{LaLettreEstInclue(ChaineCaracteres, "z", ref nombre)}");
            Console.WriteLine($"-->Bilan:{nombre} lettres de l'alphabet en minuscules");
        }
  
    }

}
