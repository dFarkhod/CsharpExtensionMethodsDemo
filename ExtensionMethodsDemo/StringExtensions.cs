using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ExtensionMethodsDemo
{
    public static class StringExtension
    {
        public static string TrimAndReduce(this string str)
        {
            return Regex.Replace(str, @"\s+", " ");
        }
    }
}
