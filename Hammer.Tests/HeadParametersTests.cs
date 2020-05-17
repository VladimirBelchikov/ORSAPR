using System;
using Hammer.MODEL.Parameters;
using NUnit.Framework;

namespace Hammer.Tests
{
    [TestFixture]
    public class HammerParametersTests
    {
        private const string ExceptionMessageHeadParametersWidth = "Поле ширины оголовья должно быть в пределах от 20мм до 50мм.";
        private const string ExceptionMessageHeadParametersLength = "Поле длины бойка должно быть в пределах от 30мм до 80мм.";
        private const string ExceptionMessageHeadParametersHeight = "Поле высоты бойка должно быть в пределах от 20мм до 50мм.";
        private const string ExceptionMessageHeadParametersTipWidth = "Поле ширина наконечника должно быть в пределах от 1мм до 10мм.";
        private const string ExceptionMessageHeadParametersToeLength = "Поле длины наконечника должно быть в пределах от 30мм до 80мм.";
        private const string ExceptionMessageHandleParametersDiameter = "Поле диаметра рукояти должно быть в пределах от 15мм до 40мм.";
        private const string ExceptionMessageHandleParametersLength = "Поле длины рукояти должно быть в пределах от 80мм до 200мм.";

        [Test]
        public void CheckParameters_TrueValuesHammerParameters_DoesNotThrow()
        {
            var hammerParameters = GetDefaultHammerParameters();
            var parametersValidator = new ParametersValidator(hammerParameters);

            Assert.DoesNotThrow(() => parametersValidator.CheckParameters());
        }

        [Test]
        [TestCase(10, TestName = "Поле ширины оголовья меньше нормы")]
        [TestCase(60, TestName = "Поле ширины оголовья больше нормы")]
        public void CheckParameters_FalseValueHeadParametersWidth_ThrowsArgumentException(double headParametersWidth)
        {
            var hammerParameters = GetDefaultHammerParameters();
            hammerParameters.HeadParameters.Width = headParametersWidth;
            var parametersValidator = new ParametersValidator(hammerParameters);

            Assert.That(
                Assert.Throws<ArgumentException>(() => parametersValidator.CheckParameters()).Message,
                Is.EqualTo(ExceptionMessageHeadParametersWidth));
        }



        [Test]
        [TestCase(20, TestName = "Поле длины оголовья меньше нормы")]
        [TestCase(90, TestName = "Поле длины оголовья больше нормы")]
        public void CheckParameters_FalseValueHeadParametersLength_ThrowsArgumentException(double headParametersLength)
        {
            var hammerParameters = GetDefaultHammerParameters();
            hammerParameters.HeadParameters.Length = headParametersLength;
            var parametersValidator = new ParametersValidator(hammerParameters);

            Assert.That(
                Assert.Throws<ArgumentException>(() => parametersValidator.CheckParameters()).Message,
                Is.EqualTo(ExceptionMessageHeadParametersLength));
        }

        [Test]
        [TestCase(10, TestName = "Поле высоты огловья меньше нормы")]
        [TestCase(60, TestName = "Поле высоты огловья больше нормы")]
        public void CheckParameters_FalseValueHeadParametersHeight_ThrowsArgumentException(double headParametersHeight)
        {
            var hammerParameters = GetDefaultHammerParameters();
            hammerParameters.HeadParameters.Height = headParametersHeight;
            var parametersValidator = new ParametersValidator(hammerParameters);

            Assert.That(
                Assert.Throws<ArgumentException>(() => parametersValidator.CheckParameters()).Message,
                Is.EqualTo(ExceptionMessageHeadParametersHeight));
        }

        [Test]
        [TestCase(0, TestName = "Поле ширина наконечника меньше нормы")]
        [TestCase(15, TestName = "Поле ширина наконечника больше нормы")]
        public void CheckParameters_FalseValueHeadParametersTipWidth_ThrowsArgumentException(double headParametersTipWidth)
        {
            var hammerParameters = GetDefaultHammerParameters();
            hammerParameters.HeadParameters.TipWidth = headParametersTipWidth;
            var parametersValidator = new ParametersValidator(hammerParameters);

            Assert.That(
                Assert.Throws<ArgumentException>(() => parametersValidator.CheckParameters()).Message,
                Is.EqualTo(ExceptionMessageHeadParametersTipWidth));
        }


        [Test]
        [TestCase(20, TestName = "Поле длины наконечника меньше нормы")]
        [TestCase(90, TestName = "Поле длины наконечника больше нормы")]
        public void CheckParameters_FalseValueHeadParametersToeLength_ThrowsArgumentException(double headParametersToeLength)
        {
            var hammerParameters = GetDefaultHammerParameters();
            hammerParameters.HeadParameters.ToeLength = headParametersToeLength;
            var parametersValidator = new ParametersValidator(hammerParameters);

            Assert.That(
                Assert.Throws<ArgumentException>(() => parametersValidator.CheckParameters()).Message,
                Is.EqualTo(ExceptionMessageHeadParametersToeLength));
        }

        [Test]
        [TestCase(10, TestName = "Поле диаметра рукояти меньше нормы")]
        [TestCase(50, TestName = "Поле диаметра рукояти больше нормы")]
        public void CheckParameters_FalseValueHandleParametersDiameter_ThrowsArgumentException(double handleParametersDiameter)
        {
            var hammerParameters = GetDefaultHammerParameters();
            hammerParameters.HandleParameters.Diameter = handleParametersDiameter;
            var parametersValidator = new ParametersValidator(hammerParameters);

            Assert.That(
                Assert.Throws<ArgumentException>(() => parametersValidator.CheckParameters()).Message,
                Is.EqualTo(ExceptionMessageHandleParametersDiameter));
        }

        [Test]
        [TestCase(70, TestName = "Поле длины рукояти меньше нормы")]
        [TestCase(210, TestName = "Поле длины рукояти больше нормы")]
        public void CheckParameters_FalseValueHandleParametersLength_ThrowsArgumentException(double handleParametersLength)
        {
            var hammerParameters = GetDefaultHammerParameters();
            hammerParameters.HandleParameters.Length = handleParametersLength;
            var parametersValidator = new ParametersValidator(hammerParameters);

            Assert.That(
                Assert.Throws<ArgumentException>(() => parametersValidator.CheckParameters()).Message,
                Is.EqualTo(ExceptionMessageHandleParametersLength));
        }

        private HammerParameters GetDefaultHammerParameters() =>
            new HammerParameters
            {
                Denominator = 1,
                HeadParameters = new HeadParameters
                {
                    Height = 30,
                    Length = 50,
                    Width = 30,
                    TipWidth = 5,
                    ToeLength = 50
                },

                HandleParameters = new HandleParameters
                {
                    Diameter = 25,
                    Length = 150
                }
            };
    }
}