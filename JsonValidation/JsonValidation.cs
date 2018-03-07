using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsonTests;

namespace JsonValidation
{
    public static class JsonValidation
    {
        public static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please insert a text to be evaluated");
                Console.ReadKey();
                return;
            }
            var x = new Json();
            args[0] = System.IO.File.ReadAllText(@"C:\Users\Radu\Documents\GitHub\JuniorMind\JsonValidation\FirstJsonText.txt");
            var (match, remaining) = x.Match(args[0]);
            if (match.Success && remaining == "")
            {
                Console.WriteLine("Text is correct");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Text is incorrect");
            Console.ReadKey();

        }
    }
}
