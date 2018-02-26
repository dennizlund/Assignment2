using System;
namespace Assignment2
{
	public class Vector
	{
		private int x;
		private int y;

		public Vector(int x, int y)
		{
			this.x = x;
			this.y = y;
		}

		public int X
		{
			get { return x; }
			set
			{
				if (X < 10 && X > -10)
				{
					x = value;
				}
			}
		}

		public int Y
		{
			get { return y; }
			set
			{
				if (Y < 10 && Y > -10)
				{
					y = value;
				}
				
			}
		}
	}
}
