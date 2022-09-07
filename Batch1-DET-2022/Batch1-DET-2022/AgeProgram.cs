//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Batch1_DET_2022
//{
//    internal class AgeProgram
//    {
//        public static void Main()
//        {
//            int age;
//            try
//            {
//                Console.WriteLine("Enter the Age b.w 1-100");
//                age = int.Parse(Console.ReadLine());
//                if (age > 100)
//                    throw new InvalidCastException("Entered age is Invalid");
//            }
//            catch (InvalidAgeException a)
//            {
//                Console.WriteLine(a.Message);

//            }
//            catch (Exception a)
//            { }
//            Console.WriteLine("");
//        }
//    }
//}

