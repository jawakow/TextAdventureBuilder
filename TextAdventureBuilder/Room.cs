using System;
using System.Collections.Generic;

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
        Item[] contents;
        bool isDark;

        public Room ()
		{
		}

        public List<string> SearchRoom()
        {
            List<string> roomContents = new List<string>();
            string itemName;
            foreach(Item item in contents)
            {
                itemName = item.name + "/n";
                roomContents.Add(itemName);
            }

            return roomContents;
        }  
	}
}

