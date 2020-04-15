using System;

namespace ch5_Methods {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Write some Methods");
            int nbr = GetInt("Enter a whole number:  ");

            Console.WriteLine("Number entered: " + nbr);


            Console.WriteLine("Sum 3 numbers = " + sum(1, 2, 3));
            Console.WriteLine("Sum 2 numbers = " + sum(1, 2));



        }




        private static int GetInt(string prompt) {

            //prompt user for input 
            Console.Write(prompt);
            //accept the input as a string
            string nbrStr = Console.ReadLine();
            //convert that string to an int
            int nbr = int.Parse(nbrStr);
            return nbr;
        }

        private static int sum(int n1, int n2, int n3=0)  {
            int sum = n1 + n2 + n3;
            return sum;



        }




    }
}
