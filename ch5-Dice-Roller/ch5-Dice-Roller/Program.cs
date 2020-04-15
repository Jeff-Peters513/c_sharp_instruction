using System;

namespace ch5_Dice_Roller {
    class Program {
        static void Main(string[] args) {
            diplayWelcome();

            int sides1 = 6;
            int sides2 = 6;
          
            String choice = "y";
            int i = 1;
            while (choice.Contains("y")|| choice.Contains("Y")) {
                // get the input from the user
                if (i <= 1) {
                    choice = askToRoll(roll);
                    i++;
                } else if (i > 1) {
                    choice = askToContinue(sc);
                    i++;
                }

                //business logic call random # generator to get two dice #'s
                int die1 = getRandomInt(sides1);
                int die2 = getRandomInt2(sides2);

                // display results etc..
                Console.WriteLine("Dice 1: " + die1 + "\n" +
                        "Dice 2: " + die2 + "\n" +
                        "Total: " + (die1 + die2));

                if (die1 == 1 && die2 == 1) {
                    Console.WriteLine("Snake Eyes!");
                }
                if (die1 == 6 && die2 == 6) {
                    Console.WriteLine("Boxcars!");
                }
                Console.WriteLine();

            
                // Console.WriteLine();
                Console.Write("Roll again? (y/n): ");
                choice = Console.ReadLine();
            }








            Console.WriteLine("Bye");
        }

        private static int getRandomInt2(int sides2) {
            throw new NotImplementedException();
        }

        private static int getRandomInt(int sides1) {
            double d = Math.random() * sides1; // d is >= 0.0 and < limit
            int randomInt = (int)d; // convert double to int
            randomInt++; // int is >= 1 and <= limit
            return randomInt;
        }

        private static void diplayWelcome() {
            Console.WriteLine("Dice Roller");
            Console.WriteLine();
        }

        public static String askToRoll(roll) {
            Console.Write("Roll the Dice? (y/n): ");
            String choice = Console.ReadLine();
            return choice;
        }

        public static String askToContinue(sc) {
           Console.Write("Roll Again? (y/n): ");
            String choice = Console.ReadLine();
            return choice;
        }

    }
}
