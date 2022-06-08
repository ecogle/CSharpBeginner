using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBeginner
{
    class ArrayDemo
    {
        public static void  testArray()
        {
            //Jagged Array
            var jaggedArr = new int[3][];

            //Rectangular Array
            var recArr = new int[3, 5];

            jaggedArr[0] = new int[] { 0, 2, 4, 6, 8, 10 };
            jaggedArr[1] = new int[] { 1, 3, 5 };
            jaggedArr[2] = new int[] { 7, 9 };

            foreach (var x in jaggedArr)
            {
                foreach (var y in x)
                {
                    Console.Write(y);   
                }
                Console.Write("\n");
            }
        }
    }
}
