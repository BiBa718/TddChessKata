using System;
using TddChessEngineLib;
using Xunit;

namespace TddChessEngineLibTests
{
    public class PawnTests
    {
        

        [Fact]
        public void WhenPawnTurnsFromE2ToE4_ThenItsPositionsChanges()
        {
            string startPos = "E2";
            string finalPos = "E4";
            Pawn pawn = new Pawn(startPos);

            pawn.Turn(startPos, finalPos);
            Assert.Equal(finalPos, pawn.CurrentPosition);
        }
    }
}
