using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace TextAdventureV2
{
    public class Room : Entity
	{
        public int Id;

        public int northDoorRoomId;
        public int southDoorRoomId;
        public int eastDoorRoomId;
        public int westDoorRoomId;

        public bool isNorthAccessible = false;
        public bool isSouthAccessible = false;
        public bool isEastAccessible = false;
        public bool isWestAccessible = false;

        public bool isDark;
        public Item[] contents;

        public Room ()
		{
            
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

