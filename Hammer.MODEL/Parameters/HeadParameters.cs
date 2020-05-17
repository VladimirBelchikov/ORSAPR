namespace Hammer.MODEL.Parameters
{
    public class HeadParameters
    {
        /// <summary>
        /// Переменная высоты бойка
        /// </summary>
        private double _height;

        public double Height
        {
            get => _height;
            set => _height = value;
        }

        /// <summary>
        /// Переменная длины оголовья
        /// </summary>
        private double _length;

        public double Length
        {
            get => _length;
            set => _length = value;
        }

        /// <summary>
        /// Переманная ширины оголовья
        /// </summary>
        private double _width;

        public double Width
        {
            get => _width;
            set => _width = value;
        }

        /// <summary>
        /// Переменная ширины наконечника
        /// </summary>
        private double _tipWidth;

        public double TipWidth
        {
            get => _tipWidth;
            set => _tipWidth = value;
        }

        /// <summary>
        /// Переменная длины носка
        /// </summary>
        private double _toeLength;

        public double ToeLength
        {
            get => _toeLength;
            set => _toeLength = value;
        }

        public HeadParameters() { }
    }
}
