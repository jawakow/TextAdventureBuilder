using System;

namespace TextAdventureV2
{

	public class TUI
	{
		public string playerName;
		public string playerDescription;
		
		public TUI()
		{
		}

		
		
		public void play()
		{
			this.welcomeScreen();
			this.setStartupPos();
			for (int i=0; i<100; i++)
			{
				if (Console.KeyAvailable)
				{
					var key = Console.ReadKey().Key;
					// Console.WriteLine(key);
					switch (key)
					{
						case ConsoleKey.LeftArrow:
							this.moveToAnotherRoom("W");
							return;
						case ConsoleKey.RightArrow:
							this.moveToAnotherRoom("E");
							return;
						case ConsoleKey.UpArrow:
							this.moveToAnotherRoom("N");
							return;
						case ConsoleKey.DownArrow:
							this.moveToAnotherRoom("S");
							return;
					}
					
					
				}
			}

			

		}
		public void welcomeScreen()
		{
			Console.Clear();
			Console.SetCursorPosition(10, 8);
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("WELCOME");
			Console.SetCursorPosition(10, 10);
			Console.WriteLine("Enter player name");
			Console.SetCursorPosition(10, 11);
			Console.ForegroundColor = ConsoleColor.Yellow;
			playerName = Console.ReadLine();
			Console.SetCursorPosition(10, 11);
			Console.Write("\r" + new string(' ', Console.WindowWidth) + "\r");

			Console.ForegroundColor = ConsoleColor.Red;
			Console.SetCursorPosition(10, 10);
			Console.WriteLine("Enter player description");
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.SetCursorPosition(10, 11);
			playerDescription = Console.ReadLine();
			Console.Clear();
			this.plotPlayerAttributes();
		}

		public void plotScreen()
		{
			for (int y = 4; y < 20; y += 4)
			{
				for (int x = 1; x < 32; x += 4)
				{
					this.plotRoom(x, y);
				}
			}
		}

		public void plotPlayerAttributes()
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.SetCursorPosition(0, 0);
			Console.WriteLine("Health: 100");
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.SetCursorPosition(15, 0);
			Console.WriteLine("Room: 1");
			Console.ForegroundColor = ConsoleColor.DarkGray;
			Console.SetCursorPosition(30, 0);
			Console.WriteLine("Weapons: None");
			this.plotScreen();
			
		}
		public void plotRoom(int x_pos, int y_pos)
		{
			Console.SetCursorPosition(x_pos, y_pos);
			Console.WriteLine("┌─┐");
			Console.SetCursorPosition(x_pos, y_pos + 1);
			Console.WriteLine("│ │");
			Console.SetCursorPosition(x_pos, y_pos + 2);
			Console.WriteLine("└─┘");

			
		}

		public void moveToAnotherRoom(string direction)
		{
			int origRow = Console.CursorTop;
			int origCol = Console.CursorLeft;
			if (direction == "S")
			{
				Console.WriteLine(" ");
				Console.SetCursorPosition(origCol, origRow + 3);
				Console.WriteLine("@");
			}

			if (direction == "N")
			{
				Console.WriteLine(" ");
				Console.SetCursorPosition(origCol, origRow - 3);
				Console.WriteLine("@");
			}

		}

		public void setStartupPos()
		{
			Console.SetCursorPosition(2, 5);
			Console.WriteLine("@");
		}

		



	}
}