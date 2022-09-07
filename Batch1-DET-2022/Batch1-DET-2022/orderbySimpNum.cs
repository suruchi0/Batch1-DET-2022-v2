using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class orderbySimpNum
    {
        static void Sample_OrderByDescending_Lambda()
        {
            string[] names = { "Ned", "Ben", "Susan" };

            var result = names.OrderByDescending(n => n);

            Debug.WriteLine("Descending ordered list of names:");
            foreach (string name in result)
                Debug.WriteLine(name);
        }
    }
}
