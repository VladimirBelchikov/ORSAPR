using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hammer.MODEL
{
    public class HammerParameters
    {

        public HeadParametrs _headParameters;

        public HandleParameters _handleParameters;

        public HeadParametrs HeadParametrs { get { return _headParameters; } set { _headParameters = value; } }

        public HandleParameters HandleParametrs { get { return _handleParameters; } set { _handleParameters = value; } }

        public HammerParameters()
        {
            _headParameters = new HeadParametrs();
            _handleParameters = new HandleParameters();
        }
    }
}
