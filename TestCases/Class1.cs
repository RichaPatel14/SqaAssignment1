using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RichaAssignment1;

namespace TestCases
{
    [TestFixture]
    public class Class1
    {
       [Test]
        public void TestLength_GetLength()
        {
            int lengthOfTest = 4, widthOfTest = 5;
            Rectangle rectangle = new Rectangle(lengthOfTest, widthOfTest);
            int length = rectangle.GetLength();
            Assert.AreEqual(length, lengthOfTest);
        }

        [Test]
        public void TestLength_GetWidth()
        {
            int lengthOfTest = 4, widthOfTest = 5;
            Rectangle rectangle = new Rectangle(lengthOfTest, widthOfTest);
            int width = rectangle.GetWidth();
            Assert.AreEqual(width, widthOfTest);
        }

        [Test]
        public void TestLength_SetLength()
        {
            int lengthOfTest = 4, widthOfTest = 5;
            Rectangle rectangle = new Rectangle(lengthOfTest, widthOfTest);
            int length = rectangle.SetLength(lengthOfTest);
            Assert.AreEqual(length, lengthOfTest);
        }

        [Test]
        public void TestLength_SetWidth()
        {
            int lengthOfTest = 4, widthOfTest = 5;
            Rectangle rectangle = new Rectangle(lengthOfTest, widthOfTest);
            int width = rectangle.SetWidth(widthOfTest);
            Assert.AreEqual(width, widthOfTest);
        }

        [Test]
        public void TestLength_GetArea()
        {
            int lengthOfTest = 4, widthOfTest = 5;
            Rectangle rectangle = new Rectangle(lengthOfTest, widthOfTest);
            int area = rectangle.GetArea();
            Assert.AreEqual(area, lengthOfTest * widthOfTest);
        }

        [Test]
        public void TestLength_GetPerimeter()
        {
            int lengthOfTest = 4, widthOfTest = 5;
            Rectangle rectangle = new Rectangle(lengthOfTest, widthOfTest);
            int perimeter = rectangle.GetPerimeter();
            Assert.AreEqual(perimeter, 2 * (lengthOfTest + widthOfTest));
        }
    }
}













































































































































































































































































































































































