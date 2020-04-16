using System;
using System.Collections.Generic;

namespace ch12_Wizard_Inventory {
    class Program {
		private static object inventory;

		static void Main(string[] args) {
            Console.WriteLine("The Wizard Inventory Game");
            Console.WriteLine();

            // initialize a List
            List<string> inventory = new List<string>();
            //add the first 3 items into inventory
            inventory.Add("wooden shoes");
            inventory.Add("wizard hat");
            inventory.Add("cloth shoes");

			String command = "";
			// Start loop
			while (!command.Contains("exit")) {
				// display menu
				displayMenu();

				// prompt and collect user input
				command = Jconsole.GetString("Command: ", true);

				// business logic - going have to display in loop
				switch (command) {
					case "show":
						// show current inventory
						showItems();
						break;
					case "grab":
						// add to current inventory add
						addItem();
						break;
					case "edit":
						// edit name of current inventory item
						editItem();
						break;
					case "drop":
						// drop an item from inventory remove(object)
						dropItem();
						break;
					case "exit":
						// exit and end game
						break;
					default:
						Console.WriteLine("Invalid entry. Try Again.");
						break;
				}
				Console.WriteLine();
				// end loop
			}
			// Bye
			Console.Write("\nBye!");

		} // end static main

		private static void dropItem() {
			//delete item from inventory
			int itemNumber = Jconsole.GetInt("Number: ", 0, inventory.size() + 1);
			String droppedItem = inventory.remove(itemNumber - 1);
			Console.WriteLine(droppedItem + " was dropped.");
		}

		private static void editItem() {
			// edit / update/ change name of item
			int itemNumber = Jconsole.GetInt("Number: ", 0, inventory.size() + 1);
			String updatedName = Jconsole.GetString("Updated Name: ", true);
			inventory.Remove(itemNumber - 1);
			inventory.Add(itemNumber - 1, updatedName);
			Console.WriteLine("Item number " + itemNumber + " was updated.");
		}

		private static void addItem() {
			// add items per user to inventory
			// max inventory is 4 items
			if (inventory.size() >= 4) {
				Console.WriteLine("Cannot grab an item. Max limit (4) reached.");
			} else {
				string itemName = Jconsole.GetString("Name: ", true);
				inventory.add(itemName);
				Console.WriteLine(itemName + " was added.");
			}
		}

		private static void showItems() {
			// display inventory of items
			for (int i = 0; i < inventory.size(); i++) {
				// inventory position will be 1 more than array index number
				int itemNbr = i + 1;
				Console.WriteLine(itemNbr + ". " + inventory.get(i));
			}
		}

		private static void displayMenu() {
			System.Text.StringBuilder menu = new System.Text.StringBuilder("COMMAND MENU\n");
			menu.Append("show - Show all Items\n");
			menu.Append("grab - Grab (Add) an Item\n");
			menu.Append("edit - Edit an Item\n");
			menu.Append("drop - Drop (Delete) an Item\n");
			menu.Append("Exit - Exit program\n");
			Console.WriteLine(menu);
		}

	}

}
    }
}
