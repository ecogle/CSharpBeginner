using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBeginner
{
    class GenericsTest
    {
        public static bool AreEqual<T>(T num1, T num2) where T:IComparable<T>
        {
            return (num1.CompareTo(num2)==0);
        }
    }
}
