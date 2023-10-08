using System;
using System.Collections.Generic;

namespace Task
{
    public class Report
    {
        public delegate bool IlegalAge(Employee e);
        public void AgeProcessing(List<Employee> emp,string Title, IlegalAge isIlegalAge)
        {
            Console.WriteLine(Title);
            foreach (var e in emp)
            {
                if (isIlegalAge(e))
                {
                    Console.WriteLine($"{e.Id} ,{e.FullName} , {e.Email} ,{e.age}");
                }
                
            }
            
        }
    }
}