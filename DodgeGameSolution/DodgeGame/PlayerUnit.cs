using System;

namespace DodgeGame
{
	public class PlayerUnit :Unit
	{
		public PlayerUnit (int x, int y, string unitGraphic) : base (x, y, unitGraphic)
		{
		}

			override public void Update(int deltaTimeMS)
		{
			//When the PLAYER's Update funtion gets called,
			// we would like to execute this INSTEAD of
			// our parent class's Update. In other words,
			// we want to OVERRIDE the parent.

			// Has the user pressed a key?
			if (Console.KeyAvailable == true) 
			{
				// if so, let's MOVE based on that key.

				ConsoleKeyInfo cki = Console.ReadKey (true);

				switch (cki.Key) 
				{

					case ConsoleKey.UpArrow:
					case ConsoleKey.W:
					case ConsoleKey.NumPad8:
						Y = Y - 1;
						break;
					case ConsoleKey.DownArrow:
					case ConsoleKey.S:
					case ConsoleKey.NumPad2:
						Y = Y + 1;
						break;
					case ConsoleKey.LeftArrow:
					case ConsoleKey.A:
					case ConsoleKey.NumPad4:
						X = X - 1;
						break;
					case ConsoleKey.RightArrow:
					case ConsoleKey.D:
					case ConsoleKey.NumPad6:
						X = X + 1;
						break;
				}

				// Check to see if user prexsed w OR W
				//if (cki.KeyChar == 'w' || cki.KeyChar == 'W' || cki.Key == 'W')
//				if (cki.Key == ConsoleKey.W || cki.Key == ConsoleKey.UpArrow) 
//				{
//					// W is up
//					Y = Y -1;
//				}
//
//				if (cki.Key == ConsoleKey.S|| cki.Key == ConsoleKey.DownArrow) 
//				{
//					// S is down
//					Y = Y +1;
//				}
//				if (cki.Key == ConsoleKey.A|| cki.Key == ConsoleKey.LeftArrow) 
//				{
//					// A is left
//					X = X -1;
//				}
//				if (cki.Key == ConsoleKey.D|| cki.Key == ConsoleKey.RightArrow) 
//				{
//					// A is left
//					X = X +1;
//				}

					
				

			}
			 




			//Now that our keyboard input is done,
			// let's call our base class's Update function
			// in case it has any important work to do.

			base.Update (deltaTimeMS);

			//throw new Exception ("We are in PlayerUnit:Update()!");
		}
	}
}

