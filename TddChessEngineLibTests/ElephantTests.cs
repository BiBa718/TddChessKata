using System;
using Xunit;
using TddChessEngineLib;

namespace TddChessEngineLibTests
{
    public class ElephantTests
    {
        [Fact]
        public void WhenCreatingElephantOnE2_ThenItCurrentPositionE2()
        {
            string startPosition = "E2";
            Elephant el = new Elephant(startPosition);
            Assert.Equal(startPosition, el.CurrentPosition);
        }

        [Fact]
        public void WhenTryCreatingElephantOnE9_ThenItThrowsArgumentException()
        {
            string startPosition = "E9";
            Elephant el = new Elephant(startPosition);
            Assert.Throws<ArgumentException>(() => el.CurrentPosition);
        }
    }
}