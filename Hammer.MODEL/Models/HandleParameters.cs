using System;

namespace Hammer.MODEL.Models
{
    public class HandleParameters
    {
        /// <summary>
        /// Валидация длины рукояти
        /// </summary>
        public int Length { get; set; }

        /// <summary>
        /// Валидация диаметра рукояти
        /// </summary>
        public int Diameter { get; set; }

        public HandleParameters() { }
    }
}
