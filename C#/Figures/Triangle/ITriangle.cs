using Figures.Common;

namespace Figures
{
    public interface ITriangle : IFigure
    {
        public double FirstSide { get; }
        public double SecondSide { get; }
        public double ThirdSide { get; }
        public bool IsRectangular { get; }
    }
}
