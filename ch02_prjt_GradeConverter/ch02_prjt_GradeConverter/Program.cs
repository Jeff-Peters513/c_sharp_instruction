using System;

namespace ch02_prjt_GradeConverter {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Letter Grade Converter");
            Console.WriteLine();
            String choice = "y";
            int numericGrade = 0;
            while (choice.Contains("y")) {
                Console.Write("Enter numerical grade: ");
                //numericGrade = Convert.ToInt32(Console.ReadLine());
                numericGrade = int.Parse(Console.ReadLine());
                string letterGrade;
                //Console.WriteLine("number grade entered: " + numericGrade);
                if (numericGrade >= 88) {
                    letterGrade = "A";
                } else if (numericGrade >= 80) {
                    letterGrade = "B";
                } else if (numericGrade >= 67) {
                    letterGrade = "C";
                } else if (numericGrade >= 60) {
                    letterGrade = "D";
                } else
                    letterGrade = "F";
                // display out put
                Console.WriteLine("Letter Grade: " + letterGrade);
                Console.WriteLine();
                Console.Write("Continue? ");
                choice = Console.ReadLine();
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Bye");
        }
    }
}
            
     

