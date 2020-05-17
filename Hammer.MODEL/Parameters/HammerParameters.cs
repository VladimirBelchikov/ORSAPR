namespace Hammer.MODEL.Parameters
{
    public class HammerParameters
    {
        /// <summary>
        /// Свойства HeadParameters
        /// </summary>
        public HeadParameters HeadParameters { get; set; }

        private int _denominator = 4;

        public int Denominator  
        {
            get => _denominator;
            set => _denominator= value;
        }


        /// <summary>
        /// Свойства HandleParameters
        /// </summary>
        public HandleParameters HandleParameters { get; set; }

        public HammerParameters()
        {
            HeadParameters = new HeadParameters();
            HandleParameters = new HandleParameters();
        }
    }
}
