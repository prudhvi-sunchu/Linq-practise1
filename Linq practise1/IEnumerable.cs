//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


////Interfaces
//namespace Linq_practise1
//{
//   class Program
//    {
//        static void Main(string[] args)
//        {
//            List<int> list = new List<int>() { 1,2,3,4,5,6,7,8,9,10};

//            List<Employee> employees = new List<Employee>()
//            {
//                    new Employee(){ Id=1, Name = "Tom"},
//                    new Employee(){ Id=2, Name = "John"}
//            };

//            IEnumerable<Employee> query = from emp in employees
//                                          where emp.Id == 1
//                                          select emp;
//            IQueryable<Employee> query1 = employees.AsQueryable().Where(x => x.Id == 1);

//            foreach (var item in query1)
//            {
//                Console.WriteLine("Id = " + item.Id+ "And Name = "+ item.Name);
//            }

//            IEnumerable<int> querySyntax = from obj in list
//                                           where obj > 2
//                                           select obj;
//            Console.ReadLine();
//        }
//        class Employee
//        {
//            public int Id { get; set; }
//            public string Name { get; set; }

//        }
//    }
//}



/*
Objective
---------
what is IEnumerable?
what is IQuerable?
Demo

IEnumerable
-----------
IEnumerable is an interface.
IEnumerable is available in System.Collection namespace.
All the collection in C# implements IEnumerable
This interface is a type if Iteration design pattern.
So,Because of this interface we can iterate(foreach loop) on collection.
IEnumerable also has a child for generic classes-IEnumerable<T>
IEnumerable or IEnumerable<T> should be used for in memory data objects.


IQuerable
---------

IQuerable is an interface.
IQuerable is available in System.Linq namespace
IQuerable is a child of IEnumerable
IQuerable has a property named as Provider which is of type IQueryProvider
interface. And it is used in LinqProviders.
IQuerable is best choice for other data provider(ex-Linq to Entities etc....)




 */