using System;
using System.Collections.Generic;
using System.Text;

namespace ch12_Wizard_Inventory {
    class Jconsole {
        // this class is to mimic Java's Console class with standard prompts and data validation etc..

        public static String GetString(String prompt, bool) {
            return GetString(prompt, false);
        }

        public static int GetInt(string prompt) {
            int nbr = 0;
            bool success = false;
            while (!success) {
                // prompt the user for input
                Console.Write(prompt);
                try {
                    // accept the input as a string
                    string nbrStr = Console.ReadLine();
                    // convert that string to an int
                    nbr = int.Parse(nbrStr);
                    success = true;
                } catch (Exception e) {
                    Console.WriteLine("Invalid # value.");
                    //Console.WriteLine(e.StackTrace);
                }
            }
            return nbr;
        }



    }
}
