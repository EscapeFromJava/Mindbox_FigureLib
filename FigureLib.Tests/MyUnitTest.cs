using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FigureLib;

namespace FigureLib.Tests
{
    [TestClass]
    public class MyUnitTest
    {
        [TestMethod]
        public void Triangle_3_4_5returned6_isRight()
        {
            // arrange
            double edge1 = 3;
            double edge2 = 4;
            double edge3 = 5;
            double expectedArea = 6;
            bool expectedIsRight = true;

            // act
            Triangle t = new Triangle(edge1, edge2, edge3);
            double actualArea = t.getArea();
            bool actualIsRight = t.isRight();

            // assert
            Assert.AreEqual(expectedArea, actualArea);
            Assert.AreEqual(expectedIsRight, actualIsRight);
        }
    }
}
