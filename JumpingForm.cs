using System;
using System.Windows.Forms;

namespace Physics_Environment
{
    public partial class JumpingForm : Form
    {
        Player pl;
        public static int winHeight;
        public static int winWidth;

        public JumpingForm()
        {
            InitializeComponent();
            pl = new Player();
            winHeight = ClientSize.Height;
            winWidth = ClientSize.Width;
        }

        private void JumpingForm_KeyDown(object sender, KeyEventArgs e)
        {
            pl.KeyDown(e);
        }

        private void JumpingForm_Paint(object sender, PaintEventArgs e)
        {
            pl.Paint(e.Graphics);
            pl.DrawStats(e.Graphics);
        }

        private void theLoop_Tick(object sender, System.EventArgs e)
        {
            Invalidate();
            pl.Update();
        }

        private void JumpingForm_Resize(object sender, System.EventArgs e)
        {
            winHeight = ClientSize.Height;
            winWidth = ClientSize.Width;
        }
    }
}
