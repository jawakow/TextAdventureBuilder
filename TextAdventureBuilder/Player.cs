using System;
using System.Collections.Generic;

namespace TextAdventureBuilder
{
	public class Player : Character
	{
		public string weapon;
		public string health;
		public int roomId;
		public Inventory inventory;
		public List<int> location;

		public Player ()
		{

		}
		
		// return 1 if movement successful, otherwise return 0			
		public int Move(string direction, Room room)
		{
	
			if (direction = "N" && room.isNorthAccessible)
				{
				this.roomId = room.northDoorRoomId;
				return 1;
			}

			if (direction = "S" && room.isSouthAccessible)
				{
				this.roomId = room.southDoorRoomId;
				return 1;
			}

			if (direction = "W" && room.isWestAccessible)
				{
				this.roomId = room.westDoorRoomId;
				return 1;
			}

			if (direction = "E" && room.isEastAccessible)
				{
				this.roomId = room.eastDoorRoomId;
				return 1;
			}

			return 0;

		}
	}
}

