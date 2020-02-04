using System;
using System.Collections.Generic;

namespace TextAdventureBuilder
{
	public class Inventory
	{
		string name;
		List<Item> inventory;

		public Inventory ()
		{ 
		}

		public void AddToInventory(Item item)
		{
			inventory.Add(item);
		}

		public void SelectInventoryItem()
		{
		}
	}
}

