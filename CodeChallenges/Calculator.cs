using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges
{
    public class Calculator
    {
        public double Result { get; private set; }

        public Calculator(double value)
        {
            Result = value;
        }

        public void Add(double value)
        {
            Result += value;
        }

        public void Subtract(double value)
        {
            Result -= value;
        }
    }
}
