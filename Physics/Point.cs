namespace Physics_Environment.Physics
{
    class Point
    {
        public int x, y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static Vector operator +(Point p, Vector v)
        {
            return new Vector(p.x + v.x, p.y + v.y);
        }

        public static Vector operator -(Point p, Point v)
        {
            return new Vector(p.x - v.x, p.y - v.y);
        }
    }
}
