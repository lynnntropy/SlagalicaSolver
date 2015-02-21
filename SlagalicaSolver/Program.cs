#define DEBUG_LOGGING

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlagalicaSolver
{
    class Program
    {
        static void Main(string[] args)
        {            
            if (args.Length > 0)
            {
                // Arguments passed.

                Slagalica slagalica = new Slagalica(args[0]);
                List<String> results = slagalica.Solve();
                
                if (results == null || results.Count == 0)
                {
                    Console.WriteLine("No matches found.");
                }
            }
            else
            {
                // print manpage.
                PrintManPage();
            }

            Console.Read();
        }

        static void PrintManPage()
        {
            Console.WriteLine("\nError: No input.\n");

            Console.WriteLine("Pass the word jumble as the first argument.");
            Console.WriteLine("Upišite izmešana slova kao prvi parametar.\n");
        }
    }
}
