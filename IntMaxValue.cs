using System;
using System.Collections.Generic;
using System.Text;

namespace Find_Maximum_By_Genric
{
    public class IntMaxValue
    {
        public int  MaxValue(int firstValue,int secondValue,int thirdValue) 
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0) { return firstValue; }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0) { return secondValue; }
            if (thirdValue.CompareTo(firstValue)  > 0 && thirdValue.CompareTo(secondValue) > 0) { return thirdValue; }
           
            return secondValue;
        }

    }
}
