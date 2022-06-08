
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBeginner
{
    class ListClass
    {
        public static void testList()
        {
            var list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            list.ForEach((c) =>
            {
                Console.WriteLine(c);

            });

        }
    }
}
