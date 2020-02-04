using System;

namespace TextAdventureBuilder
{
	public class Room : Entity
	{
        string Id;
        string northDoorRoomId;
        string southDoorRoomId;
        string eastDoorRoomId;
        string westDoorRoomId;
        string isNorthAccessible;
        string isSouthAccessible;
        string isEastAccessible;
        string isWestAccessible;
        string[] contents;
        bool isDark;

        public Room ()
		{
		}
        
	}
}

