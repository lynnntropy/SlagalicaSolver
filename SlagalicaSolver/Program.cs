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

                if (results != null && results.Count > 0)
                {
                    //Console.WriteLine("\nMatches found (up to 10):");
                    //foreach (String result in results)
                    //{
                    //    Console.WriteLine(string.Format(" {0}", result));
                    //}
                }
                else
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
            //string executableDirectory = (new FileInfo(System.Reflection.Assembly.GetEntryAssembly().Location)).Directory.ToString();

            //string manualContents = System.IO.File.ReadAllText(executableDirectory + @"\readme.txt");
            //Console.Write(manualContents);
            //Console.ReadLine();

            Console.WriteLine("\nError: No input.");

            Console.WriteLine("Pass the word jumble as the first argument.");
            Console.WriteLine("Upišite izmešana slova kao prvi parametar.\n");
        }
    }
}
