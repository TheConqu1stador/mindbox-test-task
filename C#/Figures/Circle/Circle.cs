using System;

namespace Figures
{
    public class Circle : ICircle
    {
        #region Public Fields
        /// <summary>
        /// Радиус окружности
        /// </summary>
        public double Radius { get; private set; }

        #endregion

        #region Constructors
        public Circle(in double radius)
        {
            if (radius <= 0)
                throw new ArgumentOutOfRangeException("Радиус не может быть отрицательным или равным нулю");

            Radius = radius;
        }

        #endregion

        #region Public Methods

        public double CalculateSquare()
        {
            return Math.PI * Radius * Radius;
        }

        #endregion
    }
}
