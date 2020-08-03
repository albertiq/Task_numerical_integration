using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task_numerical_integration.Tests
{
    [TestClass]
    public class Numerical_integrationTests
    {
        //public delegate double Function(double x);
        static double Df(double x)
        {
            return Math.Cos(x);
        }
        [TestMethod]
        public void Rectangle_method_test()
        {
            // arrange
            double a = 0;
            double b = 1;
            uint n = 10;
            double expected = Math.Round(0.863754526795013, 4);

            // act
            double actual = Numerical_methods.Rectangle_method(a, b, n, Df);
            
            // assert
            Assert.AreEqual(expected, Math.Round(actual, 4));
        }
        [TestMethod]
        public void Trapezoid_method_test()
        {
            // arrange
            double a = 0;
            double b = 1;
            uint n = 10;
            double expected = Math.Round(0.84076964208842, 4);

            // act
            double actual = Numerical_methods.Trapezoid_method(a, b, n, Df);

            // assert
            Assert.AreEqual(expected, Math.Round(actual, 4));
        }
        [TestMethod]
        public void Parabola_method_test()
        {
            // arrange
            double a = 0;
            double b = 1;
            uint n = 10;
            double expected = Math.Round(0.841471014034337, 4);

            // act
            double actual = Numerical_methods.Parabola_method(a, b, n, Df);

            // assert
            Assert.AreEqual(expected, Math.Round(actual, 4));
        }

    }
}
