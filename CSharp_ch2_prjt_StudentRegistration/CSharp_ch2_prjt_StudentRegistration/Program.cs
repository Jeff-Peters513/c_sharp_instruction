using System;

namespace CSharp_ch2_prjt_StudentRegistration {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Student Registration Form");
            Console.WriteLine();
            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter year of birth: ");
            int birthYear = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Welcome "+firstName+" "+lastName+"!");
            Console.WriteLine("Your registration is complete.");
            Console.WriteLine("Your temporary password is: "+firstName+"*"+birthYear);

        }
    }
}
