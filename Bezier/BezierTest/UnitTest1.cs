using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BezierVector;
using BezierFormula;
using Program;

namespace BezierTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BezierFormulaTest()
        {
            var B = new Bezier();
            float t1 = 0.9f;
            float t2 = 0.3f;
            var p0 = new Vector(1.0f, 1.0f);
            var p1 = new Vector(3.0f, 6.0f);
            var p2 = new Vector(6.0f, 3.0f);
            var p3 = new Vector(7.0f, 7.0f);

            var b1 = B.BezierFormula(p0, p1, p2, p3, t1);
            var b2 = B.BezierFormula(p0, p1, p2, p3, t2);
            //var actual = Calc.Add(b1.y, b2.y);
            var i = 0;
            var expected = 1;
            if (b1.y > b2.y) i++;
            Assert.AreEqual(expected, i);
        }
    }
}
