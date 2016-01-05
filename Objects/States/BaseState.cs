using System;
using System.Windows.Forms;

namespace Physics_Environment.Objects.States
{
    abstract class BaseState
    {
        protected Player pl;

        public abstract void Update();
        public abstract void KeyDown(KeyEventArgs e);
    }
}
