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

                if (args[0] == "slagalica")
                {
                    Slagalica slagalica = new Slagalica(args[1]);
                    List<String> results = slagalica.Solve();

                    if (results != null && results.Count > 0)
                    {
                        Console.WriteLine("\nMatches found (up to 10):");
                        foreach (String result in results)
                        {
                            Console.WriteLine(string.Format(" {0}", result));
                        }
                    }
                    else
                    {
                        Console.WriteLine("No matches found.");
                    }
                }
                else if (args[1] == "mojbroj")
                {

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
            string executableDirectory = (new FileInfo(System.Reflection.Assembly.GetEntryAssembly().Location)).Directory.ToString();

            string manualContents = System.IO.File.ReadAllText(executableDirectory + @"\readme.txt");
            Console.Write(manualContents);
            //Console.ReadLine();
        }
    }
}
