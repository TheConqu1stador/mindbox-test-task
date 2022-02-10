using Figures.Common;
using System.Collections.Generic;
using System.Linq;

namespace Figures
{
    public class Process
    {
        public static double CalculateSquareSum(IReadOnlyCollection<IFigure> figures)
        {
            return figures.Sum(x => x.CalculateSquare());
        }
    }
}
