using CoreEF.Models;
using FrameworkEF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreEF
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var ctx = new SchoolDbContext())
            {
                ////Eager Loading in Entity Framework
                //var stud1 = ctx.Students
                //               .Include("Address")
                //               .Where(s => s.FirstName == "Bill")
                //               .FirstOrDefault<Student>();

                ////Lazy Loading In Entity Framework--------------------------------------------------
                //IList<Student> studList = ctx.Students.ToList<Student>();
                //Student std = studList[0];
                //string city = std.Address.City;
                if (ctx.Customers.Count() == 0)
                {
                    Persistance.Initialize(ctx);
                }
            }
            Console.WriteLine("Hello World!");
        }


    }   
  
}
