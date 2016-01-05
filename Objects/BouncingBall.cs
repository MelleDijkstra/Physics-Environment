using System.Drawing;
using System.Windows.Forms;

namespace Physics_Environment.Objects
{
    class BouncingBall : BallBase
    {
        public int velocityX = 2;
        public int velocityY = 2;

        public BouncingBall(int x, int y, int diameter) : base(x, y, diameter)
        {
            
        }

        public BouncingBall(int x, int y, int diameter, Brush color) : base(x, y, diameter, color)
        {

        }

        public new void Update()
        {

            x += velocityX;
            y += velocityY;
        }

        public new void KeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                if (velocityX < 0)
                {
                    velocityX--;
                }
                else
                {
                    velocityX++;
                }
                if (velocityY < 0)
                {
                    velocityY--;
                }
                else
                {
                    velocityY++;
                }
            }
            if (e.KeyCode == Keys.S)
            {
                if (velocityX > 0)
                {
                    velocityX--;
                }
                else
                {
                    velocityX++;
                }
                if (velocityY > 0)
                {
                    velocityY--;
                }
                else
                {
                    velocityY++;
                }
            }
        }

        public override string ToString()
        {
            return base.ToString()+" - velocity X: "+velocityX+" velocity Y: "+velocityY;
        }
    }
}
