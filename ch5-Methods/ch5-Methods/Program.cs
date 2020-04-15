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
            int nbr;
            bool success = false;
            while (!success) {
                //prompt user for input 
                Console.Write(prompt);
                try {
                    //accept the input as a string
                    string nbrStr = Console.ReadLine();
                    //convert that string to an int
                    nbr = int.Parse(nbrStr);
                    success = true;
                } catch (Exception e) {
                    Console.WriteLine("Invalid # value");
                    // Console.WriteLine(e.StackTrace);

                    throw;
                }

                return nbr;
            }
        } 

        private static int sum(int n1, int n2, int n3=0)  {
            int sum = n1 + n2 + n3;
            return sum;



        }

        


    }
}
