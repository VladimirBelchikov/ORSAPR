using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hammer.MODEL
{
    public class HandleParameters
    {

        private int _handleHeight;

        private int _handleWidth;

        private int _handleLength;

        public HandleParameters() { }

        public HandleParameters(int handleHeight, int handleWidth, int handleLength)
        {
            Height = handleHeight;
            Width = handleWidth;
            Length = handleLength;
        }

        public int Height
        {
            get => _handleHeight;

            set
            {


                if (value < 0)
                {
                    throw new ArgumentException("Высота не может быть равна нулю");
                }
                else
                {
                    _handleHeight = value;
                }
            }
        }

        public int Length
        {
            get => _handleLength;

            set
            {


                if (value < 0)
                {
                    throw new ArgumentException("Высота не может быть равна нулю");
                }
                else
                {
                    _handleLength = value;
                }
            }
        }

        public int Width
        {
            get => _handleWidth;

            set
            {


                if (value < 0)
                {
                    throw new ArgumentException("Высота не может быть равна нулю");
                }
                else
                {
                    _handleWidth = value;
                }
            }
        }
    }
}
