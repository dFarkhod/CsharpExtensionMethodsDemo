using MathLib;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethodsDemo
{
    public static class MathsExtensions
    {
        public static int Substract(this MyMath math, int a, int b)
        {
            return a - b;
        }
    }
}
