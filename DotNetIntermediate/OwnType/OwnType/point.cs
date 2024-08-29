using System;

namespace Structure
{
    public class MyPoint
    {
        public int X { get; set; }
        public int Y { get; set; }

        public MyPoint(int x, int y)
        {
            X = x;
            Y = y;
        }

        public double DistanceTo(MyPoint p)
        {
            return Math.Sqrt((p.X - X) * (p.X - X) + (p.Y - Y) * (p.Y - Y));
        }

        public override string ToString()
        {
            return $"[{X}, {Y}]";
        }
    }
}
    