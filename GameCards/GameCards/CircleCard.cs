using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCards
{
    class CircleCard:Card
    {
        public CircleCard(int value)
        {
            SetValue(value);
        }
        public override string GetKind()
        {
            return "Circle";
        }
        public override void PaintCard()
        {
            Painter.PaintCicleCard(GetValue());
        }
    }
}
