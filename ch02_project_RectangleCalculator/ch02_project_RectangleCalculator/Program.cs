using System;

namespace ch02_project_RectangleCalculator {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Area and Perimeter Calculator");
            Console.WriteLine();

            String choice = "y";
            while (choice.Contains("y")) {
                Console.Write("Enter Length:  ");
                double length = double.Parse(Console.ReadLine());
                Console.Write("Enter Width:  ");
                double width = double.Parse(Console.ReadLine());
                double area = width * length;
                double perimeter = 2.0 * width + 2.0 * length;
                Console.WriteLine();
                Console.WriteLine("Area:           " + area);
                Console.WriteLine("Perimeter:      " + perimeter);
                Console.WriteLine();
                Console.Write("Continue? (y/n): ");
                choice = Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("Bye");
        }
    }
}
