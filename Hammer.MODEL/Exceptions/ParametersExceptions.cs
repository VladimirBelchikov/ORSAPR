using System;

namespace Hammer.MODEL.Exceptions
{
    public class ParametersExceptions : Exception
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="message">Описание ошибки</param>
        public ParametersExceptions(string message)
            : base(message)
        {
        }
    }
}