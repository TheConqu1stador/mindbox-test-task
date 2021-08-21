using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Figures.Tests.Input
{
    [TestClass]
    public class TriangleInputTests
    {
        /// <summary>
        /// Тест проверяет, что треугольник создаётся корректно
        /// </summary>
        [TestMethod]
        public void Triangle_StandardSides_True()
        {
            double firstSide = 4.0;
            double secondSide = 5.0;
            double thirdSide = 6.0;

            Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);

            Assert.AreEqual(firstSide, triangle.FirstSide, "Некорректно присвоено значение первой стороне треугольника");
            Assert.AreEqual(secondSide, triangle.SecondSide, "Некорректно присвоено значение второй стороне треугольника");
            Assert.AreEqual(thirdSide, triangle.ThirdSide, "Некорректно присвоено значение третьей стороне треугольника");
        }

        /// <summary>
        /// Тест проверяет правильность идентификации треугольника как прямоугольного (положительный сценарий)
        /// </summary>
        [TestMethod]
        public void Triangle_CreateRectangularTriangle_True()
        {
            double firstSide = 3.0;
            double secondSide = 4.0;
            double thirdSide = 5.0;

            Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);

            Assert.AreEqual(true, triangle.IsRectangular, "Некорретно выставлен флаг, показывающий, является ли треугольник прямоугольным");
        }

        /// <summary>
        /// Тест проверяет правильность идентификации треугольника как прямоугольного (отрицательный сценарий)
        /// </summary>
        [TestMethod]
        public void Triangle_CreateRectangularTriangle_False()
        {
            double firstSide = 4.0;
            double secondSide = 5.0;
            double thirdSide = 6.0;

            Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);

            Assert.AreEqual(false, triangle.IsRectangular, "Некорретно выставлен флаг, показывающий, является ли треугольник прямоугольным");
        }

        /// <summary>
        /// Тест проверяет, что исключение срабатывает, 
        /// если попытаться создать треугольник с отрицательным значением длин сторон
        /// </summary>
        [TestMethod]
        public void Triangle_NegativeSides_False()
        {
            double firstSide = -1.0;
            double secondSide = -2.0;
            double thirdSide = -3.0;

            try
            {
                Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);
                Assert.Fail("Должно сработать исключение");
            }
            catch (ArgumentOutOfRangeException aore)
            { }
        }

        /// <summary>
        /// Тест проверяет, что исключение срабатывает, 
        /// если попытаться создать треугольник с нулевым значением длин сторон
        /// </summary>
        [TestMethod]
        public void Triangle_ZeroSides_False()
        {
            double firstSide = 0.0;
            double secondSide = 0.0;
            double thirdSide = 0.0;

            try
            {
                Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);
                Assert.Fail("Должно сработать исключение");
            }
            catch (ArgumentOutOfRangeException aore)
            { }
        }

        /// <summary>
        /// Тест проверяет, что исключение срабатывает, 
        /// если попытаться создать треугольник, у которого длина одной стороны больше либо равна 
        /// сумме длин двух других сторон
        /// </summary>
        [TestMethod]
        public void Triangle_OneSideBiggerThanSumOfElse_False()
        {
            try
            {
                Triangle triangle = new Triangle(2, 3, 6);
                Assert.Fail("Должно сработать исключение");
            }
            catch (ArgumentException ae)
            { }
        }
    }
}
