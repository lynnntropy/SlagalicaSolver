using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlagalicaSolver
{
    class Slagalica
    {
        string input;

        string[] wordlist;


        public Slagalica(string input)
        {
            this.input = input;
        }

        public List<String> Solve()
        {
            Console.WriteLine();

            List<String> output = new List<string>();            
            
            LoadWordlist();
            SortWordlistByLength();

            foreach (String word in wordlist)
            {
                if (output.Count < 10)
                {
                    if (word.Length <= input.Length)
                    {
                        string lowercase = word.ToLower();

                        Console.Write("Trying word {0}... ", lowercase);

                        foreach(char character in input)
                        {
                            //lowercase = lowercase.Replace(character.ToString(), "");

                            if (lowercase.Contains(character))
                            {
                                int index = lowercase.IndexOf(character);
                                lowercase = lowercase.Remove(index, 1);
                            }
                        }

                        Console.Write("Leftover: [{0}]", lowercase);

                        if (lowercase.Length == 0)
                        {
                            Console.Write(" (match!)");
                            // Word is a match!
                            output.Add(word.ToLower());
                        }
                        else
                        {
                            Console.Write(" (no match)");
                        }

                        Console.WriteLine();
                    }
                }
                else
                {
                    break;
                }
            }
            
            return output;
        }

        private void LoadWordlist()
        {
            Console.WriteLine();

            string executableDirectory = (new FileInfo(System.Reflection.Assembly.GetEntryAssembly().Location)).Directory.ToString();

            Console.Write("Searching for wordlist... ");
            string[] filesFound = System.IO.Directory.GetFiles(executableDirectory + @"\wordlist");
            Console.Write(filesFound.Length > 0 ? "Wordlist found." : "No files in /wordlist folder.");
            Console.WriteLine();

            Console.WriteLine("Loading wordlist {0} into memory...", Path.GetFileName(filesFound[0]));
            this.wordlist = File.ReadAllLines(filesFound[0]);
            Console.WriteLine("Wordlist loaded, {0} words in memory.", wordlist.Length);
        }

        private void SortWordlistByLength()
        {
            Console.WriteLine();

            Console.Write("Sorting word list... ");
            Array.Sort(this.wordlist, (x, y) => x.Length.CompareTo(y.Length) * -1);
            Console.Write("Done.\n");

            Console.WriteLine("First word is {0}.", wordlist[0]);
        }
    }
}
