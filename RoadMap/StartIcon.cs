using System;
using System.Drawing;

namespace RoadMap
{
    [Serializable]
    public class StartIcon : Icon
    {
        public StartIcon(int x, int y) : base(x, y)
        {
        }

        public StartIcon()
        {
        }

        public override void Draw(Graphics g)
        {
            Image image = Properties.Resources.Start;
            g.DrawImage(image, X, Y);
        }
    }
}