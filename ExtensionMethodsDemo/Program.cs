using MathLib;
using System;

namespace ExtensionMethodsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1-misol. MyMath klassi uchun yozilgan extension metod:
            MyMath math = new MyMath();
            Console.WriteLine(math.Substract(5,2));

            // 2-misol. String turi uchun yozilgan extension metod:
            string content = @"Assalomu    alaykum.   Virtual  darsga xush  kelibsiz. 
            Siz   bilan Farhod   Dadajonov.";
            Console.WriteLine( content.TrimAndReduce());
            Console.Read();
        }
    }
}
