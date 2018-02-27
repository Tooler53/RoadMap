using System;
using System.Drawing;

namespace RoadMap
{
    [Serializable]
    public class Dot
    {
        protected int X;
        protected int Y;

        public Dot(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Dot()
        {
        }

        public Point Coordinates
        {
            protected set
            {
                X = value.X;
                Y = value.Y;
            }
            get => new Point(X, Y);
        }
    }
}