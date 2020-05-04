using System;
using System.Dynamic;

namespace Hammer.MODEL.Models
{
    public class HeadParameters
    {
        /// <summary>
        /// Валидация высоты бойка
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Валидация длины бойка
        /// </summary>
        public int Length { get; set; }

        /// <summary>
        /// Валидация ширины плоского бойка
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// Валидация ширины наконечника
        /// </summary>
        public int TipWidth { get; set; }

        /// <summary>
        /// Валидация длины наконечника
        /// </summary>
        public int ToeLength { get; set; }

        public HeadParameters() { }
    }
}
