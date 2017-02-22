using System;

namespace DodgeGame
{
	public class EnemyUnit : Unit
	{
		// This is just an geneeric enemy Unit that moves from the right
		// side of the screen to the left, and then disappears.


		public EnemyUnit (int x, int y, string unitGraphic) : base (x, y, unitGraphic)
		{
		}

		public int TimeBetweenMoves = 100; // in milliseconds
		private int timeSinceLastMove =0;

		public override void Update(int deltaTimeMS)
		{
			// Has enough time passed so that we should be moving?
			timeSinceLastMove += deltaTimeMS; 

			if (timeSinceLastMove < TimeBetweenMoves) 
			{
				// Not enoiugh time has passed. Let's not do anything.
				return; // exist the function

			}

			// if we get here, it means we need to make a move.
			timeSinceLastMove -= TimeBetweenMoves;

			//Do AI here!

			// These enemies simply moves from the right side
			// of the screen to the left. If they go out of bounds,
			// then we delete ourselves...How does that work?


			// Move one to the left, but only if we still can move to the left.

			if (X > 0) {
				// Move to the left.
				X = X - 1;
			} 
			else 
			{
				// We are at our move limit. So  do something
			}

			//Now that the AI calculation is done,
			// let's call our base class's Update function
			// in case it has any important work to do.

			base.Update (deltaTimeMS);
		}
	}
}
	