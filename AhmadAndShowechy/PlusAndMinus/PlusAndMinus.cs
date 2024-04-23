using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhmadAndShowechy.PlusAndMinus
{
    public class PlusAndMinus : IPlusAndMinus
    {
        public float Plus(float number1, float number2)
        {
            return number1 + number2;
        }

        public float Minus(float number1, float number2)
        {
            return number1 - number2;
        }
    }
}
