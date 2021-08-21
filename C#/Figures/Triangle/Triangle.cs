using System;
using System.Linq;

namespace Figures
{
    public class Triangle : ITriangle
    {
        #region Public Fields

        /// <summary>
        /// Первая сторона
        /// </summary>
        public double FirstSide { get; private set; }

        /// <summary>
        /// Вторая сторона
        /// </summary>
        public double SecondSide { get; private set; }

        /// <summary>
        /// Третья сторона
        /// </summary>
        public double ThirdSide { get; private set; }

        /// <summary>
        /// Флаг, показывающий, является ли треугольник прямоугольным
        /// </summary>
        public bool IsRectangular { get; private set; }

        #endregion

        #region Constructors
        public Triangle(in double firstSide, in double secondSide, in double thirdSide)
        {
            if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
                throw new ArgumentOutOfRangeException("Сторона не может быть отрицательной или нулевой");

            if ((firstSide + secondSide <= thirdSide) ||
                (firstSide + thirdSide <= secondSide) ||
                (secondSide + thirdSide <= firstSide))
                throw new ArgumentException("Сумма длин двух сторон меньше либо равна длине третьей стороны");

            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;

            IsRectangular = CheckRectangular();
        }

        #endregion

        #region Public Methods
        
        /// <summary>
        /// Вычисление площади по формуле Герона
        /// </summary>
        public double CalculateSquare()
        {
            double semiPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - FirstSide) * (semiPerimeter - SecondSide) * (semiPerimeter - ThirdSide));
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Проверка на то, является ли треугольник прямоугольным
        /// </summary>
        private bool CheckRectangular()
        {
            double presumedHypotenuse = new[] { FirstSide, SecondSide, ThirdSide }.Max();
            double presumedHypotenuseSqr = presumedHypotenuse * presumedHypotenuse;
            return (presumedHypotenuseSqr == FirstSide * FirstSide + SecondSide * SecondSide) || 
                    (presumedHypotenuseSqr == FirstSide * FirstSide + ThirdSide * ThirdSide) ||
                    (presumedHypotenuseSqr == ThirdSide * ThirdSide + SecondSide * SecondSide);
        }

        #endregion
    }
}