using System;
using System.Threading;
using System.Diagnostics;

namespace DodgeGame
{
	public class Game
	{
		// This is our cunstructor -- it gets run automatically
		// when a new INSTANCE of gamer is created.


		public Game ()
		{
			// Instantiate a Unit that will represent
			// the player.
			playerUnit = new PlayerUnit(10, 5, "@");
			// Now instantiate the enemy.

			enemyUnit = new EnemyUnit (Console.WindowWidth -1, 17, "X");

			stopwatch = new Stopwatch ();

		}
		private Stopwatch stopwatch;

		private Unit playerUnit;
		private Unit enemyUnit;

		public void run()
		{

			// We are happy to run at any framerate whatsoever,
			// however -- do we need to know how much time eaach
			// frame it took.


			//int desiredFPS = 100;
			stopwatch.Start();
			long timeAtPreviousFrame = stopwatch.ElapsedMilliseconds;

			// int deltaTimeMS = 33; // desiredFPS;

			while (true)
			{
				 // The time since last frame 
				int deltaTimeMS = (int)(stopwatch.ElapsedMilliseconds - timeAtPreviousFrame);
				timeAtPreviousFrame = stopwatch.ElapsedMilliseconds;
			
				//Update all of our units
				playerUnit.Update (deltaTimeMS);
				enemyUnit.Update (deltaTimeMS);

			

				// Now draw both units
				playerUnit.Draw();
				enemyUnit.Draw ();


				// Let's just do a TINY sleep to avoid running at a billion FPS.
				Thread.Sleep (5);
			 
			}
		}
	
	}

}

