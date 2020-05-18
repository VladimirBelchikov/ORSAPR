namespace Hammer.MODEL.Parameters
{
    public class HammerParameters
    {
        /// <summary>
        /// Свойства HeadParameters
        /// </summary>
        public HeadParameters HeadParameters { get; set; }

        /// <summary>
        /// Переменная делителя
        /// </summary>
        private int _denominator = 4;

        /// <summary>
        /// Свойства делителя
        /// </summary>
        public int Denominator  
        {
            get => _denominator;
            set => _denominator= value;
        }

        /// <summary>
        /// Свойства HandleParameters
        /// </summary>
        public HandleParameters HandleParameters { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        public HammerParameters()
        {
            HeadParameters = new HeadParameters();
            HandleParameters = new HandleParameters();
        }
    }
}
