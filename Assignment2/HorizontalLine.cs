using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Assignment2
{
    class HorizontalLine : Line
    {
        public HorizontalLine(Color color, int length, Point position) : base(color, length, position)
        {
            this.detectionArea = new Rectangle(position.X, position.Y, length, 20);
        }

        public override void Draw(Graphics g)
        {
            g.DrawLine(pen, position, new Point(position.X + length, position.Y));
        }

        public override void CollisionEffect(Ball ball)
        {
            ball.Speed.Y = ball.Speed.Y * - 1;
        }

    }
}
