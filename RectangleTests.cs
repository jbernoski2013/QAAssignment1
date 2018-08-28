using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using JBQA1;

namespace JBQA1.test
{
    [TestFixture]
    class RectangleTests
    {
        [Test]
        public void setWidthTest_ExpectValue_5_5()
        {
            Rectangle r = new Rectangle();
            r.setWidth(5);
            Assert.AreEqual(5, r.getWidth(5));
        }
        [Test]
        public void setLengthTest_ExpectValue_4_5()
        {
            Rectangle r = new Rectangle();
            r.setLength(4);
            Assert.AreEqual(5, r.getLength(5));
        }

        [Test]
        public void getLengthTest_ExpectValue_4_5()
        {
            Rectangle r = new Rectangle();
            r.getLength(4);
            Assert.AreEqual(5, r.getLength(5));
        }

        [Test]
        public void getWidthTest_ExpectValue_4_5()
        {
            Rectangle r = new Rectangle();
            r.getLength(4);
            Assert.AreEqual(5, r.getWidth(5));
        }

        [Test]
        public void getPerimeterTest_ExpectValue_4_5()
        {
            Rectangle r = new Rectangle();
            r.getPerimeter(4, 5);
            Assert.AreEqual(5, r.getPerimeter(4, 5));
        }

        [Test]
        public void getAreaTest_ExpectValue_4_5()
        {
            Rectangle r = new Rectangle();
            r.getArea(4, 5);
            Assert.AreEqual(5, r.getArea(4, 5));
        }
    }
}
