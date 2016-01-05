using System;
using System.Drawing;
using System.Windows.Forms;

namespace Physics_Environment.Objects
{
    class TurningBall : BallBase
    {
        public int speed;
        public double angle { get; set; }

        public TurningBall(int x, int y, int diameter) : base(x, y, diameter)
        {
        }

        public TurningBall(int x, int y, int diameter, Brush color) : base(x, y, diameter, color)
        {
        }

        public new void Update()
        {
            double speed_y = speed * Math.Sin(angle);
            double speed_x = speed * Math.Cos(angle);
            x += speed_x;
            y += speed_y;
        }

        public new void KeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                speed = 2;
            }
            if (e.KeyCode == Keys.S)
            {
                speed = 0;
            }
            if (e.KeyCode == Keys.Left)
            {
                angle -= 0.3;
            }
            if (e.KeyCode == Keys.Right)
            {
                angle += 0.3;
            }
        }

        public override string ToString()
        {
            return "X: " + Math.Round(x, 2) + " Y: " + Math.Round(y, 2) + " - angle: " + Math.Round(angle, 2) + " Sin: " + Math.Round(Math.Sin(angle), 2) + " Cos: " + Math.Round(Math.Cos(angle), 2);
        }

    }
}
