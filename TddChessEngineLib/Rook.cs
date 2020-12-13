namespace TddChessEngineLib
{
    public class Rook
    {
        public string CurrentPosition {get; private set;}

        public Rook(string initialPosiotion)
        {
            CurrentPosition = initialPosiotion;
        }
    }
}