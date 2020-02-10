using System;
using System.Collections.Generic;

namespace TextAdventureV2
{
    public class MainActivity
    {
        Adventure adventure = new Adventure();
        public MainActivity(Adventure adventure)
        {
            this.adventure = adventure;
            // Console.WriteLine("Hello there");
            CheckCompletion();
        }

        public void CheckCompletion()
        {
            while (adventure.isCompleted == false)
            {
                GetInput();
            }
        }

        public void SearchRoom()
        {
            Room room = adventure.rooms[adventure.pc.roomId];
            var itemList = room.SearchRoom();
            foreach (string item in itemList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("You search the room");
            CheckCompletion();
        }

        public void GetInput()
        {
            string input = Console.ReadLine();

            if (input.ToLower() == "search")
            {
                SearchRoom();
            }
            else 
            {
                MovePlayer(input);
            }
        }

        public void MovePlayer(string input)
        {
            Room room = adventure.rooms[adventure.pc.roomId];
            adventure.pc.Move(input, room);
            Console.WriteLine();
        }

        public void TakeItem(string input)
        {
            string command = input;
            Room room = adventure.rooms[adventure.pc.roomId];
            var itemList = room.contents;
            
            foreach (var item in itemList)
            {
                if (item.name == command) 
                {
                    adventure.pc.inventory.AddToInventory(item);
                }
                Console.WriteLine(item);
            }
        }
    }
}


