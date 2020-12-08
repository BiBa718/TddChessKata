using System;
using Xunit;
using TddChessEngineLib;

namespace TddChessEngineLibTests
{
    public class ElephantTests
    {
        string startPosition;

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
            
        }
    }
}