using System;
using System.Drawing;

namespace RoadMap
{
    [Serializable]
    public abstract class Icon : Dot, IDrawable
    {
        public Icon(int x, int y) : base(x, y)
        {
        }

        public Icon()
        {
        }

        public abstract void Draw(Graphics g);
    }
}