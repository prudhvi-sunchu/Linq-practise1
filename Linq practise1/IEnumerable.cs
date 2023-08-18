using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Interfaces
namespace Linq_practise1
{
   class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1,2,3,4,5,6,7,8,9,10};

            List<Employee> employees = new List<Employee>()
            {
                    new Employee(){ Id=1, Name = "Tom"},
                    new Employee(){ Id=2, Name = "John"}
            };

            IEnumerable<Employee> query = from emp in employees
                                          where emp.Id == 1
                                          select emp;
            IQueryable<Employee> query1 = employees.AsQueryable().Where(x => x.Id == 1);

            foreach (var item in query1)
            {
                Console.WriteLine("Id = " + item.Id+ "And Name = "+ item.Name);
            }

            IEnumerable<int> querySyntax = from obj in list
                                           where obj > 2
                                           select obj;
            Console.ReadLine();
        }
        class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }

        }
    }
}