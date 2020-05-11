using Hammer.MODEL.Exceptions;
using Hammer.MODEL.Models;

namespace Hammer.MODEL
{
    public class ValidatorParameters
    {
        private readonly HammerParameters _hammerParameters;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="hammerParameters"></param>
        public ValidatorParameters(HammerParameters hammerParameters)
        {
            _hammerParameters = hammerParameters;
        }
        
        /// <summary>
        /// Валидация параметров оголовья
        /// </summary>
        public void CheckHeadParameters()
        {
            if (string.IsNullOrEmpty(_hammerParameters.HeadParameters.Length.ToString()))
            {
                throw new ParametersExceptions("Длина бойка не может пустой");
            }
            if (_hammerParameters.HeadParameters.Length < 30 || _hammerParameters.HeadParameters.Length > 80)
            {
                throw new ParametersExceptions("Длина бойка не может быть менее 30мм или более 80мм");
            }


            if (string.IsNullOrEmpty(_hammerParameters.HeadParameters.Width.ToString()))
            {
                throw new ParametersExceptions("Ширина бойка не может пустой");
            }
            if (_hammerParameters.HeadParameters.Width < 20 || _hammerParameters.HeadParameters.Width > 50)
            {
                throw new ParametersExceptions("Ширина бойка не можеть быть менее 20мм или более 50мм");
            }


            if (string.IsNullOrEmpty(_hammerParameters.HeadParameters.Height.ToString()))
            {
                throw new ParametersExceptions("Высота бойка не может пустой");
            }
            if (_hammerParameters.HeadParameters.Height < 20 || _hammerParameters.HeadParameters.Height > 50)
            {
                throw new ParametersExceptions("Высота бойка не можеть быть менее 20мм или более 50мм");
            }

            if (string.IsNullOrEmpty(_hammerParameters.HeadParameters.TipWidth.ToString()))
            {
                throw new ParametersExceptions("Ширина V-образного наконечника не может пустой");
            }
            if (_hammerParameters.HeadParameters.TipWidth < 1 || _hammerParameters.HeadParameters.TipWidth > 10)
            {
                throw new ParametersExceptions("Ширина V-образного наконечника не может быть менее 1мм или более 10мм");
            }

            if (string.IsNullOrEmpty(_hammerParameters.HeadParameters.ToeLength.ToString()))
            {
                throw new ParametersExceptions("Длина наконечника не может пустой");
            }
            if (_hammerParameters.HeadParameters.ToeLength < 30 || _hammerParameters.HeadParameters.ToeLength > 80)
            {
                throw new ParametersExceptions("Длина наконечника не может быть менее 30мм или более 80мм");
            }
        }

        /// <summary>
        /// Валидация параметров рукояти
        /// </summary>
        public void CheckParametersHandle()
        {
            if (string.IsNullOrEmpty(_hammerParameters.HandleParameters.Length.ToString()))
            {
                throw new ParametersExceptions("Длина рукояти не может пустой");
            }
            if (_hammerParameters.HandleParameters.Length < 130 || _hammerParameters.HandleParameters.Length > 280)
            {
                throw new ParametersExceptions("Длина рукояти не может быть менее 130мм или более 280мм");
            }

            if (string.IsNullOrEmpty(_hammerParameters.HandleParameters.Diameter.ToString()))
            {
                throw new ParametersExceptions("Ширина рукояти не может пустой");
            }
            if (_hammerParameters.HandleParameters.Diameter < 15 || _hammerParameters.HandleParameters.Diameter > 40)
            {
                throw new ParametersExceptions("Ширина рукояти не может быть менее 15мм или более 40мм");
            }
            if (_hammerParameters.HandleParameters.Diameter >= _hammerParameters.HeadParameters.Width)
            {
                throw new ParametersExceptions("Ширина рукояти не может больше или равна ширины бойка");
            }
        }
    }
}