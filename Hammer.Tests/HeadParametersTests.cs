using Hammer.MODEL.Models;
using NUnit.Framework;

namespace Hammer.Tests
{
    [TestFixture]
    public class HeadParametersTests
    {

        //    Я не могу понять, как написать тесты на негативные параметры, если их проверка происходит только при нажатии кнопки "Build" в MainForm
        //    А валидация вынесена отдельным классом.

        //[Test]
        //[TestCase(10, TestName = "Негативный тест длины оголовья")]
        //[TestCase(90, TestName = "Негативный тест длины оголовья")]
        //public void SetHeadLength_NegativeTest(double headLength)
        //{
        //    var headParameters = new HeadParameters();



        //    Assert.Throws<ArgumentException>(() => headParameters.Length = headLength);
        //}

        [Test]
        [TestCase(30, TestName = "Позитивный тест установки длины оголовья 30")]
        [TestCase(70, TestName = "Позитивный тест установки длины огловья 70")]
        public void SetHeadLength_PositiveTest(double headLength)
        {
            new HeadParameters {Length = headLength};
        }

        [Test]
        [TestCase(30, TestName = "Позитивный тест установки ширины оголовья 30")]
        [TestCase(50, TestName = "Позитивный тест установки ширины огловья 50")]
        public void SetHeadWidth_PositiveTest(double headWidth)
        {
            new HeadParameters {Width = headWidth};
        }

        [Test]
        [TestCase(25, TestName = "Позитивный тест установки высоты оголовья 25")]
        [TestCase(45, TestName = "Позитивный тест установки длины огловья 45")]
        public void SetHeadHeight_PositiveTest(double headHeight)
        {
            new HeadParameters {Height = headHeight};
        }

        [Test]
        [TestCase(1, TestName = "Позитивный тест установки ширины наконечника 1")]
        [TestCase(7, TestName = "Позитивный тест установки ширины наконечника 7")]
        public void SetTipWidth_PositiveTest(double tipWidth)
        {
            new HeadParameters {TipWidth = tipWidth};
        }

        [Test]
        [TestCase(30, TestName = "Позитивный тест установки длины наконечника 30")]
        [TestCase(60, TestName = "Позитивный тест установки длины наконечника 60")]
        public void SetToeLength_PositiveTest(double toeLength)
        {
            new HeadParameters {ToeLength = toeLength};
        }

        [Test]
        [TestCase(20, TestName = "Позитивный тест установки диаметра рукояти 20")]
        [TestCase(30, TestName = "Позитивный тест установки длины огловья 30")]
        public void SetHandleDiameter_PositiveTest(double handleDiameter)
        {
            new HandleParameters {Diameter = handleDiameter};
        }

        [Test]
        [TestCase(100, TestName = "Позитивный тест установки длины рукояти 100")]
        [TestCase(180, TestName = "Позитивный тест установки длины огловья 180")]
        public void SetHandleLength_PositiveTest(double handleLength)
        {
            new HandleParameters {Length = handleLength};
        }

    }
}