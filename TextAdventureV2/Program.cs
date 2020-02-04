using System;

namespace TextAdventureV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Adventure adventure = new Adventure();
            MainActivity mainActivity = new MainActivity(adventure);
            mainActivity.CheckCompletion();
        }
    }
}
