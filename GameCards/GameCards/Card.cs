using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCards
{
    abstract class Card
    {
        private int _value;

        //protected Card(int value)
        //{
        //    SetValue(value);
        //}
        public void SetValue(int value)
        {
            if(value>13 || value<0)
            {
                throw new IllegalValueException(value);
            }
            else _value = value;
        }
        public int GetValue()
        {
            return _value;
        }

        public abstract string GetKind();
        public abstract void PaintCard();
    }
}
