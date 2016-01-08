using System;
using System.Drawing;

namespace Physics_Environment.Objects
{
    class BaseBlock
    {
        public double x;
        public double y;
        public int size;
        protected Brush color;

        public BaseBlock(int x, int y, int size)
        {
            this.x = x;
            this.y = y;
            this.size = size;
            color = Brushes.DarkRed;
        }

        public BaseBlock(int x, int y, int size, Brush color)
        {
            this.x = x;
            this.y = y;
            this.size = size;
            this.color = color;
        }

        public void Update()
        {
            
        }

        public void Draw(Graphics g)
        {
            g.FillRectangle(color, new Rectangle(Convert.ToInt32(x), Convert.ToInt32(y), size, size));
        }
    }
}
