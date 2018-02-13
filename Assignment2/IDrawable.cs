using System.Drawing;

namespace Assignment2
{
	public abstract class Shape
	{
		protected Point position;

		public Shape(Point position)
		{
			this.position = position;
		}

		public abstract void Draw(Graphics g);
	}
}
