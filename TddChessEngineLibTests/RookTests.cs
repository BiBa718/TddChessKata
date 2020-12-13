using System;
using Xunit;
using TddChessEngineLib;

namespace TddChessEngineLibTests
{
    public class RookTests
    {
        string startPosition;

        [Fact]
        public void WhenRookCreatedOnA1_ThenItCreated()
        {
            startPosition = "A1";
            Assert.Equal(startPosition, new Rook(startPosition).CurrentPosition);
        }

        [Fact]
        public void WhenRookCreatedOnA9_ThenItThrowExeption()
        {
            startPosition = "A9";
            Assert.Throws<ArgumentException>(() => new Rook(startPosition).CurrentPosition);
        }

        [Fact]
        public void WhenRookCreatedOnP1_ThenItThrowExeption()
        {
            startPosition = "P1";
            Assert.Throws<ArgumentException>(() => new Rook(startPosition).CurrentPosition);
        }
    }
}