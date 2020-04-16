using System;

namespace ch5_Dice_Roller {
    class Program {
        
        static void Main(string[] args) {
            diplayWelcome();

            int sides1 = 1;
            int sides2 = 1;
          
            String choice = "y";
            int i = 1;
            while (choice.Contains("y") || choice.Contains("Y")) {
                // get the input from the user
                if (i <= 1) {
                    choice = askToRoll("Roll the Dice? (y/n): ");
                    i++;
                } else if (i > 1) {
                    choice = askToContinue("Roll Again? (y/n): ");
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

            }
                // Console.WriteLine();
                Console.Write("Roll again? (y/n): ");
                choice = Console.ReadLine();
            

            Console.WriteLine("Bye");
        }


        private static int getRandomInt2(int sides2) {
            Random random = new Random();
            int rand6 = random.Next(6);
            double d = rand6 * sides2; // d is >= 0.0 and < limit
            int randomInt = (int)d; // convert double to int
            randomInt++; // int is >= 1 and <= limit
            return randomInt;
        }

        private static int getRandomInt(int sides1) {
            Random random = new Random();
            int rand6 = random.Next(6);
            double d = rand6 * sides1; // d is >= 0.0 and < limit
            int randomInt = (int)d; // convert double to int
            randomInt++; // int is >= 1 and <= limit
            return randomInt;
        }

        private static void diplayWelcome() {
            Console.WriteLine("Dice Roller");
            Console.WriteLine();
        }

        public static String askToRoll(string prompt) {
            Console.Write(prompt);
            String choice = Console.ReadLine();
            return choice;
        }

        public static String askToContinue(string prompt) {
           Console.Write(prompt);
            String choice = Console.ReadLine();
            return choice;
        }

    }
}
