using GameOfLife.GameObjects;
using NUnit.Framework;

namespace GameOfLife.Tests
{
    [TestFixture]
    public class SpaceshipTests
    {
        [Test]
        public void GivenAnIntialSeedOfAGliderWhenWeHaveMoreThanOneIterationThenTheGliderWillMove()
        {
            var seed = new[] 
            {
                new Cell(5, 6),
                new Cell(6, 5),
                new Cell(4, 4),
                new Cell(5, 4),
                new Cell(6, 4)
            };

            var engine = new Engine(seed);

            var firstGeneration = engine
                .GetNextGeneration();

            var secondGeneration = engine
                .GetNextGeneration();

            var thirdGeneration = engine
                .GetNextGeneration();

            var fourthGeneration = engine
                .GetNextGeneration();

            var fifthGeneration = engine
                .GetNextGeneration();

            Assert.AreEqual(5, firstGeneration.Length);

            Assert.AreEqual(new Cell(4, 5), firstGeneration[0]);
            Assert.AreEqual(new Cell(6, 5), firstGeneration[1]);
            Assert.AreEqual(new Cell(5, 4), firstGeneration[2]);
            Assert.AreEqual(new Cell(5, 3), firstGeneration[3]);
            Assert.AreEqual(new Cell(6, 4), firstGeneration[4]);

            Assert.AreEqual(5, secondGeneration.Length);

            Assert.AreEqual(new Cell(4, 4), secondGeneration[0]);
            Assert.AreEqual(new Cell(6, 5), secondGeneration[1]);
            Assert.AreEqual(new Cell(6, 4), secondGeneration[2]);
            Assert.AreEqual(new Cell(6, 3), secondGeneration[3]);
            Assert.AreEqual(new Cell(5, 3), secondGeneration[4]);

            Assert.AreEqual(5, thirdGeneration.Length);

            Assert.AreEqual(new Cell(5, 3), thirdGeneration[0]);
            Assert.AreEqual(new Cell(5, 5), thirdGeneration[1]);
            Assert.AreEqual(new Cell(6, 4), thirdGeneration[2]);
            Assert.AreEqual(new Cell(7, 4), thirdGeneration[3]);
            Assert.AreEqual(new Cell(6, 3), thirdGeneration[4]);

            Assert.AreEqual(5, fourthGeneration.Length);

            Assert.AreEqual(new Cell(5, 3), fourthGeneration[0]);
            Assert.AreEqual(new Cell(6, 3), fourthGeneration[1]);
            Assert.AreEqual(new Cell(6, 5), fourthGeneration[2]);
            Assert.AreEqual(new Cell(7, 3), fourthGeneration[3]);
            Assert.AreEqual(new Cell(7, 4), fourthGeneration[4]);

            Assert.AreEqual(5, fifthGeneration.Length);

            Assert.AreEqual(new Cell(5, 4), fifthGeneration[0]);
            Assert.AreEqual(new Cell(6, 2), fifthGeneration[1]);
            Assert.AreEqual(new Cell(6, 3), fifthGeneration[2]);
            Assert.AreEqual(new Cell(7, 4), fifthGeneration[3]);
            Assert.AreEqual(new Cell(7, 3), fifthGeneration[4]);
        }
    }
}
