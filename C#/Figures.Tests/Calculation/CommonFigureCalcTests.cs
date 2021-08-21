using Figures.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Figures.Tests.Calculation
{
    [TestClass]
    public class CommonFigureCalcTests
    {   
        [TestMethod]
        public void CommonFigure_CalcSquare_True()
        {
            double firstSide = 3.0;
            double secondSide = 4.0;
            double thirdSide = 5.0;

            double expectedTriangleSquare = 6.0;

            IFigure figure;

            figure = new Triangle(firstSide, secondSide, thirdSide);
            Assert.AreEqual(expectedTriangleSquare, figure.CalculateSquare(), "Площадь вычислена неверно");

            double radius = 5.0;

            double expectedCircleSquare = Math.PI * radius * radius;

            figure = new Circle(radius);
            Assert.AreEqual(expectedCircleSquare, figure.CalculateSquare(), "Площадь вычислена неверно");
        }
    }
}
