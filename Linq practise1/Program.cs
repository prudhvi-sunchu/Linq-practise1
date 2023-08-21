using System.Linq;
using System.Collections;
using System.Collections.Generic;

//class Program
//{
//    static void Main(string[] args)
//    {
//        int[] numbers = new int[] { 1, 2, 6, 7, 8, 9, 10, 3, 4, 5 };

//        List<string> names = new List<string>() { "Sai", "Ravi", "Mahesh", "Pavan", "Nikhil" };

//        var ms = numbers.Skip(3).ToArray();

//        var mixeds = (from n in names select n).Skip(2).ToList();
//        foreach (var num in ms)
//        {
//            Console.WriteLine(ms);
//        }
//    }
//}


namespace Linq_practise1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){ Id=1, Name = "Tom", Email="tom@gmail.com"},
                new Employee(){ Id=2, Name = "John", Email="john@gmail.com"},
                new Employee(){ Id=3, Name = "Ramu", Email="ram@gmail.com"},
                new Employee(){ Id=4, Name = "Kiran", Email="kiran@gmail.com"},
                new Employee(){ Id=5, Name = "Savan", Email="savan@gmail.com"},
            };
            var basicQuery = (from emp in employees //this part is query
                             select emp).ToList();  //tolist is the exection 
            var basicMethod = employees.ToList();

            //---------operations based on id
            //we are trying to featch names and email one after another

            var basicPropQuery = (from emp in employees
                                  select emp.Id).ToList();
            var basicpopQuey = (from emp in employees
                                select emp.Name).ToList();
            var basicEQuey = (from emp in employees
                              select emp.Email).ToList();


            var selectQuery= (from emp in employees
                             select new Employee()
                             {
                                 Id = emp.Id,
                                 Email = emp.Email
                             }).ToList();

            var selectsQuery = (from emp in employees
                               select new student()
                               {
                                   StudentId = emp.Id,
                                   FullName = emp.Name,
                                   StEmail = emp.Email
                               }).ToList();

            foreach (var item in selectsQuery)//basicQuery
            {
                Console.WriteLine($"Id = {item.StudentId}, Name = {item.FullName} Email={item.StEmail}");
            }
            //foreach (var item in selectsQuery)//basicQuery
            //{
            //    Console.WriteLine($"Id = {item.Id}, Name = {item.Name} Email={item.Email}");
            //}
            Console.ReadLine();
        }
    }
}