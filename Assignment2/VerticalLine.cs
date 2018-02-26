using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Assignment2
{
    class VerticalLine : Line
    {
        public VerticalLine(Color color, int length, Point position) : base(color, length, position)
        {
            this.detectionArea = new Rectangle(position.X, position.Y, 20, length);
        }

        public override void Draw(Graphics g)
        {
            g.DrawLine(pen, position, new Point(position.X, position.Y + length));
        }

        public override void CollisionEffect(Ball ball)
        {
            ball.Speed.X = ball.Speed.X * - 1;
        }

}
}
