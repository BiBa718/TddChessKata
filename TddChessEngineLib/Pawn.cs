using System;

namespace TddChessEngineLib
{
    public class Pawn
    {
        public string CurrentPosition {get; private set;}
        public FigureColor FigureColor {get;}

        public Pawn(string initialPosition, FigureColor figureColor)
        {
            CurrentPosition = initialPosition;
            FigureColor = figureColor;
        }

        // возможность первого хода
        // 1. Если кто-то в точке назначения
        // 2. Граница карты
        // 3. Направления
        // 4. Ввести переменную сходила ли пешка или нет
        // 5. (жива или нет)
        // 6. Длина шага 2 или 1
        public void Turn(string startPosition, string finalPosition)
        {
            CurrentPosition = finalPosition;
        }
    }

    public enum FigureColor
    {
        White,
        Black
    }
}
