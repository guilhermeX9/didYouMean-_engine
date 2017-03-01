using System;
using System.Collections.Generic;
using System.Text;
 
namespace Did_You_Mean
{
    class Program
    {
        static void Main(string[] args)
        {
            clsDidYouMean check = new clsDidYouMean();
            string[] banco = { "quexo", "pexe", "preto" };
            string input = Console.ReadLine();
            Console.WriteLine("Did You Mean: " + check.DidYouMean(input, banco));
 
            Console.ReadKey();
        }
    }
}
