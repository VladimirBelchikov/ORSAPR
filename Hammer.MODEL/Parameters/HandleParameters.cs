namespace Hammer.MODEL.Parameters
{
	public class HandleParameters
	{
		/// <summary>
        /// Конструктор
        /// </summary>
		public HandleParameters() { }

		/// <summary>
        /// Переменная длины рукояти
        /// </summary>
        private double _length;

        /// <summary>
        /// Свойства длины рукояти
        /// </summary>
        public double Length
        {
	        get => _length;
	        set => _length = value;
        }

        /// <summary>
        /// Переменная диаметра рукояти
        /// </summary>
        private double _diameter;

        /// <summary>
        /// Свойства диаметра рукояти
        /// </summary>
        public double Diameter
        {
	        get => _diameter;
	        set => _diameter = value;
        }
    }
}
