using System;

namespace AlterationTexte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phraseTest = "je prefere programmer en c++ {patrice@divano.dev}";
            //Console.WriteLine(VariableStringAnalyser(phraseTest));
            Console.WriteLine(VariableStringAnalyserV1(phraseTest));
            //  VariableStringAnalyserV2(phraseTest);
            //   Console.WriteLine(ProperCaseStringStyle(phraseTest));
            // PratiqueRxercicesSuppl("bizimana kevine");

        }
        static string ProperCaseStringStyle(string ProperCaseStringStyle)
        {
            string tmp = "";
                            int y = 0;
            for (int x = 0; x < ProperCaseStringStyle.ToLower().Length; x++) 
            {
                for (int z = 0x10; z < 0xBE; z++)
                {
                    {
                        if (ProperCaseStringStyle[x] == z)
                        {
                            for (int a = 0; a <= ProperCaseStringStyle.Length; a++)
                            {
                               switch (z)
                                {
                                    case 0xA0: { y++; Console.WriteLine($"{(char)z} a l'index {x}"); } break;
                                    case 0xD0: { y++; Console.WriteLine($"{(char)z} a l'index {x}"); } break;
                                    case 0xFE: { y++; Console.WriteLine($"{(char)z} a l'index {x}"); } break;
                                    case 0x20: 
                                        {
                                            y++;
                             Console.WriteLine($" {(char)(z)}, Valeur:{z},Index:{x},Position:{x+1} Reslutat: {(char)((ProperCaseStringStyle[z + 1]))}");
                                             }
                                        break; //espace
                                }
                            }
                            tmp = tmp + $" {(char)(z)}, {z}";
                        }
                    }
                }
            }
            return tmp;
        }
        static string VariableStringAnalyser(string VariableStringAnalyser)
        {
            string tmp = "";
            for (int x = 0; x < VariableStringAnalyser.ToLower().Length; x++) //facon de conpter aussi le majuscule
            {
                for (int z = 97; z < 123; z++)
                {
                    {
                        if (VariableStringAnalyser[x] == z)
                        {
                            int y = 0;
                            for (int a = 0; a < VariableStringAnalyser.Length; a++)
                            {
                                if (VariableStringAnalyser.Substring(a, 1).Contains((char)z)) { y++; }
                            }
                            tmp = tmp + $" {(char)(z)}, {y}";
                        }
                    }
                }
            }
            return tmp;
        }
        static string VariableStringAnalyserV1(string VariableStringAnalyser)
        {
            int[] alpha = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            string tmp = null;
            int b = VariableStringAnalyser.Length;
            Console.WriteLine($"Début de la procédure avec {tmp}");
            for (int x = 0; x < b; x++) //facon de conpter aussi le majuscule
            {
                if (char.IsLetter(VariableStringAnalyser[x]))
                {
                    for (int z = 97; z < 123; z++)
                    {
                        {
                            if (VariableStringAnalyser[x] == z)
                            {
                                int y = 0;
                                for (int a = 0; a < b; a++)
                                {
                                    if (char.IsWhiteSpace(VariableStringAnalyser[x]))
                                    {
                                        Console.WriteLine($"Espace détecté offset: {x}");
                                    }
                                    if (VariableStringAnalyser.Substring(a, 1).Contains((char)z)) { y++; alpha[z - 97] = y; }
                                }
                                tmp = tmp + (char)(z);
                            }
                        }
                    }
                }
                else if ( char.IsDigit(VariableStringAnalyser[x])) 
                {
                    tmp = tmp + (char)VariableStringAnalyser[x];
                }
                else 
                {
                  tmp = tmp +VariableStringAnalyser[x];
                }
            }
            for (int x=0; x < 26; x++) { 
                Console.WriteLine($"{x+1} {(char)(x+97)} = {alpha[x]}");
            }
            return tmp;
        }
        static void VariableStringAnalyserV2(string VariableStringAnalyser)
        {
            string tmp =VariableStringAnalyser[0].ToString();
            bool blanc = false;
            int b = VariableStringAnalyser.Length;
            int[] alpha = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            Console.WriteLine($"Début de la procédure avec {tmp}");
            for (int x = 0; x < VariableStringAnalyser.ToLower().Length; x++) //facon de conpter aussi le majuscule
            {
                if (char.IsLetter(VariableStringAnalyser[x]) == true)
                {
                    for (int z = 97; z < 123; z++)
                    {
                        if (VariableStringAnalyser[x] == z)
                        {
                            int y = 0;
                            for (int a = 0; a < b; a++)
                            {
                                if (blanc == true && (a+1)<b)
                                {
                  //                  x++;
                                    if (VariableStringAnalyser.Substring(a++, 1).Contains((char)z))
                                    {
                                        y++;
                                        alpha[z-97]=y;
                                    }
                                }
                                else
                                {
                                    if (VariableStringAnalyser.Substring(a++, 1).Contains((char)z)) 
                                    {
                                        alpha[z - 97] = y;
                                    }

                                }
                            }
                            if (blanc == true)
                            {
                                if (x + 1 > b)
                                {
                                    tmp = tmp + VariableStringAnalyser[x + 2];
                                }
                                else {
                                    tmp = tmp + (char)VariableStringAnalyser[x+1];
                                }
                            }
                            else
                            {
                                tmp = tmp+(char)(z);

                            }
                            if (y > 1) // s ou pas S a occurance
                            {
                                Console.Write((char)(z));
                            }
                            else 
                            { 
                                Console.WriteLine((char)(z));
                            }
                        }
                       
                    }
                }
                else if (char.IsDigit(VariableStringAnalyser[x]) == true)
                {
                    tmp=tmp+(char)VariableStringAnalyser[x];
                }
                else 
                {
                    Console.Write($" {(char)(0x3FC)}");
                    if (char.IsWhiteSpace(VariableStringAnalyser[x]))
                    {
                        blanc = true;
                        //                   
                        if (x + 1 >= b)
                        {
                            tmp = tmp + (char)0x20 + (char)(VariableStringAnalyser[x] - 32);
                        }
                        else
                        {
                            Console.WriteLine($"Expace détecté offset: {x}");
                         /*   if (VariableStringAnalyser[x] == 0x20)
                            {
                                Console.WriteLine($"Expace détecté offset: {x}");
                                x++;
                            }*/
                            tmp = tmp + (char)(VariableStringAnalyser[x + 1] - 32)+ (char)0x20;
                        }

                    }
                    else {
                        blanc = false;
                    }
                    tmp = tmp + (VariableStringAnalyser[x]);

                    //
                }
            }            
            Console.WriteLine($"\n\nSource={VariableStringAnalyser}");
            for(int x= 0; x < 26; x++) 
            {
                Console.WriteLine($"{(char)(x+97)} {alpha[x]} occurances");
                
            }
            Console.WriteLine($"Resultat={tmp}");

        }
        //PratiqueRxercicesSuppl("bizimana kevine");// < mettre dans void Main

        static void PratiqueRxercicesSuppl(string texte) // Requete [21:31] CHANTAL DUSABIMANA INGABIRE (Etudiant)
        {
            string resultat = "";
            Console.WriteLine(texte.GetType());
            for (int x = 0; x <  texte.ToLower().Length; x++) //facon de conpter aussi le majuscule
            {
                for (int z = 97; z < 123; z++)//valeurs des lettres de la table ASCII
                {                   
                    if ( texte[x] == z)
                    {
                        int y = 0; //compteur
                        for (int a = 0; a <  texte.Length; a++)//explorer la chaine de texte pour compter la lettre
                        {
                            if ( texte.Substring(a, 1).Contains((char)z)) { y++; }
                        }
                        resultat = resultat + $" {(char)(z)}, {y}";
                    }
                }
            }
            Console.WriteLine(resultat);
        }
    }
}
