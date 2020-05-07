using Hammer.MODEL;
using Hammer.MODEL.Models;
using NUnit.Framework;

namespace Hammer.Tests
{
    [TestFixture]
    public class HeadParametersTests
    {
        private ValidatorParameters _validatorParameters;

        [Test]
        public void CheckParametersHandle_HandleParametersLengthAndHandleParametersDiameterCorrectVaue()
        {
            _validatorParameters = new ValidatorParameters(GetCorrectParametersHandle());

            Assert.DoesNotThrow(_validatorParameters.CheckParametersHandle);
        }

        [Test]
        public void CheckParametersHandle_HandleParametersLengthNull()
        {
            var parameters = GetCorrectParametersHandle();

            parameters.HandleParameters.Length = null;

            _validatorParameters = new ValidatorParameters();

            Assert.DoesNotThrow(_validatorParameters.CheckParametersHandle);
        }

        private HammerParameters GetCorrectParametersHandle() => new HammerParameters
        {
            HandleParameters = { Diameter = 30, Length = 150 }, 
            HeadParameters = { Width = 35 }
        };
    }
}