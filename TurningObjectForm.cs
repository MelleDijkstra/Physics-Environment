using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Physics_Environment.Objects;

namespace Physics_Environment
{
    public partial class TurningObjectForm : Form
    {
        private TurningBall ball;
        const int blockSize = 30;
        Grid grid;

        public TurningObjectForm()
        {
            InitializeComponent();
            ball = new TurningBall(50, 50, 50);
            grid = new Grid(Width / blockSize, blockSize);
        }

        private void theLoop_Tick(object sender, EventArgs e)
        {
            Invalidate();
            ball.Update();
        }

        private void canvasPaint(object sender, PaintEventArgs e)
        {
            grid.PaintGrid(e.Graphics);
            ball.Draw(e.Graphics);
            ball.drawStats(e.Graphics);
        }

        private void PhysicsForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.P)
            {
                if (theLoop.Enabled)
                {
                    theLoop.Stop();
                    timerStateLabel.Text = "Not running";
                }
                else
                {
                    theLoop.Start();
                    timerStateLabel.Text = "Running";
                }
            }
            if (theLoop.Enabled)
            {
                ball.KeyDown(e);
            }
        }
    }
}
