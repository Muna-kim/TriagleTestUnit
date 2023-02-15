using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Policy;
using TriangleSolver;

namespace TriangleTest
{
    [TestClass]
    public class UnitTest1
    {
        //- Only one(1) test for a valid equilateral triangle
        [TestMethod]
        public void AnalyzeTriangle_f10s10t10_EQUILATERAL()
        {
            // Arrange
            int firstSide = 10;
            int secondSide = 10;
            int thirdSide = 10;
            string output = "Based on all sides being equal, the type of triangle is an EQUILATERAL";

            // Act
            Triangle triagle = new Triangle();
            string actual = triagle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(output, actual);
        }
        
    }
}


