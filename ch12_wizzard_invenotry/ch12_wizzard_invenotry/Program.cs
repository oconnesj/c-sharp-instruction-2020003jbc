using System;
using System.Collections.Generic;

namespace ch12_wizzard_invenotry
{
    class MainClass
    {
       static List<string> items = new List<string>();


        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Wizard Invenotry!\n");
            items.Add("wooden staff");
            items.Add("wizzard hat");
            items.Add("cloth shoes");

            DisplayMenu();
            string command = "";
            while (!command.Contains("exit"))
            {
                DisplayMenu();
                Console.Write("Command: ");
                command = Console.ReadLine();
                switch (command) { 
                
                    case "show":
                        ShowItems();
                        break;
                    case "grab":
                        Grabtems();
                        break;
                    case "edit":
                        EditItems();
                        break;
                    case "drop":
                        DropItems();
                        break;
                    default:
                        Console.WriteLine("Invalid command.");
                        break;
                }
                Console.WriteLine();

            }


            Console.WriteLine("Bye");
        }

        private static string FindItemByNumber()
        {
            string item = null;
            while(item == null)
            {
                Console.Write("Item Number: ");
                int itemNbr = 0;
                try
                {
                   itemNbr = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("invlaid number.");
                    continue;
                }
                item = items[itemNbr - 1];
                     
            }


            return item;

        }

        private static void DropItems()
        {
            //promp for item to drop
            // prompt the item
            string item = FindItemByNumber();
            items.Remove(item);
            Console.WriteLine(item + " removed.\n");
        }

        private static void EditItems()
        {
            // prompt for item to edit
            // edit the item
            string item = FindItemByNumber();
            int idx = items.IndexOf(item);
            Console.Write("Updated nam: ");
            string updItem = Console.ReadLine();
            items[idx] = updItem;
            Console.WriteLine();
        }

        private static void ShowItems()
        {
            Console.WriteLine("List of items: ");
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine((i + 1) + "." + items[i]);
            }
            Console.WriteLine();
        }

        private static void Grabtems()
        {
            Console.WriteLine("Grab/Add an item:");
            if (items.Count >= 4)
            {
                Console.WriteLine("Cannot add more times. Please drop an item first.");
            }
            else
            {
                Console.Write("Item Name:  ");
                string name = Console.ReadLine();
                items.Add(name);

            }
            Console.WriteLine();
        }

        static void DisplayMenu()
        {
            Console.WriteLine("COMMAND MENU:");
            Console.WriteLine("=============");
            Console.WriteLine("show - list all items:");
            Console.WriteLine("grab - Grab/add an item:");
            Console.WriteLine("edit - edit an item");
            Console.WriteLine("drop - remove an item");
            Console.WriteLine("exit - exit the app");
            Console.WriteLine();






        }

    }
}
