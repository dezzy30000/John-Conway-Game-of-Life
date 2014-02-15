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
            var nextGeneration = new List<Cell>();

            foreach (var cell in _currentGeneration)
            {
                nextGeneration.AddRange(cell.Process(_currentGeneration));
            }

            _currentGeneration = nextGeneration
                .Distinct()
                .ToArray();

            return _currentGeneration;
        }
    }
}
