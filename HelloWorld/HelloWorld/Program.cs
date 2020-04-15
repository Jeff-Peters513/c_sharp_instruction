using System;

namespace HelloWorld {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            Console.Write("abc");
            int n1 = 5;
            int n2 = 2;
            int n3;
            Console.WriteLine("sum = " + (n1 + n2));
            var t1 = "Hello";
            // single line comments

            
             

        double d1 = 5.7;
        double d2 = 54.2;
            Console.WriteLine("double sum is " + (d1 + d2));

            Console.WriteLine("Enter a whole number: ");
            int n4 = int.Parse(Console.ReadLine());
            Console.WriteLine("You entered: " + n4);

            String choice = "y";
            while (choice.Contains("y")) {
                Console.WriteLine("In the loop..");
                Console.WriteLine("continue?");
                choice = Console.ReadLine();
            }
            

            

        }
    }
}
