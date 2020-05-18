using System;

using NUnit.Framework;

using Hammer.MODEL.Parameters;


namespace Hammer.Tests
{
    [TestFixture]
    public class HammerParametersTests
    {
        [Test]
        public void CheckParameters_TrueValuesHammerParameters_DoesNotThrow()
        {
            var hammerParameters = GetDefaultHammerParameters();
            var parametersValidator = new ParametersValidator(hammerParameters);

            Assert.DoesNotThrow(() => parametersValidator.CheckParameters());
        }

        [Test]
        [TestCase(10, TestName = "Head width less than normal")]
        [TestCase(60, TestName = "Head width more than normal")]
        public void CheckParameters_FalseValueHeadWidth_ThrowsArgumentException
            (double headParametersWidth)
        {
            var hammerParameters = GetDefaultHammerParameters();
            hammerParameters.HeadParameters.Width = headParametersWidth;
            var parametersValidator = new ParametersValidator(hammerParameters);

            Assert.That(
                Assert.Throws<ArgumentException>(() => 
	                parametersValidator.CheckParameters()).Message,
                Is.EqualTo(
	                "Head width must be in a range from 20mm up to 50mm."));
        }



        [Test]
        [TestCase(20, TestName = "Head length less than normal")]
        [TestCase(90, TestName = "Head length more than normal")]
        public void CheckParameters_FalseValueHeadLength_ThrowsArgumentException
	        (double headParametersLength)
        {
            var hammerParameters = GetDefaultHammerParameters();
            hammerParameters.HeadParameters.Length = headParametersLength;
            var parametersValidator = new ParametersValidator(hammerParameters);

            Assert.That(
                Assert.Throws<ArgumentException>(() => 
	                parametersValidator.CheckParameters()).Message,
                Is.EqualTo(
	                "Head length must be in a range from 30mm up to 80mm."));
        }

        [Test]
        [TestCase(10, TestName = "Head height less than normal")]
        [TestCase(60, TestName = "Head height more than normal")]
        public void CheckParameters_FalseValueHeadHeight_ThrowsArgumentException
	        (double headParametersHeight)
        {
            var hammerParameters = GetDefaultHammerParameters();
            hammerParameters.HeadParameters.Height = headParametersHeight;
            var parametersValidator = new ParametersValidator(hammerParameters);

            Assert.That(
                Assert.Throws<ArgumentException>(() => 
	                parametersValidator.CheckParameters()).Message,
                Is.EqualTo(
	                "Head height must be in a range from 20mm up to 50mm."));
        }

        [Test]
        [TestCase(0, TestName = "Tip width less than normal")]
        [TestCase(15, TestName = "Tip width more than normal")]
        public void CheckParameters_FalseValueTipWidth_ThrowsArgumentException
	        (double headParametersTipWidth)
        {
            var hammerParameters = GetDefaultHammerParameters();
            hammerParameters.HeadParameters.TipWidth = headParametersTipWidth;
            var parametersValidator = new ParametersValidator(hammerParameters);

            Assert.That(
                Assert.Throws<ArgumentException>(() => 
	                parametersValidator.CheckParameters()).Message,
                Is.EqualTo(
	                "Tip width must be in a range from 1mm up to 10mm."));
        }


        [Test]
        [TestCase(20, TestName = "Toe length less than normal")]
        [TestCase(90, TestName = "Toe length more than normal")]
        public void CheckParameters_FalseValueToeLength_ThrowsArgumentException
	        (double headParametersToeLength)
        {
            var hammerParameters = GetDefaultHammerParameters();
            hammerParameters.HeadParameters.ToeLength = headParametersToeLength;
            var parametersValidator = new ParametersValidator(hammerParameters);

            Assert.That(
                Assert.Throws<ArgumentException>(() => 
	                parametersValidator.CheckParameters()).Message,
                Is.EqualTo(
	                "Toe length must be in a range from 30mm up to 80mm."));
        }

        [Test]
        [TestCase(10, TestName = "Handle diameter less than normal")]
        [TestCase(50, TestName = "Handle diameter more than normal")]
        public void CheckParameters_FalseValueHandleDiameter_ThrowsArgumentException
	        (double handleParametersDiameter)
        {
            var hammerParameters = GetDefaultHammerParameters();
            hammerParameters.HandleParameters.Diameter = handleParametersDiameter;
            var parametersValidator = new ParametersValidator(hammerParameters);

            Assert.That(
                Assert.Throws<ArgumentException>(() => 
	                parametersValidator.CheckParameters()).Message,
                Is.EqualTo(
	                "Handle diameter must be in a range from 15mm up to 40mm."));
        }

        [Test]
        [TestCase(70, TestName = "Handle length less than normal")]
        [TestCase(210, TestName = "Handle length more than normal")]
        public void CheckParameters_FalseValueHandleLength_ThrowsArgumentException
	        (double handleParametersLength)
        {
            var hammerParameters = GetDefaultHammerParameters();
            hammerParameters.HandleParameters.Length = handleParametersLength;
            var parametersValidator = new ParametersValidator(hammerParameters);

            Assert.That(
                Assert.Throws<ArgumentException>(() => 
	                parametersValidator.CheckParameters()).Message,
                Is.EqualTo(
	                "Handle length must be in a range from 80mm up to 200mm."));
        }

        private HammerParameters GetDefaultHammerParameters() =>
            new HammerParameters
            {
                Denominator = 4,
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