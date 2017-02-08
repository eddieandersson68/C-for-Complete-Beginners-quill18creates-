using System;

namespace DodgeGame
{
	public class Game
	{
		public Game ()
		{
			// Instantiate a Unit that will represent
			// the player.
			playerUnit = new PlayerUnit(10, 5, "@");
			// Now instantiate the enemy.

			enemyUnit = new EnemyUnit (20, 17, "X");


		}

		private Unit playerUnit;
		private Unit enemyUnit;

		public void run()
		{
			while (true)
			{
				
			
			//First, Update all of our units
			playerUnit.Update ();
			enemyUnit.Update ();

			// Now draw both units
			playerUnit.Draw();
			enemyUnit.Draw ();
			}
		}
	
	}

}

