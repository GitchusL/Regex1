using System;
using System.Text.RegularExpressions;

namespace Regex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string frase = "Encantado de veros 2344 reunidos";
            string patron = "(cans)";

            Regex miRegex = new Regex(patron);
            MatchCollection vale = miRegex.Matches(frase);
            Console.WriteLine(vale.Count >=1? "Se ha encontrado" : "De eso nada");
            Console.WriteLine(miRegex.Matches(frase).Count >= 1 ? "Se ha encontrado" : "De eso nada");
            

        }
    }
}
