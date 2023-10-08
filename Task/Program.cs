using System;
using System.Collections.Generic;
using System.Linq;

namespace Task
{
    internal class Program
    {
        public static void Main(string[] args)
        {
           List<Employee> employees = new List<Employee>();
            var emp1 = new Employee { Id = 1, FullName = "Sabeha", Email = "Sabeha@gmail.com" ,age = 13};
            var emp2 = new Employee { Id = 2, FullName = "Rihab",  Email = "Rihab@gmail.com",age = 30};
            var emp3 = new Employee { Id = 3, FullName = "osama",  Email = "osama@gmail.com",age = 40};
            Employee[] array = new Employee[]
            {
                emp1, emp2, emp3
            };
            
            employees.Add(new Employee{Id = 4,FullName = "aya", Email = "aya@gmail.com",age = 50});
            employees.AddRange(array);
            //employees.RemoveAll(x => x.FullName.EndsWith("a"));
            employees.ToString();
            
            var  report = new Report();
            report.AgeProcessing(employees, "Age < 18", e => e.age < 18);
            report.AgeProcessing(employees, "Age >= 18 && Age < 40", e => (e.age >= 18 && e.age < 40));
            report.AgeProcessing(employees, "Age >= 40 && Age < 50", e => (e.age >= 40 && e.age < 50));
             report.AgeProcessing(employees,"Age >= 50",e=>e.age>=50 );
             var orderNames = employees.OrderBy(n => n.FullName);
              employees.Sort();
             foreach (var entry in orderNames)
             {
                 Console.WriteLine(entry.ToString()); 
             }
                      
        }
    }

    
    public class Employee
    {
        
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public int age { get; set; }

        public override string ToString()
        {
            return $"{Id} ,{FullName} , {Email} ,{age}";
        }

        public  void searching(int id ,List<Employee> emp )     
        {
            foreach (var e in emp)
            {
                if (id==e.Id)
                {
                    Console.WriteLine(e.ToString());
                }
                else
                  Console.WriteLine("this is employee not found");
               
            }
           
                
        }      

        

    }
}