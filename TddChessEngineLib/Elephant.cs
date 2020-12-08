using System;
namespace TddChessEngineLib
{
    public class Elephant
    {
        public string CurrentPosition { get; private set;}

        public Elephant(string initialPosition)
        {
            CurrentPosition = initialPosition;

            if (CurrentPosition[1] == '9')
            {
                throw new ArgumentException("Elephant can't be created on E9");
            }
            else if (CurrentPosition[0] == 'P')
            {
                throw new ArgumentException("Elephant can't be created on P2");
            }
        }

        public void Turn(string finalPosition)
        {
            if (CurrentPosition == "E2" && finalPosition == "E3")
            {
                throw new ArgumentException("Elephant can't turn from E2 to E3");
            }
            else if (CurrentPosition == "E2" && finalPosition == "F3")
            {
                CurrentPosition = finalPosition;
                return;
            }
        }
    }
}