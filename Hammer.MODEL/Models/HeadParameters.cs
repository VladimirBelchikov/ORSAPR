namespace Hammer.MODEL.Models
{
    public class HeadParameters
    {
        /// <summary>
        /// Переменная высоты бойка
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Переменная длины оголовья
        /// </summary>
        public int Length { get; set; }

        /// <summary>
        /// Переманная ширины оголовья
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// Переменная ширины наконечника
        /// </summary>
        public int TipWidth { get; set; }

        /// <summary>
        /// Переменная длины носка
        /// </summary>
        public int ToeLength { get; set; }

        public HeadParameters() { }
    }
}
