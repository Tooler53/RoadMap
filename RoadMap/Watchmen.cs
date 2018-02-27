using System;
using System.Drawing;

namespace RoadMap
{
    [Serializable]
    public class Watchmen : Icon
    {
        public Watchmen(int x, int y) : base(x, y)
        {
        }

        public Watchmen()
        {
        }
        public override void Draw(Graphics g)
        {
            Image image = Properties.Resources.Wathcmen;
            g.DrawImage(image, X, Y);
        }
    }
}