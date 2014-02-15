using GameOfLife.GameObjects;
using NUnit.Framework;
using System.Linq;

namespace GameOfLife.Tests
{
    [TestFixture]
    public class StillLifeTests
    {
        [Test]
        public void GivenAnInitialSeedOfABlockWhenWeHaveMoreThanOneIterationThenWeStillHaveABlock()
        {
            var seed = new[] 
            {
                new Cell(4, 4),
                new Cell(5, 4),
                new Cell(4, 5),
                new Cell(5, 5)
            };

            var engine = new Engine(seed);

            var firstGeneration = engine
                .GetNextGeneration();

            var secondGeneration = engine
                .GetNextGeneration();

            Assert.AreEqual(4, firstGeneration.Length);

            foreach (var cell in firstGeneration)
            {
                Assert.IsTrue(seed.Contains(cell));
            }

            Assert.AreEqual(4, secondGeneration.Length);

            foreach (var cell in secondGeneration)
            {
                Assert.IsTrue(seed.Contains(cell));
            }
        }

        [Test]
        public void GivenAnInitialSeedOfABeehiveWhenWeHaveMoreThanOneIterationThenWeStillHaveABeehive()
        {
            var seed = new[] 
            {
                new Cell(4, 4),
                new Cell(5, 5),
                new Cell(6, 5),
                new Cell(7, 4),
                new Cell(5, 3),
                new Cell(6, 3)
            };

            var engine = new Engine(seed);

            var firstGeneration = engine
                .GetNextGeneration();

            var secondGeneration = engine
                .GetNextGeneration();

            Assert.AreEqual(6, firstGeneration.Length);

            foreach (var cell in firstGeneration)
            {
                Assert.IsTrue(seed.Contains(cell));
            }

            Assert.AreEqual(6, secondGeneration.Length);

            foreach (var cell in secondGeneration)
            {
                Assert.IsTrue(seed.Contains(cell));
            }
        }

        [Test]
        public void GivenAnInitialSeedOfALoafWhenWeHaveMoreThanOneIterationThenWeStillHaveALoaf()
        {
            var seed = new[] 
            {
                new Cell(4,4),
                new Cell(5,5),
                new Cell(6,5),
                new Cell(7,4),
                new Cell(7,3),
                new Cell(6,2),
                new Cell(5,3)
            };

            var engine = new Engine(seed);

            var firstGeneration = engine
                .GetNextGeneration();

            var secondGeneration = engine
                .GetNextGeneration();

            Assert.AreEqual(7, firstGeneration.Length);

            foreach (var cell in firstGeneration)
            {
                Assert.IsTrue(seed.Contains(cell));
            }

            Assert.AreEqual(7, secondGeneration.Length);

            foreach (var cell in secondGeneration)
            {
                Assert.IsTrue(seed.Contains(cell));
            }
        }

        [Test]
        public void GivenAnInitialSeedOfABoatWhenWeHaveMoreThanOneIterationThenWeStillHaveABoat()
        {
            var seed = new[] 
            {
                new Cell(4,4),
                new Cell(5,4),
                new Cell(4,3),
                new Cell(5,2),
                new Cell(6,3)
            };

            var engine = new Engine(seed);

            var firstGeneration = engine
                .GetNextGeneration();

            var secondGeneration = engine
                .GetNextGeneration();

            Assert.AreEqual(5, firstGeneration.Length);

            foreach (var cell in firstGeneration)
            {
                Assert.IsTrue(seed.Contains(cell));
            }

            Assert.AreEqual(5, secondGeneration.Length);

            foreach (var cell in secondGeneration)
            {
                Assert.IsTrue(seed.Contains(cell));
            }
        }
    }
}
