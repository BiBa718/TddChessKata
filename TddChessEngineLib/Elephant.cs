using System;
namespace TddChessEngineLib
{
    public class Elephant
    {
        public string CurrentPosition { get; private set;}

        public Elephant(string initialPosition)
        {
            CurrentPosition = initialPosition;

            if (CurrentPosition == "E9")
            {
                throw new ArgumentException("Elephant can't be created on E9");
            }
        }

        public void Turn(string startPosition)
        {
            CurrentPosition = startPosition;

            
        }
    }
}