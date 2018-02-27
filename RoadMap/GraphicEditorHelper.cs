using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace RoadMap
{
    class GraphicEditorHelper
    {
        protected List<Dot> Shapes;
        protected bool Mouse_Down;
        protected ShapeType Type;
        protected Dot Start;
        protected Dot End;
        protected Dot Shape;

        public bool IsMouseDown()
        {
            return Mouse_Down;
        }
        public void OnMouseDown()
        {
            Mouse_Down = true;
        }
        public void OnMouseUp()
        {
            Mouse_Down = false;
        }

        public GraphicEditorHelper()
        {
            Shapes = new List<Dot>();
            OnMouseUp();
        }

        public void Draw(Graphics g)
        {
            if (Shape != null)
            {
                switch (Type)
                {
                    case ShapeType.Watch:
                        {
                            Shape = new Watchmen(Start.Coordinates.X, Start.Coordinates.Y);
                            break;
                        }
                    case ShapeType.Start:
                        {
                            Shape = new StartIcon(Start.Coordinates.X, Start.Coordinates.Y);
                            break;
                        }
                    case ShapeType.Stop:
                        {
                            Shape = new StopIcon(Start.Coordinates.X, Start.Coordinates.Y);
                            break;
                        }
                    case ShapeType.Check:
                        {
                            Shape = new CheckpointIcon(Start.Coordinates.X, Start.Coordinates.Y);
                            break;
                        }
                }
                (Shape as IDrawable).Draw(g);
            }

            foreach (var Shape in Shapes)
                if (Shape is IDrawable)
                    (Shape as IDrawable).Draw(g);
        }

        public void SetType(string type)
        {
            switch (int.Parse(type))
            {
                case 4:
                    {
                        Type = ShapeType.Watch;
                        Shape = new Watchmen();
                        break;
                    }
                case 1:
                    {
                        Type = ShapeType.Start;
                        Shape = new StartIcon();
                        break;
                    }
                case 2:
                    {
                        Type = ShapeType.Stop;
                        Shape = new StopIcon();
                        break;
                    }
                case 3:
                    {
                        Type = ShapeType.Check;
                        Shape = new CheckpointIcon();
                        break;
                    }
            }
        }

        public void AddStartPoint(int x, int y)
        {
            Start = new Dot(x, y);
        }

        public void AddEndPoint(int x, int y)
        {
            End = new Dot(x, y);

            switch (Type)
            {
                case ShapeType.Watch:
                    {
                        Shapes.Add(new Watchmen(Start.Coordinates.X, Start.Coordinates.Y));
                        break;
                    }
                case ShapeType.Start:
                    {
                        Shapes.Add(new StartIcon(Start.Coordinates.X, Start.Coordinates.Y));
                        break;
                    }
                case ShapeType.Stop:
                    {
                        Shapes.Add(new StopIcon(Start.Coordinates.X, Start.Coordinates.Y));
                        break;
                    }
                case ShapeType.Check:
                    {
                        Shapes.Add(new CheckpointIcon(Start.Coordinates.X, Start.Coordinates.Y));
                        
                        break;
                    }
            }
        }

        public void SaveFile(string file, int index, System.Windows.Forms.PictureBox contest)
        {
            if (index == 1)
                using (FileStream fstream = new FileStream(file, FileMode.CreateNew))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fstream, Shapes);
                }
            else
            {
                Bitmap bitmap = new Bitmap(contest.Width, contest.Height);
                contest.DrawToBitmap(bitmap, contest.Bounds);
                bitmap.Save(file);
            }
        }
    }
}
