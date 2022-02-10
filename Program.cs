using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PG2;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int year = Input.ReadInteger("Year:", 1908, 2021);
            //Console.WriteLine(year);
            //Console.ReadKey();
            //
            //string make = string.Empty; 
            //Input.ReadString("Make: ", ref make); 
            //
            //string model = string.Empty;


            Input.GetSpeech();
            string[] delims = new string[] { " ", ".", ",", ": ", "—", "-", "\n", "\r", "\t", "?", "!" };
            string Speech = Input.GetSpeech();
            string[] Newspeech = Speech.Split(delims, StringSplitOptions.RemoveEmptyEntries);

            List<string> WordList = Newspeech.ToList();

            int menuChoice = 0;
            string[] mainMenu = new string[] { $"1. The Speech", "2. List of Words", "3. Show Histogram", "4. Search for Word", "5. Remove Word", "6. Exit" };
            bool looptest = true;

            Dictionary<string, int> Wordsearch = new Dictionary<string, int>();
            
            
                int Counter = 0;
                                           

                foreach (string c in WordList)
                {
                    if (Wordsearch.ContainsKey(c))
                    {
                       int value = Wordsearch[c];
                       value++;
                       Counter++;
                       Wordsearch[c] = value;
            
                    }
                   else
                   {
                       
                       Wordsearch.Add(c, 1);
            
                   }
                }
            
               for (int i = 0; i < Wordsearch.Count(); i++)
               {
                   Console.WriteLine($"0 is displayed {Counter} times");
               }
               
            

            while (looptest)
            {
                Input.ReadChoice("Pick an option, then press 'Enter'. ", mainMenu, out menuChoice);

                switch (menuChoice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine(Input.GetSpeech());
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Press any key to go back to Menu...");
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        for (int i = 0; i < WordList.Count; i++)
                        {
                            Console.WriteLine(WordList[i]);
                        }
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Press any key to continue...");
                        Console.ResetColor();
                        Console.ReadKey();
                        break;
                    case 3:
                        //code
                        break;
                    case 4:
                        //code
                        break;
                    case 5:
                        //code
                        break;
                    case 6:
                        looptest = false;
                        break;

                }

            }

        }        
    }
 
}
