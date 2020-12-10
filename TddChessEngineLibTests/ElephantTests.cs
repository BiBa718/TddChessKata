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
            Assert.Throws<ArgumentException>(() => new Elephant(startPosition).CurrentPosition);
        }

        [Fact]
        public void WhenTryCreatingElephantOnP2_ThenItThrowsArgumentException()
        {
            startPosition = "P2";
            Assert.Throws<ArgumentException>(() => new Elephant(startPosition).CurrentPosition);
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
            finalPosition = "F3";
            Elephant el = new Elephant(startPosition);
            el.Turn(finalPosition);
            Assert.Equal(finalPosition, el.CurrentPosition);
        }

        [Fact]
        public void WhenCreatingElephantOnC1_ThenItCurrentPositionOnC1()
        {
            startPosition = "C1";
            Elephant el = new Elephant(startPosition);
            Assert.Equal(startPosition, el.CurrentPosition);
        }

        [Fact]
        public void WhenCreatingElephantOnBBB_ThenItThrowsArgumentException()
        {
            startPosition = "BBB";
            Assert.Throws<ArgumentException>(() => new Elephant(startPosition).CurrentPosition);
        }

        [Fact]
        public void WhenElephantTurnsFromC1ToD2_ThenItChangesCurrentPosition()
        {
            startPosition = "C1";
            finalPosition = "D2";
            Elephant el = new Elephant(startPosition);
            el.Turn(finalPosition);
            Assert.Equal(finalPosition, el.CurrentPosition);
        }

        [Fact]
        public void WhenElephantTurnsFromC1ToBBB_ThenItThrowsArgumentExceptiona()
        {
            startPosition = "C1";
            finalPosition = "BBB";
            Elephant el = new Elephant(startPosition);
            Assert.Throws<ArgumentException>(() => el.Turn(finalPosition));
        }

        [Fact]
        public void WhenElephantTurnFromE3ToC1_ThenItChangesCurrentPosition()
        {
            startPosition = "E3";
            finalPosition = "C1";
            Elephant el = new Elephant(startPosition);
            el.Turn(finalPosition);
            Assert.Equal(finalPosition, el.CurrentPosition);
        }
    }
}