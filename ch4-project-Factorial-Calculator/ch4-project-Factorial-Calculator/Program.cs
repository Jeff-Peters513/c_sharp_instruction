using System;

namespace ch4_project_Factorial_Calculator {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Factorial Calculator");
            Console.WriteLine();

            int nmbr;
           
            String choice = "y";
            while (choice.Contains("y") || choice.Contains("Y")) {
                long factorial = 1;
                Console.WriteLine();
                Console.Write("Enter an integer that's greater than 0 and less than 10: ");
                nmbr = int.Parse(Console.ReadLine());
                for (int i = 1; i <= nmbr; i++) {
                    factorial *= i;
                    //Console.WriteLine(factorial);
                   }

                Console.WriteLine("The Factorial of " + nmbr + " is " + factorial);
                Console.WriteLine();


                Console.Write("Continue? (y/n): ");
                choice = Console.ReadLine();

            }
            Console.WriteLine();
            Console.WriteLine("Bye!");
            Console.WriteLine();
        }
    }
}
