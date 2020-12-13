using System;
namespace TddChessEngineLib
{
    public class Rook
    {
        public string CurrentPosition {get; private set;}

        public Rook(string initialPosiotion)
        {
            CurrentPosition = initialPosiotion;

            if (initialPosiotion[1] == '9')
            {
                throw new ArgumentException("Rook can't be created on position with 9");
            }
            else if (initialPosiotion[0] == 'P')
            {
                throw new ArgumentException("Rook can't be created on position with P");
            }
        }
    }
}