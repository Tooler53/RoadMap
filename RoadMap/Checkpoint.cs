using System;
using System.Drawing;

namespace RoadMap
{
    [Serializable]
    public class CheckpointIcon : Icon
    {
        public CheckpointIcon(int x, int y) : base(x, y)
        {
        }

        public CheckpointIcon()
        {
        }
        public override void Draw(Graphics g)
        {
            Image image = Properties.Resources.Chechpoint;
            g.DrawImage(image, X, Y);
        }
    }
}