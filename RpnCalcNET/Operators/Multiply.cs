﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpnCalcNET.Operators
{
    public class Multiply: Operator
    {
        public override decimal Calculate(ref Stack<decimal> numberStack)
        {
            decimal secondNumber = numberStack.Pop();
            decimal firstNumber = numberStack.Pop();
            return firstNumber * secondNumber;
        }
    }
}
