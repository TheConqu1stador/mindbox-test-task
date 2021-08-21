using Figures.Common;

namespace Figures
{
    /// <summary>
    /// Интерфейс окружности, в котором описаны основные свойства фигуры
    /// Наследуется от IFigure
    /// </summary>
    public interface ICircle : IFigure
    {
        /// <summary>
        /// Радиус окружности
        /// </summary>
        public double Radius { get; }
    }
}
