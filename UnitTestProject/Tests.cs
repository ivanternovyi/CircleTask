using System;
using NUnit.Framework;
using TaskApp;

namespace UnitTestProject
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void LiesInFirstQuaterTestTrue()
        {
            //Arrange
            Circle testCircle = new Circle(2, 2, 1);
            //Act
            bool actual = testCircle.LiesInFirstQuater();
            //Assert
            Assert.IsTrue(actual);
        }

        [Test]
        public void CalculateSquareTest()
        {
            Circle testCircle = new Circle(2, 2, 1);
            double supposition = Math.PI * 1 * 1;
            double rez = testCircle.CalculateSquare();
            Assert.AreEqual(rez, supposition);
        }

        [Test]
        public void CompareToTest()
        {
            Circle testCircle1 = new Circle(2, 2, 1);
            Circle testCircle2 = new Circle(2, 2, 2);
            int rez = testCircle1.CompareTo(testCircle2);
            Assert.AreEqual(rez, 1);
        }

        [Test]
        public void CalculateLengthTest()
        {
            Circle testCircle = new Circle(2, 2, 1);
            int testR = 1;
            double supposition = 2 * Math.PI * testR;
            double rez = testCircle.CalculateLength();
            Assert.AreEqual(rez, supposition);
        }

        [Test]
        public void IsInterceptedTestTrue()
        {
            Circle testCircle1 = new Circle(2, 2, 3);
            Circle testCircle2 = new Circle(2, 4, 3);
            bool rez = testCircle1.IsIntercepted(testCircle2);
            Assert.IsTrue(rez);
        }
    }
}