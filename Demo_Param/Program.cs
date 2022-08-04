using System;

namespace Demo_Param
{
    class Program
    {
        static void Main(string[] args)
        {
            double RayonCercle = 5;
            double SurfaceCalculee=1979;

            Console.Write($"Méthode A - Surface du cercle de rayon {RayonCercle} est : ");
            Console.WriteLine(Math.Round(CalculerSurfaceCercle_A(RayonCercle),2));
            Console.WriteLine("\n-----------\n");
            Console.Write($"Méthode B - Surface du cercle de rayon {RayonCercle} est : ");
            CalculerSurfaceCercle_B(RayonCercle, ref SurfaceCalculee);
            Console.WriteLine(SurfaceCalculee);
            Console.WriteLine("\n-----------\n");


        }

        static void CalculerSurfaceCercle_B(double Rayon, ref double SurfaceCalculee)
        {
            SurfaceCalculee = Rayon * Rayon * Math.PI;
            Console.WriteLine($"\n\n***Dans la méthode : SurfaceCalculee={SurfaceCalculee}***\n");
        }
        static double CalculerSurfaceCercle_A(double Rayon)
        {
            double SurfaceCalculee = Rayon * Rayon * Math.PI;

            return SurfaceCalculee;
        }
    }
}
