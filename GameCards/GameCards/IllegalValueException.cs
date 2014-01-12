using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCards
{
    class IllegalValueException: Exception
    {
        public int ValueCard;
        public IllegalValueException(int value)
        {
            this.ValueCard = value;
        }

    }
}
