namespace Hammer.MODEL.Parameters
{
    public class HeadParameters
    {
	    /// <summary>
        /// Конструктор
        /// </summary>
	    public HeadParameters() { }

        /// <summary>
        /// Переменная высоты бойка
        /// </summary>
        private double _height;

        /// <summary>
        /// Свойства высоты бойка
        /// </summary>
	    public double Height
        {
            get => _height;
            set => _height = value;
        }

        /// <summary>
        /// Переменная длины оголовья
        /// </summary>
        private double _length;

        /// <summary>
        /// Свойства длины оголовья
        /// </summary>
        public double Length
        {
            get => _length;
            set => _length = value;
        }

        /// <summary>
        /// Переманная ширины оголовья
        /// </summary>
        private double _width;

	    /// <summary>
        /// Свойства ширины оголовья
        /// </summary>
        public double Width
        {
            get => _width;
            set => _width = value;
        }

	    /// <summary>
        /// Переменная ширины наконечника
        /// </summary>
        private double _tipWidth;

	    /// <summary>
        /// Свойства ширины наконечника
        /// </summary>
        public double TipWidth
        {
            get => _tipWidth;
            set => _tipWidth = value;
        }

	    /// <summary>
        /// Переменная длины носка
        /// </summary>
        private double _toeLength;

        /// <summary>
        /// Свойства длины наконечника
        /// </summary>
        public double ToeLength
        {
            get => _toeLength;
            set => _toeLength = value;
        }
    }
}
