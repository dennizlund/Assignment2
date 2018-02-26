using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Assignment2
{
    class SpeedUpBox : Box
    {
        public SpeedUpBox(Color color, int height, int width, Point position) : base(color, height, width, position)
        {

        }
        public override void CollisionEffect(Ball ball)
        {
                ball.Speed.X = ball.Speed.X * 2;
                ball.Speed.Y = ball.Speed.Y * 2;
        }
    }
}
