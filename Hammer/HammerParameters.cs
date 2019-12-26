using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hammer
{
    /// <summary>
    /// класс параметров объекта
    /// </summary>
    public class HammerParameters
    {
        /// <summary>
        /// поле с первым параметром объекта
        /// </summary>
        private int _param1;

        /// <summary>
        /// поле со вторым параметром объекта
        /// </summary>
        private int _param2;
        
        /// <summary>
        /// поле с третьим параметром объекта
        /// </summary>
        private int _param3;
        
        /// <summary>
        /// поле с четвёртым параметром объекта
        /// </summary>
        private int _param4;
        
        /// <summary>
        /// поле с пятым параметром объекта
        /// </summary>
        private int _param5;
        
        /// <summary>
        /// поле с шестым параметром объекта
        /// </summary>
        private int _param6;
        
        /// <summary>
        /// поле с седьмым параметром объекта
        /// </summary>
        private int _param7;
        
        /// <summary>
        /// конструктор класса
        /// </summary>
        public HammerParameters()
        {
        }

        /// <summary>
        /// Свойста поля первого параметра
        /// </summary>
        public int Param1
        {
            get => _param1;
            set => _param1 = value;
        }

        /// <summary>
        /// Свойста поля второго параметра
        /// </summary>
        public int Param2
        {
            get => _param2;
            set => _param2 = value;
        }

        /// <summary>
        /// Свойста поля третьего параметра
        /// </summary>
        public int Param3
        {
            get => _param3;
            set => _param3 = value;
        }

        /// <summary>
        /// Свойства поля четвёртого параметра
        /// </summary>
        public int Param4
        {
            get => _param4;
            set => _param4 = value;
        }

        /// <summary>
        /// Свойства поля пятого параметра
        /// </summary>
        public int Param5
        {
            get => _param5;
            set => _param5 = value;
        }

        /// <summary>
        /// Свойства поля шестого параметра
        /// </summary>
        public int Param6
        {
            get => _param6;
            set => _param6 = value;
        }

        /// <summary>
        /// Свойства поля седьмого параметра
        /// </summary>
        public int Param7
        {
            get => _param7;
            set => _param7 = value;
        }

    }
}
