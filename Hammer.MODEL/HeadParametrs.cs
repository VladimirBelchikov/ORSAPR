using System;

namespace Hammer.MODEL
{
    public class HeadParametrs
    {
        private int _headLength;

        private int _headWidth;

        private int _holeDiameter;

        private int _tipWidth;

        private int _toeLength;

        public HeadParametrs() { }

        public HeadParametrs(int headLength, int headWidth, int holeDiameter, int tipWidth, int toeLength)
        {
            Length = headLength;
            Width = headWidth;
            HoleDiameter = holeDiameter;
            TipWidth = tipWidth;
            ToeLength = toeLength;
        }

        public int Length
        {
            get => _headLength;

            set
            {
                
                if (value < 0)
                {
                    throw new ArgumentException("Поле не может быть пустым");
                }
                else if (value == 0)
                {
                    throw new ArgumentException("Длина не может быть меньше или равна нулю");
                }
                else
                {
                    _headLength = value;
                }
            }
        }

        public int Width
        {
            get => _headWidth;

            set
            {


                if (value < 0)
                {
                    throw new ArgumentException("Выс11ота не может быть равна нулю");
                }
                else
                {
                    _headWidth = value;
                }
            }
        }


        public int HoleDiameter
        {
            get => _holeDiameter;

            set
            {


                if (value < 0)
                {
                    throw new ArgumentException("Высота не может быть равна нулю");
                }
                else
                {
                    _holeDiameter = value;
                }
            }
        }

        public int TipWidth
        {
            get => _tipWidth;

            set
            {


                if (value < 0)
                {
                    throw new ArgumentException("Высо123та не может быть равна нулю");
                }
                else
                {
                    _tipWidth = value;
                }
            }
        }

        public int ToeLength
        {
            get => _toeLength;

            set
            {


                if (value < 0)
                {
                    throw new ArgumentException("Вы4123сота не может быть равна нулю");
                }
                else
                {
                    _toeLength = value;
                }
            }
        }







    }
}
