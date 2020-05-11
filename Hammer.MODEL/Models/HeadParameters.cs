namespace Hammer.MODEL.Models
{
    public class HeadParameters
    {
        /// <summary>
        /// Переменная высоты бойка
        /// </summary>
        public double Height { get; set; }

        /// <summary>
        /// Переменная длины оголовья
        /// </summary>
        public double Length { get; set; }

        /// <summary>
        /// Переманная ширины оголовья
        /// </summary>
        public double Width { get; set; }

        /// <summary>
        /// Переменная ширины наконечника
        /// </summary>
        public double TipWidth { get; set; }

        /// <summary>
        /// Переменная длины носка
        /// </summary>
        public double ToeLength { get; set; }

        public HeadParameters() { }
    }
}
