using System.Drawing;

namespace Physics_Environment
{
    class Grid
    {
        private int _numOfCells;
        private float _cellSize;

        public Grid(int numOfCells, float cellSize)
        {
            _numOfCells = numOfCells;
            _cellSize = cellSize;
        }

        public Grid(int numOfCells)
        {
            _numOfCells = numOfCells;
            _cellSize = 30;
        }

        public void PaintGrid(Graphics g)
        {
            for (int y = 0; y < _numOfCells * _cellSize; y++)
            {
                g.DrawLine(Pens.Black, 0, y * _cellSize, _numOfCells * _cellSize, y * _cellSize);
            }

            for (int x = 0; x < _numOfCells * _cellSize; x++)
            {
                g.DrawLine(Pens.Black, x * _cellSize, 0, x * _cellSize, _numOfCells * _cellSize);
            }
        }
    }
}
