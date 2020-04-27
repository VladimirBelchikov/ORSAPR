using System;

namespace Hammer.MODEL
{
    public class HandleParameters
    {
        /// <summary>
        /// Переменная высоты рукояти
        /// </summary>
        private int _handleHeight;

        /// <summary>
        /// Переменная ширины рукояти
        /// </summary>
        private int _handleWidth;

        /// <summary>
        /// Переменная длины рукояти
        /// </summary>
        private int _handleLength;

        public HandleParameters() { }

        /// <summary>
        /// Конструктор класса HandleParameters
        /// </summary>
        /// <param name="handleHeight"></param>
        /// <param name="handleWidth"></param>
        /// <param name="handleLength"></param>
        public HandleParameters(int handleHeight, int handleWidth, int handleLength)
        {
            Height = handleHeight;
            Width = handleWidth;
            Length = handleLength;
        }

        /// <summary>
        /// Валидация высоты рукояти
        /// </summary>
        public int Height
        {
            get => _handleHeight;

            set
            {
                if (value < 130 || value < 280)
                {
                    throw new ArgumentException("Высота рукояти не может быть менее 130мм или более 280мм");
                }
                else
                {
                    _handleHeight = value;
                }
            }
        }

        /// <summary>
        /// Валидация длины рукояти
        /// </summary>
        public int Length
        {
            get => _handleLength;

            set
            {


                if (value < 20 || value > 50)
                {
                    throw new ArgumentException("Длина рукояти не может быть менее 20мм или более 50мм");
                }
                else
                {
                    _handleLength = value;
                }
            }
        }

        /// <summary>
        /// Валидация ширины рукояти
        /// </summary>
        public int Width
        {
            get => _handleWidth;

            set
            {
                if (value < 15 || value > 40)
                {
                    throw new ArgumentException("Ширина рукояти не может быть менее 15мм или более 40мм");
                }
                else
                {
                    _handleWidth = value;
                }
            }
        }
    }
}
