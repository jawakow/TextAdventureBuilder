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
            Console.WriteLine("Hello there");
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
            List<string> itemList;
            ////foreach (string item in itemList)
            ////{
            ////    Console.WriteLine(item);
            ////}
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
        }

        public void MovePlayer()
        {
            adventure.pc.Move(input, )
        }
    }
}
