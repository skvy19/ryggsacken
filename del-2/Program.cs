using System;
using System.Collections.Generic;

namespace del_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string input;
            var items = new List<string>();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nVälkommen till ryggsäcken!\n");
            Console.ResetColor();

            while(true) {

                Console.WriteLine("*****************************************");
                Console.WriteLine("[1] Lägg till ett föremål\n[2] Skriv ut innehållet\n[3] Ta bort senaste objektet\n[4] Avsluta");
                Console.WriteLine("*****************************************");
                Console.Write("Välj: ");
                input = Console.ReadLine();

                    switch(input) {
                        case "1":
                            if (items.Count <= 6) {
                                Console.Clear();
                                Console.WriteLine("Vad vill du lägga till?: ");
                                input = Console.ReadLine();
                                items.Add(input);
                                Console.Clear();
                            } else {
                                Console.Clear();
                                Console.WriteLine("Din ryggsäck är full!\n");
                            }
                            break; 
                        case "2":
                            if(items.Count > 0) {
                                Console.Clear();
                                Console.WriteLine("Detta har du i din ryggsäck: ");
                                foreach(var n in items) Console.WriteLine(" - " + n);
                                Console.WriteLine();
                            } else {
                                Console.Clear();
                                Console.WriteLine("Din ryggsäck är tom!\n");
                            }
                            break; 
                        case "3":
                            if(items.Count > 0) {
                                Console.Clear();
                                var lastIndex = items[items.Count -1].ToUpper();
                                Console.WriteLine("{0} har tagits bort från din ryggsäck!\n", lastIndex);
                                items.RemoveAt(items.Count - 1);
                            } else {
                                Console.Clear();
                                Console.WriteLine("Din ryggsäck är tom!\n");
                            }
                            break; 
                        case "4":
                            return; 
                        default:
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ogilltigt val!\n");
                            Console.ResetColor();
                            continue;
                    }
                        

            }

        }
    }
}
