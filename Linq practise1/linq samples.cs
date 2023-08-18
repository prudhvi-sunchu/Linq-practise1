//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Linq_practise1
//{
//    class Progam
//    {
//        static void Main(string[] args)
//        {
//            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; //Data source

//            var querySyntax = from obj in list
//                              where obj > 2       //Query
//                              select obj;

//            foreach (var item in querySyntax)
//            {
//                Console.WriteLine(item);       //Execution
//            }
//            Console.WriteLine("------------------------");

//            var methodSyntax = list.Where(obj => obj > 2);

//            foreach (var item in querySyntax)
//            {
//                Console.WriteLine(item);       //Execution
//            }
//            Console.WriteLine("------------------------");
//            var mixedSyntax = (from obj in list
//                               select obj).Max();
//            Console.WriteLine("max value =" + mixedSyntax);

//            Console.ReadLine();
//        }
//    }
//}
