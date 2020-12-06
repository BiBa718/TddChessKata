using System;
namespace TddChessEngineLib
{
    public class Elephant
    {
        public string CurrentPosition { get; private set;}

        public Elephant(string initialPosition)
        {
            CurrentPosition = initialPosition;
        }

        public void Turn(string startPosition)
        {
            CurrentPosition = startPosition;

            if (startPosition == "E9")
            {
                throw new ArgumentException("Elephant can't be created on E9");
            }
        }
    }
}