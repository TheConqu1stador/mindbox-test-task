using Figures.Common;

namespace Figures
{
    /// <summary>
    /// Интерфейс треугольника, в котором описаны основные свойства фигуры
    /// Наследуется от IFigure
    /// </summary>
    public interface ITriangle : IFigure
    {
        /// <summary>
        /// Первая сторона
        /// </summary>
        public double FirstSide { get; }

        /// <summary>
        /// Вторая сторона
        /// </summary>
        public double SecondSide { get; }

        /// <summary>
        /// Третья сторона
        /// </summary>
        public double ThirdSide { get; }

        /// <summary>
        /// Флаг, показывающий, является ли треугольник прямоугольным
        /// </summary>
        public bool IsRectangular { get; }
    }
}
