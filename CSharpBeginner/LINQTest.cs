using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CSharpBeginner
{
    class LINQTest
    {
        public static void testLINQ()
        {
            string sentence = "I love cats";
            string[] catName = { "Lucky", "Bella", "Luna", "Oreo", "Simba", "Toby", "Loki", "Oscar" };
            int[] numbers = { 5, 6, 3, 2, 1, 5, 6, 7, 8, 4, 234, 54, 14, 653, 3, 4, 5, 6, 7 };

            var getTheNumbers = from number in numbers
                select number;

        }
    }

}
