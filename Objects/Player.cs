using System;
using System.Drawing;
using System.Windows.Forms;
using Physics_Environment.Objects.States;

namespace Physics_Environment
{
    class Player
    {
        private Image skin;
        public double x;
        public double y;
        private BaseState currentState;

        public Player(double x, double y)
        {
            this.x = x;
            this.y = y;
            currentState = new PlayerIdleState(this);
            skin = GameResources.Player;
        }

        public Player()
        {
            x = 100;
            y = 100;
            currentState = new PlayerIdleState(this);
            skin = GameResources.Player;
        }

        public void Paint(Graphics g)
        {
            g.DrawImage(skin,new Point(Convert.ToInt32(x),Convert.ToInt32(y)));
        }

        public void Update()
        {
            currentState.Update();
        }

        public void KeyDown(KeyEventArgs e)
        {
            currentState.KeyDown(e);
        }

        public void changeState(BaseState newstate)
        {
            currentState = newstate;
        }

        public Image getSkin()
        {
            return skin;
        }

        public void DrawStats(Graphics g)
        {
            g.FillRectangle(Brushes.Black,new Rectangle(10,10,JumpingForm.winWidth - 20,30));
            g.DrawString(ToString(),SystemFonts.DefaultFont,Brushes.Chocolate,12,12);
        }

        public override string ToString()
        {
            return "X: " + x + " Y: " + y + " - state: " + currentState.GetType().Name;
        }

    }

    // IDLE STATE

    internal class PlayerIdleState : BaseState
    {

        public PlayerIdleState(Player pl)
        {
            Console.WriteLine("Player is idling");
            this.pl = pl;
        }

        public override void Update()
        {
            if (pl.y < JumpingForm.winHeight - pl.getSkin().Height)
            {
                pl.changeState(new FallingState(pl));
            }
        }

        public override void KeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                pl.changeState(new JumpingState(pl));
            }
            if (e.KeyCode == Keys.Left)
            {
                pl.x -= 2;
            }
            if (e.KeyCode == Keys.Right)
            {
                pl.x += 2;
            }
        }
    }

    // JUMPING STATE

    internal class JumpingState : BaseState
    {

        public JumpingState(Player pl)
        {
            Console.WriteLine("Jumping");
            this.pl = pl;
        }

        public override void Update()
        {
            pl.y -= 2;
            if (pl.y < JumpingForm.winHeight - pl.getSkin().Height - 20)
            {
                pl.changeState(new FallingState(pl));
            }
        }

        public override void KeyDown(KeyEventArgs e)
        {
            
        }
    }

    // FALLING STATE

    internal class FallingState : BaseState
    {
        double _acc;
        int _fallingSpeed = 1;

        public FallingState(Player pl)
        {
            Console.WriteLine("Falling");
            this.pl = pl;
            _acc = 0.5;
        }

        public override void Update()
        {
            int groundY = JumpingForm.winHeight - pl.getSkin().Height;
            if (pl.y < groundY)
            {
                pl.y += _fallingSpeed * _acc;
                _acc += 0.1;
            }
            else
            {
                pl.y = groundY;
                pl.changeState(new PlayerIdleState(pl));
            }
        }

        public override void KeyDown(KeyEventArgs e)
        {
            
        }
    }
}
