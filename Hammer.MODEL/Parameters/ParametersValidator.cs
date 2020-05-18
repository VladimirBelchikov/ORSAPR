using System;

namespace Hammer.MODEL.Parameters
{
    public class ParametersValidator
    {
        private readonly HammerParameters _hammerParameters;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="hammerParameters"></param>
        public ParametersValidator(HammerParameters hammerParameters)
        { 
            _hammerParameters = hammerParameters;
        }

        /// <summary>
        /// Валидация входного значения
        /// </summary>
        /// <param name="parameter"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <param name="paramName"></param>
        private void CheckValueRange(double parameter, double min, double max, string paramName)
        {
            if (parameter < min || parameter > max)
            {
                string message = paramName + " must be in a range from " + min + "mm up to " + max + "mm.";
                throw new ArgumentException(message);
            }
        }

        /// <summary>
        /// Валидация параметров
        /// </summary>
        public void CheckParameters()
        {
            CheckValueRange(_hammerParameters.HeadParameters.Width, 20, 50, "Head width");

            CheckValueRange(_hammerParameters.HeadParameters.Length, 30, 80, "Head length");

            CheckValueRange(_hammerParameters.HeadParameters.Height, 20, 50, "Head height");

            CheckValueRange(_hammerParameters.HeadParameters.ToeLength, 30, 80, "Toe length");

            CheckValueRange(_hammerParameters.HeadParameters.TipWidth, 1, 10, "Tip width");

            CheckValueRange(_hammerParameters.HandleParameters.Diameter, 15, 40, "Handle diameter");

            CheckValueRange(_hammerParameters.HandleParameters.Length, 80, 200, "Handle length");
        }
    }
}