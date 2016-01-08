using System.Drawing;
using Point = Physics_Environment.Physics.Point;

namespace Physics_Environment.Objects
{
    class VectorBall
    {
        public Point position;
        public int diameter;
        private Brush color;

        public VectorBall(int x, int y, int diameter)
        {
            position = new Point(x,y);
            this.diameter = diameter;
            color = Brushes.CadetBlue;
        }

        public VectorBall(int x, int y, int diameter, Brush color)
        {
            position = new Point(x, y);
            this.diameter = diameter;
            this.color = color;
        }

        public void Paint(Graphics g)
        {
            g.FillEllipse(color,position.x,position.y,diameter,diameter);
        }

        public void ChangeColor(Brush color)
        {
            this.color = color;
        }
    }
}