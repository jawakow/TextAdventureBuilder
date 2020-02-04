using System;
using System.Collections.Generic;

namespace TextAdventureV2
{
	public class Player : Character
	{
		public string weapon;
		public string health;
		public int roomId;
		Inventory inventory;
		public List<int> location;

		public Player ()
		{
		}
		
		// return 1 if movement successful, otherwise return 0			
		public int Move(string direction, Room room)
		{
	
			if (direction == "N" || direction == "North" && room.isNorthAccessible)
				{
				this.roomId = room.northDoorRoomId;
				Console.WriteLine("You move north into {0}", room.name);
				return 1;
			}

			if (direction == "S" || direction == "South" && room.isSouthAccessible)
				{
				this.roomId = room.southDoorRoomId;
				Console.WriteLine("You move south into {0}", room.name);
				return 1;
			}

			if (direction == "W" || direction == "West" && room.isWestAccessible)
				{
				this.roomId = room.westDoorRoomId;
				Console.WriteLine("You move west into {0}", room.name);
				return 1;
			}

			if (direction == "E" || direction == "East" && room.isEastAccessible)
				{
				this.roomId = room.eastDoorRoomId;
				Console.WriteLine("You move east into {0}", room.name);
				return 1;
			}

			return 0;

		}
	}
}

