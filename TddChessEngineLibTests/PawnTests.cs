using System;
using TddChessEngineLib;
using Xunit;

namespace TddChessEngineLibTests
{
    public class PawnTests
    {
        const string startPosition = "E2";
        const string finalPosition = "E4";

        [Fact]
        public void WhenWhitePawnTurnsFromE2ToE4_ThenItsPositionsChanges()
        {
            Pawn pawn = new Pawn(startPosition, FigureColor.White);
            pawn.Turn(startPosition, finalPosition);
            Assert.Equal(finalPosition, pawn.CurrentPosition);
        }

        [Fact]
        public void WhenBlackPawnTriesGoBack_ThenItCantGoBack()
        {
            Pawn pawn = new Pawn(startPosition, FigureColor.Black);           
            pawn.Turn(startPosition, finalPosition);
            Assert.Equal(finalPosition, pawn.CurrentPosition);
        }
    }
}
