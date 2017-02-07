using System;

namespace DodgeGame
{
	public class PlayerUnit :Unit
	{
		public PlayerUnit (int x, int y, string unitGraphic) : base (x, y, unitGraphic)
		{
		}



		override public void Update()
		{
			//When the PLAYER's Update funtion gets called,
			// we would like to execute this INSTEAD of
			// our parent class's Update. In other words,
			// we want to OVERRIDE the parent.

			// Has the user pressed a key?
			// if so, let's MOVE based on that key. 




			//Now that our keyboard input is done,
			// let's call our base class's Update function
			// in case it has any important work to do.

			base.Update ();

			//throw new Exception ("We are in PlayerUnit:Update()!");
		}
	}
}

