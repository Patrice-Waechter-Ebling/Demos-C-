using System;

namespace ConsoleTypesVariables
{
    class Program
    {

        static void Main(string[] args)  {
            Console.Title = "Bienvenue au cours d AEC";
              Console.ForegroundColor = ConsoleColor.Cyan | ConsoleColor.DarkGray;
            Console.WriteLine("Int Minimal:" +int.MinValue + " : "+int.MinValue.GetType());
            Console.WriteLine("Int Maximal:" + int.MaxValue + " : " + int.MinValue.GetType());
            Console.WriteLine("Int16 Minimal:" + Int16.MinValue + " : " + Int16.MinValue.GetType());
            Console.WriteLine("Int16 Maximal:" + Int16.MaxValue + " : " + Int16.MinValue.GetType());
            Console.WriteLine("Int32 Minimal:" + Int32.MinValue + " : " + Int32.MinValue.GetType());
            Console.WriteLine("Int32 Maximal:" + Int32.MaxValue + " : " + Int32.MinValue.GetType());
            Console.WriteLine("Int64 Minimal:" + Int64.MinValue + " : " + Int64.MinValue.GetType());
            Console.WriteLine("Int64 Maximal:" + Int64.MaxValue + " : " + Int64.MinValue.GetType());
            Console.WriteLine("Int non signe Minimal:" + uint.MinValue + " : " + uint.MinValue.GetType());
            Console.WriteLine("Int non signe Maximal:" + uint.MaxValue + " : " + uint.MinValue.GetType());
            Console.WriteLine("Int16 non signe Minimal:" + UInt16.MinValue + " : " + Int16.MinValue.GetType());
            Console.WriteLine("Int16 non signe Maximal:" + UInt16.MaxValue + " : " + Int16.MinValue.GetType());
            Console.WriteLine("Int32 non signe Minimal:" + UInt32.MinValue + " : " + Int32.MinValue.GetType());
            Console.WriteLine("Int32 non signe Minimal:" + UInt32.MaxValue + " : " + Int32.MinValue.GetType());
            Console.WriteLine("Int364 non signe Minimal:" + UInt64.MinValue + " : " + Int64.MinValue.GetType());
            Console.WriteLine("Int64 non signe Maximal:" + UInt64.MaxValue + " : " + Int64.MinValue.GetType());
            Console.WriteLine("Double Minimal:" + double.MinValue + " : " + double.MinValue.GetType());
            Console.WriteLine("Double  Maximal:" + double.MaxValue + " : " + double.MinValue.GetType());
            Console.WriteLine("Decimal Minimal:" + decimal.MinValue + " : " + decimal.MinValue.GetType());
            Console.WriteLine("Decimal Maximal:" + decimal.MaxValue + " : " + decimal.MinValue.GetType());
        }
    }
}
