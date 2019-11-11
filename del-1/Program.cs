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
                Console.WriteLine("[1] Lägg till ett föremål\n[2] Skriv ut innehållet\n[3] Rensa innehållet\n[4] Avsluta");
                Console.WriteLine("*****************************************");
                Console.Write("Välj: ");
                input = Console.ReadLine();

                    switch(input) {
                        case "1":
                            Console.Clear();
                            Console.WriteLine("Vad vill du lägga till?: ");
                            input = Console.ReadLine();
                            items.Add(input);
                            Console.Clear();
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
                            items.Clear();
                            Console.Clear();
                            Console.WriteLine("Din ryggsäck är tömd!\n");
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
