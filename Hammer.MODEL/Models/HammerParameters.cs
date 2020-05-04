namespace Hammer.MODEL.Models
{
    public class HammerParameters
    {
        /// <summary>
        /// Переменная HeadParameters
        /// </summary>
        public HeadParameters HeadParameters { get; set; }

        /// <summary>
        /// Переменная HandleParameters
        /// </summary>
        public HandleParameters HandleParameters { get; set; }

        public HammerParameters()
        {
            HeadParameters = new HeadParameters();
            HandleParameters = new HandleParameters();
        }
    }
}
