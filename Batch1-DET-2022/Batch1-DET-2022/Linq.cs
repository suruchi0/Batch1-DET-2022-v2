//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Diagnostics;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Batch1_DET_2022
//{
//    internal class LearnLINQ
//    {
//        public static void Main()
//        {


//            //List<int> num = new List<int>();
//            //num.Add(100);
//            //num.Add(103);
//            //num.Add(105);
//            //num.Add(102);

//            //var numQuery = from number in num select number;

//            //num.Add(205);
//            //num.Add(301);
//            //num.Add(400);
//            //foreach (int number in numQuery)
//            //{
//            //    Console.WriteLine("{0}", number);

//            //}
//            //Console.ReadLine();

//            //SKIP
//            //string[] words = { "one", "two", "three", "four", "five", "six" };

//            //var result = words.Skip(4);

//            //Console.WriteLine("Skips the first 4 words:");
//            //foreach (string word in result)
//            //    Console.WriteLine(word);

//            ////SKIPWHILE
//            //string[] words = { "one", "two", "three", "four", "five", "six" };

//            //var result = words.SkipWhile(w => w.Length == 3);

//            //Console.WriteLine("Skips words while the condition is met:");
//            //foreach (string word in result)
//            //    Console.WriteLine(word);

//            //TAKE
//            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//            //var result = numbers.Take(5);

//            //Console.WriteLine("Takes the first 5 numbers only:");
//            //foreach (int number in result)
//            //    Console.WriteLine(number);

//            //TakeWhile

//            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//            //var result = numbers.TakeWhile(n => n < 6);

//            //Console.WriteLine("Takes numbers one by one, and stops when condition is no longer met:");
//            //foreach (int number in result)
//            //    Console.WriteLine(number);

//            //SET
//            //1. DISTINCT

//            //{
//            //    int[] numbers = { 1, 2, 2, 3, 5, 6, 6, 6, 8, 9 };

//            //    var result = numbers.Distinct();

//            //    Console.WriteLine("Distinct removes duplicate elements:");
//            //    foreach (int number in result)
//            //        Console.WriteLine(number);
//            //}

//            //2. EXCEPT

//            //{
//            //int[] numbers1 = { 1, 2, 3 };
//            //int[] numbers2 = { 3, 4, 5 };

//            //var result = numbers1.Except(numbers2);

//            //Console.WriteLine("Except creates a single sequence from numbers1 and removes the duplicates found in numbers2:");
//            //foreach (int number in result)
//            //    Console.WriteLine(number);
//            //}
//            //3. INTERSECT
//            //{
//            //    int[] numbers1 = { 1, 2, 3 };
//            //    int[] numbers2 = { 3, 4, 5 };

//            //    var result = numbers1.Intersect(numbers2);

//            //    Console.WriteLine("Intersect creates a single sequence with only the duplicates:");
//            //    foreach (int number in result)
//            //        Console.WriteLine(number);
//            //}
//            //4. UNION
//            //{
//            //    int[] numbers1 = { 1, 2, 3 };
//            //    int[] numbers2 = { 3, 4, 5 };

//            //    var result = numbers1.Union(numbers2);

//            //    Console.WriteLine("Union creates a single sequence and eliminates the duplicates:");
//            //    foreach (int number in result)
//            //        Console.WriteLine(number);
//            //}
//            //ELEMENT
//            //1. ELEMENT AT
//            //string[] words = { "One", "Two", "Three" };

//            //var result = words.ElementAt(1);

//            //Console.WriteLine("Element at index 1 in the array is:");
//            //Console.WriteLine(result);

//            //2. ELEMENT AT OR DEFAULT
//            //string[] colors = { "Red", "Green", "Blue" };

//            //var resultIndex1 = colors.ElementAtOrDefault(1);

//            //var resultIndex10 = colors.ElementAtOrDefault(10);

//            //Console.WriteLine("Element at index 1 in the array contains:");
//            //Console.WriteLine(resultIndex1);

//            //Console.WriteLine("Element at index 10 in the array does not exist:");
//            //Console.WriteLine(resultIndex10 == null);

//            //3. FIRST (SIMPLE)

//            //string[] fruits = { "Banana", "Apple", "Orange" };

//            //var result = fruits.First();

//            //Console.WriteLine("First element in the array is:");
//            //Console.WriteLine(result);

//            //4. FIRST (CONDITIONAL)

//            //string[] countries = { "Denmark", "Sweden", "Norway" };

//            //var result = countries.First(c => c.Length == 6);

//            //Console.WriteLine("First element with a length of 6 characters:");
//            //Console.WriteLine(result);

//            //5.FIRST OR DEFAULT

//            //string[] countries = { "Denmark", "Sweden", "Norway" };
//            //string[] empty = { };

//            //var result = countries.FirstOrDefault();

//            //var resultEmpty = empty.FirstOrDefault();

//            //Console.WriteLine("First element in the countries array contains:");
//            //Console.WriteLine(result);

//            //Console.WriteLine("First element in the empty array does not exist:");
//            //Console.WriteLine(resultEmpty == null);

//            //6. LAST

//            //int[] numbers = { 7, 3, 5 };

//            //var result = numbers.Last();

//            //Console.WriteLine("Last number in array is:");
//            //Console.WriteLine(result);

//            //7. LAST OR DEFAULT (SIMPLE)

//            //string[] words = { "one", "two", "three" };
//            //string[] empty = { };

//            //var result = words.LastOrDefault();

//            //var resultEmpty = empty.LastOrDefault();

//            //Console.WriteLine("Last element in the words array contains:");
//            //Console.WriteLine(result);

//            //Console.WriteLine("Last element in the empty array does not exist:");
//            //Console.WriteLine(resultEmpty == null);

//            //8. LAST OR DEFAULT (CONDITIONAL)

//            //string[] words = { "one", "two", "three" };

//            //var result = words.LastOrDefault(w => w.Length == 3);

//            //var resultNoMatch = words.LastOrDefault(w => w.Length == 2);

//            //Console.WriteLine("Last element in the words array having a length of 3:");
//            //Console.WriteLine(result);

//            //Console.WriteLine("Last element in the empty array having a length of 2 does not exist:");
//            //Console.WriteLine(resultNoMatch == null);

//            //9. SINGLE 

//            //string[] names1 = { "Peter" };
//            //string[] names3 = { "Peter", "Joe", "Wilma" };
//            //string[] empty = { };

//            //var result1 = names1.Single();

//            //Console.WriteLine("The only name in the array is:");
//            //Console.WriteLine(result1);

//            //try
//            //{

//            //    var resultEmpty = empty.Single();
//            //}
//            //catch (Exception e)
//            //{
//            //    Console.WriteLine(e.Message);
//            //}

//            //try
//            //{

//            //    var result3 = names3.Single();
//            //}
//            //catch (Exception e)
//            //{
//            //    Console.WriteLine(e.Message);
//            //}

//            //10. SINGLE OR DEFAULT

//            //string[] names1 = { "Peter" };
//            //string[] names3 = { "Peter", "Joe", "Wilma" };
//            //string[] empty = { };

//            //var result1 = names1.SingleOrDefault();

//            //var resultEmpty = empty.SingleOrDefault();

//            //Console.WriteLine("The only name in the array is:");
//            //Console.WriteLine(result1);

//            //Console.WriteLine("As array is empty, SingleOrDefault yields null:");
//            //Console.WriteLine(resultEmpty == null);

//            //try
//            //{

//            //    var result3 = names3.SingleOrDefault();
//            //}
//            //catch (Exception e)
//            //{
//            //    Console.WriteLine(e.Message);
//            //}
//            // AGGREGATE 

//            //1. AGGREGATE (SIMPLE)

//            //  var numbers = new int[] { 1, 2, 3, 4, 5 };

//            //  var result = numbers.Aggregate((a, b) => a * b);

//            //Console.WriteLine("Aggregated numbers by multiplication:");
//            //  Console.WriteLine(result);

//            //2. AVERAGE

//            //int[] numbers = { 10, 10, 11, 11 };

//            //var result = numbers.Average();

//            //Console.WriteLine("Average is:");
//            //Console.WriteLine(result);

//            //3. COUNT

//            //string[] names = { "Peter", "John", "Kathlyn", "Allen", "Tim" };

//            //var result = names.Count();

//            //Console.WriteLine("Counting names gives:");
//            //Console.WriteLine(result);

//            //4.MAX

//            //int[] numbers = { 2, 8, 5, 6, 1 };

//            //var result = numbers.Max();

//            //Console.WriteLine("Highest number is:");
//            //Console.WriteLine(result);

//            //5. MIN

//            //int[] numbers = { 6, 9, 3, 7, 5 };

//            //var result = numbers.Min();

//            //Console.WriteLine("Lowest number is:");
//            //Console.WriteLine(result);

//            //6. SUM

//            //int[] numbers = { 2, 5, 10 };

//            //var result = numbers.Sum();

//            //Console.WriteLine("Summing the numbers yields:");
//            //Console.WriteLine(result);


//            //QUANTIFIERS
//            //1. ALL

//            //string[] names = { "Bob", "Ned", "Amy", "Bill" };

//            //var result = names.All(n => n.StartsWith("B"));

//            //Console.WriteLine("Does all of the names start with the letter 'B':");
//            //Console.WriteLine(result);

//            //2. ANY

//            //string[] names = { "Bob", "Ned", "Amy", "Bill" };

//            //var result = names.Any(n => n.StartsWith("B"));

//            //Console.WriteLine("Does any of the names start with the letter 'B':");
//            //Console.WriteLine(result);

//            //3. CONTAINS
//            //int[] numbers = { 1, 3, 5, 7, 9 };

//            //var result = numbers.Contains(5);

//            //Console.WriteLine("sequence contains the value 5:");
//            //Console.WriteLine(result);

//            //ASSIGNMENT 1
//            //string[] names = { "Rutu", "Sus", "Rohan" };


//            //var result = names.Where(names => names.Contains("o"));

//            //Console.WriteLine("name which contain o :");
//            //foreach (string name in result)
//            //    Console.WriteLine(name);

//            //ASSIGNMENT 3

//            //string[] words = { "believe", "relief", "reciept", "field" };
//            //foreach (string m in words)
//            //    Console.WriteLine($"{m} -- {m.Length}");

//            //ASSIGNMENT 2

//            //string[] capitals = { "John", "Peter", "Jacob", "Harry", "Jackson" };

//            //var res = capitals.OrderBy(c => c.Length);
//            //var result = capitals.Skip(4);

//            //Console.WriteLine("Name which has max no of character length:");
//            //foreach (string capital in result)
//            //    Console.WriteLine(capital);

//            //ASSIGNMENT 4

//            //string[] words = { "blueberry", "blackberry", "abacus" };
//            //var result = words.OrderBy(x => x);
//            //foreach (string item in result)
//            //    Console.WriteLine(item.Reverse().ToArray());







//            //List<string> words = new List<string> { "basket" ,"blueberry", "chimpanze", "abacus", "banana", "apple", "cheese"};
//            // var wordGroups = words.GroupBy(x => x[0]).Select
//            //     (y => new { FirstLetter = y.Key, wORDSS = y });
//            // foreach (var item in wordGroups)
//            // {
//            //     Console.WriteLine("Words that start with the" + "letter '{0}':",
//            //         item.FirstLetter);
//            //     foreach (var w in item.wORDSS)
//            //     {
//            //         Console.WriteLine(w);

//            //     }
//            // }



//            List<string> words = new List<string> { "basket", "blueberry", "chimpanze", "abacus", "banana", "apple", "cheese" };
//            var wordGroups = words.GroupBy(x => x[0]).Select
//                (y => new { FirstLetter = y.Key, wORDSS = y });
//            foreach (var item in wordGroups)
//            {
//                Console.WriteLine("Words that has the " + "letter '{0}':",
//                    item.FirstLetter);
//                foreach (var w in item.words)
//                {
//                    Console.WriteLine(word);
//                    Console.WriteLine();

//                }
//            }




//        }
//    }
//    }

   