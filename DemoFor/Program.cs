using System;
using System.Threading;

namespace DemoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            string phraseTest = "je prefere programmer en c++ {patwe33@divanoDev}";
            // MethodeUsageBaseUtilisationFor();
            //-------
            // ManipulateurDeStringVersionASCII("phrase de test.");
            Console.WriteLine( AnalyseurDeString(phraseTest));
        }
        static void ManipulateurDeString(string tmp)
        {
            string maj = tmp.ToUpper();
            for (int x = 0; x < tmp.Length - 1; x++)
            {
                if (x % 2 != 0)
                {
                    Console.Write(tmp.ToUpper()[x]);
                }
                else
                {
                    Console.Write(tmp.ToLower()[x]);
                }
            }
        }
        static void ManipulateurDeStringVersionASCII(string tmp)
        {
            for (int x = 0; x < tmp.Length - 1; x++)
            {
                if (x % 2 == 0)
                {
                    Console.Write(tmp[x]);
                
                }
                else
                {
                   if (tmp[x] > 0x60 && tmp[x] < 0x7b) {
                        Console.Write(((char)(tmp[x] - 32)));
                    }
                }
            }
        }
        static void ManipulateurDeStringV3(string tmp)
        {
            string maj = tmp.ToUpper();
            for (int x = 0; x < tmp.Length - 1; x++)
            {
                if (x % 2 != 0)
                {
                    Console.Write(maj[x]);
                }
                else
                {
                    Console.Write(tmp[x]);
                }
            }
        }
        static void MethodeUsageBaseUtilisationFor()
        {
            for (int i = 0; i < 5; i++)
                Console.WriteLine("Hello World!");

            for (int i = 0; i < 3; i++)
                Console.WriteLine($"Valeur courante de i = {i}");

            Console.WriteLine("Appuyez sur ENTRÉE lorsque vous serez prête pour la suite.");
            Console.ReadLine();

            for (int patate = 10; patate < 20; patate++)
                AffichageFancy(patate);

            for (int patate = 10; patate > 0; patate--)
                AffichageFancy(patate);
        }
        static void AffichageFancy(int ValeurCompteur)
        {
            Console.Clear();
            Console.Write(ValeurCompteur);
            if (ValeurCompteur % 2 == 0)
            {
                Console.WriteLine(" +");
                Thread.Sleep(250);
            }
            else
            {
                Console.WriteLine(" x");
                Thread.Sleep(250);
            }
        }
        static string AnalyseurDeString(string VariableStringAnalyser) 
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
                else if (char.IsDigit(VariableStringAnalyser[x]))
                {
                    tmp = tmp + (char)VariableStringAnalyser[x];
                }
                else
                {
                    tmp = tmp + VariableStringAnalyser[x];
                }
            }
            for (int x = 0; x < 26; x++)
            {
                Console.WriteLine($"{x + 1} {(char)(x + 97)} = {alpha[x]}");
            }
            
            return tmp;
        }
        static void VariableStringAnalyserV2(string VariableStringAnalyser)
        {
            string tmp = VariableStringAnalyser[0].ToString();
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
                                if (blanc == true && (a + 1) < b)
                                {
                                    //                  x++;
                                    if (VariableStringAnalyser.Substring(a++, 1).Contains((char)z))
                                    {
                                        y++;
                                        alpha[z - 97] = y;
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
                                else
                                {
                                    tmp = tmp + (char)VariableStringAnalyser[x + 1];
                                }
                            }
                            else
                            {
                                tmp = tmp + (char)(z);

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
                    tmp = tmp + (char)VariableStringAnalyser[x];
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
                            tmp = tmp + (char)(VariableStringAnalyser[x + 1] - 32) + (char)0x20;
                        }

                    }
                    else
                    {
                        blanc = false;
                    }
                    tmp = tmp + (VariableStringAnalyser[x]);

                    //
                }
            }
            Console.WriteLine($"\n\nSource={VariableStringAnalyser}");
            for (int x = 0; x < 26; x++)
            {
                Console.WriteLine($"{(char)(x + 97)} {alpha[x]} occurances");

            }
            Console.WriteLine($"Resultat={tmp}");
        }

    }
}
