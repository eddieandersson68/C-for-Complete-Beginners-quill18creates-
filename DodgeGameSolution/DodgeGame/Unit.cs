using System;

namespace DodgeGame
{
	public class Unit
	{
		public Unit (int x, int y, string unitGraphic)
		{
			this.X = x;
			this.Y = y;
			this.UnitGraphic = unitGraphic;
		}
		private int X // the way the rest of the program interacts with X
		{
			get
			{
				return _x;
			}
			set
			{
					if (value <  0 || value >= Console.WindowWidth) 

				{
					// Freak out, and put up some kind of error message!
					throw new Exception ("Invalid X coordinate passed ");
				}
				_x = value;
			}
		}
		private int _x; // Where the Value of X is actually stored.

		public int Y // The way the rest of the program interacts with Y.
		{
			get
			{
				return _y;
			}

			set
			{ 
				if (value < 0 || value >= Console.WindowHeight) 
				{
					throw new Exception ("Invalid Y coordinate passed. ");
				}

				_y = value;
			}
		}
		private int _y; // Where the Value of Y is actually stored.
	
		public string UnitGraphic { get; set;}
		
		virtual public void Update()
		{
			// This is and instance method that gets run every
			// frame, where the Unit should resolve any gamey
			// things that are going on.
			// The idea is that all Units Update themselves,
			// then all units will be drawn.


			//Since this Update runs for both Enemy AND Players,
			// it will need to be OVERRIDDEN by the child classes.
			//throw new Exception ("We are in Unit::Update()!");
		}
		

		// This draws the unit on screen
		public void Draw()
		{
			// This is an instance method, so if we refer 
			// to fields like x and y, we will be using
			// the values that belong to this instance,
			// and this instance ONLY.
			Console.SetCursorPosition (this.X, this.Y);
			Console.Write (this.UnitGraphic);
		

		}
	}
}

