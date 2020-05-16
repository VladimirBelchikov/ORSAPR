﻿using System;
using Hammer.MODEL.Models;

namespace Hammer.MODEL
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
                string message = paramName + " должно быть в пределах от " + min + "мм до " + max + "мм.";
                throw new ArgumentException(message);
            }
        }

        /// <summary>
        /// Валидация параметров
        /// </summary>
        public void CheckParameters()
        {
            CheckValueRange(_hammerParameters.HeadParameters.Width, 20, 50, "Поле ширины оголовья");

            CheckValueRange(_hammerParameters.HeadParameters.Length, 30, 80, "Поле длины бойка");

            CheckValueRange(_hammerParameters.HeadParameters.Height, 20, 50, "Поле высоты бойка");

            CheckValueRange(_hammerParameters.HeadParameters.TipWidth, 1, 10, "Поле ширина наконечника");

            CheckValueRange(_hammerParameters.HeadParameters.ToeLength, 30, 80, "Поле длины наконечника");

            CheckValueRange(_hammerParameters.HandleParameters.Diameter, 15, 40, "Поле диаметра рукояти");

            CheckValueRange(_hammerParameters.HandleParameters.Length, 80, 200, "Поле длины рукояти");
        }
    }
}