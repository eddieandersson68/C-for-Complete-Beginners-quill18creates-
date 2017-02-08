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
		public override void Update()
		{
			//Do AI here!

			//Now that the AI calculation is done,
			// let's call our base class's Update function
			// in case it has any important work to do.

			base.Update ();
		}
	}
}

