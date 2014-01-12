using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCards
{
    class SquareCard:Card
    {
        public SquareCard(int value)
        {
            SetValue(value);
        }
        public override string GetKind()
        {
            return "Square";
        }
        public override void PaintCard()
        {
            Painter.PaintSquareCard(GetValue());
        }
    }
}
