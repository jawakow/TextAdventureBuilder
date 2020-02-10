using System;
using System.Collections.Generic;

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
        public Item[] contents;

        public Room ()
		{
            push
		}

        public List<string> SearchRoom()
        {
            List<string> roomContents = new List<string>();
            string itemName;
            foreach (Item item in contents)
            {
                itemName = item.name + "/n";
                roomContents.Add(itemName);
            }

            return roomContents;
        }

    }
}

