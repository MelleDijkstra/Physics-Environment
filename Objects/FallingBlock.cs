using System;
using System.Drawing;
using System.Windows.Forms;

namespace Physics_Environment.Objects
{
    class FallingBlock : BaseBlock
    {
        protected BaseState currentState;

        public FallingBlock(int x, int y, int size) : base(x, y, size)
        {
            currentState = new FallingState();
        }

        public FallingBlock(int x, int y, int size, Brush color) : base(x, y, size, color)
        {
            currentState = new FallingState();
        }

        public void setCurrentState(BaseState newState)
        {
            currentState = newState;
        }

        public new void Update()
        {
            currentState.Update(this);
        }

        public void KeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                y = 0;
            }
            if (e.KeyCode == Keys.Left)
            {
                x -= 5;
            }
            if (e.KeyCode == Keys.Right)
            {
                x += 5;
            }
        }

        public void drawStats(Graphics g)
        {
            g.FillRectangle(Brushes.Black, 5, 5, 500, 25);
            g.DrawString(ToString(), SystemFonts.DefaultFont, Brushes.Chocolate, 10, 10);
        }

        public override string ToString()
        {
            return "X: " + Math.Round(x, 2) + " Y: " + Math.Round(y, 2);
        }

    }

    internal abstract class BaseState
    {
        public abstract void Update(FallingBlock _fallingBlock);
    }

    internal class IdleState : BaseState
    {
        public IdleState()
        {
            Console.WriteLine("Idling... (doing nothing)");
        }

        public override void Update(FallingBlock _fallingBlock)
        {
            if (_fallingBlock.y != GravityTestForm.wHeight - _fallingBlock.size)
            {
                _fallingBlock.setCurrentState(new FallingState());
            }
        }
    }

    internal class FallingState : BaseState
    {
        private double acc = 0.5;
        private int fallingSpeed = 1;

        public FallingState()
        {
            Console.WriteLine("Falling...");
        }

        public override void Update(FallingBlock _fallingBlock)
        {
            int groundY = GravityTestForm.wHeight - _fallingBlock.size;
            if (_fallingBlock.y < groundY)
            {
                _fallingBlock.y += fallingSpeed * acc;
                acc += 0.1;
            }
            else
            {
                _fallingBlock.y = groundY;
                _fallingBlock.setCurrentState(new IdleState());
            }
        }
    }
}
