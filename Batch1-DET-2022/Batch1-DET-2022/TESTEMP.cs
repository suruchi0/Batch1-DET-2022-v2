﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Batch1_DET_2022
//{
//    internal class TESTEMP
//    {
//        public static void Main()

//        {

//            try

//            {

//                Emp m = new Manager(4671, "Karthika", new DateOnly(2005, 5, 10), "techtrng", 10);  //default constructor

//                // Console.WriteLine(m.Print());



//                Emp m1 = new Manager(2345, "Jeeva", new DateOnly(2010, 1, 14), "PEMS", 450);

//                // Console.WriteLine(m1.Print());  //base class ref can point to derived object



//                Emp e1 = new Emp(1, "Jiyana", new DateOnly(2020, 1, 5));

//                //Console.WriteLine(e1.Print());



//                Console.WriteLine("enter empid b.w 1001 - 25000");

//                int id = Convert.ToInt32(Console.ReadLine());

//                if (id < 1001 || id > 25000)

//                    throw new InvalidEmpIdException("Entered empid is not in the range...");



//                Console.WriteLine("enter emp name");

//                string name = Console.ReadLine();



//                Console.WriteLine("enter doj");

//                DateOnly doj = DateOnly.Parse(Console.ReadLine());



//                Emp e2 = new(id, name, doj);





//                List<Emp> list = new List<Emp>();

//                list.Add(m);

//                list.Add(m1);

//                list.Add(e1);

//                foreach (Emp x in list)

//                    Console.WriteLine(x.Print());

//            }

//            catch (InvalidEmpIdException e)

//            {

//                Console.WriteLine(e.Message);

//            }

//            catch (Exception e)

//            { }



//        }
//    }
//}