using Hammer.MODEL;
using Hammer.MODEL.Models;
using NUnit.Framework;

namespace Hammer.Tests
{
    [TestFixture]
    public class HeadParametersTests
    {
        private ParametersValidator _parametersValidator;

        [Test]
        public void CheckParametersHandle_HandleParametersLengthAndHandleParametersDiameterCorrectVaue()
        {
            _parametersValidator = new ParametersValidator(GetCorrectParametersHandle());

            Assert.DoesNotThrow(_parametersValidator.CheckValueRagne());
        }

        [Test]
        public void CheckParametersHandle_HandleParametersLengthNull()
        {
            var parameters = GetCorrectParametersHandle();

            parameters.HandleParameters.Length = null;

            _parametersValidator = new ValidatorParameters();

            Assert.DoesNotThrow(_parametersValidator.CheckParametersHandle);
        }

        private HammerParameters GetCorrectParametersHandle() => new HammerParameters
        {
            HandleParameters = { Diameter = 30, Length = 150 }, 
            HeadParameters = { Width = 35 }
        };
    }
}