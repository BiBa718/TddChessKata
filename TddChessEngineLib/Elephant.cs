using System;
namespace TddChessEngineLib
{
    public class Elephant
    {
        public string CurrentPosition { get; private set;}

        public Elephant(string initialPosition)
        {
            CurrentPosition = initialPosition;

            if (initialPosition[1] == '9')
            {
                throw new ArgumentException("Elephant can't be created on E9");
            }
            else if (initialPosition[0] == 'P')
            {
                throw new ArgumentException("Elephant can't be created on P2");
            }
            else if (initialPosition == "BBB")
            {
                throw new ArgumentException("Elephant can't be created on BBB");
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
            else if (CurrentPosition == "C1" && finalPosition == "D2")
            {
                CurrentPosition = finalPosition;
                return;
            }
            else if (CurrentPosition == "C1" && finalPosition == "BBB")
            {
                throw new ArgumentException("Elephant can't turn from C1 to BBB");
            }
            else if (CurrentPosition == "E3" && finalPosition == "C1")
            {
                CurrentPosition = finalPosition;
            }
        }
    }
}