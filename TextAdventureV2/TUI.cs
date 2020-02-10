using System;

namespace TextAdventureV2
{

	public class TUI
	{
		public string playerName;

		public TUI()
		{
		}

		public void Run()
		{
			Console.Clear();
			Console.WriteLine("Please enter your name");
			playerName = Console.ReadLine();
		}
	}
}