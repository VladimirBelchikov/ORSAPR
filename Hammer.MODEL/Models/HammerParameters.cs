namespace Hammer.MODEL.Models
{
    public class HammerParameters
    {
        /// <summary>
        /// Свойства HeadParameters
        /// </summary>
        public HeadParameters HeadParameters { get; set; }

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
