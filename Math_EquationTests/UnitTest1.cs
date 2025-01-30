using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Math_EquationTests
{
    [TestClass()]
    public class Math_EquationTests
    {
        [TestMethod()]
        public void QuadraticEquationTest()
        {
            var result = Math_Equation.SolveQuadraticEquation(21, 5, 1);
            Assert.AreEqual(6, result.x1);
            Assert.AreEqual(2, result.x2);
        }
    }
}
