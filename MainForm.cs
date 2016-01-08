using System;
using System.Windows.Forms;

namespace Physics_Environment
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        // Start turning object form and hide this one
        private void startTurningFormBtn_Click(object sender, EventArgs e)
        {
            TurningObjectForm form = new TurningObjectForm();
            form.Closed += (o, args) => { Show(); };
            Hide();
            form.Show(this);
        }

        private void startGravityTest_Click(object sender, EventArgs e)
        {
            GravityTestForm form = new GravityTestForm();
            form.Closed += (o, args) => { Show(); };
            Hide();
            form.Show(this);
        }

        private void startBorderBouncingForm_Click(object sender, EventArgs e)
        {
            BorderBouncingForm form = new BorderBouncingForm();
            form.Closed += (o, args) => { Show(); };
            Hide();
            form.Show(this);
        }

        private void startJumpingForm_Click(object sender, EventArgs e)
        {
            JumpingForm form = new JumpingForm();
            form.Closed += (o, args) => { Show(); };
            Hide();
            form.Show(this);
        }

        private void openFollowPlayerForm_Click(object sender, EventArgs e)
        {
            VectorTestingForm form = new VectorTestingForm();
            form.Closed += (o, args) => { Show(); };
            Hide();
            form.Show(this);
        }
    }
}
