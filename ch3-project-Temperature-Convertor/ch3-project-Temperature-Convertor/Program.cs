using System;

namespace ch3_project_Temperature_Convertor {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Temperature Converter");
            Console.WriteLine();

            string choice = "y";
            double tempF;
            double tempC;
            while (choice.Contains("y")) {
                Console.Write("Enter degrees in Fahrenheit: ");
                tempF = double.Parse(Console.ReadLine());

                tempC = (tempF - 32) * 5 / 9;

                Console.WriteLine("Degrees in Celsius: " + tempC);

                Console.WriteLine();
                Console.Write("Continue? (y/n): ");
                choice = Console.ReadLine();
                Console.WriteLine();


            }
            Console.WriteLine("Bye");
        }
    }
}
