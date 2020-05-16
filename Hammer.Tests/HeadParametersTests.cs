using Hammer.MODEL.Models;
using NUnit.Framework;

namespace Hammer.Tests
{
    [TestFixture]
    public class HeadParametersTests
    {
        //[Test(Description = "Негативный тест HeadLength")]
        //public void SetHeadLength_NegativeTest(double headLength)
        //{

        //    Assert.Throws<ArgumentException>(() => { _hammerParameters.HeadParameters.Length = headLength; }, "Должно возникать исключение");
            
            
            
        //    //var headParameters = new HeadParameters();
        //    //Assert.Throws<ArgumentException>(() => headParameters.Length = headLength);
        //    //Assert.AreEqual(headLength, 10);
        //}

        [Test]
        [TestCase(30, TestName = "Позитивный тест длины оголовья 30")]
        [TestCase(70, TestName = "Позитивный тест длины огловья 70")]
        public void SetHeadLength_PositiveTest(double headLength)
        {
            new HeadParameters {Length = headLength};
        }

        [Test]
        [TestCase(30, TestName = "Позитивный тест ширины оголовья 30")]
        [TestCase(50, TestName = "Позитивный тест ширины огловья 50")]
        public void SetHeadWidth_PositiveTest(double headWidth)
        {
            new HeadParameters {Width = headWidth};
        }

        [Test]
        [TestCase(25, TestName = "Позитивный тест высоты оголовья 25")]
        [TestCase(45, TestName = "Позитивный тест длины огловья 45")]
        public void SetHeadHeight_PositiveTest(double headHeight)
        {
            new HeadParameters {Height = headHeight};
        }

        [Test]
        [TestCase(1, TestName = "Позитивный тест ширины наконечника 1")]
        [TestCase(7, TestName = "Позитивный тест ширины наконечника 7")]
        public void SetTipWidth_PositiveTest(double tipWidth)
        {
            new HeadParameters {TipWidth = tipWidth};
        }

        [Test]
        [TestCase(30, TestName = "Позитивный тест длины наконечника 30")]
        [TestCase(60, TestName = "Позитивный тест длины наконечника 60")]
        public void SetToeLength_PositiveTest(double toeLength)
        {
            new HeadParameters {ToeLength = toeLength};
        }

        [Test]
        [TestCase(20, TestName = "Позитивный тест диаметра рукояти 20")]
        [TestCase(30, TestName = "Позитивный тест длины огловья 30")]
        public void SetHandleDiameter_PositiveTest(double handleDiameter)
        {
            new HandleParameters {Diameter = handleDiameter};
        }

        [Test]
        [TestCase(100, TestName = "Позитивный тест длины рукояти 100")]
        [TestCase(180, TestName = "Позитивный тест длины огловья 180")]
        public void SetHandleLength_PositiveTest(double handleLength)
        {
            new HandleParameters {Length = handleLength};
        }

    }
}