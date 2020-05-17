namespace Hammer.MODEL.Parameters
{
    public class HandleParameters
    {
        /// <summary>
        /// Переменная длины рукояти
        /// </summary>
        private double _length;


        public double Length
        {
            get => _length;
            set => _length = value;
        }




        /// <summary>
        /// Переменная диаметра рукояти
        /// </summary>
        private double _diameter;

        public double Diameter
        {
            get => _diameter;
            set => _diameter = value;
        }

        public HandleParameters() { }
    }
}
