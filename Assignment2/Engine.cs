using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Assignment2
{
	public class Engine
	{
		private MainForm form;
		private Timer timer;

		private ISet<Ball> balls = new HashSet<Ball>();
        private ISet<Line> lines = new HashSet<Line>();
		private ISet<Box> boxes = new HashSet<Box>();

		private Random random = new Random();
        


		public Engine()
		{
			form = new MainForm();
			timer = new Timer();

			AddBall();
            AddCollidables();
			
		}

		public void Run()
		{
			form.Paint += new PaintEventHandler(Draw);
			
			timer.Tick += new EventHandler(TimerEventHandler);
			timer.Interval = 1000/25;
			timer.Start();
			
			Application.Run(form);

		}

		private void AddBall()
		{
			var ball = new Ball(400, 300, 10);
			ball.Speed = new Vector(random.Next(10) - 5, random.Next(10) - 5);
			balls.Add(ball);
		}

        private void AddCollidables()
        {
            var farLeft = new VerticalLine(Color.Yellow, 550, new Point (15,50));
            lines.Add(farLeft);
            var secondLeft = new VerticalLine(Color.Yellow, 250, new Point(105, 80));
	        lines.Add(secondLeft);
            var farRight = new VerticalLine(Color.Yellow, 500, new Point(760, 20));
            lines.Add(farRight);

            var firstFromTop = new HorizontalLine(Color.DarkGreen, 250, new Point(80, 20));
	        lines.Add(firstFromTop);
            var secondFromTop = new HorizontalLine(Color.DarkGreen, 250, new Point(380, 20));
	        lines.Add(secondFromTop);
            var bottomLeft = new HorizontalLine(Color.DarkGreen, 600, new Point(10, 550));
	        lines.Add(bottomLeft);
            var bottomRight = new HorizontalLine(Color.DarkGreen, 200, new Point(540, 450));
	        lines.Add(bottomRight);
            var secondFromBottom = new HorizontalLine(Color.DarkGreen, 300, new Point(200, 400));
	        lines.Add(secondFromBottom);
            var thirdFromTop = new HorizontalLine(Color.DarkGreen, 200, new Point(130, 100));
	        lines.Add(thirdFromTop);

            var SpeedUpBox1 = new SpeedUpBox(Color.Red, 100, 100, new Point(150, 120));
            boxes.Add(SpeedUpBox1);
            var SpeedUpBox2 = new SpeedUpBox(Color.Red, 60, 100, new Point(650, 250));
	        boxes.Add(SpeedUpBox2);

            var SpeedDownBox1 = new SpeedDownBox(Color.Cyan, 250, 50, new Point(130, 450));
	        boxes.Add(SpeedDownBox1);
            var SpeedDownBox2 = new SpeedDownBox(Color.Cyan, 100, 100, new Point(480, 90));
	        boxes.Add(SpeedDownBox2);
        }

		private void CheckLineCollisions()
		{
			foreach (var line in lines)
			{
				foreach (var ball in balls)
				{
					if (line.CollisionDetected(ball.Position))
					{
						line.CollisionEffect(ball);
					}
				}
			}

		}

		private void CheckBoxCollisions()
		{
			foreach (var box in boxes)
			{
				foreach (var ball in balls)
				{
					if (box.CollisionDetected(ball.Position))
					{
						box.CollisionEffect(ball);
					}
				}
			}
		}

		private void CheckCollisions()
		{
			CheckLineCollisions();
			CheckBoxCollisions();
		}

		private void TimerEventHandler(Object obj, EventArgs args)
		{
			if (random.Next(100) < 25) AddBall();

			
			foreach (var ball in balls)
			{
				ball.Move();
			}
			CheckCollisions();
			form.Refresh();
		}

		private void Draw(Object obj, PaintEventArgs args)
		{
			foreach (var ball in balls)
			{
				ball.Draw(args.Graphics);
			}
            foreach (var line in lines)
            {
                line.Draw(args.Graphics);
            }
			foreach (var box in boxes)
			{
				box.Draw(args.Graphics);
			}
		}

    }
}
