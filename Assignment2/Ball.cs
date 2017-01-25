using System;
using System.Drawing;

namespace Assignment2
{
	public class Ball : Shape
	{
		private Pen pen = new Pen(Color.Black);
		private int radius;

		public Ball(Point position, int radius) : base(position)
		{
			this.radius = radius;
		}

		public Ball(int x, int y, int radius) : base(new Point(x, y))
		{
			this.radius = radius;
		}

		override public void Draw(Graphics g)
		{
			g.DrawEllipse(pen,position.X - radius, position.Y - radius, 2 * radius, 2 * radius);
		}

		public void Move()
		{
			position.X = position.X + speed.X;
			position.Y = position.Y + speed.Y;
		}

		private Vector speed;

		public Vector Speed
		{
			get { return speed; }
			set { speed = value; }
		}

	}
}
