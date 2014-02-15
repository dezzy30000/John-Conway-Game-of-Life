using GameOfLife.GameObjects;
using NUnit.Framework;
using System.Linq;

namespace GameOfLife.Tests
{
    public class OscillatorTests
    {
        [Test]
        public void GivenAnInitialSeedOfABlinkerWhenWeHaveMoreThanOneIterationThenWeHaveAnOscilatingBlinker()
        {
            var seed = new[] 
            {
                new Cell(4, 4),
                new Cell(5, 4),
                new Cell(6, 4)
            };

            var engine = new Engine(seed);

            var firstGeneration = engine
                .GetNextGeneration();

            var secondGeneration = engine
                .GetNextGeneration();

            Assert.AreEqual(3, firstGeneration.Length);

            Assert.AreEqual(new Cell(5, 3), firstGeneration[0]);
            Assert.AreEqual(new Cell(5, 5), firstGeneration[1]);
            Assert.AreEqual(new Cell(5, 4), firstGeneration[2]);

            Assert.AreEqual(3, secondGeneration.Length);

            foreach (var cell in secondGeneration)
            {
                Assert.IsTrue(seed.Contains(cell));
            }
        }

        [Test]
        public void GivenAnInitialSeedOfAToadWhenWeHaveMoreThanOneIterationThenWeHaveAnOscilatingToad()
        {
            var seed = new[] 
            {
                new Cell(4, 4),
                new Cell(5, 4),
                new Cell(6, 4),
                new Cell(5, 5),
                new Cell(6, 5),
                new Cell(7, 5)
            };

            var engine = new Engine(seed);

            var firstGeneration = engine
                .GetNextGeneration();

            var secondGeneration = engine
                .GetNextGeneration();

            Assert.AreEqual(6, firstGeneration.Length);

            Assert.AreEqual(new Cell(4, 4), firstGeneration[0]);
            Assert.AreEqual(new Cell(4, 5), firstGeneration[1]);
            Assert.AreEqual(new Cell(5, 3), firstGeneration[2]);
            Assert.AreEqual(new Cell(7, 4), firstGeneration[3]);
            Assert.AreEqual(new Cell(6, 6), firstGeneration[4]);
            Assert.AreEqual(new Cell(7, 5), firstGeneration[5]);

            Assert.AreEqual(6, secondGeneration.Length);

            foreach (var cell in secondGeneration)
            {
                Assert.IsTrue(seed.Contains(cell));
            }
        }

        [Test]
        public void GivenAnInitialSeedOfABeaconWhenWeHaveMoreThanOneIterationThenWeHaveAnOscilatingBeacon()
        {
            var seed = new[] 
            {
                new Cell(4, 4),
                new Cell(5, 4),
                new Cell(4, 3),
                new Cell(7, 2),
                new Cell(7, 1),
                new Cell(6, 1)
            };

            var engine = new Engine(seed);

            var firstGeneration = engine
                .GetNextGeneration();

            var secondGeneration = engine
                .GetNextGeneration();

            Assert.AreEqual(8, firstGeneration.Length);

            Assert.AreEqual(new Cell(4, 4), firstGeneration[0]);
            Assert.AreEqual(new Cell(5, 3), firstGeneration[1]);
            Assert.AreEqual(new Cell(5, 4), firstGeneration[2]);
            Assert.AreEqual(new Cell(4, 3), firstGeneration[3]);
            Assert.AreEqual(new Cell(7, 2), firstGeneration[4]);
            Assert.AreEqual(new Cell(6, 2), firstGeneration[5]);
            Assert.AreEqual(new Cell(7, 1), firstGeneration[6]);
            Assert.AreEqual(new Cell(6, 1), firstGeneration[7]);

            Assert.AreEqual(6, secondGeneration.Length);

            foreach (var cell in secondGeneration)
            {
                Assert.IsTrue(seed.Contains(cell));
            }
        }
    }
}
