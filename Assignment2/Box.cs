using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Assignment2
{
    public abstract class Box : IDrawable, ICollidable
    {
        protected Pen pen;
        protected int heigth, width;
        protected Point position;
        protected Rectangle detectionArea;

        public Box(Color color, int heigth, int width, Point position)
        {
            pen = new Pen(color);
            this.heigth = heigth;
            this.width = width;
            this.position = position;
            this.detectionArea.X = position.X;
            this.detectionArea.Y = position.Y;
            this.detectionArea.Height = heigth;
            this.detectionArea.Width = width;
        }

        public abstract void CollisionEffect(Ball ball);
        

        public void Draw(Graphics g)
        {
            g.DrawRectangle(pen, position.X, position.Y, heigth, width);
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
    }
}
