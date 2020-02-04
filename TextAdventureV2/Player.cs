using System;
using System.Collections.Generic;

namespace TextAdventureV2
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
		
		// return 1 if movement successful, otherwise return 0			
		public int Move(string direction, Room room)
		{
	
			if (direction == "N" || direction == "North" && room.isNorthAccessible)
				{
				this.roomId = room.northDoorRoomId;
				return 1;
			}

			if (direction == "S" || direction == "South" && room.isSouthAccessible)
				{
				this.roomId = room.southDoorRoomId;
				return 1;
			}

			if (direction == "W" || direction == "West" && room.isWestAccessible)
				{
				this.roomId = room.westDoorRoomId;
				return 1;
			}

			if (direction == "E" || direction == "East" && room.isEastAccessible)
				{
				this.roomId = room.eastDoorRoomId;
				return 1;
			}

			return 0;

		}
	}
}

