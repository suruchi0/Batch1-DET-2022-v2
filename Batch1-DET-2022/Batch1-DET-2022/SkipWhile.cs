﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class SkipWhile
    {
        static void Sample_SkipWhile_Lambda()
        {
            string[] words = { "one", "two", "three", "four", "five", "six" };

            var result = words.SkipWhile(w => w.Length == 3);

            Console.WriteLine("Skips words while the condition is met:");
            foreach (string word in result)
                Console.WriteLine(word);
        }
    }
}
