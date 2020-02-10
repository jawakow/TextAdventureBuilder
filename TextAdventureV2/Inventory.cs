using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace TextAdventureV2
{
	[Serializable]
	public class Inventory
	{
		[XmlElement("name")]
		string name;
		[XmlElement("inventory")]
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

