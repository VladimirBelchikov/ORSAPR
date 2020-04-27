namespace Hammer.MODEL
{
    public class HammerParameters
    {
        /// <summary>
        /// Переменная HeadParameters
        /// </summary>
        public HeadParametrs HeadParameters;

        /// <summary>
        /// Переменная HandleParameters
        /// </summary>
        public HandleParameters HandleParameters;

        public HeadParametrs HeadParametrs { get => HeadParameters; set => HeadParameters = value; }

        public HandleParameters HandleParametrs { get => HandleParameters; set => HandleParameters = value; }

        public HammerParameters()
        {
            HeadParameters = new HeadParametrs();
            HandleParameters = new HandleParameters();
        }
    }
}
