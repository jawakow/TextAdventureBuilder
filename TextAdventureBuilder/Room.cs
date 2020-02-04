using System;

namespace TextAdventureBuilder
{
	public class Room : Entity
	{
        public string Id;
        public string northDoorRoomId;
        public string southDoorRoomId;
        public string eastDoorRoomId;
        public string westDoorRoomId;
        public string isNorthAccessible;
        public string isSouthAccessible;
        public string isEastAccessible;
        public string isWestAccessible;
        public bool isDark;

        public Room ()
		{
		}
        
	}
}

