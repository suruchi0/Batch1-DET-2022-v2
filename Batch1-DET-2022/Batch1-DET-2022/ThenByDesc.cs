using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class ThenByDesc
    {
        static void Sample_ThenByDescending_Lambda()
        {
            var dates = new DateTime[] {
        new DateTime(2013, 3, 1),
        new DateTime(2014, 7, 1),
        new DateTime(2013, 5, 1),
        new DateTime(2015, 1, 1),
        new DateTime(2015, 7, 1)
    };

            var result = dates.OrderByDescending(d => d.Year).ThenByDescending(d => d.Month);

            Debug.WriteLine("List of dates first ordered by year descending, and then by month descending:");
            foreach (DateTime dt in result)
                Debug.WriteLine(dt.ToString("yyyy/MM/dd"));
        }
    }
}
