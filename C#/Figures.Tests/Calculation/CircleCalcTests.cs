using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Figures.Tests.Calculation
{
    [TestClass]
    public class CircleCalcTests
    {
        /// <summary>
        /// Тест проверяет корректность вычисления площади окружности
        /// </summary>
        [TestMethod]
        public void Circle_CalcSquare_True()
        {
            double radius = 3.0;

            double expectedSquare = Math.PI * radius * radius;

            Circle circle = new Circle(radius);

            Assert.AreEqual(expectedSquare, circle.CalculateSquare(), "Площадь вычислена неверно");
        }
    }
}