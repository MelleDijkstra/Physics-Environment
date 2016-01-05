using System;
using System.Drawing;
using System.Windows.Forms;
using Physics_Environment.Objects;

namespace Physics_Environment
{
    public partial class BorderBouncingForm : Form
    {
        BouncingBall _bounceBall;
        Grid _grid;
        public static int wHeight;
        public static int wWidth;

        public BorderBouncingForm()
        {
            // C# doin' his thing
            InitializeComponent();

            // get actual width and height
            wHeight = ClientSize.Height;
            wWidth = ClientSize.Width;

            _grid = new Grid(Width / 30);
            _bounceBall = new BouncingBall(30,30,20,Brushes.Tomato);
        }

        private void BorderBouncingForm_Paint(object sender, PaintEventArgs e)
        {
            // paint gravity form
            _grid.PaintGrid(e.Graphics);
            _bounceBall.Draw(e.Graphics);
            _bounceBall.drawStats(e.Graphics);
        }

        private void theLoop_Tick(object sender, EventArgs e)
        {
            Invalidate();
            if (Math.Round(_bounceBall.x) >= ClientSize.Width - _bounceBall.diameter || Math.Round(_bounceBall.x) <= 0)
            {
                Console.WriteLine("Toggling X to change direction");
                _bounceBall.velocityX *= -1;
            }
            if (Math.Round(_bounceBall.y) <= 0 || (Math.Round(_bounceBall.y) >= ClientSize.Height - _bounceBall.diameter))
            {
                Console.WriteLine("Toggling Y to change direction");
                _bounceBall.velocityY *= -1;
            }
            _bounceBall.Update();
        }

        private void BorderBouncingForm_KeyDown(object sender, KeyEventArgs e)
        {
            _bounceBall.KeyDown(e);
        }

        private void BorderBouncingForm_Resize(object sender, EventArgs e)
        {
            _grid = new Grid(ClientSize.Width / 30);
        }
    }
}
