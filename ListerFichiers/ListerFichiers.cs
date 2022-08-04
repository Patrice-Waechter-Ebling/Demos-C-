using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;


namespace ListerFichiers
{
    class ListerFichiers
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
             string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
             var dirnames = Directory.GetDirectories(Directory.GetCurrentDirectory());
             Console.WriteLine(Directory.GetCurrentDirectory());
            int i = 0;

            try
            {
                foreach (var dir in dirnames)
                {
                    var fnames = Directory.GetFiles(dir);

                    DirectoryInfo d = new DirectoryInfo(dir);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write(dir);
                    FileInfo[] finfo = d.GetFiles("*.*");
                    Console.WriteLine(" modification le : {0} ", File.GetLastWriteTime(dir));

                    foreach (var f in fnames)
                    {
                        i++;
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("Index "+ i);
                        Console.Write(Path.Combine(dir, f));
                            Console.WriteLine(" modification le : {0} ", File.GetLastWriteTime(dir));
  /*                      foreach (FileInfo fi in finfo)
                        {
                        }**/
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}
