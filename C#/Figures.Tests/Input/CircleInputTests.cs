using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Figures.Tests.Input
{
    public class CircleInputTests
    {
        /// <summary>
        /// Тест проверяет, что круг создаётся корректно
        /// </summary>
        [TestMethod]
        public void Circle_StandardRadius_True()
        {
            double radius = 3.0;

            Circle circle = new Circle(radius);

            Assert.AreEqual(radius, circle.Radius, "Некорректно присвоено значение радиусу окружности");
        }

        /// <summary>
        /// Тест проверяет, что исключение срабатывает, 
        /// если попытаться создать окружность с отрицательным значением радиуса
        /// </summary>
        [TestMethod]
        public void Circle_NegativeRadius_False()
        {
            double radius = -1.0;
            try
            {
                Circle circle = new Circle(radius);
                Assert.Fail("Должно сработать исключение");
            }
            catch (ArgumentOutOfRangeException aore)
            { }
        }

        /// <summary>
        /// Тест проверяет, что исключение срабатывает, 
        /// если попытаться создать окружность с нулевым значением радиуса
        /// </summary>
        [TestMethod]
        public void Circle_ZeroRadius_False()
        {
            double radius = 0.0;

            try
            {
                Circle circle = new Circle(radius);
                Assert.Fail("Должно сработать исключение");
            }
            catch (ArgumentOutOfRangeException aore)
            { }
        }
    }
}
