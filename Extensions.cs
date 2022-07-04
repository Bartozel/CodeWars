using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    internal static class Extensions
    {
        public static void ConsolePrint(this List<string> words)
        {
            words.ForEach(word => Console.WriteLine(word));
        }
    }
}
