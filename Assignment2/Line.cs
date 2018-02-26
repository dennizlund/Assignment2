using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Assignment2
{
    public abstract class Line : IDrawable, ICollidable
    {
        protected Pen pen;
        protected int length;
        protected Point position;
        protected Rectangle detectionArea;

        public Line(Color color, int length, Point position)
        {
            pen = new Pen(color);
            this.length = length;
            this.position = position;
        }

        public bool CollisionDetected(Point position)
        {
            if (position.Y > detectionArea.Y && position.Y < detectionArea.Bottom)
            {
                return (position.X >= detectionArea.X && position.X <= detectionArea.Right);
            }
            else
                return false;

        }

        public abstract void CollisionEffect(Ball ball);
        
        public abstract void Draw(Graphics g);
    }
}
