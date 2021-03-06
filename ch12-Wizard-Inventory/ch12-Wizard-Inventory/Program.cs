﻿using System;
using System.Collections.Generic;

namespace ch12_Wizard_Inventory {
    class Program {
		//private static object inventory;
            static List<string> inventory = new List<string>();

		static void Main(string[] args) {
            Console.WriteLine("The Wizard Inventory Game");
            Console.WriteLine();

            // initialize a List
            //add the first 3 items into inventory
            inventory.Add("wooden shoes");
            inventory.Add("wizard hat");
            inventory.Add("cloth shoes");

			string command = "";
			// Start loop
			while (!command.Contains("exit")) {
				// display menu
				DisplayMenu();

				// prompt and collect user input
				//command = Jconsole.GetString("Command: ");
				Console.Write("Command: ");
				command = Console.ReadLine();
				
				// business logic - going have to display in loop
				switch (command) {
					case "show":
						// show current inventory
						ShowItems();
						break;
					case "grab":
						// add to current inventory add
						AddItem();
						break;
					case "edit":
						// edit name of current inventory item
						EditItem();
						break;
					case "drop":
						// drop an item from inventory remove(object)
						DropItem();
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

		private static string FindItemByNumber() {
			string item = null;
			while (item == null) {
				Console.Write("Item Number: ");
				int itemNbr = 0;
				try {
					itemNbr = int.Parse(Console.ReadLine());

				} catch (Exception e) {
					Console.WriteLine("Invalid number.");
					Console.Write(e);
					continue;
				}
				item = inventory[itemNbr-1];
					}
			
			return item;
		}

		private static void DropItem() {
			//delete item from inventory
			string item = FindItemByNumber();
			inventory.Remove(item);
			Console.WriteLine(item + " removed.\n");
		
		}



		private static void EditItem() {
			string item = FindItemByNumber();
			int idx = inventory.IndexOf(item);
			Console.Write("Updated Name: ");
			string updItem = Console.ReadLine();
			//edit item
			inventory[idx] = updItem;
			Console.WriteLine(item+" was updated to " + updItem);

		}		   			 
			
			
			private static void AddItem() {
			// add items per user to inventory
			// max inventory is 4 items
			if (inventory.Count >= 4) {
				Console.WriteLine("Cannot grab an item. Max limit (4) reached.");
			} else {
				Console.WriteLine("Name: ");
				string itemName = Console.ReadLine();
				inventory.Add(itemName);
				Console.WriteLine(itemName + " was added.");
			}
		}

		private static void ShowItems() {
			// display inventory of items
			for (int i = 0; i < inventory.Count; i++) {
				// inventory position will be 1 more than array index number
				int itemNbr = i + 1;
				Console.WriteLine(itemNbr + ". " + inventory[i]);
			}
		}

		private static void DisplayMenu() {
			System.Text.StringBuilder menu = new System.Text.StringBuilder("COMMAND MENU\n");
			menu.Append("show - Show all Items\n");
			menu.Append("grab - Grab (Add) an Item\n");
			menu.Append("edit - Edit an Item\n");
			menu.Append("drop - Drop (Delete) an Item\n");
			menu.Append("Exit - Exit program\n");
			Console.WriteLine(menu);
			Console.WriteLine();

		}

	}

}
    

