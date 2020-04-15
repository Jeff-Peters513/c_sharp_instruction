using System;

namespace ch4_control_structure {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Control Structures App");


            //command menu
            string command = "";
            Console.WriteLine("Command Menu:");
            Console.WriteLine("list - list all");
            Console.WriteLine("add - add an item");
            Console.WriteLine("exit - exit loop");

            while (!command.Contains("exit")) {
                Console.WriteLine("Enter a commad: ");
                switch (command) {
                    case "list":
                    case "List":
                    case "LIST":
                        Console.WriteLine("list selected");
                        break;
                    case "add":
                        Console.WriteLine("add selected");
                        break;
                    case "exit":
                        Console.WriteLine("exit selected");
                        break;
                    default:
                        Console.WriteLine("invalid option");
                        break;
                }
                Console.WriteLine("Bye");

                string[] names = { "Sarah", "Sam", "Tyler", "Jacob" };
                // in Java: for (type t : collection
                foreach (string name in names) {
                    Console.WriteLine(name);
                }

                Console.WriteLine("for loop");
                for (int i = 0; i < names.Length; i++) {
                    Console.WriteLine(names[i]);

                }
            }
        }
    }
}
