using System;
using System.Collections.Generic;

namespace GameOfLife.GameObjects
{
    public class Cell
    {
        private readonly int _x;
        private readonly int _y;

        public Cell(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public Cell[] Process(Cell[] currentGeneration)
        {
            var nextGeneration = new List<Cell>();

            var numberOfAliveNeighbours = GetNumberOfAliveNeighbours(this, currentGeneration);

            if (numberOfAliveNeighbours == 2 || numberOfAliveNeighbours == 3)
            {
                nextGeneration.Add(this);
            }

            IterateOverNeighbours(this, (neighbour) =>
            {
                if (GetNumberOfAliveNeighbours(neighbour, currentGeneration) == 3)
                {
                    nextGeneration.Add(neighbour);
                }
            });

            return nextGeneration.ToArray();
        }

        private uint GetNumberOfAliveNeighbours(Cell cell, IList<Cell> currentGeneration)
        {
            uint counter = 0;

            IterateOverNeighbours(cell, (neighbour) =>
            {
                if (currentGeneration.Contains(neighbour))
                {
                    counter++;
                }
            });

            return counter;
        }

        private void IterateOverNeighbours(Cell cell, Action<Cell> run)
        {
            for (int i = cell._x - 1; i <= cell._x + 1; i++)
            {
                for (int j = cell._y - 1; j <= cell._y + 1; j++)
                {
                    if (i == cell._x && j == cell._y)
                    {
                        continue;
                    }

                    run(new Cell(i, j));
                }
            }
        }

        #region Equality overrides

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            var p = obj as Cell;

            return (Object)p != null && p._x.Equals(_x) && p._y.Equals(_y);
        }

        public bool Equals(Cell cell)
        {
            return (object)cell != null && cell._x.Equals(_x) && cell._y.Equals(_y);
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("({0}, {1})", _x, _y);
        }

        public static bool operator ==(Cell a, Cell b)
        {
            if (ReferenceEquals(a, b))
            {
                return true;
            }

            if (((object)a == null) || ((object)b == null))
            {
                return false;
            }

            return a._x.Equals(b._x) && a._y.Equals(b._y);
        }

        public static bool operator !=(Cell a, Cell b)
        {
            return !(a == b);
        }

        #endregion
    }
}
