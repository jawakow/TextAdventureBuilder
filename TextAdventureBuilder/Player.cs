using System;
using System.Collections.Generic;

namespace TextAdventureBuilder
{
	public class Player : Character
	{
		string weapon;
		string health;
		int roomId;
		Inventory inventory;
		List<int> location;

		public Player ()
		{
		}
	}
}

