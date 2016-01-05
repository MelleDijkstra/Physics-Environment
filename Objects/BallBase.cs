using System;
using System.Drawing;
using System.Windows.Forms;

namespace Physics_Environment.Objects
{
    class BallBase
    {
        public double x { get; set; }
        public double y { get; set; }
        public int diameter { get; set; }
        private Brush color;

        public BallBase(int x, int y, int diameter)
        {
            this.x = x;
            this.y = y;
            this.diameter = diameter;
            color = Brushes.DarkRed;
        }

        public BallBase(int x, int y, int diameter,Brush color)
        {
            this.x = x;
            this.y = y;
            this.diameter = diameter;
            this.color = color;
        }

        public void Draw(Graphics g)
        {
            g.FillEllipse(color,new Rectangle(Convert.ToInt32(x),Convert.ToInt32(y),diameter,diameter));
        }

        public void Update() {}

        public void KeyDown(KeyEventArgs e)
        {
            
        }

        public void drawStats(Graphics g)
        {
            g.FillRectangle(Brushes.Black,5,5,500,25);
            g.DrawString(ToString(),SystemFonts.DefaultFont,Brushes.Chocolate,10,10);
        }

        public override string ToString()
        {
            return "X: " + Math.Round(x,2) + " Y: " + Math.Round(y,2);
        }
    }
}
