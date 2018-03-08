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
            var inputText = System.IO.File.ReadAllText(args[0]);
            var (match, remaining) = x.Match(inputText);
            if (match.Success )
            {
                Console.Write("Text is correct");
                Console.ReadKey();
                return;
            }
            Console.Write("Text is incorrect");
            Console.ReadKey();

        }
    }
}
