using System.Collections.Generic;
using System.Linq;

namespace GameOfLife.GameObjects
{
    public class Engine
    {
        private Cell[] _currentGeneration;

        public Engine(Cell[] seed)
        {
            _currentGeneration = seed;
        }

        public Cell[] GetNextGeneration()
        {
            IEnumerable<Cell> nextGeneration = new Cell[] { };

            foreach (var cell in _currentGeneration)
            {
                nextGeneration = nextGeneration.Union(cell.Process(_currentGeneration));
            }

            return (_currentGeneration = nextGeneration.ToArray());
        }
    }
}
