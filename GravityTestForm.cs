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
    public partial class GravityTestForm : Form
    {
        FallingBlock _fallingBlock;
        Grid grid;
        const int blockSize = 30;
        public static int wHeight;
        public static int wWidth;

        public GravityTestForm()
        {
            // C# doin' his thing
            InitializeComponent();

            // get actual width and height
            wHeight = ClientSize.Height;
            wWidth = ClientSize.Width;

            grid = new Grid(Width / 30);
            _fallingBlock = new FallingBlock(30, 30, 30, Brushes.BlueViolet);
        }

        private void GravityTestForm_Paint(object sender, PaintEventArgs e)
        {
            grid.PaintGrid(e.Graphics);
            _fallingBlock.Draw(e.Graphics);
            _fallingBlock.drawStats(e.Graphics);
        }

        private void theLoop_Tick(object sender, EventArgs e)
        {
            Invalidate();
            _fallingBlock.Update();
        }

        private void GravityTestForm_KeyDown(object sender, KeyEventArgs e)
        {
            _fallingBlock.KeyDown(e);
        }
    }
}
