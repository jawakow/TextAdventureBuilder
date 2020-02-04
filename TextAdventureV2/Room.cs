using System;

namespace TextAdventureV2
{
	public class Room : Entity
	{
        public int Id;
        public int northDoorRoomId;
        public int southDoorRoomId;
        public int eastDoorRoomId;
        public int westDoorRoomId;
        public bool isNorthAccessible;
        public bool isSouthAccessible;
        public bool isEastAccessible;
        public bool isWestAccessible;
        public bool isDark;

        public Room ()
		{
		}
        
	}
}

