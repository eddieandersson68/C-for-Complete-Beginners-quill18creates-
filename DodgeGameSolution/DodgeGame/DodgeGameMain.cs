using System;

namespace DodgeGame
{
	class DodgeGameMain
	{
		static void Main ()
		{	

			//Let's hide the blinking cursor. We don't need it.
			Console.CursorVisible = false;
			// Create a new game.
			Game game = new Game ();

			//Run the game.
			game.run();

			// When we get here the game is over.

			//Program end
			// Do some clean-up

			//Set cursor to bottom most row
			Console.SetCursorPosition (0, Console.WindowHeight + 1);


		}
	}
} 