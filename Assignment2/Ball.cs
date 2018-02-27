using System;
using System.Drawing;
using System.Collections.Generic;

namespace Assignment2
{
	public class Ball : IDrawable
	{
		private Pen pen = new Pen(Color.White);
		private int radius;
        Point position;

		public Point Position
		{
			get { return position; }
		}
		

		public Ball(Point position, int radius)
		{
            this.position = position;
			this.radius = radius;
		}

		public Ball(int x, int y, int radius) : this(new Point(x, y), radius)
		{
			this.radius = radius;
		}

		public void Draw(Graphics g)
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

	    public void SpeedUp()
	    {
	        Speed.X = Speed.X * 2;
	        Speed.Y = Speed.Y * 2;
        }

	    public void SpeedDown()
	    {
	        if (Speed.X / 2 != 0 && Speed.Y / 2 != 0)
	        {
	            Speed.X = Speed.X / 2;
	            Speed.Y = Speed.Y / 2;
	        }

        }

	    public void FlipYSpeed()
	    {
	        Speed.Y = Speed.Y * -1;
        }

	    public void FlipXSpeed()
	    {
	        Speed.X = Speed.X * -1;
        }
    }
}
