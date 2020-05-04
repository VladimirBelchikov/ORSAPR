using System;

namespace Hammer.MODEL.Models
{
    public class HeadParameters
    {
        /// <summary>
        /// Переменная длины бойка
        /// </summary>
        private int _headLength;

        /// <summary>
        /// Переменная ширины оголовья
        /// </summary>
        private int _headWidth;

        /// <summary>
        /// Переменная диаметра выреза под рукоять
        /// </summary>
        private int _holeDiameter;

        /// <summary>
        /// Переменная ширины наконечника
        /// </summary>
        private int _tipWidth;

        /// <summary>
        /// Переменная длины носка
        /// </summary>
        private int _toeLength;

        public HeadParameters() { }

        /// <summary>
        /// Конструктор класса HeadParameters
        /// </summary>
        /// <param name="headLength"></param>
        /// <param name="headWidth"></param>
        /// <param name="holeDiameter"></param>
        /// <param name="tipWidth"></param>
        /// <param name="toeLength"></param>
        public HeadParameters(int headLength, int headWidth, int holeDiameter, int tipWidth, int toeLength)
        {
            Length = headLength;
            Width = headWidth;
            HoleDiameter = holeDiameter;
            TipWidth = tipWidth;
            ToeLength = toeLength;
        }

        /// <summary>
        /// Валидация длины бойка
        /// </summary>
        public int Length
        {
            get => _headLength;

            set
            {

                if (value < 30 || value > 80)
                {
                    throw new ArgumentException("Длина бойка не может быть менее 30мм или более 80мм");
                }

                _headLength = value;
            }
        }

        /// <summary>
        /// Валидация ширины плоского бойка
        /// </summary>
        public int Width
        {
            get => _headWidth;

            set
            {
                if (value < 20 || value > 50)
                {
                    throw new ArgumentException("Ширина бойка не можеть быть менее 20мм или более 50мм");
                }

                _headWidth = value;
            }
        }

        /// <summary>
        /// Валидация диаметра выреза под рукоять
        /// </summary>
        public int HoleDiameter
        {
            get => _holeDiameter;

            set
            {
                if (value < 15 || value > 40)
                {
                    throw new ArgumentException("Диаметр выреза не может быть менее 15мм или более 40мм");
                }

                _holeDiameter = value;
            }
        }

        /// <summary>
        /// Валидация ширины наконечника
        /// </summary>
        public int TipWidth
        {
            get => _tipWidth;

            set
            {
                if (value < 1 || value > 10)
                {
                    throw new ArgumentException("Ширина V-образного наконечника не может быть менее 1мм или более 10мм");
                }

                _tipWidth = value;
            }
        }

        /// <summary>
        /// Валидация длины наконечника
        /// </summary>
        public int ToeLength
        {
            get => _toeLength;

            set
            {
                if (value < 30 || value > 80)
                {
                    throw new ArgumentException("Длина наконечника не может быть менее 30мм или более 80мм");
                }

                _toeLength = value;
            }
        }
    }
}
