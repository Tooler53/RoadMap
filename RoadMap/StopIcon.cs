using System;
using System.Drawing;

namespace RoadMap
{
    [Serializable]
    public class StopIcon : Icon
    {
        public StopIcon(int x, int y) : base(x, y)
        {
        }

        public StopIcon()
        {
        }

        public override void Draw(Graphics g)
        {
            Image image = Properties.Resources.Stop;
            g.DrawImage(image, X, Y);
        }
    }
}