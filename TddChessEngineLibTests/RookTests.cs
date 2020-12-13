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
    }
}