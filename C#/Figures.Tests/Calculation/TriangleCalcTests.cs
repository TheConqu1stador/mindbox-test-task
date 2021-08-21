using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Figures.Tests.Calculation
{
    [TestClass]
    public class TriangleCalcTests
    {
        /// <summary>
        /// Тест проверяет корректность вычисления площади треугольника
        /// </summary>
        [TestMethod]
        public void Triangle_CalcSquare_True()
        {
            double firstSide = 3.0;
            double secondSide = 4.0;
            double thirdSide = 5.0;

            double expectedSquare = 6.0;

            Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);

            Assert.AreEqual(expectedSquare, triangle.CalculateSquare(), "Площадь вычислена неверно");
        }
    }
}
