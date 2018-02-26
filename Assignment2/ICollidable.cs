using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Assignment2
{
    public interface ICollidable : IDrawable
    {
        bool CollisionDetected(Point position);
        void CollisionEffect(Ball ball);
    }
}
