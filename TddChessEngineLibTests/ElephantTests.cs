using System;
using Xunit;
using TddChessEngineLib;

namespace TddChessEngineLibTests
{
    public class ElephantTests
    {
        public string startPosition;
        public string finalPosition;

        [Fact]
        public void WhenCreatingElephantOnE2_ThenItCurrentPositionE2()
        {
            startPosition = "E2";
            Elephant el = new Elephant(startPosition);
            Assert.Equal(startPosition, el.CurrentPosition);
        }

        [Fact]
        public void WhenTryCreatingElephantOnE9_ThenItThrowsArgumentException()
        {
            startPosition = "E9";
            Elephant el = new Elephant(startPosition);
            Assert.Throws<ArgumentException>(() => el.CurrentPosition);
        }

        [Fact]
        public void WhenTryCreatingElephantOnP2_ThenItThrowsArgumentException()
        {
            startPosition = "P2";
            Elephant el = new Elephant(startPosition);
            Assert.Throws<ArgumentException>(() => el.CurrentPosition);
        }

        [Fact]
        public void WhenElephantTurnFromE2ToE3_ThenItThrowsArgumentException()
        {
            startPosition = "E2";
            finalPosition = "E3";
            Assert.Throws<ArgumentException>(() => new Elephant(startPosition).Turn(finalPosition));
        }

        [Fact]
        public void WhenElephantTurnFromE2ToF3_ThenItChangesPosition()
        {
            startPosition = "E2";
            finalPosition = "E3";
            Elephant el = new Elephant(startPosition);
            el.Turn(finalPosition);
            Assert.Equal(finalPosition, el.CurrentPosition);
        }
    }
}