namespace Physics_Environment.Physics
{
    public class Vector
    {
        public int x, y;

        public Vector(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return "x: "+x+", y: "+y;
        }
    }
}
