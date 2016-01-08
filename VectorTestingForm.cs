using System;
using System.Drawing;
using System.Windows.Forms;
using Physics_Environment.Objects;
using Physics_Environment.Physics;
using Point = Physics_Environment.Physics.Point;

namespace Physics_Environment
{
    public partial class VectorTestingForm : Form
    {
        private VectorBall pacman;
        private Random r;
        private Point mousePoint;
        private VectorBall inky;
        Vector distance;

        public VectorTestingForm()
        {
            InitializeComponent();

            // create a ball
            pacman = new VectorBall(30,30,20,Brushes.Yellow);
            inky = new VectorBall(100,100,20,Brushes.Aqua);
            r = new Random();

            distance = pacman.position - inky.position;
            Console.WriteLine(distance);
        }

        private void VectorTestingForm_Paint(object sender, PaintEventArgs e)
        {
            pacman.Paint(e.Graphics);
            inky.Paint(e.Graphics);
        }

        private void theLoop_Tick(object sender, EventArgs e)
        {
            Invalidate(); // invalidate so that Paint event runs again

        }

        private void VectorTestingForm_MouseClick(object sender, MouseEventArgs e)
        {
            pacman.position = new Point(e.X,e.Y);

            distance = pacman.position - inky.position;
            Console.WriteLine(distance);
        }
    }
}
