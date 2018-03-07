using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsonTests;

namespace JsonValidation
{
    class JsonValidation
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please insert a text to be evaluated");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
            }
            var x = new Json();
            var (match, remaining) = x.Match(args[0].ToString());
            if (match.Success && remaining == "")
            {
                Console.WriteLine("Text is correct");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
            }
            Console.WriteLine("Text is incorrect");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
